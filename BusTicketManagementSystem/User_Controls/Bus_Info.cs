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

namespace BusTicketManagementSystem.User_Controls
{
    public partial class Bus_Info : UserControl
    {
        DatabaseFunctions db = new DatabaseFunctions();


        public Bus_Info()
        {
            InitializeComponent();
        }

        private void Bus_Info_Load(object sender, EventArgs e)
        {
            showAllBus();
        }


        // Adding a bus to the Database
        private void btnAddBus_Click(object sender, EventArgs e)
        {
            //Variables to store all the textBox and ComboBox Value
            string busNumber = busNumberTextBox.Text;
            string busClass = busClassComboBox.Text;
            string busStatus = busStatusComboBox.Text;

            //Checking if any field is empty...
            if (string.IsNullOrEmpty(busNumber) || string.IsNullOrEmpty(busClass) || string.IsNullOrEmpty(busStatus))
            {
                MessageBox.Show("Empty Field", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Checking if the bus already added in the List
                if(busExistance("SELECT bus_number FROM Bus", busNumber))
                {
                    MessageBox.Show("Bus Already Exist", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    db.SetData("INSERT INTO Bus VALUES('" + busNumber + "', '" + busClass + "', '" + busStatus + "')");
                    busNumberTextBox.Text = "";
                    busStatusComboBox.SelectedIndex = -1;
                    busClassComboBox.SelectedIndex = -1;
                    MessageBox.Show("Bus Added Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        //Fetching All data from Bus Table
        public void showAllBus()
        {
            var reader = db.GetData("SELECT * FROM Bus");
            populateGrid(reader);
            //Checking if the scrollBar Exist
            foreach (var scroll in busInfoGrid.Controls.OfType<VScrollBar>())
            {
                if (scroll.Visible)
                {
                    panel1.Visible = true;
                }
                else
                {
                    panel1.Visible = false;
                }
            }
        }
        

        //Bus Info Edit & Delete Functionality
        private void busInfoGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Delete...
            if(busInfoGrid.Columns[e.ColumnIndex].Name == "deleteColumn")
            {
                string selectedBusNumber = busInfoGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "DATA DELETION WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (dialogResult == DialogResult.Yes)
                {
                    //If bus assigned for a trip delete operation not possible
                    if(busExistance("SELECT bus_number FROM Trip", selectedBusNumber))
                    {
                        MessageBox.Show("Bus already assigned for a trip", "Can't Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        db.SetData("DELETE FROM Bus WHERE bus_number = '" + selectedBusNumber + "'");
                        MessageBox.Show("Data Deleted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            //Edit...
            if(busInfoGrid.Columns[e.ColumnIndex].Name == "editColumn")
            {
                string selectedBusNumber = busInfoGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                string selectedBusClass = busInfoGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                string selectedBusStatus = busInfoGrid.Rows[e.RowIndex].Cells[2].Value.ToString();

                //If bus assigned for a trip UPDATE operation not possible
                if (busExistance("SELECT bus_number FROM Trip", selectedBusNumber))
                {
                    MessageBox.Show("Bus already assigned for a trip", "Can't Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Popups.EditBusInfo_Popup editBusInfo_Popup = new Popups.EditBusInfo_Popup(selectedBusNumber, selectedBusClass, selectedBusStatus);
                    editBusInfo_Popup.ShowDialog();
                }
            }
        }

        //Search Box...
        private void searchBoxEvenet(object sender, EventArgs e)
        {
            var reader = db.GetData("SELECT * FROM Bus WHERE bus_number LIKE '"+searchBox.Text+"%'");
            populateGrid(reader);
        }

        //AFunction Fetching data from database and populating Grid
        private void populateGrid(SqlDataReader reader)
        {
            busInfoGrid.Rows.Clear();
            while (reader.Read())
            {
                busInfoGrid.Rows.Add(reader["bus_number"], reader["bus_class"], reader["bus_status"]);
            }
        }

        //A function for checking if a bus is assigned for a trip or not
        private bool busExistance(string query, string busNumber)
        {
            var reader = db.GetData(query);
            bool existance = false;
            while (reader.Read())
            {
                if(busNumber == reader["bus_number"].ToString())
                {
                    existance = true;
                    break;
                }
            }
            return existance;
        }


    }
}
