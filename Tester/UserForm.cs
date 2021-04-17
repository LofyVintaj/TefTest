using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;

namespace Tester
{
	public partial class UserForm : Form
	{
		public UserForm()
		{
			InitializeComponent();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			panel2.Capture = false;
			Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref m);
		}

		private void UserForm_Load(object sender, EventArgs e)
		{
			string connectionString = "TestBook";
			MongoCRUD db = new MongoCRUD(connectionString);
			List<Test> list_tests = db.ListTests<Test>("Test");
			foreach (Test s in list_tests)
			{
				Label label_element = new Label();
				label_element.Text = s.name;
				label_element.ForeColor = Color.White;
				tableLayoutPanel1.Controls.Add(label_element);
			}


		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
