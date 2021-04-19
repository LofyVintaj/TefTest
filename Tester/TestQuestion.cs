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
	public partial class TestQuestion : Form
	{
		//Наш список вопросов
		public List<TestQuestion> test_object_questions = new List<TestQuestion>();
		public int test_count_question;
		public int page;

		public QuestionTermin question_termin = new QuestionTermin();
		public QuestionChoiseAnser question_choise_answer = new QuestionChoiseAnser();
		public QuestionInsertWordQuestion question_insert_word = new QuestionInsertWordQuestion();
		public bool bool_question_termin = false;
		public bool bool_question_choise_answer = false;
		public bool bool_question_insert_word = false;
		public TestQuestion()
		{
			InitializeComponent();
		}
		public void TestQuestion_Load(object sender, EventArgs e)
		{
			//label2.Text = Convert.ToString(page);
			page = int.Parse(this.Text);
			label2.Text = Convert.ToString(page);

			if (this.Text == "0")
			{
				button3.Visible = false;
			}
			else if (page == test_count_question - 1)
			{
				button2.Visible = false;
			}

			if (bool_question_termin == true)
			{
				Console.WriteLine("bool_questin_termin 1");
				Label rich_box = new Label();
				TextBox text_box = new TextBox();

				Console.WriteLine("---------0000---------");
				Console.WriteLine(question_termin.termin_text);
				Console.WriteLine("---------0000---------");

			}
			else if (bool_question_choise_answer == true)
			{
				Console.WriteLine("bool_questin_choise_answer 2");
				TableLayoutPanel button_box = new TableLayoutPanel();
			}
			else if (bool_question_insert_word == true)
			{
				Console.WriteLine("bool_questin_insert_word 3");
				// Сделать цикл из label закидывать в grawLayout и там где должно быть пустое место, будет textBox 
				FlowLayoutPanel button_box = new FlowLayoutPanel();
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			panel1.Capture = false;
			Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref m);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			test_object_questions[page + 1].Show();
			test_object_questions[page].Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			test_object_questions[page - 1].Show();
			if (page != test_count_question - 1)
			{
				test_object_questions[page].Hide();
			}
		}
	}
}
