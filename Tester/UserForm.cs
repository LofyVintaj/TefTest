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
		//закрытие окна
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

		//При клике он поменяет добавит бэкграунд
		private void voidLabelMouseClick(object sender, System.EventArgs e)
		{
			var label = (Label)sender;
			label.BackColor = Color.DarkCyan;
		}
		//При двойном клике у нас переходит к самому тесту
		private void LabelMouseDoubleClick(object sender, System.EventArgs e)
		{
			string connectionString = "TestBook";
			MongoCRUD db = new MongoCRUD(connectionString);

			var label = (Label)sender;
			label.BackColor = Color.FromArgb(69, 69, 97);
			var test = db.SearchTest<Test>("Test", label.Text);
			Console.WriteLine(test.ToJson());
		}


		//создание списка ссылок на тесты
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
				label_element.Font = new Font(label1.Font.Name, Convert.ToSingle(20), label1.Font.Style);
				label_element.Width = 500;
				label_element.Height = 50;
				label_element.MouseClick += voidLabelMouseClick;
				label_element.MouseDoubleClick += LabelMouseDoubleClick;
				tableLayoutPanel1.Controls.Add(label_element);
			}


		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
