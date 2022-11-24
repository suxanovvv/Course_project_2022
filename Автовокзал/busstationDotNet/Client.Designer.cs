
namespace busstationDotNet
{
	partial class Client
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tripsClient = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsclients = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeintripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busStationBaseDataSetDrivers = new busstationDotNet.busStationBaseDataSetDrivers();
            this.tripsTableAdapter = new busstationDotNet.busStationBaseDataSetDriversTableAdapters.tripsTableAdapter();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.TicketDate = new System.Windows.Forms.DateTimePicker();
            this.PlaceQuontity = new System.Windows.Forms.NumericUpDown();
            this.OrderTicket = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PrintTickets = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busStationBaseDataSetDrivers)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceQuontity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tripsClient,
            this.ticketsclients});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 18);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(117, 54);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tripsClient
            // 
            this.tripsClient.Name = "tripsClient";
            this.tripsClient.Size = new System.Drawing.Size(108, 24);
            this.tripsClient.Text = "Рейсы";
            this.tripsClient.Click += new System.EventHandler(this.tripsClient_Click);
            // 
            // ticketsclients
            // 
            this.ticketsclients.Name = "ticketsclients";
            this.ticketsclients.Size = new System.Drawing.Size(108, 24);
            this.ticketsclients.Text = "Мои билеты";
            this.ticketsclients.Click += new System.EventHandler(this.ticketsclients_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.departureDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.frequencyDataGridViewTextBoxColumn,
            this.timeintripDataGridViewTextBoxColumn,
            this.driveridDataGridViewTextBoxColumn,
            this.placesDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tripsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(215, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1144, 185);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // departureDataGridViewTextBoxColumn
            // 
            this.departureDataGridViewTextBoxColumn.DataPropertyName = "departure";
            this.departureDataGridViewTextBoxColumn.HeaderText = "departure";
            this.departureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departureDataGridViewTextBoxColumn.Name = "departureDataGridViewTextBoxColumn";
            this.departureDataGridViewTextBoxColumn.ReadOnly = true;
            this.departureDataGridViewTextBoxColumn.Width = 125;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "destination";
            this.destinationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.ReadOnly = true;
            this.destinationDataGridViewTextBoxColumn.Width = 125;
            // 
            // frequencyDataGridViewTextBoxColumn
            // 
            this.frequencyDataGridViewTextBoxColumn.DataPropertyName = "frequency";
            this.frequencyDataGridViewTextBoxColumn.HeaderText = "frequency";
            this.frequencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.frequencyDataGridViewTextBoxColumn.Name = "frequencyDataGridViewTextBoxColumn";
            this.frequencyDataGridViewTextBoxColumn.ReadOnly = true;
            this.frequencyDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeintripDataGridViewTextBoxColumn
            // 
            this.timeintripDataGridViewTextBoxColumn.DataPropertyName = "timeintrip";
            this.timeintripDataGridViewTextBoxColumn.HeaderText = "timeintrip";
            this.timeintripDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeintripDataGridViewTextBoxColumn.Name = "timeintripDataGridViewTextBoxColumn";
            this.timeintripDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeintripDataGridViewTextBoxColumn.Width = 125;
            // 
            // driveridDataGridViewTextBoxColumn
            // 
            this.driveridDataGridViewTextBoxColumn.DataPropertyName = "driver_id";
            this.driveridDataGridViewTextBoxColumn.HeaderText = "driver_id";
            this.driveridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.driveridDataGridViewTextBoxColumn.Name = "driveridDataGridViewTextBoxColumn";
            this.driveridDataGridViewTextBoxColumn.ReadOnly = true;
            this.driveridDataGridViewTextBoxColumn.Width = 125;
            // 
            // placesDataGridViewTextBoxColumn
            // 
            this.placesDataGridViewTextBoxColumn.DataPropertyName = "places";
            this.placesDataGridViewTextBoxColumn.HeaderText = "places";
            this.placesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.placesDataGridViewTextBoxColumn.Name = "placesDataGridViewTextBoxColumn";
            this.placesDataGridViewTextBoxColumn.ReadOnly = true;
            this.placesDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // tripsBindingSource
            // 
            this.tripsBindingSource.DataMember = "trips";
            this.tripsBindingSource.DataSource = this.busStationBaseDataSetDrivers;
            // 
            // busStationBaseDataSetDrivers
            // 
            this.busStationBaseDataSetDrivers.DataSetName = "busStationBaseDataSetDrivers";
            this.busStationBaseDataSetDrivers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tripsTableAdapter
            // 
            this.tripsTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(223, 223);
            this.toolStripContainer1.Location = new System.Drawing.Point(11, 10);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(248, 254);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // TicketDate
            // 
            this.TicketDate.Location = new System.Drawing.Point(16, 251);
            this.TicketDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TicketDate.MinDate = new System.DateTime(2021, 5, 5, 0, 0, 0, 0);
            this.TicketDate.Name = "TicketDate";
            this.TicketDate.Size = new System.Drawing.Size(265, 22);
            this.TicketDate.TabIndex = 3;
            this.TicketDate.Visible = false;
            // 
            // PlaceQuontity
            // 
            this.PlaceQuontity.Location = new System.Drawing.Point(291, 251);
            this.PlaceQuontity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlaceQuontity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PlaceQuontity.Name = "PlaceQuontity";
            this.PlaceQuontity.Size = new System.Drawing.Size(160, 22);
            this.PlaceQuontity.TabIndex = 4;
            this.PlaceQuontity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PlaceQuontity.Visible = false;
            // 
            // OrderTicket
            // 
            this.OrderTicket.Location = new System.Drawing.Point(481, 252);
            this.OrderTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderTicket.Name = "OrderTicket";
            this.OrderTicket.Size = new System.Drawing.Size(100, 28);
            this.OrderTicket.TabIndex = 5;
            this.OrderTicket.Text = "Купить билет";
            this.OrderTicket.UseVisualStyleBackColor = true;
            this.OrderTicket.Click += new System.EventHandler(this.OrderTicket_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(247, 10);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1101, 185);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.Visible = false;
            // 
            // PrintTickets
            // 
            this.PrintTickets.Location = new System.Drawing.Point(481, 251);
            this.PrintTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrintTickets.Name = "PrintTickets";
            this.PrintTickets.Size = new System.Drawing.Size(100, 28);
            this.PrintTickets.TabIndex = 7;
            this.PrintTickets.Text = "Распечатать";
            this.PrintTickets.UseVisualStyleBackColor = true;
            this.PrintTickets.Visible = false;
            this.PrintTickets.Click += new System.EventHandler(this.PrintTickets_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 554);
            this.Controls.Add(this.PrintTickets);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.OrderTicket);
            this.Controls.Add(this.PlaceQuontity);
            this.Controls.Add(this.TicketDate);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busStationBaseDataSetDrivers)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceQuontity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tripsClient;
		private System.Windows.Forms.DataGridView dataGridView1;
		private busStationBaseDataSetDrivers busStationBaseDataSetDrivers;
		private System.Windows.Forms.BindingSource tripsBindingSource;
		private busStationBaseDataSetDriversTableAdapters.tripsTableAdapter tripsTableAdapter;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStripMenuItem ticketsclients;
		private System.Windows.Forms.DateTimePicker TicketDate;
		private System.Windows.Forms.NumericUpDown PlaceQuontity;
		private System.Windows.Forms.Button OrderTicket;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn frequencyDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeintripDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn driveridDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn placesDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Button PrintTickets;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
	}
}