namespace Bptd_Lab3
{
	partial class Form1
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
			this.openFileBtn1 = new System.Windows.Forms.Button();
			this.fileBox1 = new System.Windows.Forms.TextBox();
			this.openSignBtn = new System.Windows.Forms.Button();
			this.signBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.openFileD1 = new System.Windows.Forms.OpenFileDialog();
			this.openSignD = new System.Windows.Forms.OpenFileDialog();
			this.hashl = new System.Windows.Forms.Label();
			this.hashBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.fileBox2 = new System.Windows.Forms.TextBox();
			this.openFileBtn2 = new System.Windows.Forms.Button();
			this.hashBox2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.openFileD2 = new System.Windows.Forms.OpenFileDialog();
			this.changedFileLabel = new System.Windows.Forms.Label();
			this.makeSignBtn = new System.Windows.Forms.Button();
			this.saveSignD = new System.Windows.Forms.SaveFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.correctSignLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileBtn1
			// 
			this.openFileBtn1.Location = new System.Drawing.Point(269, 30);
			this.openFileBtn1.Name = "openFileBtn1";
			this.openFileBtn1.Size = new System.Drawing.Size(75, 23);
			this.openFileBtn1.TabIndex = 0;
			this.openFileBtn1.Text = "Open file";
			this.openFileBtn1.UseVisualStyleBackColor = true;
			this.openFileBtn1.Click += new System.EventHandler(this.openFileBtn1_Click);
			// 
			// fileBox1
			// 
			this.fileBox1.Location = new System.Drawing.Point(47, 32);
			this.fileBox1.Name = "fileBox1";
			this.fileBox1.Size = new System.Drawing.Size(201, 20);
			this.fileBox1.TabIndex = 1;
			// 
			// openSignBtn
			// 
			this.openSignBtn.Location = new System.Drawing.Point(269, 94);
			this.openSignBtn.Name = "openSignBtn";
			this.openSignBtn.Size = new System.Drawing.Size(75, 23);
			this.openSignBtn.TabIndex = 0;
			this.openSignBtn.Text = "Open sign";
			this.openSignBtn.UseVisualStyleBackColor = true;
			this.openSignBtn.Click += new System.EventHandler(this.openSignBtn_Click);
			// 
			// signBox
			// 
			this.signBox.Location = new System.Drawing.Point(47, 96);
			this.signBox.Name = "signBox";
			this.signBox.Size = new System.Drawing.Size(201, 20);
			this.signBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "File";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Sign";
			// 
			// hashl
			// 
			this.hashl.AutoSize = true;
			this.hashl.Location = new System.Drawing.Point(13, 67);
			this.hashl.Name = "hashl";
			this.hashl.Size = new System.Drawing.Size(32, 13);
			this.hashl.TabIndex = 2;
			this.hashl.Text = "Hash";
			// 
			// hashBox1
			// 
			this.hashBox1.Location = new System.Drawing.Point(47, 64);
			this.hashBox1.Name = "hashBox1";
			this.hashBox1.Size = new System.Drawing.Size(151, 20);
			this.hashBox1.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.correctSignLabel);
			this.groupBox1.Controls.Add(this.changedFileLabel);
			this.groupBox1.Controls.Add(this.fileBox1);
			this.groupBox1.Controls.Add(this.makeSignBtn);
			this.groupBox1.Controls.Add(this.openFileBtn1);
			this.groupBox1.Controls.Add(this.hashBox1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.hashl);
			this.groupBox1.Controls.Add(this.signBox);
			this.groupBox1.Controls.Add(this.openSignBtn);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(351, 153);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Source file";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.fileBox2);
			this.groupBox2.Controls.Add(this.openFileBtn2);
			this.groupBox2.Controls.Add(this.hashBox2);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(382, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(351, 153);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Fake file";
			// 
			// fileBox2
			// 
			this.fileBox2.Location = new System.Drawing.Point(47, 32);
			this.fileBox2.Name = "fileBox2";
			this.fileBox2.Size = new System.Drawing.Size(201, 20);
			this.fileBox2.TabIndex = 1;
			// 
			// openFileBtn2
			// 
			this.openFileBtn2.Location = new System.Drawing.Point(269, 30);
			this.openFileBtn2.Name = "openFileBtn2";
			this.openFileBtn2.Size = new System.Drawing.Size(75, 23);
			this.openFileBtn2.TabIndex = 0;
			this.openFileBtn2.Text = "Open file";
			this.openFileBtn2.UseVisualStyleBackColor = true;
			this.openFileBtn2.Click += new System.EventHandler(this.openFileBtn2_Click);
			// 
			// hashBox2
			// 
			this.hashBox2.Location = new System.Drawing.Point(47, 64);
			this.hashBox2.Name = "hashBox2";
			this.hashBox2.Size = new System.Drawing.Size(151, 20);
			this.hashBox2.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Hash";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 35);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "File";
			// 
			// changedFileLabel
			// 
			this.changedFileLabel.AutoSize = true;
			this.changedFileLabel.ForeColor = System.Drawing.Color.Red;
			this.changedFileLabel.Location = new System.Drawing.Point(143, 128);
			this.changedFileLabel.Name = "changedFileLabel";
			this.changedFileLabel.Size = new System.Drawing.Size(68, 13);
			this.changedFileLabel.TabIndex = 5;
			this.changedFileLabel.Text = "File changed";
			this.changedFileLabel.Visible = false;
			// 
			// makeSignBtn
			// 
			this.makeSignBtn.Location = new System.Drawing.Point(269, 62);
			this.makeSignBtn.Name = "makeSignBtn";
			this.makeSignBtn.Size = new System.Drawing.Size(75, 23);
			this.makeSignBtn.TabIndex = 0;
			this.makeSignBtn.Text = "Make sign";
			this.makeSignBtn.UseVisualStyleBackColor = true;
			this.makeSignBtn.Click += new System.EventHandler(this.makeSignBtn_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(138, 99);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Recount hash";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// correctSignLabel
			// 
			this.correctSignLabel.AutoSize = true;
			this.correctSignLabel.ForeColor = System.Drawing.Color.ForestGreen;
			this.correctSignLabel.Location = new System.Drawing.Point(63, 128);
			this.correctSignLabel.Name = "correctSignLabel";
			this.correctSignLabel.Size = new System.Drawing.Size(74, 13);
			this.correctSignLabel.TabIndex = 6;
			this.correctSignLabel.Text = "Sign is correct";
			this.correctSignLabel.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(745, 180);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button openFileBtn1;
		private System.Windows.Forms.TextBox fileBox1;
		private System.Windows.Forms.Button openSignBtn;
		private System.Windows.Forms.TextBox signBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.OpenFileDialog openFileD1;
		private System.Windows.Forms.OpenFileDialog openSignD;
		private System.Windows.Forms.Label hashl;
		private System.Windows.Forms.TextBox hashBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label changedFileLabel;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox fileBox2;
		private System.Windows.Forms.Button openFileBtn2;
		private System.Windows.Forms.TextBox hashBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.OpenFileDialog openFileD2;
		private System.Windows.Forms.Button makeSignBtn;
		private System.Windows.Forms.SaveFileDialog saveSignD;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label correctSignLabel;
	}
}

