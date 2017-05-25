namespace BPtD_Lab4_Server
{
	partial class ServerWindow
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
			this.stopButton = new System.Windows.Forms.Button();
			this.consoleBox = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.addressBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.portBox = new System.Windows.Forms.TextBox();
			this.StartButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// stopButton
			// 
			this.stopButton.Enabled = false;
			this.stopButton.Location = new System.Drawing.Point(397, 10);
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(61, 23);
			this.stopButton.TabIndex = 0;
			this.stopButton.TabStop = false;
			this.stopButton.Text = "Stop";
			this.stopButton.UseVisualStyleBackColor = true;
			this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
			// 
			// consoleBox
			// 
			this.consoleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.consoleBox.Location = new System.Drawing.Point(12, 41);
			this.consoleBox.Name = "consoleBox";
			this.consoleBox.ReadOnly = true;
			this.consoleBox.Size = new System.Drawing.Size(446, 320);
			this.consoleBox.TabIndex = 1;
			this.consoleBox.TabStop = false;
			this.consoleBox.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(191, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Port";
			// 
			// addressBox
			// 
			this.addressBox.Location = new System.Drawing.Point(57, 12);
			this.addressBox.Name = "addressBox";
			this.addressBox.Size = new System.Drawing.Size(128, 20);
			this.addressBox.TabIndex = 4;
			this.addressBox.TabStop = false;
			this.addressBox.Text = "localhost";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Address";
			// 
			// portBox
			// 
			this.portBox.Location = new System.Drawing.Point(223, 12);
			this.portBox.Name = "portBox";
			this.portBox.Size = new System.Drawing.Size(79, 20);
			this.portBox.TabIndex = 4;
			this.portBox.TabStop = false;
			this.portBox.Text = "9580";
			// 
			// StartButton
			// 
			this.StartButton.Location = new System.Drawing.Point(319, 10);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(61, 23);
			this.StartButton.TabIndex = 5;
			this.StartButton.TabStop = false;
			this.StartButton.Text = "Start";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// ServerWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 370);
			this.Controls.Add(this.StartButton);
			this.Controls.Add(this.portBox);
			this.Controls.Add(this.addressBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.consoleBox);
			this.Controls.Add(this.stopButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "ServerWindow";
			this.Text = "Chat server";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button stopButton;
		private System.Windows.Forms.RichTextBox consoleBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox addressBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox portBox;
		private System.Windows.Forms.Button StartButton;
	}
}

