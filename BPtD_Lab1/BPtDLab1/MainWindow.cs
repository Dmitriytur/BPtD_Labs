using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPtDLab1
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void generateKeyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var keyGenWindow = new KeyGenWindow();
			keyGenWindow.StartPosition = FormStartPosition.CenterParent;
			keyGenWindow.ShowDialog();
		}

		private void openChatButton_Click(object sender, EventArgs e)
		{
			IPHostEntry ipHost = Dns.GetHostEntry(addressBox.Text);
			IPAddress ipAddr = ipHost.AddressList[0];
			IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, Convert.ToInt32(portBox.Text));
			
			Socket senderSocket = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			senderSocket.Connect(ipEndPoint);

			var chatWindow = new ChatWindow(senderSocket, Convert.ToInt64(keyBox.Text, 16));
			chatWindow.StartPosition = FormStartPosition.Manual;
			chatWindow.Location = this.Location;
			chatWindow.Show();
		}

		private void waitButton_Click(object sender, EventArgs e)
		{
			var waitWindow = new WaitWindow(addressBox.Text, Convert.ToInt32(portBox.Text), Convert.ToInt64(keyBox.Text, 16));
			waitWindow.StartPosition = FormStartPosition.Manual;
			waitWindow.Location = this.Location;
			waitWindow.Show();
		}
	}
}
