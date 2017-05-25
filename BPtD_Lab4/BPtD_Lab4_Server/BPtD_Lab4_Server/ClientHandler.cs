using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BPtD_Lab4_Server
{
	public enum ClientState
	{
		New, Exchanging, Connected
	}
	public class ClientHandler
	{
		public ClientState State { get; set; }

		public Socket Handler { get; private set; }

		public int PartialKey { get; private set; }


		public ClientHandler(Socket handler)
		{
			Handler = handler;
			State = ClientState.New;
		}

		

		public void SendInitialize(int module, int publicValue)
		{
			SendIntValue(module);
			SendIntValue(publicValue);
			
		}

		public void SendFirst()
		{
			SendHeader(1);
			State = ClientState.Exchanging;
			PartialKey = GetIntValue();

		}

		public int SendIntemediate(int value)
		{
			SendHeader(2);
			SendIntValue(value);
			return GetIntValue();
		}

		public void SendFinal(int final)
		{
			SendHeader(3);
			SendIntValue(final);
			
		}

		public void SendHeader(byte value)
		{
			byte[] header = new byte[] { value };
			Handler.Send(header);


		}

		public void SendIntValue(int value)
		{
			byte[] buffer = BitConverter.GetBytes(value);
			Handler.Send(buffer);
		}

		public int GetIntValue()
		{
			byte[] buffer = new byte[4];
			Handler.Receive(buffer);
			return BitConverter.ToInt32(buffer, 0);
		}

		public byte[] GetNextMessage()
		{
			byte[] header = new byte[4];
			Handler.Receive(header, 4, SocketFlags.None);
			int messageLength = BitConverter.ToInt32(header, 0);
			byte[] buffer = new byte[messageLength];
			Handler.Receive(buffer);
			return header.Concat(buffer).ToArray();
		}

		public byte[] GetAllBuffer()
		{
			var buffer = new List<byte>();
			while(Handler.Available != 0)
			{
				buffer.Concat(GetNextMessage());
			}
			return buffer.ToArray();
		}


		public void Stop()
		{
			Handler.Disconnect(true);
			Handler.Shutdown(SocketShutdown.Both);
			Handler.Close();
			Handler.Dispose();
		}
	}
}
