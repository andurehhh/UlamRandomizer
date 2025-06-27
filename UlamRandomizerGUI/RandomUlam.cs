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
        private string Type = "API";
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
                pictureBox1.LoadAsync(RandomUlam.ImgString);
                lblIngredient1.Text = RandomUlam.MainIngredient1;
                lblIngredient2.Text = RandomUlam.MainIngredient2;
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
            ViewUlam view = new ViewUlam(curr, selectedID, Type);
            view.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbUlamName.Text = string.Empty;
            RandomizeUlam();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
