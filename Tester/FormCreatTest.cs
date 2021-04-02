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
        public FormCreatTest()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            int count_question = Int32.Parse(textBox1.Text);
                List<CustomizeQuestion> object_questions = new List<CustomizeQuestion>();

            for (int i = 0; i < count_question; i++)
            {
                object_questions.Add(new CustomizeQuestion());
            }

            for (int i = 0; i < count_question; i++)
            {
                object_questions[i].Text = Convert.ToString(i);
            }

            object_questions[0].Show();

        }
	}
}
