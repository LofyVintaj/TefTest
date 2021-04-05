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

		public List<CustomizeQuestion> object_questions = new List<CustomizeQuestion>();
		public int count_question;
		public int page;

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				MessageBox.Show(radioButton1.Text);
				CustomizeChoiseAnswerQuestion frm = new CustomizeChoiseAnswerQuestion();
				
				frm.Show();
			}
			if (radioButton2.Checked)
			{
				MessageBox.Show(radioButton2.Text);
				CustomizeTerminQuestion frm = new CustomizeTerminQuestion();
				frm.Show();
			}
			if (radioButton3.Checked)
			{
				MessageBox.Show(radioButton3.Text);
				CustiomizeInstertWordQuestion frm = new CustiomizeInstertWordQuestion();
				frm.Show();
			}
		}

		private void CustomizeQuestion_Load(object sender, EventArgs e)
		{
			page = int.Parse(this.Text);
			if ( this.Text == "0")
				{
					button3.Visible = false;
			}
			if ( page == count_question - 1 )
			{
				button2.Visible = false;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{

			object_questions[page + 1].Show();

			object_questions[page].Hide();



		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			object_questions[page - 1].Show();

			if (page != count_question - 1)
			{
				object_questions[page].Hide();
			}
		}
	}
}
