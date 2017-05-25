using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace BPtD_Lab2_Client
{
	public partial class Form1 : Form
	{
		string address;
		RSACryptoServiceProvider provider;

		public Form1()
		{
			InitializeComponent();
		}


		private void requestBtn_Click(object sender, EventArgs e)
		{
			address = addressBox.Text;
			HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(address + "/key");
			HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

			string base64key;
			using (StreamReader stream = new StreamReader(resp.GetResponseStream(), Encoding.UTF8))
			{
				base64key = stream.ReadToEnd();
			}
			keyBox.Text = base64key;
			byte[] publicKey = Convert.FromBase64String(base64key);
			provider = FormatResolver.DecodeX509PublicKey(publicKey);
		}

		private void sendBtn_Click(object sender, EventArgs e)
		{
			byte[] message = Encoding.UTF8.GetBytes(messageBox.Text);
			chatBox.Text += ">> " + messageBox.Text + '\n';
			messageBox.Clear();

			byte[] encryptedMessage = provider.Encrypt(message, false);
			HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(address + "/getData");
			req.Method = "POST";
			using (Stream stream = req.GetRequestStream())
			{
				stream.Write(encryptedMessage, 0, encryptedMessage.Length);
			}
			req.GetResponse();

			encBox.Text = Convert.ToBase64String(encryptedMessage);
		}


	}
}
