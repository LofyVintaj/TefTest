using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
	public partial class CustomizeQuestion : Form
	{
		public CustomizeQuestion()
		{
			InitializeComponent();
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				MessageBox.Show(radioButton1.Text);
			}
			if (radioButton2.Checked)
			{
				MessageBox.Show(radioButton2.Text);
			}

		}
	}
}
