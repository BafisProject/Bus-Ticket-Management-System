using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementSystem.User_Controls
{
    public partial class Reservations : UserControl
    {
        DatabaseFunctions db = new DatabaseFunctions();
        public Reservations()
        {
            InitializeComponent();
            reservationGrid.Rows.Clear();
        }

        //Showing all reservations
        public void showAllReservations()
        {
            //Fetching Data From Reservations Table...
            var reservationReader = db.GetData("SELECT * FROM Reservation");
            int i = 0;
            reservationGrid.Rows.Clear();

            while (reservationReader.Read())
            {
                //Fteching ticket number and Purchased Time based on reservation id
                var readTicket = db.GetData("SELECT * FROM Ticket WHERE reservation_ID = '" + reservationReader["reservation_ID"].ToString() + "'");
                if(reservationReader["reserved_seat"].ToString() == "")
                {
                    continue;
                }
                reservationGrid.Rows.Add();
                while (readTicket.Read())
                {
                    //Adding it to the column(ticket number) of current row
                    reservationGrid.Rows[i].Cells[0].Value = readTicket["ticket_number"].ToString();

                    //Reading Purchased Date and Time
                    DateTime dbPurchasedTime = DateTime.Parse(readTicket["purchased_time"].ToString());
                    DateTime dbPurchasedDate = DateTime.Parse(readTicket["purchased_date"].ToString());

                    ////Adding it to the column(purchased on) of current row
                    reservationGrid.Rows[i].Cells[2].Value = dbPurchasedTime.ToString("hh:mm tt") + " (" + dbPurchasedDate.ToString("dd, MMM") + ")";
                    break;
                }

                //Fteching passenger phone number from passenger table based on passenger id
                var readPsngNumber = db.GetData("SELECT phone_number FROM Passenger WHERE passenger_ID = '" + reservationReader["passenger_ID"].ToString() + "'");
                while (readPsngNumber.Read())
                {
                    //Adding it to the column(phone number) of current row
                    reservationGrid.Rows[i].Cells[1].Value = readPsngNumber["phone_number"].ToString();
                    break;
                }

                //Adding reserved seat of current passenger based on reserved id
                reservationGrid.Rows[i].Cells[3].Value = reservationReader["reserved_seat"].ToString().TrimEnd(',');

                //Fetching Bus Number
                var readTrip = db.GetData("SELECT bus_number FROM Trip WHERE trip_ID = '"+ reservationReader["trip_ID"].ToString() + "'");
                while (readTrip.Read())
                {
                    reservationGrid.Rows[i].Cells[4].Value = readTrip["bus_number"].ToString();
                    break;
                }

                i++;
            }
        }

        private void Reservations_Load(object sender, EventArgs e)
        {
            showAllReservations();
        }

        //performaing Printing and Cancellation
        private void reservationGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ticketNumber = reservationGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            string phoneNumber = reservationGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            string grandTotal = "", destination = "", seats = "", reservationID = "";
            DateTime departDate = DateTime.Now, departTime = DateTime.Now;
            string busNumber = reservationGrid.Rows[e.RowIndex].Cells[4].Value.ToString(); ;

            var reader = db.GetData("SELECT total_fare, destination, depart_date, depart_time, reserved_seat, Ticket.reservation_ID FROM Ticket JOIN Reservation ON Ticket.reservation_ID = Reservation.reservation_ID JOIN Trip ON Reservation.trip_ID = Trip.trip_ID WHERE ticket_number = '" + ticketNumber + "'");
            while (reader.Read())
            {
                grandTotal = reader["total_fare"].ToString();
                destination = reader["destination"].ToString();
                departDate = DateTime.Parse(reader["depart_date"].ToString());
                departTime = DateTime.Parse(reader["depart_time"].ToString());
                seats = reader["reserved_seat"].ToString();
                reservationID = reader["reservation_ID"].ToString();
            }

            //ticket print
            if (reservationGrid.Columns[e.ColumnIndex].Name == "ticket_print")
            {
                Popups.Bus_Ticket bus_Ticket = new Popups.Bus_Ticket(ticketNumber, phoneNumber, grandTotal, destination, departDate.ToString("dd-MM-yyyy"), departTime.ToString("hh:mm tt"), seats, busNumber);
                bus_Ticket.ShowDialog();
            }
            //cancellation
            if(reservationGrid.Columns[e.ColumnIndex].Name == "ticket_cancel")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to canecl?", "Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    DateTime dbDateTime = new DateTime(departDate.Year, departDate.Month, departDate.Day, departTime.Hour, departTime.Minute, 0);
                    TimeSpan remainTime = dbDateTime.Subtract(DateTime.Now);
                    float deductedAmount = 0, returnAmount = 0;
                    if (remainTime.TotalMinutes <= 2880 && remainTime.TotalMinutes >= 720)
                    {
                        deductedAmount = float.Parse(grandTotal) * 0.25f;
                        returnAmount = float.Parse(grandTotal) - deductedAmount;
                        cancellationUpdate(ticketNumber, reservationID, deductedAmount, returnAmount);
                    }
                    else if (remainTime.TotalMinutes < 720 && remainTime.TotalMinutes >= 240)
                    {
                        deductedAmount = float.Parse(grandTotal) * 0.5f;
                        returnAmount = float.Parse(grandTotal) - deductedAmount;
                        cancellationUpdate(ticketNumber, reservationID, deductedAmount, returnAmount);
                    }
                    else if (remainTime.TotalMinutes < 240)
                    {
                        MessageBox.Show("Cancellation Time exceded", "Unable To Cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        cancellationUpdate(ticketNumber, reservationID, deductedAmount, float.Parse(grandTotal));
                    }
                }
                
            }
        }

        //Updating info to some tables after cancelling a ticket
        void cancellationUpdate(string ticketNumber, string reservationID, float deductedAmount, float returnAmount)
        {
            db.SetData("UPDATE Ticket SET total_fare = '" + deductedAmount + "' WHERE ticket_number = '" + ticketNumber + "'");
            db.SetData("UPDATE Reservation SET reserved_seat = '' WHERE reservation_ID = '" + reservationID + "'");
            MessageBox.Show("Return: " + returnAmount.ToString() + " TAKA", "Successfully Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
