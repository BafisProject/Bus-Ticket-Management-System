﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementSystem.Popups
{
    public partial class EditTripInfo_Popup : Form
    {
        DatabaseFunctions db = new DatabaseFunctions();
        int id;
        string destination, time, date;
        public EditTripInfo_Popup()
        {
            InitializeComponent();
        }       

        public EditTripInfo_Popup(int id, string destination, string time, string date)
        {
            InitializeComponent();
            this.id = id;
            this.destination = destination;
            this.time = time;
            this.date = date;
        }
 

        private void EditTripInfo_Popup_Load(object sender, EventArgs e)
        {
            tripIDTxt.Text = "TRIP ID: " + id.ToString();
            destinationComboBox.Text = destination;
            departTimePicker.Text = time.ToString();
            departDatePicker.Text = date.ToString();
        }

        private void btnUpdateTrip_Click(object sender, EventArgs e)
        {
            string selectedDestination = destinationComboBox.Text;
            string selectedTime = departTimePicker.Value.ToString("hh:mm tt");
            string selectedDate = departDatePicker.Value.ToString("yyyy-MM-dd");
            if(selectedDestination != "" && selectedTime != null && selectedDate != null)
            {
                //Validating time and Date
                if(DateTime.Parse(selectedDate, CultureInfo.InvariantCulture) < DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"), CultureInfo.InvariantCulture))
                {
                    MessageBox.Show("Invalid Date Selection", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else if(DateTime.Parse(selectedDate, CultureInfo.InvariantCulture) == DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"), CultureInfo.InvariantCulture))
                {
                    if(DateTime.Parse(selectedTime, CultureInfo.InvariantCulture) < DateTime.Parse(DateTime.Now.ToString("hh:mm tt"), CultureInfo.InvariantCulture))
                    {
                        MessageBox.Show("Invalid Time Selection");
                    }
                    else
                    {
                        db.SetData("UPDATE Trip SET destination = '" + selectedDestination + "', depart_time = '" + selectedTime + "', depart_date = '" + selectedDate + "' WHERE trip_ID = " + id + "");
                        MessageBox.Show("Trip Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    db.SetData("UPDATE Trip SET destination = '" + selectedDestination + "', depart_time = '" + selectedTime+ "', depart_date = '" + selectedDate + "' WHERE trip_ID = " + id + "");
                    MessageBox.Show("Trip Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}