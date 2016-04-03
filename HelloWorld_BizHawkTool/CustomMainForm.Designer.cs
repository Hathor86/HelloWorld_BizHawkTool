namespace BizHawk.Client.EmuHawk
{
	public partial class CustomMainForm
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
			this.label_Watch1 = new System.Windows.Forms.Label();
			this.label_Watch2 = new System.Windows.Forms.Label();
			this.label_Watch3 = new System.Windows.Forms.Label();
			this.label_Game = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label_GameHash = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_Watch1
			// 
			this.label_Watch1.AutoSize = true;
			this.label_Watch1.Location = new System.Drawing.Point(12, 57);
			this.label_Watch1.Name = "label_Watch1";
			this.label_Watch1.Size = new System.Drawing.Size(35, 13);
			this.label_Watch1.TabIndex = 0;
			this.label_Watch1.Text = "label1";
			// 
			// label_Watch2
			// 
			this.label_Watch2.AutoSize = true;
			this.label_Watch2.Location = new System.Drawing.Point(12, 79);
			this.label_Watch2.Name = "label_Watch2";
			this.label_Watch2.Size = new System.Drawing.Size(35, 13);
			this.label_Watch2.TabIndex = 1;
			this.label_Watch2.Text = "label2";
			// 
			// label_Watch3
			// 
			this.label_Watch3.AutoSize = true;
			this.label_Watch3.Location = new System.Drawing.Point(12, 102);
			this.label_Watch3.Name = "label_Watch3";
			this.label_Watch3.Size = new System.Drawing.Size(35, 13);
			this.label_Watch3.TabIndex = 2;
			this.label_Watch3.Text = "label3";
			// 
			// label_Game
			// 
			this.label_Game.AutoSize = true;
			this.label_Game.Location = new System.Drawing.Point(13, 13);
			this.label_Game.Name = "label_Game";
			this.label_Game.Size = new System.Drawing.Size(35, 13);
			this.label_Game.TabIndex = 3;
			this.label_Game.Text = "label4";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(176, 226);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Frame Advance";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label_GameHash
			// 
			this.label_GameHash.AutoSize = true;
			this.label_GameHash.Location = new System.Drawing.Point(13, 35);
			this.label_GameHash.Name = "label_GameHash";
			this.label_GameHash.Size = new System.Drawing.Size(35, 13);
			this.label_GameHash.TabIndex = 5;
			this.label_GameHash.Text = "label5";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(72, 197);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(98, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Current Buttons";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(72, 226);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(98, 23);
			this.button3.TabIndex = 7;
			this.button3.Text = "10 A Press";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// CustomMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label_GameHash);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label_Game);
			this.Controls.Add(this.label_Watch3);
			this.Controls.Add(this.label_Watch2);
			this.Controls.Add(this.label_Watch1);
			this.Name = "CustomMainForm";
			this.Text = "HelloWorld";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_Watch1;
		private System.Windows.Forms.Label label_Watch2;
		private System.Windows.Forms.Label label_Watch3;
		private System.Windows.Forms.Label label_Game;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label_GameHash;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}