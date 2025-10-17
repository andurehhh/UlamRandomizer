using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UlamRandomizerBusinessLogic;

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

        private async void button1_Click(object sender, EventArgs e)
        {
            EmailBL emailBL = new EmailBL();
            AccountBusinessLogic ABL = new AccountBusinessLogic();
            string FirstName = txbFirst.Text.ToString();
            string LastName = txbLast.Text.ToString();
            string Gender = cmbGender.Text.ToString();
            DateOnly Birthday = DateOnly.FromDateTime(dtpBirthday.Value);

            string Username = txbUser.Text.ToString();
            string email = txbEmail.Text.ToString();
            string password;
            if (txbPass.Text.Equals(txbConfPass.Text))
            {
                password = txbPass.Text.ToString();

                try
                {
                    ABL.AddAccount(Username, password, email, FirstName, LastName, Gender, Birthday);
                    MessageBox.Show("Account Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await emailBL.sendConfirmationEmail(email, FirstName);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
