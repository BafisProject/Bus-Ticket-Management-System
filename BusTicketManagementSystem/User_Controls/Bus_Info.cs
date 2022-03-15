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
    public partial class Bus_Info : UserControl
    {
        DatabaseFunctions db = new DatabaseFunctions();

        public Bus_Info()
        {
            InitializeComponent();
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
                var reader = db.GetData("SELECT bus_number FROM BUS");
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
                    busClassComboBox.Items.Clear();
                    busStatusComboBox.Items.Clear();
                    MessageBox.Show("Bus Added Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }



    }
}
