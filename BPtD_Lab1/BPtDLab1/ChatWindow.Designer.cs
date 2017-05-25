namespace BPtDLab1
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
			this.messageBox = new System.Windows.Forms.RichTextBox();
			this.sendButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// chatBox
			// 
			this.chatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chatBox.Location = new System.Drawing.Point(12, 12);
			this.chatBox.Name = "chatBox";
			this.chatBox.ReadOnly = true;
			this.chatBox.Size = new System.Drawing.Size(641, 341);
			this.chatBox.TabIndex = 0;
			this.chatBox.Text = "";
			// 
			// messageBox
			// 
			this.messageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.messageBox.Location = new System.Drawing.Point(12, 360);
			this.messageBox.Name = "messageBox";
			this.messageBox.Size = new System.Drawing.Size(530, 67);
			this.messageBox.TabIndex = 1;
			this.messageBox.Text = "";
			// 
			// sendButton
			// 
			this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sendButton.Location = new System.Drawing.Point(566, 369);
			this.sendButton.Name = "sendButton";
			this.sendButton.Size = new System.Drawing.Size(75, 40);
			this.sendButton.TabIndex = 2;
			this.sendButton.Text = "Send";
			this.sendButton.UseVisualStyleBackColor = true;
			this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
			// 
			// ChatWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(665, 437);
			this.Controls.Add(this.sendButton);
			this.Controls.Add(this.messageBox);
			this.Controls.Add(this.chatBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "ChatWindow";
			this.Text = "ChatWindow";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox chatBox;
		private System.Windows.Forms.RichTextBox messageBox;
		private System.Windows.Forms.Button sendButton;
	}
}