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
			//object_question.termin_value = textBox1.Text;
			db.UpdateQuestionsRecord<Test>("Test", test_name, object_question, page);
			this.Hide();
		}

		private void CustomizeChoiseAnswerQuestion_Load(object sender, EventArgs e)
		{

		}
	}
}
