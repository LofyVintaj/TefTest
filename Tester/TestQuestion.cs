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
		public float calculate_figure; 
		public int test_count_question;
		public int page;

		public QuestionTermin question_termin = new QuestionTermin();
		public QuestionChoiseAnser question_choise_answer = new QuestionChoiseAnser();
		public QuestionInsertWordQuestion question_insert_word = new QuestionInsertWordQuestion();
		public bool bool_question_termin = false;
		public bool bool_question_choise_answer = false;
		public bool bool_question_insert_word = false;

		public PassedTest passed_test { get; set; }
		public TestQuestion()
		{
			InitializeComponent();
		}
		public void TestQuestion_Load(object sender, EventArgs e)
		{
			page = int.Parse(this.Text);
			label2.Text = Convert.ToString(page);

			if (this.Text == "0")
			{
				button3.Visible = false;
			}
			if (page == test_count_question - 1)
			{
				button2.Visible = false;
				button5.Visible = true;
			}
			else
			{
				button5.Visible = false;
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

			if (bool_question_termin == true)
			{
				Console.WriteLine("bool_question_termin  ");

				Console.WriteLine("ITEM CONTROLS -----  ");
				string text_answer = tableLayoutPanel1.Controls[1].Text;
				if (text_answer == question_termin.termin_value )
				{
					passed_test.assessment = passed_test.assessment + calculate_figure;
					Console.WriteLine(" YEEEEEEEEES ");
				}
				Console.	WriteLine("ITEM CONTROLS -----  ");

			}
			else if (bool_question_choise_answer == true)
			{
				Console.WriteLine("bool_question_choise_answer  ");

				Console.WriteLine("ITEM CONTROLS -----  ");
				foreach (var i in tableLayoutPanel1.Controls)
				{
					Console.WriteLine(i);
				}
				Console.WriteLine("ITEM CONTROLS -----  ");

			}
			else if (bool_question_insert_word == true)
			{
				Console.WriteLine("bool_question_insert_word  ");

				Console.WriteLine("ITEM CONTROLS -----  ");



				//foreach (var i in tableLayoutPanel1.Controls)
				//{
				//	Console.WriteLine(i);
				//}
				Console.WriteLine("ITEM CONTROLS -----  ");
			}
			test_object_questions[page + 1].Show();
			test_object_questions[page].Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			
			test_object_questions[page - 1].Show();
			test_object_questions[page].Hide();
			//if (page != test_count_question - 1)
			//{
			//	test_object_questions[page].Hide();
			//}
		}

		private void label2_Click(object sender, EventArgs e)
		{



		}

		private void TestQuestion_Shown(object sender, EventArgs e)
		{
			tableLayoutPanel1.Controls.Clear();

			// Проверяет какой вопрос true такие данные и будет заполнять
			if (bool_question_termin == true)
			{

				Console.WriteLine("bool_questin_termin 1 ----");
				Console.WriteLine(question_termin.termin_text);
				Label rich_box = new Label();
				TextBox text_box = new TextBox();

				rich_box.Location = new Point(50, 450);
				rich_box.Width = 1000;
				rich_box.Height = 250;
				rich_box.BackColor = Color.FromArgb(69, 69, 97);
				rich_box.ForeColor = Color.White;
				rich_box.Text = question_termin.termin_text;
				tableLayoutPanel1.Controls.Add(rich_box);
				//Controls.Add(rich_box);


				text_box.Location = new Point(250, 25);
				text_box.AutoSize = false;
				text_box.Width = 1000;
				//rich_box.Padding = Padding.All(15,15,15,15);
				text_box.BackColor = Color.FromArgb(69, 69, 97);
				text_box.ForeColor = Color.White;
				text_box.BorderStyle = BorderStyle.None;
				tableLayoutPanel1.Controls.Add(text_box);

			}
			else if (bool_question_choise_answer == true)
			{

				Console.WriteLine("bool_questin_choise_answer 2 ----");
				Console.WriteLine(question_choise_answer.text);
				TableLayoutPanel button_box = new TableLayoutPanel();

				button_box.Location = new Point(50, 50);
				button_box.Width = 1000;
				button_box.Height = 800;
				button_box.BackColor = Color.FromArgb(69, 69, 97);
				button_box.ForeColor = Color.White;

				foreach (var i in question_choise_answer.object_buttons)
				{
					RadioButton but = new RadioButton();
					but.Text = i.name;
					button_box.Controls.Add(but);
				}


				tableLayoutPanel1.Controls.Add(button_box);
			}
			else if (bool_question_insert_word == true)
			{
				Console.WriteLine("bool_questin_insert_word 3 ----");
				// Сделать цикл из label закидывать в grawLayout и там где должно быть пустое место, будет textBox 
				FlowLayoutPanel button_box = new FlowLayoutPanel();
				//foreach (var i in question_insert_word.text)
				button_box.Width = 1000;
				button_box.Height = 800;
				int i = 0;
				string str = question_insert_word.text;
				string[] split = str.Split(' ', '!', '\'');
				int t = 500;
				int l = 20;
				Console.WriteLine("-=================================-");
				foreach (string s in split)
				{
					if (s != "")
					{
						Console.WriteLine(s);
						t = t + 30;
						var lb = new Label();
						lb.Text = s;
						if (t == 710)
						{
							l = l + 30;
						}
						lb.Top = t;
						lb.Left = l;
						lb.ForeColor = Color.CornflowerBlue;
						button_box.Controls.Add(lb);
						Console.WriteLine(s);
						// Controls.Add(lb);
						++i;
					}
				}
				Console.WriteLine("-=================================-");

				tableLayoutPanel1.Controls.Add(button_box);
				Controls.Add(tableLayoutPanel1);

			}


		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Hide();
			passed_test.assessment = passed_test.assessment + calculate_figure;
			string connectionString = "TestBook";
			MongoCRUD db = new MongoCRUD(connectionString);
			db.InsertRecord("PassedTest", passed_test);
			Form1 first_form = new Form1();
			first_form.Show();
		}
	}
}
