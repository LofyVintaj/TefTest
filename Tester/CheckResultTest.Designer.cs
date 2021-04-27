
namespace Tester
{
	partial class CheckResultTest
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
			this.button4 = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
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
			this.button6.Location = new System.Drawing.Point(895, 3);
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
			this.panel2.Size = new System.Drawing.Size(971, 44);
			this.panel2.TabIndex = 14;
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			// 
			// button4
			// 
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.ForeColor = System.Drawing.Color.DarkCyan;
			this.button4.Location = new System.Drawing.Point(819, 2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(70, 38);
			this.button4.TabIndex = 15;
			this.button4.Text = "-";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(97)))));
			this.flowLayoutPanel1.ForeColor = System.Drawing.Color.White;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 62);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(934, 462);
			this.flowLayoutPanel1.TabIndex = 19;
			this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 23);
			this.label1.TabIndex = 20;
			// 
			// CheckResultTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(971, 542);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "CheckResultTest";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CheckResultTest";
			this.Load += new System.EventHandler(this.CheckResultTest_Load);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button4;
	}
}