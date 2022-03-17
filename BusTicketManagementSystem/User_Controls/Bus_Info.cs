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

            bool busExist = false;

            //Checking if any field is empty...
            if (string.IsNullOrEmpty(busNumber) || string.IsNullOrEmpty(busClass) || string.IsNullOrEmpty(busStatus))
            {
                MessageBox.Show("Empty Field", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Checking Bus number that if it's already exist or not
                var reader = db.GetData("SELECT bus_number FROM Bus");
                while (reader.Read())
                {
                    if(busNumber == reader["bus_number"].ToString())
                    {
                        busExist = true;//this will help to know bus existance
                        MessageBox.Show("Bus Already Exist", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                }

                //IF bus number is unique then the below if block will INSERT the bus...
                if(busExist == false)
                {
                    db.SetData("INSERT INTO Bus VALUES('"+busNumber+"', '"+busClass+"', '"+busStatus+"')");
                    busNumberTextBox.Text = "";             
                    busStatusComboBox.SelectedIndex = -1;
                    busClassComboBox.SelectedIndex = -1;
                    MessageBox.Show("Bus Added Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }


        public void showAllBus()
        {
            var reader = db.GetData("SELECT * FROM Bus");
            busInfoGrid.Rows.Clear();
            while (reader.Read())
            {
                busInfoGrid.Rows.Add(reader["bus_number"], reader["bus_class"], reader["bus_status"]);
            }
        }
  
        private void busInfoGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(busInfoGrid.Columns[e.ColumnIndex].Name == "deleteColumn")
            {
                string selectedBusNumber = busInfoGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "DATA DELETION WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    db.SetData("DELETE FROM Bus WHERE bus_number = '"+selectedBusNumber+"'");
                    MessageBox.Show("Data Deleted Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        
    }
}
