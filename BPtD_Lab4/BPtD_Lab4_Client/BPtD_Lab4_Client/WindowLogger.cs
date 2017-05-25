using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPtD_Lab4_Client
{
	class WindowLogger
	{
		private static RichTextBox log;

		public static bool TurnedOn { set; get; } = true;

		public static void Write(string message)
		{
			if (TurnedOn && log != null)
			{
				Action action = () => log.AppendText("<< Log >> " + message + " << Log >>" + '\n');
				log.Invoke(action);
			}
		}

		public static void SetLogger(RichTextBox textBox)
		{
			log = textBox;
		}

	}
}
