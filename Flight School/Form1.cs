using System;
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
    public partial class mainMenuForm : Form
    {
        public mainMenuForm()
        {
            InitializeComponent();
        }

        private void addCustButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            addCustomer custForm = new addCustomer();
            custForm.ShowDialog();
            this.Close();
        }

        private void enterFlightButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Would be entering flight info");
            this.Hide();
            enterFlight flightForm = new enterFlight();
            flightForm.ShowDialog();
            this.Close();
        }

        private void changeCustRatingButton_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Would change customer rating");
            this.Hide();
            changeCustRating ratingForm = new changeCustRating();
            ratingForm.ShowDialog();
            this.Close();
        }

        private void payEmployeeButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Would be paying employees");
            this.Hide();
            payInstructor payForm = new payInstructor();
            payForm.ShowDialog();
            this.Close();
        }

        private void exitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
