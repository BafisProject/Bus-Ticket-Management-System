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
    public partial class Analytics : UserControl
    {
        public Analytics()
        {
            InitializeComponent();
        }

        private void Analytics_Load(object sender, EventArgs e)
        {
            incomeChart.Series["TAKA"].Points.AddXY("Sunday", "5000");
            incomeChart.Series["TAKA"].Points.AddXY("Monday", "4070");
            incomeChart.Series["TAKA"].Points.AddXY("Tuesday", "3360");
            incomeChart.Series["TAKA"].Points.AddXY("Wednesday", "4012");
            incomeChart.Series["TAKA"].Points.AddXY("Thursday", "6894");
            incomeChart.Series["TAKA"].Points.AddXY("Friday", "5555");
            incomeChart.Series["TAKA"].Points.AddXY("Saturday", "7896");
        }
    }
}
