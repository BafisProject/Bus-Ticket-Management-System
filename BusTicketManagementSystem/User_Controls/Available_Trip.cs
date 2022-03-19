using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementSystem.User_Controls
{
    public partial class Available_Trip : UserControl
    {
        DatabaseFunctions db = new DatabaseFunctions();
        public Available_Trip()
        {
            InitializeComponent();
        }

        //Adding Bus to the database
        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            string destination = destinationComboBox.Text;
            string departTime = departTimePicker.Value.ToString("hh:mm tt");
            string departDate = departDatePicker.Value.ToString("yyyy-MM-dd");
            string busNumber = busNumberText.Text;
            bool busAvailability = false, tripExist = false;
            //Checking any field is blank or not
            if (String.IsNullOrEmpty(destination) || string.IsNullOrEmpty(departTime) || string.IsNullOrEmpty(departDate) || string.IsNullOrEmpty(busNumber))
            {
                MessageBox.Show("Fill up all fields", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Before inserting checking Bus Number as it is Foreign Key
                var reader = db.GetData("SELECT * FROM Bus");
                while (reader.Read())
                {
                    if(busNumber == reader["bus_number"].ToString())
                    {
                        //If bus number found then will look for availability
                        if (reader["bus_status"].ToString() == "Available")
                        {
                            busAvailability = true;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                }

                if(busAvailability == true)
                {
                    var reader2 = db.GetData("SELECT * FROM Trip");
                    string dbDestination = "", dbBusNumber, dbDepartDate;
                    DateTime dbDepartTime;
                    while (reader2.Read())
                    {
                        dbDestination = reader2["destination"].ToString();
                        dbDepartDate = string.Format("{0:yyyy-MM-dd}", reader2["depart_date"]);
                        dbDepartTime = DateTime.Parse(reader2["depart_time"].ToString());
                        dbBusNumber = reader2["bus_number"].ToString();
                        if(dbDepartTime.ToString("hh:mm tt") == departTime && dbDepartDate == departDate && dbBusNumber == busNumber)
                        {
                            tripExist = true;
                            break;
                        }
                    }

                    //Validating time and Date
                    if (DateTime.Parse(departDate, CultureInfo.InvariantCulture) < DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"), CultureInfo.InvariantCulture))
                    {
                        MessageBox.Show("Invalid Date Selection", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (DateTime.Parse(departDate, CultureInfo.InvariantCulture) == DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"), CultureInfo.InvariantCulture))
                    {
                        if (DateTime.Parse(departTime, CultureInfo.InvariantCulture) < DateTime.Parse(DateTime.Now.ToString("hh:mm tt"), CultureInfo.InvariantCulture))
                        {
                            MessageBox.Show("Invalid Time Selection", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if(tripExist == false)
                            {
                                db.SetData("INSERT INTO Trip VALUES('" + destination + "', '" + departTime + "', '" + departDate + "', '" + busNumber + "')");
                                destinationComboBox.SelectedIndex = -1;
                                busNumberText.Text = "";
                                MessageBox.Show("Trip Added Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Trip Alredy Exist in " + dbDestination, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        if (tripExist == false)
                        {
                            db.SetData("INSERT INTO Trip VALUES('" + destination + "', '" + departTime + "', '" + departDate + "', '" + busNumber + "')");
                            destinationComboBox.SelectedIndex = -1;
                            busNumberText.Text = "";
                            MessageBox.Show("Trip Added Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Trip Alredy Exist" + dbDestination, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    
                }
                else if(busAvailability == false)
                {
                    MessageBox.Show("Bus Already Departed", "DEPARTED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Fetching Trip From Database and Populating data to tripGrid
        public void showAllTrip()
        {
            var reader = db.GetData("SELECT * FROM Trip");
            populateGrid(reader);
        }

        private void Available_Trip_Load(object sender, EventArgs e)
        {
            showAllTrip();
        }

        private void tripGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Delete...
            if (tripGrid.Columns[e.ColumnIndex].Name == "deleteColumn")
            {
                int selectedID = Convert.ToInt32(tripGrid.Rows[e.RowIndex].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "DATA DELETION WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    db.SetData("DELETE FROM Trip WHERE trip_ID = '" + selectedID + "'");
                    MessageBox.Show("Data Deleted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //Edit...
            if (tripGrid.Columns[e.ColumnIndex].Name == "editColumn")
            {
                int selectedID = Convert.ToInt32(tripGrid.Rows[e.RowIndex].Cells[0].Value);
                string selectedDestination = tripGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                string selectedTime = tripGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                string selectedDate = tripGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                Popups.EditTripInfo_Popup editTripInfo_Popup = new Popups.EditTripInfo_Popup(selectedID, selectedDestination, selectedTime, selectedDate);
                editTripInfo_Popup.ShowDialog();
            }
        }

        //Search trip by bus number
        private void searchBox_TextChange(object sender, EventArgs e)
        {
            var reader = db.GetData("SELECT * FROM Trip WHERE bus_number LIKE '" + searchBox.Text + "%'");
            populateGrid(reader);
        }

        //Popuplate grid by reader data
        public void populateGrid(SqlDataReader reader)
        {
            string date;
            DateTime time;
            tripGrid.Rows.Clear();
            while (reader.Read())
            {
                time = DateTime.Parse(reader["depart_time"].ToString());
                date = string.Format("{0:dd, MMMM, yyyy}", reader["depart_date"]);
                if (DateTime.Parse(date, CultureInfo.InvariantCulture) < DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"), CultureInfo.InvariantCulture))
                {
                    db.SetData("DELETE FROM Trip WHERE trip_ID ='"+ reader["trip_ID"] + "'");
                    db.SetData("UPDATE Bus SET bus_status = 'Departed' WHERE bus_number = '" + reader["bus_number"].ToString() + "'");
                }
                else if (DateTime.Parse(date, CultureInfo.InvariantCulture) == DateTime.Parse(DateTime.Now.ToString("dd, MMMM, yyyy"), CultureInfo.InvariantCulture))
                {
                    if (DateTime.Parse(time.ToString("HH:mm:ss"), CultureInfo.InvariantCulture) < DateTime.Parse(DateTime.Now.ToString("HH:mm:ss"), CultureInfo.InvariantCulture))
                    {
                        db.SetData("DELETE FROM Trip WHERE trip_ID ='" + reader["trip_ID"] + "'");
                        db.SetData("UPDATE Bus SET bus_status = 'Departed' WHERE bus_number = '" + reader["bus_number"].ToString() + "'");
                    }
                    else
                    {
                        tripGrid.Rows.Add(reader["trip_ID"], reader["destination"], time.ToString("hh:mm tt"), date, reader["bus_number"]);
                    }
                }
                else
                {
                    tripGrid.Rows.Add(reader["trip_ID"], reader["destination"], time.ToString("hh:mm tt"), date, reader["bus_number"]);
                }
            }
        }
    }
}
