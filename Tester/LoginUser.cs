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
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string connectionString = "TestBook";
			string FIO = textBox3.Text;
			string Group = textBox2.Text;
			//MongoClient client = new MongoClient(connectionString);
			//IMongoDatabase database = client.GetDatabase("tester");
			MongoCRUD db = new MongoCRUD(connectionString);
			//db.InsertRecord("User", < Object >);
			db.InsertRecord("Student", new Student
			{
				FIO = FIO,
				Group = Group
			});
			User frm = new User();
			frm.Show();
			frm.label1.Text = FIO;
		}
	}
}
