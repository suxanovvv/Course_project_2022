using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.IO;
//using Microsoft.Office.Interop.Word;
namespace busstationDotNet
{
	public partial class Client : Form
	{
		public static int id;
		public Client(int userId)
		{
			InitializeComponent();
			id = userId;
		}

		private void tripsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			//this.tripsBindingSource.EndEdit();
			//this.tableAdapterManager.UpdateAll(this.busStationBaseDataSetDrivers);

		}

		private void tripsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
		{
			this.Validate();
		//	this.tripsBindingSource.EndEdit();
			//this.tableAdapterManager.UpdateAll(this.busStationBaseDataSetDrivers);

		}

		private void tripsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
		{
			this.Validate();
			//this.tripsBindingSource.EndEdit();
			//this.tableAdapterManager.UpdateAll(this.busStationBaseDataSetDrivers);

		}

		private void tripsBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
		{

		}

		private void tripsBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
		{

		}

		private void Client_Load(object sender, EventArgs e)
		{

		}

		private void Client_Load_1(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'busStationBaseDataSetDrivers.trips' table. You can move, or remove it, as needed.
			this.tripsTableAdapter.Fill(this.busStationBaseDataSetDrivers.trips);

		}

		private void tripsClient_Click(object sender, EventArgs e)
		{
			dataGridView1.Visible = true;
			TicketDate.Visible = true;
			OrderTicket.Visible = true;
			PlaceQuontity.Visible = true;
			PrintTickets.Visible = false;
		}

		private void OrderTicket_Click(object sender, EventArgs e)
		{
			// Get the currently selected row using the SelectedRow property.
			// Get the currently selected row using the SelectedRow property.

			// In this example, the first column (index 0) contains
			//TextBox1.Tex//t = row.Cells[0].Text;
			String TripPrice = dataGridView1.SelectedRows[0].Cells[7].Value + string.Empty;
			
			decimal price = decimal.Parse(TripPrice);

			//decimal price = TripPrice;
			decimal FinalPrice = price * PlaceQuontity.Value;
			String TripId = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;

			SqlConnection connect = Config.Connection();
			connect.Open();
			SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
			cmd.CommandType = System.Data.CommandType.Text;
			//cmd.CommandText = "INSERT dbo.tickets (places,date,client_id,price,trip_id) VALUES ("+ PlaceQuontity.Value+","+TicketDate.Value.Date.ToString("yyyyMMdd") + ","+id+","+FinalPrice+","+TripId+")";
			//cmd.CommandText = "INSERT dbo.tickets (places,date,client_id,price,trip_id) VALUES (" + PlaceQuontity.Value + ",@date "  + "," + id + "," +"'"+ FinalPrice+"'" + "," + TripId + ")";
			cmd.CommandText = "INSERT dbo.tickets (places,date,client_id,price,trip_id) VALUES (" + PlaceQuontity.Value + ",@date "  + "," + id + "," + "@price" + "," + TripId + ")";

			cmd.Parameters.Add("@date", SqlDbType.Date).Value = TicketDate.Value.Date;
			cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = FinalPrice;

			cmd.Connection = connect;
			cmd.ExecuteNonQuery();
			connect.Close();
		}
		private void BindDataGridView()
		{
			var select = "select dbo.tickets.id,dbo.tickets.price,dbo.tickets.places,dbo.tickets.client_id,trip_id,destination,date from dbo.tickets left join  dbo.trips on dbo.trips.id=dbo.tickets.trip_id where dbo.tickets.client_id="+id;
			//var c = new SqlConnection(yourConnectionString); // Your Connection String here
			var c = Config.Connection();
			var dataAdapter = new SqlDataAdapter(select, c);

			var commandBuilder = new SqlCommandBuilder(dataAdapter);
			var ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView2.ReadOnly = true;
			dataGridView2.DataSource = ds.Tables[0];
		}

		private void ticketsclients_Click(object sender, EventArgs e)
		{
			this.BindDataGridView();
			//MessageBox.Show(id.ToString());
			dataGridView2.Visible = true;
			OrderTicket.Visible = false;
			PrintTickets.Visible = true;
			dataGridView1.Visible = false;
			PlaceQuontity.Visible = false;
			TicketDate.Visible = false;
		}

		//Bitmap bmp;

		private void PrintTickets_Click(object sender, EventArgs e)
		{
			this.BindDataGridView();
			//show in word
			//Table start.
			string html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>";

			//Adding HeaderRow.
			html += "<tr>";
			foreach (DataGridViewColumn column in dataGridView2.Columns)
			{
				html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + column.HeaderText + "</th>";
			}
			html += "</tr>";

			//Adding DataRow.
			foreach (DataGridViewRow row in dataGridView2.Rows)
			{
				html += "<tr>";
				foreach (DataGridViewCell cell in row.Cells)
				{
					html += "<td style='width:120px;border: 1px solid #ccc'>" + cell.Value.ToString() + "</td>";
				}
				html += "</tr>";
			}

			//Table end.
			html += "</table>";

			//Save the HTML string as HTML File.
			string htmlFilePath = @"C:\Files\Database.htm";
			File.WriteAllText(htmlFilePath, html);

			//Convert the HTML File to Word document.
			
			//end

		}
		

	}
}
