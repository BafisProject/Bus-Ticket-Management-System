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

    }
}
