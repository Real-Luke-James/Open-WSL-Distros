
namespace Open_WSL_Distros
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.ubuntu1 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.ubuntu2 = new System.Windows.Forms.Button();
			this.ubuntu3 = new System.Windows.Forms.Button();
			this.ubuntu4 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cascadia Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(137, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(819, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Press any button to open that specific distro in a new window.";
			this.label1.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(307, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(441, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Once opened, you can close this window.";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Open_WSL_Distros.Properties.Resources.WSL;
			this.pictureBox1.Location = new System.Drawing.Point(41, 47);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(49, 50);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// ubuntu1
			// 
			this.ubuntu1.Location = new System.Drawing.Point(183, 240);
			this.ubuntu1.Name = "ubuntu1";
			this.ubuntu1.Size = new System.Drawing.Size(75, 23);
			this.ubuntu1.TabIndex = 3;
			this.ubuntu1.Text = "Ubuntu";
			this.ubuntu1.UseVisualStyleBackColor = true;
			this.ubuntu1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Open_WSL_Distros.Properties.Resources.Ubuntu;
			this.pictureBox2.Location = new System.Drawing.Point(128, 227);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(49, 51);
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// ubuntu2
			// 
			this.ubuntu2.Location = new System.Drawing.Point(264, 240);
			this.ubuntu2.Name = "ubuntu2";
			this.ubuntu2.Size = new System.Drawing.Size(108, 23);
			this.ubuntu2.TabIndex = 5;
			this.ubuntu2.Text = "Ubuntu 20.04 LTS";
			this.ubuntu2.UseVisualStyleBackColor = true;
			this.ubuntu2.Click += new System.EventHandler(this.button2_Click);
			// 
			// ubuntu3
			// 
			this.ubuntu3.Location = new System.Drawing.Point(378, 240);
			this.ubuntu3.Name = "ubuntu3";
			this.ubuntu3.Size = new System.Drawing.Size(106, 23);
			this.ubuntu3.TabIndex = 6;
			this.ubuntu3.Text = "Ubuntu 18.04 LTS";
			this.ubuntu3.UseVisualStyleBackColor = true;
			this.ubuntu3.Click += new System.EventHandler(this.button3_Click);
			// 
			// ubuntu4
			// 
			this.ubuntu4.Location = new System.Drawing.Point(490, 240);
			this.ubuntu4.Name = "ubuntu4";
			this.ubuntu4.Size = new System.Drawing.Size(105, 23);
			this.ubuntu4.TabIndex = 7;
			this.ubuntu4.Text = "Ubuntu 16.04 LTS";
			this.ubuntu4.UseVisualStyleBackColor = true;
			this.ubuntu4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(307, 178);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 25);
			this.label3.TabIndex = 8;
			this.label3.Text = "Ubuntu";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1124, 617);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ubuntu4);
			this.Controls.Add(this.ubuntu3);
			this.Controls.Add(this.ubuntu2);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.ubuntu1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "WSL Start Window";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button ubuntu1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button ubuntu2;
		private System.Windows.Forms.Button ubuntu3;
		private System.Windows.Forms.Button ubuntu4;
		private System.Windows.Forms.Label label3;
	}
}

