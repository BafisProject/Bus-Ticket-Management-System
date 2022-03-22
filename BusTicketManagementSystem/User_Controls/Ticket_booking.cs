using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace BusTicketManagementSystem.User_Controls
{
    public partial class Ticket_booking : UserControl
    {

        public static Ticket_booking Ticket_booking_Instance;
        DatabaseFunctions db = new DatabaseFunctions();
        public string selectedTripNumber = "";

        public Ticket_booking()
        {
            InitializeComponent();
            Ticket_booking_Instance = this;
        }

        private void btnCheckNow_Click(object sender, EventArgs e)
        {
            seatDistributionPanel.Visible = false;
            bookingFromPanel.Visible = false;
            selectedTripNumber = "";

            string tripDestination = destinatonBox.Text;
            string tripDate = departDate.Value.ToString("yyyy-MM-dd");
            string tripTime = departTime.Value.ToString("hh:mm tt");

            if (!string.IsNullOrEmpty(tripDestination))
            {
                Popups.Trip_Availability trip_Availability = new Popups.Trip_Availability(tripDestination, tripDate, tripTime);
                trip_Availability.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please fill up everything", "unable to proceed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void showSeats()
        {
            string reserved_seat;
            //Button[] buttons = { A1, A2, B1, B2 };
            Guna2Button[] seats = { A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4, D1, D2, D3, D4, E1, E2, E3, E4, F1, F2, F3, F4, G1, G2, G3, G4, H1, H2, H3, H4, I1, I2, I3, I4, J1, J2, J3, J4, EX };
            all_seat_available(seats);

            if (selectedTripNumber != "")
            {
                var reader = db.GetData("SELECT * FROM Reservation WHERE trip_ID = "+Convert.ToInt32(selectedTripNumber)+"");
                while (reader.Read())
                {
                    reserved_seat = reader["reserved_seat"].ToString();
                    string[] reserve = reserved_seat.Split(',');
                    for(int i = 0; i < reserve.Length; i++)
                    {
                        switch (reserve[i])
                        {
                            case "A1":
                                reserved_status(A1);
                                break;
                            case "A2":
                                reserved_status(A2);
                                break;
                            case "A3":
                                reserved_status(A3);
                                break;
                            case "A4":
                                reserved_status(A4);
                                break;
                            case "B1":
                                reserved_status(B1);
                                break;
                            case "B2":
                                reserved_status(B2);
                                break;
                            case "B3":
                                reserved_status(B3);
                                break;
                            case "B4":
                                reserved_status(B4);
                                break;
                            case "C1":
                                reserved_status(C1);
                                break;
                            case "C2":
                                reserved_status(C2);
                                break;
                            case "C3":
                                reserved_status(C3);
                                break;
                            case "C4":
                                reserved_status(C4);
                                break;
                            case "D1":
                                reserved_status(D1);
                                break;
                            case "D2":
                                reserved_status(D2);
                                break;
                            case "D3":
                                reserved_status(D3);
                                break;
                            case "D4":
                                reserved_status(D4);
                                break;
                            case "E1":
                                reserved_status(E1);
                                break;
                            case "E2":
                                reserved_status(E2);
                                break;
                            case "E3":
                                reserved_status(E3);
                                break;
                            case "E4":
                                reserved_status(E4);
                                break;
                            case "F1":
                                reserved_status(F1);
                                break;
                            case "F2":
                                reserved_status(F3);
                                break;
                            case "F3":
                                reserved_status(F3);
                                break;
                            case "F4":
                                reserved_status(F4);
                                break;
                            case "G1":
                                reserved_status(G1);
                                break;
                            case "G2":
                                reserved_status(G2);
                                break;
                            case "G3":
                                reserved_status(G3);
                                break;
                            case "G4":
                                reserved_status(G4);
                                break;
                            case "H1":
                                reserved_status(H1);
                                break;
                            case "H2":
                                reserved_status(H2);
                                break;
                            case "H3":
                                reserved_status(H3);
                                break;
                            case "H4":
                                reserved_status(H4);
                                break;
                            case "I1":
                                reserved_status(I1);
                                break;
                            case "I2":
                                reserved_status(I2);
                                break;
                            case "I3":
                                reserved_status(I3);
                                break;
                            case "I4":
                                reserved_status(I4);
                                break;
                            case "J1":
                                reserved_status(J1);
                                break;
                            case "J2":
                                reserved_status(J2);
                                break;
                            case "J3":
                                reserved_status(J3);
                                break;
                            case "J4":
                                reserved_status(J4);
                                break;
                            case "EX":
                                reserved_status(EX);
                                break;
                        }
                    }
                }
            }
        }

        private void all_seat_available(Guna2Button[] button)
        {

            for (int i = 0; i < button.Length; i++)
            {
                button[i].Enabled = true;
                button[i].Cursor = Cursors.Default;
            }

        }

        void reserved_status(Guna2Button x)
        {
            x.Enabled = false;
            x.Cursor = Cursors.No;
        }


    }
}
