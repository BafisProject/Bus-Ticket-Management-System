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
        public string selectedBusClass = "";
        public string selectedBusNumber = "";
        string seatSelection;
        public float totalAmount = 0, perSeatAmount = 0;
        int seatCount = 1;

        //Constructor
        public Ticket_booking()
        {
            InitializeComponent();
            //To get the trip_ID from available trip popup
            Ticket_booking_Instance = this;
        }

        //Check available trip on selected time and destination
        private void btnCheckNow_Click(object sender, EventArgs e)
        {
            seatDistributionPanel.Visible = false;
            bookingFromPanel.Visible = false;
            selectedTripNumber = "";

            string tripSource = sourceBox.Text;
            string tripDestination = destinatonBox.Text;
            string tripDate = departDate.Value.ToString("yyyy-MM-dd");
            string tripTime = departTime.Value.ToString("hh:mm tt");

            if (!string.IsNullOrEmpty(tripSource) && !string.IsNullOrEmpty(tripDestination))
            {
                Popups.Trip_Availability trip_Availability = new Popups.Trip_Availability(tripSource, tripDestination, tripDate, tripTime);
                trip_Availability.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please fill up everything", "unable to proceed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //A Function to show all available seats
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

        //Function to make all seats available by default
        private void all_seat_available(Guna2Button[] button)
        {

            for (int i = 0; i < button.Length; i++)
            {
                button[i].Enabled = true;
                button[i].Checked = false;
                seatSelection = "";
                button[i].Cursor = Cursors.Default;
            }

        }

        //It will make a seat disabled if it's already reserved
        void reserved_status(Guna2Button button)
        {
            button.Enabled = false;
            button.Cursor = Cursors.No;
        }

        // Seat booking complete functionalities
        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            string psngName = passengerName.Text;
            string psngPhone = passengerPhone.Text;
            bool psngExist = false;

            string passengerID = "";

            if(psngName != "" && psngPhone != "")
            {
                //adding passenger to the passenger table
                //retrieving passenger table infromations
                var psngReader = db.GetData("SELECT * FROM Passenger");
                while (psngReader.Read())
                {
                    //if this passenger not exist then inseritng it
                    if(psngName == psngReader["name"].ToString() && psngPhone == psngReader["phone_number"].ToString())
                    {
                        psngExist = true;
                        break;
                    }
                }

                //Checking if already passenger exit or null seat selection
                if (seatSelection != "")
                {
                    if (psngExist == false)
                    {
                        db.SetData("INSERT INTO Passenger VALUES('" + psngName + "', '" + psngPhone + "')");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid seat selection", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //retrieving passenger table infromations to get the passenger ID
                if(seatSelection != "")
                {
                    var psngIDReader = db.GetData("SELECT * FROM Passenger WHERE name = '" + psngName + "' AND phone_number = '" + psngPhone + "'");
                    while (psngIDReader.Read())
                    {
                        passengerID = psngIDReader["passenger_ID"].ToString();
                    }
                }

                //Inserting Reservation of a passenger to Database

                if(passengerID != "")
                {
                    db.SetData("INSERT INTO Reservation VALUES('"+passengerID+"','"+seatSelection+"','"+selectedTripNumber+"')");
                    var reservationIDReader = db.GetData("SELECT * FROM Reservation WHERE passenger_ID = '" + passengerID + "' AND reserved_seat = '" + seatSelection + "' AND trip_ID = '" + selectedTripNumber + "'");
                    string reservedID = "";
                    while (reservationIDReader.Read())
                    {
                        reservedID = reservationIDReader["reservation_ID"].ToString();
                    }

                    //Generating random ticket number and inserting data to ticket table
                    Random random = new Random();
                    string ticketNumber = "#(" + selectedBusNumber + ")-" + random.Next(10000, 20000).ToString();

                    if (reservedID != "")
                    {
                        string purchasedTime = DateTime.Now.ToString("hh:mm tt");
                        string purchasedDate = DateTime.Now.ToString("yyyy-MM-dd");
                        db.SetData("INSERT INTO Ticket VALUES('"+ticketNumber+"','"+purchasedTime+"','"+purchasedDate+"','"+totalAmount+"','"+reservedID+"')");
                    }

                    MessageBox.Show("Purchase Completed for " + psngName, "RESERVED SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
                    //Genertaing Ticket For the passenger
                    Popups.Bus_Ticket bus_Ticket = new Popups.Bus_Ticket(ticketNumber, psngPhone, totalAmount.ToString(), sourceBox.Text, destinatonBox.Text, departDate.Value.ToString("dd/MM/yyyy"), departTime.Value.ToString("hh:mm tt"), seatSelection, selectedBusNumber);

                    //resetting all fields
                    seatCount = 1;
                    passengerName.Text = "";
                    passengerPhone.Text = "";
                    totalAmount = 0;
                    grandTotal.Text = totalAmount.ToString() + " TAKA";

                    //showing ticket popup

                    bus_Ticket.ShowDialog();


                    showSeats();
                }
            }
            else
            {
                MessageBox.Show("Please fill up everything", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //This function will help to generate the selections of seats
        public void seatBtnToggle(Guna2Button button, string seat_no)
        {
            string selectedSource =  sourceBox.Text;
            string selectedDestination = destinatonBox.Text;
            
            busFare(selectedSource, selectedDestination);

                if (button.Checked == true)
                {
                    seatSelection += seat_no + ",";
                    totalAmount += perSeatAmount;
                    seatCount++;
                }
                else
                {
                    seatSelection = seatSelection.Remove(seatSelection.IndexOf(seat_no), 3);
                    if (totalAmount > 0)
                    {
                        totalAmount -= perSeatAmount;
                        seatCount--;
                        MessageBox.Show(seatCount.ToString());
                    }
                }

        }

        //All seat button click event
        private void seatClick(object sender, EventArgs e)
        {
            if(seatCount >= 0 && seatCount <= 5)
            {
                Guna2Button button = (Guna2Button)sender;
                seatBtnToggle(button, button.Text);
                grandTotal.Text = totalAmount.ToString() + " TAKA";
            }
            else
            {
                Guna2Button button = (Guna2Button)sender;
                button.Checked = false;
                MessageBox.Show("Individual Customer can't purchase more than 5 seats", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Bus Fare Based on destiantion and Class
        void busFare(string selectedSource, string selectedDestination)
        {
            var reader = db.GetData("SELECT * FROM Fare WHERE source = '" + selectedSource + "' AND destination = '" + selectedDestination + "' AND class = '" + selectedBusClass + "'");

            while (reader.Read())
            {
                perSeatAmount = (float)Convert.ToDouble(reader["fare"].ToString());
            }
        }

        //Show Direction Button
        private void showDirection(object sender, EventArgs e)
        {
            string source = sourceBox.Text;
            string destination = destinatonBox.Text;
            if(source != "" && destination != "")
            {
                Popups.Direction direction = new Popups.Direction(source, destination);
                direction.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select Source and Destination", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }

        //Invoke when select a trip from the available trip popup
        public void showClassAndPrice()
        {
            busFare(sourceBox.Text, destinatonBox.Text);
            busClassTxt.Text = selectedBusClass;
            busFareTxt.Text = perSeatAmount.ToString();
        }
    }
}
