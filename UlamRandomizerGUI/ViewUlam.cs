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
using UlamRandomizerDataLogic;

namespace UlamRandomizerGUI
{
    public partial class ViewUlam : Form
    {
        private Account curr;
        private Ulam UlamSelected;
        private int selectedID;
        public ViewUlam(Account CurrentUser, int index)
        {
            InitializeComponent();
            curr = CurrentUser;
            selectedID = index;
            DisplayUlamDetails();

        }
        private async void DisplayUlamDetails()
        {
            if (selectedID != null)
            {
                UlamSelected = await SpoonacularBL.GetUlamInfo(SpoonacularBL.sharedClient, selectedID);
                if (UlamSelected != null)
                {
                    txtbUlamName.Text = UlamSelected.UlamName;
                    txbDescription.Text = BusinessLogic.StripHtmlTags(UlamSelected.ulamDescription);
                }
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToFav_Click(object sender, EventArgs e)
        {
            AccountBusinessLogic ABL = new AccountBusinessLogic();
            try
            {
                if (ABL.DoesFavoriteExist(curr.Id, selectedID))
                {
                    ABL.AddAPIUlamToFavorite(curr.Id, selectedID);
                    MessageBox.Show("Ulam added to favorites successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This Ulam already exists in your favorites.", "Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding Ulam to favorites: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
