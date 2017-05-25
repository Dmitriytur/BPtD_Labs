namespace BPtDLab1
{
	partial class MainWindow
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.genereteKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addressBox = new System.Windows.Forms.TextBox();
			this.portBox = new System.Windows.Forms.TextBox();
			this.keyBox = new System.Windows.Forms.TextBox();
			this.openChatButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.waitButton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genereteKeyToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// genereteKeyToolStripMenuItem
			// 
			this.genereteKeyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateKeyToolStripMenuItem});
			this.genereteKeyToolStripMenuItem.Name = "genereteKeyToolStripMenuItem";
			this.genereteKeyToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.genereteKeyToolStripMenuItem.Text = "Keys";
			// 
			// generateKeyToolStripMenuItem
			// 
			this.generateKeyToolStripMenuItem.Name = "generateKeyToolStripMenuItem";
			this.generateKeyToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.generateKeyToolStripMenuItem.Text = "Generate key";
			this.generateKeyToolStripMenuItem.Click += new System.EventHandler(this.generateKeyToolStripMenuItem_Click);
			// 
			// addressBox
			// 
			this.addressBox.Location = new System.Drawing.Point(82, 40);
			this.addressBox.Name = "addressBox";
			this.addressBox.Size = new System.Drawing.Size(167, 20);
			this.addressBox.TabIndex = 1;
			this.addressBox.Text = "localhost";
			// 
			// portBox
			// 
			this.portBox.Location = new System.Drawing.Point(82, 69);
			this.portBox.Name = "portBox";
			this.portBox.Size = new System.Drawing.Size(167, 20);
			this.portBox.TabIndex = 2;
			this.portBox.Text = "11000";
			// 
			// keyBox
			// 
			this.keyBox.Location = new System.Drawing.Point(82, 95);
			this.keyBox.Name = "keyBox";
			this.keyBox.Size = new System.Drawing.Size(167, 20);
			this.keyBox.TabIndex = 3;
			this.keyBox.Text = "e48f09fe8f1458da";
			// 
			// openChatButton
			// 
			this.openChatButton.Location = new System.Drawing.Point(26, 130);
			this.openChatButton.Name = "openChatButton";
			this.openChatButton.Size = new System.Drawing.Size(76, 23);
			this.openChatButton.TabIndex = 4;
			this.openChatButton.Text = "Connect";
			this.openChatButton.UseVisualStyleBackColor = true;
			this.openChatButton.Click += new System.EventHandler(this.openChatButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Address";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Port";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Key";
			// 
			// waitButton
			// 
			this.waitButton.Location = new System.Drawing.Point(134, 130);
			this.waitButton.Name = "waitButton";
			this.waitButton.Size = new System.Drawing.Size(116, 23);
			this.waitButton.TabIndex = 6;
			this.waitButton.Text = "Wait for connection";
			this.waitButton.UseVisualStyleBackColor = true;
			this.waitButton.Click += new System.EventHandler(this.waitButton_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 188);
			this.Controls.Add(this.waitButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.openChatButton);
			this.Controls.Add(this.keyBox);
			this.Controls.Add(this.portBox);
			this.Controls.Add(this.addressBox);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.Text = "MainWindow";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem genereteKeyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem generateKeyToolStripMenuItem;
		private System.Windows.Forms.TextBox addressBox;
		private System.Windows.Forms.TextBox portBox;
		private System.Windows.Forms.TextBox keyBox;
		private System.Windows.Forms.Button openChatButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button waitButton;
	}
}