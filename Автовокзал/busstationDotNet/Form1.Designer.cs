﻿
namespace busstationDotNet
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.login = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.Signin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(245, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Логин";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(248, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Пароль";
			// 
			// login
			// 
			this.login.Location = new System.Drawing.Point(215, 103);
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(100, 20);
			this.login.TabIndex = 2;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(215, 179);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(100, 20);
			this.password.TabIndex = 3;
			// 
			// Signin
			// 
			this.Signin.Location = new System.Drawing.Point(218, 222);
			this.Signin.Name = "Signin";
			this.Signin.Size = new System.Drawing.Size(75, 23);
			this.Signin.TabIndex = 4;
			this.Signin.Text = "Вход";
			this.Signin.UseVisualStyleBackColor = true;
			this.Signin.Click += new System.EventHandler(this.Signin_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Signin);
			this.Controls.Add(this.password);
			this.Controls.Add(this.login);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox login;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Button Signin;
	}
}

