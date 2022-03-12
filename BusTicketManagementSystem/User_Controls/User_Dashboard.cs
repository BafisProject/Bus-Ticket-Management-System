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
    public partial class User_Dashboard : UserControl
    {
        public User_Dashboard()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hourText.Text = DateTime.Now.ToString("HH");
            minuteText.Text = DateTime.Now.ToString("mm");
            secondText.Text = DateTime.Now.ToString("ss");
            dayText.Text = DateTime.Now.ToString("dddd");
            dayNumber.Text = DateTime.Now.ToString("dd");
            monthText.Text = DateTime.Now.ToString("MMMM");
        }

        private void User_Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
