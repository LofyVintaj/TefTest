using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tester
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Вы не ввели значения");
                return;
            }

            this.Cursor = System.Windows.Forms.Cursors.Default;
            string path = "admin.txt";
            StreamReader fileI = new StreamReader(path);
            string line = fileI.ReadLine();
            var line1 = File.ReadLines(path).ElementAt(0);
            var line2 = File.ReadLines(path).ElementAt(1);
            string username = line1;
            string password = line2;
            if (username == textBox3.Text & password == textBox2.Text)
            {
                label1.Text = " yeah, you entered ";
                Admin admin = new Admin();
                admin.Show();
            }
            else {
                MessageBox.Show(
                        "Error username or password",
                        "message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                textBox3.Text = "";
                textBox2.Text = "";
            } 
            label2.Text = line1;
            label3.Text = line2;

            fileI.Close();  
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void Login_Load(object sender, EventArgs e)
		{
            textBox2.UseSystemPasswordChar = true;
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

		private void label1_Click(object sender, EventArgs e)
		{
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

		private void label2_Click(object sender, EventArgs e)
		{
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

		private void label3_Click(object sender, EventArgs e)
		{
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

		private void button3_Click(object sender, EventArgs e)
		{
            //Application.Exit();
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

		private void button1_Click_1(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
            panel1.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
            panel1.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

		private void button4_Click(object sender, EventArgs e)
		{
            this.WindowState = FormWindowState.Minimized;
        }
	}
}
