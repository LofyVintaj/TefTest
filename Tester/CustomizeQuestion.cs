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
		public Test test = new Test();
		public string test_name;
		public int count_question;
		public int page;

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				CustomizeChoiseAnswerQuestion frm = new CustomizeChoiseAnswerQuestion();
				frm.test_name = test_name;
				frm.page = page;

				string connectionString = "TestBook";
				MongoCRUD db = new MongoCRUD(connectionString);
				QuestionChoiseAnser object_question = new QuestionChoiseAnser();
				//object_question.termin_text = richTextBox1.Text;
				//object_question.termin_value = textBox1.Text;
				object_question.text = "";
				object_question.object_buttons = new List<RadioDataQuestion>();
				db.UpdateQuestionsRecord<Test>("Test", test_name, object_question, page);

				frm.Show();
				//db.UpdateQuestionsRecord<Test>("Test", test_name, object_question, page);

			}
			if (radioButton2.Checked)
			{
				CustomizeTerminQuestion frm = new CustomizeTerminQuestion();
				frm.test_name = test_name;
				frm.page = page;

				string connectionString = "TestBook";
				MongoCRUD db = new MongoCRUD(connectionString);
				QuestionTermin object_question = new QuestionTermin();
				//object_question.termin_text = richTextBox1.Text;
				//object_question.termin_value = textBox1.Text;
				db.UpdateQuestionsRecord<Test>("Test", test_name, object_question, page);

				frm.Show();

			}
			if (radioButton3.Checked)
			{
				CustiomizeInstertWordQuestion frm = new CustiomizeInstertWordQuestion();
				frm.test_name = test_name;
				frm.page = page;

				string connectionString = "TestBook";
				MongoCRUD db = new MongoCRUD(connectionString);
				QuestionInsertWordQuestion object_question = new QuestionInsertWordQuestion();
				//object_question.termin_text = richTextBox1.Text;
				//object_question.termin_value = textBox1.Text;
				db.UpdateQuestionsRecord<Test>("Test", test_name, object_question, page);

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
				button5.Visible = true;
			}
			else
			{
				button5.Visible = false;
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

		private void button5_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 first_form = new Form1();
			first_form.Show();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			panel2.Capture = false;
			Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref m);
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
