using DESEncryption;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPtDLab1
{
	public partial class TestWindow : Form
	{
		long key = 0;
		byte[] message;
		byte[] cryptogram;
		byte[] result;

		public TestWindow()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			message = Encoding.UTF8.GetBytes(richTextBox1.Text);
			cryptogram = Cipher.Encrypt(message, key);
			richTextBox2.Text =  BitConverter.ToString(cryptogram);
	
		}

		private void button2_Click(object sender, EventArgs e)
		{
			result = Cipher.Decrypt(cryptogram, key);
			richTextBox3.Text = Encoding.UTF8.GetString(result);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string keyHex = Convert.ToString(key, 16);
			long key2 = Convert.ToInt64(keyHex, 16);
			textBox1.Text = key.ToString();
			textBox2.Text = keyHex;
			textBox3.Text = key2.ToString();
		}
	}
}
