namespace BPtD_Lab4_Client
{
	partial class ChatWindow
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
			this.chatBox = new System.Windows.Forms.RichTextBox();
			this.messageBox = new System.Windows.Forms.TextBox();
			this.sendButton = new System.Windows.Forms.Button();
			this.connectBtn = new System.Windows.Forms.Button();
			this.disconnectBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.addressBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.portBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.userNameBox = new System.Windows.Forms.TextBox();
			this.logCheckBox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// chatBox
			// 
			this.chatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chatBox.Location = new System.Drawing.Point(12, 70);
			this.chatBox.Name = "chatBox";
			this.chatBox.ReadOnly = true;
			this.chatBox.Size = new System.Drawing.Size(439, 262);
			this.chatBox.TabIndex = 0;
			this.chatBox.TabStop = false;
			this.chatBox.Text = "";
			// 
			// messageBox
			// 
			this.messageBox.Enabled = false;
			this.messageBox.Location = new System.Drawing.Point(12, 340);
			this.messageBox.Name = "messageBox";
			this.messageBox.Size = new System.Drawing.Size(358, 20);
			this.messageBox.TabIndex = 3;
			// 
			// sendButton
			// 
			this.sendButton.Enabled = false;
			this.sendButton.Location = new System.Drawing.Point(376, 338);
			this.sendButton.Name = "sendButton";
			this.sendButton.Size = new System.Drawing.Size(75, 23);
			this.sendButton.TabIndex = 4;
			this.sendButton.Text = "Send";
			this.sendButton.UseVisualStyleBackColor = true;
			this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
			// 
			// connectBtn
			// 
			this.connectBtn.Location = new System.Drawing.Point(376, 12);
			this.connectBtn.Name = "connectBtn";
			this.connectBtn.Size = new System.Drawing.Size(75, 23);
			this.connectBtn.TabIndex = 5;
			this.connectBtn.Text = "Connect";
			this.connectBtn.UseVisualStyleBackColor = true;
			this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
			// 
			// disconnectBtn
			// 
			this.disconnectBtn.Enabled = false;
			this.disconnectBtn.Location = new System.Drawing.Point(376, 41);
			this.disconnectBtn.Name = "disconnectBtn";
			this.disconnectBtn.Size = new System.Drawing.Size(75, 23);
			this.disconnectBtn.TabIndex = 5;
			this.disconnectBtn.Text = "Disconnect";
			this.disconnectBtn.UseVisualStyleBackColor = true;
			this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Address";
			// 
			// addressBox
			// 
			this.addressBox.Location = new System.Drawing.Point(76, 12);
			this.addressBox.Name = "addressBox";
			this.addressBox.Size = new System.Drawing.Size(145, 20);
			this.addressBox.TabIndex = 7;
			this.addressBox.Text = "localhost";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(227, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Port";
			// 
			// portBox
			// 
			this.portBox.Location = new System.Drawing.Point(256, 12);
			this.portBox.Name = "portBox";
			this.portBox.Size = new System.Drawing.Size(71, 20);
			this.portBox.TabIndex = 7;
			this.portBox.Text = "9580";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "User name";
			// 
			// userNameBox
			// 
			this.userNameBox.Location = new System.Drawing.Point(76, 38);
			this.userNameBox.Name = "userNameBox";
			this.userNameBox.Size = new System.Drawing.Size(107, 20);
			this.userNameBox.TabIndex = 7;
			this.userNameBox.Text = "User1";
			// 
			// logCheckBox
			// 
			this.logCheckBox.AutoSize = true;
			this.logCheckBox.Location = new System.Drawing.Point(230, 41);
			this.logCheckBox.Name = "logCheckBox";
			this.logCheckBox.Size = new System.Drawing.Size(44, 17);
			this.logCheckBox.TabIndex = 8;
			this.logCheckBox.Text = "Log";
			this.logCheckBox.UseVisualStyleBackColor = true;
			this.logCheckBox.CheckedChanged += new System.EventHandler(this.logCheckBox_CheckedChanged);
			// 
			// ChatWindow
			// 
			this.AcceptButton = this.sendButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 368);
			this.Controls.Add(this.logCheckBox);
			this.Controls.Add(this.portBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.userNameBox);
			this.Controls.Add(this.addressBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.disconnectBtn);
			this.Controls.Add(this.connectBtn);
			this.Controls.Add(this.sendButton);
			this.Controls.Add(this.messageBox);
			this.Controls.Add(this.chatBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "ChatWindow";
			this.Text = "ChatWindow";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox chatBox;
		private System.Windows.Forms.TextBox messageBox;
		private System.Windows.Forms.Button sendButton;
		private System.Windows.Forms.Button connectBtn;
		private System.Windows.Forms.Button disconnectBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox addressBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox portBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox userNameBox;
		private System.Windows.Forms.CheckBox logCheckBox;
	}
}