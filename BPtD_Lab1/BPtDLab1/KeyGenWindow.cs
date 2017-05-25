using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DESEncryption;
using System.Security.Cryptography;
namespace BPtDLab1
{
	public partial class KeyGenWindow : Form
	{
		public KeyGenWindow()
		{
			InitializeComponent();
		}

		private void keyGenButton_Click(object sender, EventArgs e)
		{
			var v = RandomNumberGenerator.Create();
			byte[] key = new byte[8];
			v.GetBytes(key);
			keyTextBox.Text = Convert.ToString(BitConverter.ToInt64(key, 0), 16);
		}
	}
}
