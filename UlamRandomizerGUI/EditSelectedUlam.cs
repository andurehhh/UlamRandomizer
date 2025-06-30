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
    public partial class EditSelectedUlam : Form
    {
        private Account curr;
        private Ulam UlamSelected;
        private int selectedID;
        private Form closingform;
        public EditSelectedUlam(Account curr, int selectedID, Form closingform)
        {
            this.curr = curr;
            this.selectedID = selectedID;
            InitializeComponent();
            DisplayUlamDetails();
            this.closingform = closingform;
        }
        private async void DisplayUlamDetails()
        {
            if (selectedID != null)
            {

                BusinessLogic ABL = new BusinessLogic();
                UlamSelected = BusinessLogic.GetUlambyID(selectedID);

                txtbUlamName.Text = UlamSelected.UlamName;
                txbDescription.Text = BusinessLogic.StripHtmlTags(UlamSelected.ulamDescription);
                txbIngredient1.Text = UlamSelected.MainIngredient1;
                txbIngredient2.Text = UlamSelected.MainIngredient2;
            }
            else
            {
                MessageBox.Show("No Ulam selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Ulam EditedUlam = new Ulam
            {
                Id = selectedID,
                UlamName = txtbUlamName.Text,
                ulamDescription = txbDescription.Text,
                MainIngredient1 = txbIngredient1.Text,
                MainIngredient2 = txbIngredient2.Text
            };
            try
            {
                BusinessLogic.EditUlam(EditedUlam);
                MessageBox.Show("Ulam details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                closingform.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Ulam details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
