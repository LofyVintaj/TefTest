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
	public partial class CustomizeChoiseAnswerQuestion : Form
	{
		public QuestionChoiseAnser object_question = new QuestionChoiseAnser();
		public List<RadioDataQuestion> kk = new List<RadioDataQuestion>();
		public string test_name;
		public int page;
		public Test test = new Test();
		public int count_nazh_but2;

		public CustomizeChoiseAnswerQuestion()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string connectionString = "TestBook";
			MongoCRUD db = new MongoCRUD(connectionString);
			object_question.text = richTextBox1.Text;
			

			int count = 0;
			foreach (RadioButton i in flowLayoutPanel1.Controls)
			{
				Console.WriteLine(i);
				if (i.Checked == true)
				{
					MessageBox.Show(i.Text);
					kk[count].or_right = true;
				}
				count++;
			}
			object_question.object_buttons = kk;
			//object_question.termin_value = textBox1.Text;
			db.UpdateQuestionsChoiseAnswerRecord("Test", test_name, object_question, page);
			this.Hide();
		}

		private void CustomizeChoiseAnswerQuestion_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			string connectionString = "TestBook";
			int count_object_gruopBox = 0;
			MongoCRUD db = new MongoCRUD(connectionString);
			//db.UpdateQuestionsRecord<Test>("Test", test_name, object_question, page);
			//object_question.object_buttons.Add(but_object);


			int top_top = 20;
			var btn = new RadioButton();
			btn.Text = textBox1.Text;
			//btn.Top = 480;
			//btn.Left = 20;
			flowLayoutPanel1.Controls.Add(btn);

			for (int i = 0; i < count_nazh_but2; i++)
			{
				top_top += 20;
			}
			btn.Top = top_top;
			btn.Left = 10;

			Console.WriteLine("----");
			foreach (object i in flowLayoutPanel1.Controls)
			{
				Console.WriteLine(i);
				count_object_gruopBox += 1;
			}
			Console.WriteLine("----");

			RadioDataQuestion but_object = new RadioDataQuestion();
			but_object.name = textBox1.Text;
			kk.Add(but_object);
			count_nazh_but2 += 1;
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			panel2.Capture = false;
			Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref m);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
