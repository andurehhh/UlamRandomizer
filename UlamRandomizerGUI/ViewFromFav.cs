using Microsoft.Data.SqlClient;
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
    public partial class ViewFromFav : Form
    {
        private Account curr;
        private Ulam UlamSelected;
        private int selectedID;
        private string TypeUlam;
        public ViewFromFav(Account CurrentUser, int index, string Type)
        {
            InitializeComponent();
            curr = CurrentUser;
            selectedID = index;
            TypeUlam = Type;
            DisplayUlamDetails();

        }
        private async void DisplayUlamDetails()
        {
            if (selectedID != null)
            {
                if (TypeUlam.Trim().Equals("API"))
                {
                    UlamSelected = await SpoonacularBL.GetUlamInfo(SpoonacularBL.sharedClient, selectedID);
                    if (UlamSelected != null)
                    {
                        txtbUlamName.Text = UlamSelected.UlamName;
                        txbDescription.Text = BusinessLogic.StripHtmlTags(UlamSelected.ulamDescription);
                        pictureBox1.LoadAsync(UlamSelected.ImgString);
                    }
                }
                else
                {

                    BusinessLogic ABL = new BusinessLogic();
                    UlamSelected = ABL.GetUlambyID(selectedID);

                    txtbUlamName.Text = UlamSelected.UlamName;
                    txbDescription.Text = BusinessLogic.StripHtmlTags(UlamSelected.ulamDescription);
                    txtbIngredient1.Text = UlamSelected.MainIngredient1;
                    txtbIngredient2.Text = UlamSelected.MainIngredient2;

                }

            }
            else
            {
                MessageBox.Show("No Ulam selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            AccountBusinessLogic ABL = new AccountBusinessLogic();
            ABL.RemoveFavorite(curr.Id, selectedID);
            MessageBox.Show("Ulam removed from favorites successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
