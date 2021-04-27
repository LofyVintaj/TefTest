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
	public partial class CustiomizeInstertWordQuestion : Form
	{

		public QuestionInsertWordQuestion object_question = new QuestionInsertWordQuestion();
		public string test_name;
		public int page;
		public Test test = new Test();
		public List<int> list_index = new List<int>();

		public CustiomizeInstertWordQuestion()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string connectionString = "TestBook";
			MongoCRUD db = new MongoCRUD(connectionString);
			object_question.text = richTextBox1.Text;
			object_question.list_index = list_index;
			//object_question.termin_value = textBox1.Text;
			db.UpdateQuestionsInstertWordQuestionRecord("Test", test_name, object_question, page);
			this.Hide();
		}

		private void CustiomizeInstertWordQuestion_Load(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			panel2.Capture = false;
			Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref m);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void voidLabelMouseClick(object sender, System.EventArgs e)
		{
			var label = (Label)sender;
			label.BackColor = Color.White;

			string need_text = label.Text;

			int i = 0;
			string str = richTextBox1.Text;
			string[] split = str.Split(' ', '!', '\'');
			int t = 500;
			int l = 20;
			foreach (string s in split)
			{
				if (s != "")
				{
					Console.WriteLine(s);
					t = t + 30;
					var lb = new Label();
					if (s == need_text)
					{
						Console.WriteLine("Есть сходство");
						Console.WriteLine(need_text);
						Console.WriteLine(s);
						Console.WriteLine("Индекс");
						Console.WriteLine(i);
						list_index.Add(i);
					}
					// Controls.Add(lb);
					++i;
				}
			}

			Console.WriteLine("Всего слов -> {0}", i);

		}

		private void LabelMouseDoubleClick(object sender, System.EventArgs e)
		{
			var label = (Label)sender;
			label.BackColor = Color.FromArgb(47, 47, 66);

			string need_text = label.Text;

			int i = 0;
			string str = richTextBox1.Text;
			string[] split = str.Split(' ', '!', '\'');
			int t = 500;
			int l = 20;
			foreach (string s in split)
			{
				if (s != "")
				{
					Console.WriteLine(s);
					t = t + 30;
					var lb = new Label();
					if (s == need_text)
					{
						Console.WriteLine("Есть сходство");
						Console.WriteLine(need_text);
						Console.WriteLine(s);
						Console.WriteLine("Индекс");
						Console.WriteLine(i);
						list_index.Remove(i);
					}
					// Controls.Add(lb);
					++i;
				}
			}

			Console.WriteLine("Всего слов -> {0}", i);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			int i = 0;
			string str = richTextBox1.Text;
			string[] split = str.Split(' ', '!', '\'');
			int t = 500;
			int l = 20;
			foreach (string s in split)
			{
				if (s != "")
				{
					Console.WriteLine(s);
					t = t + 30;
					var lb = new Label();
					lb.Text = s;
					if (t == 710)
					{
						l = l + 30;
					}
					lb.AutoSize = true;
					lb.Top = t;
					lb.Left = l;
					lb.ForeColor = Color.CornflowerBlue;
					lb.MouseClick += voidLabelMouseClick;
					lb.MouseDoubleClick += LabelMouseDoubleClick;
					flowLayoutPanel1.Controls.Add(lb);
					// Controls.Add(lb);
					++i;
				}
			}

			Console.WriteLine("Всего слов -> {0}", i);
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
