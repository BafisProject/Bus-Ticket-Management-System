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
    public partial class Bus_Ticket : Form
    {
        string ticketNumber, phoneNumber, total, destination, departDate, departTime, seats, busNumber;

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            print();
        }

        public Bus_Ticket()
        {
            InitializeComponent();
        }

        public Bus_Ticket(string ticketNumber, string phoneNumber, string total, string destination, string departDate, string departTime, string seats, string busNumber)
        {
            this.ticketNumber = ticketNumber;
            this.phoneNumber = phoneNumber;
            this.total = total;
            this.destination = destination;
            this.departDate = departDate;
            this.departTime = departTime;
            this.seats = seats;
            this.busNumber = busNumber;

            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void Bus_Ticket_Load(object sender, EventArgs e)
        {
            ticketNumberBox.Text = ticketNumber;
            phoneNumberBox.Text = phoneNumber;
            totalBox.Text = total;
            destinationBox.Text = destination;
            departDateBox.Text = departDate;
            departTimeBox.Text = departTime;
            seatsBox.Text = seats;
            busNumberBox.Text = busNumber;          
        }

        //painting the ticket
        void print()
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        Bitmap bitmap;

        
    }
}
