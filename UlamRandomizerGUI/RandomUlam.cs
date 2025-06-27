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
    public partial class RandomUlam : Form
    {
        private Account curr;
        private int selectedID;
        public RandomUlam(Account CurrentUser)
        {
            InitializeComponent();
            RandomizeUlam();
            curr = CurrentUser;
        }

        private async void RandomizeUlam()
        {
            Ulam RandomUlam = await SpoonacularBL.GenerateRandomUlam(SpoonacularBL.sharedClient);
            if (RandomUlam != null)
            {
                txtbUlamName.Text = RandomUlam.UlamName;
                // Assuming you have a method to display the image
                // DisplayImage(RandomUlam.ImageUrl);
                selectedID = Convert.ToInt32(RandomUlam.Id);
            }
            else
            {
                MessageBox.Show("No random Ulam found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewUlam view = new ViewUlam(curr,selectedID);
            view.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbUlamName.Text = string.Empty;
            RandomizeUlam();
        }
    }
}
