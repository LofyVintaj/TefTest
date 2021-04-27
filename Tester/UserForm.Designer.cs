
namespace Tester
{
	partial class UserForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button6 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.button4 = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(53)))));
			this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button6.ForeColor = System.Drawing.Color.Crimson;
			this.button6.Location = new System.Drawing.Point(1210, 3);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(73, 38);
			this.button6.TabIndex = 9;
			this.button6.Text = "X";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(53)))));
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.button6);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1286, 44);
			this.panel2.TabIndex = 14;
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label1.Location = new System.Drawing.Point(42, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 33);
			this.label1.TabIndex = 15;
			this.label1.Text = "Список тестов";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label2.Location = new System.Drawing.Point(706, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 33);
			this.label2.TabIndex = 16;
			this.label2.Text = "Пользователь";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button2.Location = new System.Drawing.Point(1137, 528);
			this.button2.Margin = new System.Windows.Forms.Padding(5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(125, 41);
			this.button2.TabIndex = 17;
			this.button2.Text = "Выбрать";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(97)))));
			this.flowLayoutPanel1.Location = new System.Drawing.Point(48, 126);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(582, 407);
			this.flowLayoutPanel1.TabIndex = 19;
			// 
			// button4
			// 
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.ForeColor = System.Drawing.Color.DarkCyan;
			this.button4.Location = new System.Drawing.Point(1137, 3);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(70, 38);
			this.button4.TabIndex = 20;
			this.button4.Text = "-";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// UserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(1286, 583);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "UserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UserForm";
			this.Load += new System.EventHandler(this.UserForm_Load);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button button4;
	}
}