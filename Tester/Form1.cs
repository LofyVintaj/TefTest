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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // In this way can create new test question in admin 
            Login frm = new Login();    
            frm.Show();
            // this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("We had load");
            //string connectionString = "TestBook";
            //MongoCRUD db = new MongoCRUD(connectionString);
			//db.SearchRecord<Test>("Test", "leha4");
			//db.UpdateQuestionsRecord<Test>("Test", "leha4");
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

		private void button3_Click(object sender, EventArgs e)
		{
            Application.Exit();
        }

		private void button2_Click(object sender, EventArgs e)
		{
            LoginUser frm = new LoginUser();
            frm.Show();
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
            panel1.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
