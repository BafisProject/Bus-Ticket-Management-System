using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementSystem.Popups
{
    public partial class Direction : Form
    {
        string source, destination;
        public Direction()
        {
            InitializeComponent();
        }

        public Direction(string source, string destination)
        {
            InitializeComponent();
            this.source = source;
            this.destination = destination;
        }

        private void Direction_Load(object sender, EventArgs e)
        {
            StringBuilder queryAddress = new StringBuilder();
            queryAddress.Append("https://www.google.com/maps/dir");
            queryAddress.Append("/" + source);
            queryAddress.Append("/" + destination);
            queryAddress.Append("/@23.5914289,89.7028593,8.5z/");
            webBrowser1.Navigate(queryAddress.ToString());
            //webBrowser1.Navigate("https://www.google.com/maps/dir/Dhaka/Khulna/@23.5914289,89.7028593,8.5z/");
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
