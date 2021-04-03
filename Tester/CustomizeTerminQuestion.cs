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
	public partial class CustomizeTerminQuestion : Form
	{
		public CustomizeTerminQuestion()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			String termin_body = richTextBox1.Text;
			String termin_value = textBox1.Text;
			this.Hide();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
