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

namespace BPtD_Lab4_Server
{
	public partial class ServerWindow : Form
	{
		ServerProvider provider;
		public ServerWindow()
		{
			InitializeComponent();
			provider = ServerProvider.GetInstance();
			WindowLogger.SetLogger(consoleBox);
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			provider.Start(addressBox.Text, Convert.ToInt32(portBox.Text));
			ChangeToRunning();
		}

		private void stopButton_Click(object sender, EventArgs e)
		{
			provider.Stop();
			ChangeToStopped();
		}

		private void ChangeToRunning()
		{
			addressBox.Enabled = false;
			portBox.Enabled = false;
			StartButton.Enabled = false;
			stopButton.Enabled = true;

		}

		private void ChangeToStopped()
		{
			addressBox.Enabled = true;
			portBox.Enabled = true;
			StartButton.Enabled = true;
			stopButton.Enabled = false;

		}

		
	}
}
