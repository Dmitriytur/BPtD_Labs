using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bptd_Lab3
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
		}

		private void openFileBtn1_Click(object sender, EventArgs e)
		{
			if (openFileD1.ShowDialog() == DialogResult.OK)
			{
				fileBox1.Text = openFileD1.FileName;
				hashBox1.Text = HashProvider.GetHash(openFileD1.FileName).ToString();
			}
			
		}

		private void openFileBtn2_Click(object sender, EventArgs e)
		{
			if (openFileD2.ShowDialog() == DialogResult.OK)
			{
				fileBox2.Text = openFileD2.FileName;
				hashBox2.Text = HashProvider.GetHash(openFileD2.FileName).ToString();
			}
			
		}

		private void openSignBtn_Click(object sender, EventArgs e)
		{
			if (openSignD.ShowDialog() == DialogResult.OK)
			{
				signBox.Text = openSignD.FileName;
				if (HashProvider.CheckSign(openFileD1.FileName, openSignD.FileName))
				{
					changedFileLabel.Hide();
					correctSignLabel.Show();
				}
				else
				{
					changedFileLabel.Show();
					correctSignLabel.Hide();
				}
			}

		}

		private void makeSignBtn_Click(object sender, EventArgs e)
		{
			if (saveSignD.ShowDialog() == DialogResult.OK)
			{
				HashProvider.MakeSign(openFileD1.FileName, saveSignD.FileName);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			hashBox2.Text = HashProvider.GetHash(openFileD2.FileName).ToString();
		}
	}
}
