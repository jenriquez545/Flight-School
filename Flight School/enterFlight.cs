﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_School
{
    public partial class enterFlight : Form
    {
        public enterFlight()
        {
            InitializeComponent();
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            mainMenuForm menuForm = new mainMenuForm();
            menuForm.ShowDialog();
        }

        private void submitFlightButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Would be adding flight");
        }
    }
}
