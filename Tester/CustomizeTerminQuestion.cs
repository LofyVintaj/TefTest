using MongoDB.Bson;
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
		public QuestionTermin object_question = new QuestionTermin();
		public string test_name;
		public int page;
		public Test test = new Test();
		public CustomizeTerminQuestion()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Page");
			Console.WriteLine(page);
			string connectionString = "TestBook";
			MongoCRUD db = new MongoCRUD(connectionString);
			object_question.termin_text = richTextBox1.Text;
			object_question.termin_value = textBox1.Text;
			db.UpdateQuestionsRecord<Test>("Test", test_name, object_question, page);
			this.Hide();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void CustomizeTerminQuestion_Load(object sender, EventArgs e)
		{

		}

		private void CustomizeTerminQuestion_MouseDown(object sender, MouseEventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void button6_MouseDown(object sender, MouseEventArgs e)
		{

		}

		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			panel2.Capture = false;
			Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref m);
		}
	}
}
