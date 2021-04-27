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
	public partial class CheckResultTest : Form
	{
		public CheckResultTest()
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

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

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
		}

		private void CheckResultTest_Load(object sender, EventArgs e)
		{
			string connectionString = "TestBook";
			MongoCRUD db = new MongoCRUD(connectionString);
			List<PassedTest> list_passed_tests = db.ListPassedTest<PassedTest>("PassedTest");
			foreach (PassedTest s in list_passed_tests)
			{
				Label label_element = new Label();
				label_element.Text = "Название теста:  " + s.test.name + "\n" + 
									 "ФИО студента: " + s.student.FIO + "\n" +
									 "Оценка: " + s.assessment;
				label_element.ForeColor = Color.White;
				label_element.Font = new Font(label_element.Font.Name, Convert.ToSingle(20), label_element.Font.Style);
				label_element.Width = 800;
				label_element.Height = 100;
				label_element.MouseClick += voidLabelMouseClick;
				label_element.MouseDoubleClick += LabelMouseDoubleClick;
				flowLayoutPanel1.Controls.Add(label_element);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
