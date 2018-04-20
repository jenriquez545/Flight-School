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
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
        }

        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            mainMenuForm menuForm = new mainMenuForm();
            menuForm.ShowDialog();
        }

        private void clearFormbutton_Click(object sender, EventArgs e)
        {
            custIDTextBox.Clear();//not really needed, but still
            custFirstNameTextBox.Clear();
            custLastNameTextBox.Clear();
            custAddressTextBox.Clear();
            addressTwoTextBox.Clear();
            cityTextBox.Clear();
            stateTextBox.Clear();
            zipTextBox.Clear();
            preferredPhoneNumTextBox.Clear();
            custBalanceTextBox.Clear();
            licenseRatingTextBox.Clear();
        }

        private void addCustButton_Click(object sender, EventArgs e)
        {

        }
    }
}
