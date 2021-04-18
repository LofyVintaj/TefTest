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
		public QuestionTermin questin_termin = new QuestionTermin();
		public QuestionChoiseAnser questin_choise_answer = new QuestionChoiseAnser();
		public QuestionInsertWordQuestion questin_insert_word = new QuestionInsertWordQuestion();
		public bool bool_questin_termin = false;
		public bool bool_questin_choise_answer = false;
		public bool bool_questin_insert_word = false;
		public TestQuestion()
		{
			InitializeComponent();
		}
		public void TestQuestion_Load(object sender, EventArgs e)
		{
			if ( bool_questin_termin == true)
			{
				Console.WriteLine("1");
			}
			else if (bool_questin_choise_answer == true)
			{
				Console.WriteLine("2");
			}
			else if (bool_questin_insert_word == true)
			{
				Console.WriteLine("3");
			}
		}
	}
}
