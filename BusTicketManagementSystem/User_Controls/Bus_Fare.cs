using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementSystem.User_Controls
{
    public partial class Bus_Fare : UserControl
    {
        DatabaseFunctions db = new DatabaseFunctions();
        public Bus_Fare()
        {
            InitializeComponent();
        }

        //Bus Fare Add Button Click Event
        private void btnSetFare_Click(object sender, EventArgs e)
        {
            string source = sourceComboBox.Text;
            string destination = destinationComboBox.Text;
            string busClass = busClassComboBox.Text;
            string busFare = busFareText.Text;

            if(source == "" || destination == "" || busClass == "" || busFare == "")
            {
                MessageBox.Show("Please fill up everything", "unable to proceed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                db.SetData("INSERT INTO Fare VALUES('"+source+"', '"+destination+"', '"+busClass+"', "+busFare+")");
                MessageBox.Show("Fare Set Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void showAllFare()
        {
            var reader = db.GetData("SELECT * FROM Fare");
            busFareGrid.Rows.Clear();
            while (reader.Read())
            {
                busFareGrid.Rows.Add(reader["source"], reader["destination"], reader["class"], reader["fare"] + " TAKA");
            }
        }
    }
}
