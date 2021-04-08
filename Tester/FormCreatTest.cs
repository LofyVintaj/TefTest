﻿using System;
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
            int count_question;
            string test_name;
            Test test = new Test();
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
            test_name = textBox2.Text;
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
               object_questions[i].test = test;
               object_questions[0].Show();
            }

            string connectionString = "TestBook";
            //MongoClient client = new MongoClient(connectionString);
            //IMongoDatabase database = client.GetDatabase("tester");
            MongoCRUD db = new MongoCRUD(connectionString);
            //db.InsertRecord("User", < Object >);
            db.InsertRecord("Test", new Test
            {
                name = test_name,
                count_question = count_question
            });
			object_questions[count_question - 1].test_name = test_name;

            this.Hide();

        
        }

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
