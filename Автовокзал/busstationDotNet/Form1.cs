using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace busstationDotNet
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Signin_Click(object sender, EventArgs e)
		{
			int role = Config.authenticate(login.Text, password.Text);
			if (role == 0)
			{
				//Показываем форму для менеджера
				var manager = new Manager();
				manager.Show();
				this.Hide();
			}
			else if (role == 1)
			{
				int id = Config.getId(login.Text, password.Text);
				var client = new Client(id);
				client.Show();

				

				this.Hide();
			}
			else
			{
				MessageBox.Show("Не верный логин или пароль");
			}
		}
	}
}
