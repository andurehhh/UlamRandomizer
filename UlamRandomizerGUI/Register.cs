using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UlamRandomizerGUI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FirstName = txbFirst.ToString();
            string LastName = txbLast.ToString();
            string Gender = cmbGender.ToString();
            DateTime Birthday = dtpBirthday.Value;

            string Username = txbUser.ToString();
            string email = txbEmail.ToString();
            string password;
            if (txbPass.Text.Equals(txbConfPass.Text))
            {
                password = txbPass.ToString();
            }
            else
            {
                MessageBox.Show("Wrong Password", "Error");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
