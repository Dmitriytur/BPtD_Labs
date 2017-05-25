using DESEncryption;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPtD_Lab4_Client
{
	public partial class ChatWindow : Form
	{

		private ClientProvider provider;

		public ChatWindow()
		{
			InitializeComponent();
			provider = ClientProvider.GetInstance();
			provider.OnReceivingMessage += WriteIncomingMessage;
			WindowLogger.SetLogger(chatBox);
			WindowLogger.TurnedOn = false;
		}

	

		private void connectBtn_Click(object sender, EventArgs e)
		{

			provider.Connect(addressBox.Text, Convert.ToInt32(portBox.Text));
			ChangeToConnectedState();
		}

		private void disconnectBtn_Click(object sender, EventArgs e)
		{
			provider.Disconnect();
			ChangeToDisconnectedState();
		}

		private void sendButton_Click(object sender, EventArgs e)
		{
			provider.AddMessage(userNameBox.Text + " >> " + messageBox.Text);
			chatBox.AppendText("You >> " + messageBox.Text + '\n');
			messageBox.Clear();
		}

		private void WriteIncomingMessage(string message)
		{
			Action action = () => chatBox.AppendText(message.Trim('\0') + '\n');
			this.Invoke(action);
			
		}

		private void ChangeToConnectedState()
		{
			addressBox.Enabled = false;
			portBox.Enabled = false;
			userNameBox.Enabled = false;
			connectBtn.Enabled = false;
			disconnectBtn.Enabled = true;
			messageBox.Enabled = true;
			sendButton.Enabled = true;
		}

		private void ChangeToDisconnectedState()
		{
			addressBox.Enabled = true;
			portBox.Enabled = true;
			userNameBox.Enabled = false;
			connectBtn.Enabled = true;
			disconnectBtn.Enabled = false;
			messageBox.Enabled = false;
			sendButton.Enabled = false;

		}

		private void logCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			WindowLogger.TurnedOn = !WindowLogger.TurnedOn;
		}
	}
}
