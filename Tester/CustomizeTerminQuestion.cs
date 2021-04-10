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
			string connectionString = "TestBook";
			MongoCRUD db = new MongoCRUD(connectionString);
			object_question.termin_text = richTextBox1.Text;
			object_question.termin_value = textBox1.Text;
			db.UpdateQuestionsRecord<Test>("Test", "leha", object_question);
			this.Hide();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
