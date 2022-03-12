using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Form field placeholder and password hide
        private void loginPassword_TextChange(object sender, EventArgs e)
        {
            if (loginPassword.Text == String.Empty)
            {
                loginPassword.PasswordChar = '\0';
            }
            else
            {
                loginPassword.PasswordChar = '●';
            }
        }

        //Validating if username or password correct or not empty and redirecting to dashboard
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = loginUsername.Text;
            string password = loginPassword.Text;

            if(username != String.Empty && password != String.Empty)
            {
                if(username == "admin" && password == "admin")
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password Incorrect", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username and Password Required", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
