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
	public partial class Manager : Form
	{
		public Manager()
		{
			InitializeComponent();
		}

		private void Drivers_Click(object sender, EventArgs e)
		{
			//ticketsgrid.Visible = false;
			button1.Visible = true;
			driversDataGridView.Visible = true;
			usersDataGridView.Visible = false;
			//tripsGrid.Visible = false;
			//driversGrid.Visible = true;
		
		}

		private void Manager_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'busStationBaseDataSetDrivers.roles' table. You can move, or remove it, as needed.
			this.rolesTableAdapter.Fill(this.busStationBaseDataSetDrivers.roles);
			// TODO: This line of code loads data into the 'busStationBaseDataSetDrivers.users' table. You can move, or remove it, as needed.
			this.usersTableAdapter.Fill(this.busStationBaseDataSetDrivers.users);
			// TODO: This line of code loads data into the 'busStationBaseDataSetDrivers.drivers' table. You can move, or remove it, as needed.
			this.driversTableAdapter.Fill(this.busStationBaseDataSetDrivers.drivers);
			// TODO: This line of code loads data into the 'busStationBaseDataSetDrivers.trips' table. You can move, or remove it, as needed.
			this.tripsTableAdapter.Fill(this.busStationBaseDataSetDrivers.trips);
			// TODO: This line of code loads data into the 'busStationBaseDataSetDrivers.trips' table. You can move, or remove it, as needed.
			this.tripsTableAdapter.Fill(this.busStationBaseDataSetDrivers.trips);
			// TODO: This line of code loads data into the 'busStationBaseDataSetDrivers.tickets' table. You can move, or remove it, as needed.
			this.ticketsTableAdapter.Fill(this.busStationBaseDataSetDrivers.tickets);
			// TODO: This line of code loads data into the 'busStationBaseDataSetDrivers.drivers' table. You can move, or remove it, as needed.
			this.driversTableAdapter.Fill(this.busStationBaseDataSetDrivers.drivers);

		}

		private void Trips_Click(object sender, EventArgs e)
		{
			driversDataGridView.Visible = false;
			usersDataGridView.Visible = false;
			tripsDataGridView.Visible = true;
			button1.Visible = true;
		}

		private void Tickets_Click(object sender, EventArgs e)
		{
			driversDataGridView.Visible = false;
			usersDataGridView.Visible = false;
			tripsDataGridView.Visible = false;
			ticketsDataGridView.Visible = true;
			button1.Visible = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			usersBindingSource.EndEdit();
			usersTableAdapter.Update(busStationBaseDataSetDrivers.users);
			driversBindingSource.EndEdit();
			driversTableAdapter.Update(busStationBaseDataSetDrivers.drivers);
			tripsBindingSource.EndEdit();
			tripsTableAdapter.Update(busStationBaseDataSetDrivers.trips);
		}

		private void Users_Click(object sender, EventArgs e)
		{
			driversDataGridView.Visible = false;
			usersDataGridView.Visible = true;
			tripsDataGridView.Visible = false;
			ticketsDataGridView.Visible = false;
		//	MessageBox.Show("users");
			button1.Visible = true;
		}
	}
}
