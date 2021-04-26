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
	public partial class LoginUser : Form
	{
		public LoginUser()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form1 frm = new Form1();
			frm.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if ( textBox3.Text == "" || textBox2.Text == "" )
			{
				MessageBox.Show("Вы не ввели значения");
				return;
			}

			string connectionString = "TestBook";
			string FIO = textBox3.Text;
			string Group = textBox2.Text;
			//MongoClient client = new MongoClient(connectionString);
			//IMongoDatabase database = client.GetDatabase("tester");
			MongoCRUD db = new MongoCRUD(connectionString);
			//db.InsertRecord("User", < Object >);
			Student student = new Student{
				FIO = FIO,
				Group = Group
			};
			db.InsertRecord("Student", student);
			UserForm frm = new UserForm();
			frm.student = student;
			frm.Show();
			frm.label2.Text = FIO;
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			panel1.Capture = false;
			Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref m);
		}
	}
}
