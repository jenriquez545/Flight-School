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
            MessageBox.Show("Would be entering flight info");
        }

        private void changeCustAuthButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Would change customer authorization");
        }

        private void custToInstButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Would change customers to instructors");
        }

        private void payEmployeeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Would be paying employees");
        }

        private void exitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
