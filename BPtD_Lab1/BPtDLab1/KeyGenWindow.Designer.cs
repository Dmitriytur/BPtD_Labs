namespace BPtDLab1
{
	partial class KeyGenWindow
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
			this.keyTextBox = new System.Windows.Forms.RichTextBox();
			this.keyGenButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// keyTextBox
			// 
			this.keyTextBox.Location = new System.Drawing.Point(12, 12);
			this.keyTextBox.Name = "keyTextBox";
			this.keyTextBox.ReadOnly = true;
			this.keyTextBox.Size = new System.Drawing.Size(260, 96);
			this.keyTextBox.TabIndex = 0;
			this.keyTextBox.Text = "";
			// 
			// keyGenButton
			// 
			this.keyGenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.keyGenButton.Location = new System.Drawing.Point(74, 114);
			this.keyGenButton.Name = "keyGenButton";
			this.keyGenButton.Size = new System.Drawing.Size(120, 29);
			this.keyGenButton.TabIndex = 1;
			this.keyGenButton.Text = "Generate key";
			this.keyGenButton.UseVisualStyleBackColor = true;
			this.keyGenButton.Click += new System.EventHandler(this.keyGenButton_Click);
			// 
			// KeyGenWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 158);
			this.Controls.Add(this.keyGenButton);
			this.Controls.Add(this.keyTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "KeyGenWindow";
			this.ShowIcon = false;
			this.Text = "KeyGenWindow";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox keyTextBox;
		private System.Windows.Forms.Button keyGenButton;
	}
}