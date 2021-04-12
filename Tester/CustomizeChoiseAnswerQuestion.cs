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
		public new List<RadioDataQuestion> kk = new List<RadioDataQuestion>();
		public string test_name;
		public int page;
		public Test test = new Test();

		public CustomizeChoiseAnswerQuestion()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string connectionString = "TestBook";
			MongoCRUD db = new MongoCRUD(connectionString);
			object_question.text = richTextBox1.Text;
			object_question.object_buttons = kk;
			//object_question.termin_value = textBox1.Text;
			db.UpdateQuestionsRecord<Test>("Test", test_name, object_question, page);
			this.Hide();
		}

		private void CustomizeChoiseAnswerQuestion_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

			string connectionString = "TestBook";
			MongoCRUD db = new MongoCRUD(connectionString);
			//db.UpdateQuestionsRecord<Test>("Test", test_name, object_question, page);

			//object_question.object_buttons.Add(but_object);

			var btn = new Button();
			btn.Text = textBox1.Text;
			btn.Top = 480;
			btn.Left = 20;
			btn.ForeColor = Color.DarkOrchid;
			btn.FlatAppearance.BorderColor = Color.DarkOrchid;
			btn.Width = 125;
			btn.Height = 41;
			Controls.Add(btn);

			RadioDataQuestion but_object = new RadioDataQuestion();
			but_object.name = textBox1.Text;
			kk.Add(but_object);
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
	}
}
