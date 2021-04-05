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
    public partial class FormCreatTest : Form
    {
        // ChoiseRadio

        public class RadioDataQuestion
        {
            // Объект теста
            public String name { get; set; }
            public bool or_right { get; set; }
        }


        public class Test
        {
            // Объект теста
            public String name { get; set; }
            public int count_question
            {
                get; set;
            }
        }

            // Объекты вопросов
        public class QuestionChoiseAnser
        {
            public List<RadioDataQuestion> object_questions = new List<RadioDataQuestion>();

        }
        public class QuestionTermin
        {
            public String termin_text { get; set; }
            public String termin_right_value { get; set; }
            public int appraisal { get; set; }
        }
        public class QuestionInsertWordQuestion
        {
            public String text { get; set; }
        }

        public FormCreatTest()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            

            int count_question;
            if (textBox1.Text == "0")
			{
                MessageBox.Show(
                       "Error you input 0",
                       "message",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
                this.Show();
            }
            count_question = Int32.Parse(textBox1.Text);
            List<CustomizeQuestion> object_questions = new List<CustomizeQuestion>();

            for (int i = 0; i < count_question; i++)
            {
                object_questions.Add(new CustomizeQuestion());
            }

            for (int i = 0; i < count_question; i++)
            {
               object_questions[i].Text = Convert.ToString(i);
               object_questions[i].object_questions = object_questions;
                object_questions[i].count_question = count_question;
                object_questions[0].Show();
            }
            this.Hide();

        
        }

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
