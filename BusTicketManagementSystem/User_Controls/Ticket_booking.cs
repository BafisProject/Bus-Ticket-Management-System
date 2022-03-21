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

        public Ticket_booking()
        {
            InitializeComponent();
            Ticket_booking_Instance = this;
        }

        private void btnCheckNow_Click(object sender, EventArgs e)
        {
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

        public void Ticket_booking_Load(object sender, EventArgs e)
        {
            
        }
    }
}
