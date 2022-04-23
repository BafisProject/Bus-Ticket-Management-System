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
    public partial class Passengers : UserControl
    {
        DatabaseFunctions db = new DatabaseFunctions();
        public Passengers()
        {
            InitializeComponent();
        }

        public void showAllPassengers()
        {
            var reader = db.GetData("SELECT * FROM Passenger");
            passengerGrid.Rows.Clear();
            while (reader.Read())
            {
                passengerGrid.Rows.Add(reader["passenger_ID"].ToString(), reader["name"].ToString(), reader["phone_number"].ToString());
            }
        }
    }
}
