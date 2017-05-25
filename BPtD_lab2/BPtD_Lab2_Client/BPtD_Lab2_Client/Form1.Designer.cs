namespace BPtD_Lab2_Client
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
			this.addressBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.requestBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.keyBox = new System.Windows.Forms.RichTextBox();
			this.messageBox = new System.Windows.Forms.TextBox();
			this.chatBox = new System.Windows.Forms.RichTextBox();
			this.sendBtn = new System.Windows.Forms.Button();
			this.encBox = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// addressBox
			// 
			this.addressBox.Location = new System.Drawing.Point(74, 15);
			this.addressBox.Name = "addressBox";
			this.addressBox.Size = new System.Drawing.Size(298, 20);
			this.addressBox.TabIndex = 1;
			this.addressBox.Text = "http://localhost:8030";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Address";
			// 
			// requestBtn
			// 
			this.requestBtn.Location = new System.Drawing.Point(378, 12);
			this.requestBtn.Name = "requestBtn";
			this.requestBtn.Size = new System.Drawing.Size(84, 23);
			this.requestBtn.TabIndex = 3;
			this.requestBtn.Text = "Request key";
			this.requestBtn.UseVisualStyleBackColor = true;
			this.requestBtn.Click += new System.EventHandler(this.requestBtn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Public key";
			// 
			// keyBox
			// 
			this.keyBox.Location = new System.Drawing.Point(74, 50);
			this.keyBox.Name = "keyBox";
			this.keyBox.ReadOnly = true;
			this.keyBox.Size = new System.Drawing.Size(388, 97);
			this.keyBox.TabIndex = 4;
			this.keyBox.Text = "";
			// 
			// messageBox
			// 
			this.messageBox.Location = new System.Drawing.Point(15, 401);
			this.messageBox.Name = "messageBox";
			this.messageBox.Size = new System.Drawing.Size(371, 20);
			this.messageBox.TabIndex = 5;
			// 
			// chatBox
			// 
			this.chatBox.Location = new System.Drawing.Point(15, 153);
			this.chatBox.Name = "chatBox";
			this.chatBox.ReadOnly = true;
			this.chatBox.Size = new System.Drawing.Size(447, 239);
			this.chatBox.TabIndex = 6;
			this.chatBox.Text = "";
			// 
			// sendBtn
			// 
			this.sendBtn.Location = new System.Drawing.Point(392, 399);
			this.sendBtn.Name = "sendBtn";
			this.sendBtn.Size = new System.Drawing.Size(70, 23);
			this.sendBtn.TabIndex = 3;
			this.sendBtn.Text = "Send";
			this.sendBtn.UseVisualStyleBackColor = true;
			this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
			// 
			// encBox
			// 
			this.encBox.Location = new System.Drawing.Point(15, 451);
			this.encBox.Name = "encBox";
			this.encBox.Size = new System.Drawing.Size(447, 84);
			this.encBox.TabIndex = 7;
			this.encBox.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(192, 435);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Encrypted message";
			// 
			// Form1
			// 
			this.AcceptButton = this.sendBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 547);
			this.Controls.Add(this.encBox);
			this.Controls.Add(this.chatBox);
			this.Controls.Add(this.messageBox);
			this.Controls.Add(this.keyBox);
			this.Controls.Add(this.sendBtn);
			this.Controls.Add(this.requestBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.addressBox);
			this.Name = "Form1";
			this.Text = "Main";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox addressBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button requestBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox keyBox;
		private System.Windows.Forms.TextBox messageBox;
		private System.Windows.Forms.RichTextBox chatBox;
		private System.Windows.Forms.Button sendBtn;
		private System.Windows.Forms.RichTextBox encBox;
		private System.Windows.Forms.Label label3;
	}
}

