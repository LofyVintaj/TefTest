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
            string path = "admin.txt";
            StreamReader fileI = new StreamReader(path);
            string line = fileI.ReadLine();
            var line1 = File.ReadLines(path).ElementAt(0);
            var line2 = File.ReadLines(path).ElementAt(1);
            string username = line1;
            string password = line2;
            if (username == textBox1.Text & password == textBox2.Text)
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
                textBox1.Text = "";
                textBox2.Text = "";
            } 
            label2.Text = line1;
            label3.Text = line2;

            fileI.Close();  
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
