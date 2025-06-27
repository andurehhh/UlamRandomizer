using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UlamCommon;
using UlamRandomizerBusinessLogic;
namespace UlamRandomizerGUI
{
    public partial class Login : Form
    {
        static AccountBusinessLogic ABL = new AccountBusinessLogic();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ABL.ConfirmLogin(txbUserName.Text, txbPassword.Text))
            {
                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Account currUser = ABL.IdentifyAccountUser(txbUserName.Text);
                frmMainMenu menu = new frmMainMenu(currUser);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //frmMainMenu menu = new frmMainMenu();

            //menu.Show();
            //this.Hide();
        }
    }
}
