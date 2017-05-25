using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BPtD_Lab4_Server
{
	public class ServerProvider
	{
		private const int NUMBER_OF_CLIENTS = 20;

		private static ServerProvider instance;

		public static ServerProvider GetInstance()
		{
			if (instance == null)
			{
				instance = new ServerProvider();
			}
			return instance;
		}

		private ServerProvider() { }

		private BlockingCollection<ClientHandler> clients = new BlockingCollection<ClientHandler>();

		private Socket listener;

		private bool stopRunning = false;

		private int publicValue;

		private int module;

		public void Start(string address, int port)
		{
			ValueGenerator.GenerateModuleAndPublic(out module, out publicValue);

			IPHostEntry ipHost = Dns.GetHostEntry(address);
			IPAddress ipAddr = ipHost.AddressList[0];
			IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);

			listener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			listener.Bind(ipEndPoint);
			listener.Listen(NUMBER_OF_CLIENTS);

			Thread listenerThread = new Thread(new ThreadStart(WaitForConnection));
			listenerThread.IsBackground = true;
			listenerThread.Start();

			Thread clientOperator = new Thread(new ThreadStart(HandleClients));
			clientOperator.IsBackground = true;
			clientOperator.Start();

		}

		private void WaitForConnection()
		{
			while (true)
			{
				Thread.Sleep(100);
				if (stopRunning)
				{
					break;
				}
				Socket handler = listener.Accept();
				clients.Add(new ClientHandler(handler));
			}
		}

		private void HandleClients()
		{
			while (true)
			{
				Thread.Sleep(100);
				if (stopRunning)
				{
					break;
				}
				if (clients.Count < 2)
				{
					continue;
				}
				foreach (ClientHandler client in clients)
				{
					if (client.State == ClientState.New)
					{
						WindowLogger.Write("\nNew client connected\n");
						SendAllStop();
						ResendAll();
						DoKeyExchange();
						break;
					}
					ResendMessage(client);
				}
			}
		}

		private void SendAllStop()
		{
			foreach(ClientHandler client in clients.Where( c => c.State == ClientState.Connected))
			{
				client.SendFirst();
			}
		}

		private void ResendAll()
		{
			foreach (ClientHandler client in clients.Where(c => c.State == ClientState.Connected))
			{
				ResendAllBuffer(client);
			}
		}

		private void DoKeyExchange()
		{
			foreach(ClientHandler client in clients.Where(c => c.State == ClientState.New))
			{
				client.SendInitialize(module, publicValue);
				client.SendFirst();
			}
			foreach (ClientHandler client in clients.Where(c => c.State == ClientState.Exchanging))
			{
				CalculateKeyFor(client);
			}
			foreach(ClientHandler client in clients.Where(c => c.State == ClientState.Exchanging))
			{
				client.State = ClientState.Connected;
			}
		}


		public void CalculateKeyFor(ClientHandler targetClient)
		{
			int intermediateKey = 0;
			foreach (ClientHandler client in clients.Where(c => c.State == ClientState.Exchanging && c != targetClient))
			{
				if (intermediateKey == 0)
				{
					intermediateKey = client.PartialKey;
					WindowLogger.Write("\nGot first:" + intermediateKey);
					continue;
				}
				WindowLogger.Write("Sended intermediate:" + intermediateKey);
				intermediateKey = client.SendIntemediate(intermediateKey);
				WindowLogger.Write("Got intermediate:" + intermediateKey);

			}
			targetClient.SendFinal(intermediateKey);
			WindowLogger.Write("Sended final:" + intermediateKey + '\n');
		}


		private void ResendMessage(ClientHandler sender)
		{
			if (sender.Handler.Available == 0)
			{
				return;
			}
			byte[] message = sender.GetNextMessage();
			foreach (ClientHandler client in clients.Where(c => c.State == ClientState.Connected && c != sender))
			{
				client.SendHeader(0);
				client.Handler.Send(message);
			}
		}

		private void ResendAllBuffer(ClientHandler sender)
		{
			byte[] message = sender.GetAllBuffer();
			foreach (ClientHandler client in clients.Where(c => c.State != ClientState.New && c != sender))
			{
				client.Handler.Send(message);
			}
		}

		public void Stop()
		{
			stopRunning = true;
			Thread.Sleep(300);
			foreach (ClientHandler client in clients)
			{
				client.Stop();
			}
			if (listener.Connected)
			{
				listener.Shutdown(SocketShutdown.Both);
				listener.Disconnect(true);
				listener.Close();
				listener.Dispose();
			}
		}
	}
}
