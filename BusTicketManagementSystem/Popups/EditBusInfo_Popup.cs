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
    
    public partial class EditBusInfo_Popup : Form
    {
        DatabaseFunctions db = new DatabaseFunctions();
        string busNumber, busClass, busStatus;
        public EditBusInfo_Popup()
        {
            InitializeComponent();
        }

        public EditBusInfo_Popup(string busNumber, string busClass, string busStatus)
        {
            InitializeComponent();
            this.busNumber = busNumber;
            this.busClass = busClass;
            this.busStatus = busStatus;
        }

        private void EditBusInfo_Popup_Load(object sender, EventArgs e)
        {
            busNumberTxt.Text = busNumber;
            busClassComboBox.Text = busClass;
            busStatusComboBox.Text = busStatus;
        }


        private void btnUpdateBus_Click(object sender, EventArgs e)
        {
            if(busClassComboBox.Text != "" && busStatusComboBox.Text != "")
            {
                db.SetData("UPDATE Bus SET bus_class = '"+ busClassComboBox.Text + "', bus_status = '"+busStatusComboBox.Text+"' WHERE bus_number = '"+busNumberTxt.Text+"'");
                MessageBox.Show("Bus Info Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            //dashboard.Activate();
            dashboard.Show();
        }
    }
}
