using DESEncryption;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPtDLab1
{
	public partial class ChatWindow : Form
	{
		Socket handler;
		long key;

		public ChatWindow(Socket handler, long key)
		{
			InitializeComponent();
			this.handler = handler;
			this.key = key;
			Thread messageReceiver = new Thread(new ThreadStart(WaitForMessages));
			messageReceiver.IsBackground = true;
			messageReceiver.Start();
		}
		
		private void WaitForMessages()
		{
			while (true)
			{
				Thread.Sleep(100);
				int messageSize = handler.Available;
				if (messageSize == 0)
				{
					continue;
				}
				byte[] buffer = new byte[messageSize];
				handler.Receive(buffer);
				byte[] message = Cipher.Decrypt(buffer, key);
				chatBox.Text += "Someone >> " + Encoding.UTF8.GetString(message);
				chatBox.Text += '\n';
				
			}

		}

		private void sendButton_Click(object sender, EventArgs e)
		{
			byte[] message = Encoding.UTF8.GetBytes(messageBox.Text);
			byte[] cryptogram = Cipher.Encrypt(message, key);
			handler.Send(cryptogram);
			chatBox.Text += "You >> " + messageBox.Text + '\n';
			messageBox.Clear();
		}

	}
}
