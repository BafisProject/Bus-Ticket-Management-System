using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementSystem.Popups
{
    public partial class Trip_Availability : Form
    {
        DatabaseFunctions db = new DatabaseFunctions();
        string source, destination, tripDate, tripTime;

        public Trip_Availability()
        {
            InitializeComponent();
        }

        public Trip_Availability(string source, string destination, string tripDate, string tripTime)
        {
            InitializeComponent();
            this.source = source;
            this.destination = destination;
            this.tripDate = tripDate;
            this.tripTime = tripTime;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Trip_Availability_Load(object sender, EventArgs e)
        {
            var reader = db.GetData("SELECT * FROM Trip WHERE source = '"+source+"' AND destination = '"+destination+"' AND depart_date = '"+tripDate+"' AND depart_time = '"+tripTime+"'");
            populateGrid(reader);
        }

        protected void populateGrid(SqlDataReader reader)
        {
            tripGrid.Rows.Clear();
            string trip_ID, busNumber, busClass = "";

            while (reader.Read())
            {
                trip_ID = reader["trip_ID"].ToString();
                busNumber = reader["bus_number"].ToString();
                var helper = db.GetData("SELECT bus_class FROM Bus WHERE bus_number = '" + busNumber + "'");
                while (helper.Read())
                {
                    busClass = helper["bus_class"].ToString();
                }
                tripGrid.Rows.Add(trip_ID, busNumber, busClass);
            }


            if(tripGrid.Rows.Count > 0)
            {
                tripGrid.Visible = true;
            }
            else
            {
                noTripTxt.Visible = true;
            }
        }


        private void tripGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(tripGrid.Columns[e.ColumnIndex].Name == "bookTrip")
            {
                string selectedTripID = tripGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                string selectedCoachClass = tripGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                string selectedCoachNumber = tripGrid.Rows[e.RowIndex].Cells[1].Value.ToString();

                if(selectedTripID != "")
                {
                    User_Controls.Ticket_booking.Ticket_booking_Instance.selectedTripNumber = selectedTripID;
                    User_Controls.Ticket_booking.Ticket_booking_Instance.selectedBusClass = selectedCoachClass;
                    User_Controls.Ticket_booking.Ticket_booking_Instance.selectedBusNumber = selectedCoachNumber;
                    User_Controls.Ticket_booking.Ticket_booking_Instance.totalAmount = 0;
                    User_Controls.Ticket_booking.Ticket_booking_Instance.grandTotal.Text = "0 TAKA";

                    User_Controls.Ticket_booking.Ticket_booking_Instance.showClassAndPrice();
                    User_Controls.Ticket_booking.Ticket_booking_Instance.showSeats();
                    User_Controls.Ticket_booking.Ticket_booking_Instance.seatDistributionPanel.Visible = true;
                    User_Controls.Ticket_booking.Ticket_booking_Instance.bookingFromPanel.Visible = true;
                    this.Close();
                }
                
            }
        }


    }
}
