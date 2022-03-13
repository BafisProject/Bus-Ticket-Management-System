using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusTicketManagementSystem.User_Controls;
using Guna.UI2.WinForms;

namespace BusTicketManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            hideallUserControl();
            uncheckAllButton();
            showUserControl(user_Dashboard1, btnDashboard);
        }

        private void uncheckAllButton()
        {
            btnDashboard.Checked = false;
            btnAvailable.Checked = false;
        }

        private void hideallUserControl()
        {
            user_Dashboard1.Visible = false;
            available_Trip1.Visible = false;
        }

        private void showUserControl(UserControl x, Guna2Button y)
        {
            hideallUserControl();
            uncheckAllButton();
            y.Checked = true;
            x.Visible = true;
            x.BringToFront();
        }
   

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            showUserControl(user_Dashboard1, btnDashboard);
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            showUserControl(available_Trip1, btnAvailable);
        }
    }
}
