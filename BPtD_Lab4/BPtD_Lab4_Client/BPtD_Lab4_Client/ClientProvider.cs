using DESEncryption;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BPtD_Lab4_Client
{
	public delegate void MessageHandler(string message);

	public enum ProviderStatus
	{
		Disconnected, Initialization, KeyExchanging, Connected
	}

	class ClientProvider
	{
		

		private static ClientProvider instance;

		public static ClientProvider GetInstance()
		{
			if (instance == null)
			{
				instance = new ClientProvider();
			}
			return instance;
		}

		private ClientProvider() { }

		private Socket handler;

		private int publicNumber;

		private int modulus;

		private int key;

		private int privateNumber;



		private Queue<string> messageQueue = new Queue<string>();

		public ProviderStatus status { private set; get; } = ProviderStatus.Disconnected;

		public event MessageHandler OnReceivingMessage;

		
		

		public void Connect(string address, int port)
		{
			IPHostEntry ipHost = Dns.GetHostEntry(address);
			IPAddress ipAddr = ipHost.AddressList[0];
			IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);
			handler = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			handler.Connect(ipEndPoint);
			status = ProviderStatus.Initialization;

			Thread messageReceiver = new Thread(new ThreadStart(WaitForMessages));
			messageReceiver.IsBackground = true;
			messageReceiver.Start();
			
		}

		private void WaitForMessages()
		{
			GetPublicValues();
			while (true)
			{
				Thread.Sleep(100);
				if (handler.Available == 0)
				{
					SendMessages();
					continue;
				}
				byte[] header = new byte[1];
				handler.Receive(header, 1, SocketFlags.None);
				AcceptCommand(header[0]);
				SendMessages();
			}

		}

		#region Key exchanging

		private void GetPublicValues()
		{
			WindowLogger.Write("Wait for public");
			modulus = ReceiveIntValue();
			publicNumber = ReceiveIntValue();
			WindowLogger.Write(String.Format("Got public Q = {0}  A = {1}",modulus, publicNumber));
		}

		private void InitializeKeyExchange()
		{
			status = ProviderStatus.KeyExchanging;
			Random r = new Random();
			privateNumber = r.Next(modulus - 1);
			int firstValue = BigIntegerOperation.ModPow(publicNumber, privateNumber, modulus);
			handler.Send(BitConverter.GetBytes(firstValue));
			WindowLogger.Write(String.Format("Sended first value {0}", firstValue));
		}

		private void DoIntermediateStage()
		{
			int intermediateValue = ReceiveIntValue();
			WindowLogger.Write(String.Format("Receive intermediate value {0}", intermediateValue));
			intermediateValue =  BigIntegerOperation.ModPow(intermediateValue, privateNumber, modulus);
			handler.Send(BitConverter.GetBytes(intermediateValue));
			WindowLogger.Write(String.Format("Send new inter value {0}", intermediateValue));

		}

		private void DoFinalStage()
		{
			int finalValue = ReceiveIntValue();
			key = BigIntegerOperation.ModPow(finalValue, privateNumber, modulus);
			status = ProviderStatus.Connected;
			WindowLogger.Write(String.Format("Recieved final value {0} and calculated key {1}", finalValue, key));
		}

		private int ReceiveIntValue()
		{
			byte[] buffer = new byte[4];
			handler.Receive(buffer, 4, SocketFlags.None);
			return BitConverter.ToInt32(buffer, 0);
		}

		#endregion

		private void AcceptCommand(int header)
		{
			switch (header)
			{
				case 0:
					{
						ReceiveMessage();
						break;
					}
				case 1:
					{
						InitializeKeyExchange();
						break;
					}
				case 2:
					{
						DoIntermediateStage();
						break;
					}
				case 3:
					{
						DoFinalStage();
						break;
					}
			}
		}

		private void ReceiveMessage()
		{
			byte[] header = new byte[4];
			handler.Receive(header);
			int messageLength = BitConverter.ToInt32(header, 0);
			byte[] buffer = new byte[messageLength];
			handler.Receive(buffer);
			byte[] message = Cipher.Decrypt(buffer, key);
			OnReceivingMessage(Encoding.UTF8.GetString(message));

		}

		private void SendMessages()
		{
			if (status != ProviderStatus.Connected)
			{
				return;
			}
			while (messageQueue.Count != 0)
			{
			    string message = messageQueue.Dequeue();
				byte [] byteMessage = Encoding.UTF8.GetBytes(message);
				byte [] cryptogram = Cipher.Encrypt(byteMessage, key);
				byte [] cryptLength = BitConverter.GetBytes(cryptogram.Length);
				handler.Send(cryptLength);
				handler.Send(cryptogram);
			}
		}

		public void AddMessage(string message)
		{
			messageQueue.Enqueue(message);
		}	

		public void Disconnect()
		{
			//TODO
			status = ProviderStatus.Disconnected;
		}

		
	}
}
