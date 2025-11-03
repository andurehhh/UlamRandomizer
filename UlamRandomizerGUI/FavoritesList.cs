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
    public partial class FavoritesList : Form
    {
        private Account curr;
        List<Ulam> Favorites;
        public FavoritesList(Account CurrentAccount)
        {
            InitializeComponent();
            dgFavorites.AutoGenerateColumns = false;
            curr = CurrentAccount;
            LoadFavorites();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgFavorites.SelectedRows[0];
            string TypeUlam = selectedRow.Cells["Type"].Value.ToString();
            int ulamSelected = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            ViewFromFav view = new ViewFromFav(curr, ulamSelected, TypeUlam);
            view.Show();

        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void LoadFavorites()
        {
            AccountBusinessLogic ABL = new AccountBusinessLogic();
            Favorites = await ABL.GetFavoriteAll(curr);

            dgFavorites.DataSource = null;
            dgFavorites.DataSource = Favorites;
        }

        private void btnRemoveUlam_Click(object sender, EventArgs e)
        {
            AccountBusinessLogic ABL = new AccountBusinessLogic();

            var AssuranceMessage = MessageBox.Show("Are you sure you want to remove this Ulam from your favorites?", "Remove?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (AssuranceMessage == DialogResult.Yes)
            {
                try
                {
                    ABL.RemoveFavorite(curr.Id, Convert.ToInt32(dgFavorites.SelectedRows[0].Cells["Id"].Value));
                    MessageBox.Show("Ulam removed from favorites successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFavorites();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnRandomizeList_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int CountNum = dgFavorites.Rows.Count;
            DataGridViewRow selectedRow = dgFavorites.Rows[random.Next(0, CountNum)];

            string TypeUlam = selectedRow.Cells["Type"].Value.ToString();
            int ulamSelected = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            ViewFromFav view = new ViewFromFav(curr, ulamSelected, TypeUlam);
            view.Show();
        }

        private void btnEditUlam_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgFavorites.SelectedRows[0];
            string TypeUlam = selectedRow.Cells["Type"].Value.ToString();
            int ulamSelected = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            if (TypeUlam.Equals("Custom"))
            {
                EditSelectedUlam edit = new EditSelectedUlam(curr, ulamSelected, this);
                edit.Show();
            }
            else
            {
                MessageBox.Show("Error: Cannot Edit Ulam from the API", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //EmailBL emailBL = new EmailBL();
            //if (Favorites.Count == 0)
            //{
            //    MessageBox.Show("Your favorites list is empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //try
            //{
            //    emailBL.sendFavouritesEmail(curr.Email, curr.FirstName, Favorites);
            //    MessageBox.Show("Favorites list sent to your email successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error sending email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;

            //}
        }


        //private async Task btn_click_sendFavToEmail(object sender, EventArgs e)
        //{
        //    EmailBL emailBL = new EmailBL();
        //    if (Favorites.Count == 0)
        //    {
        //        MessageBox.Show("Your favorites list is empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }

        //    try
        //    {
        //        var confirmSent = await emailBL.sendFavouritesEmail(curr.Email, curr.FirstName, Favorites);
        //        if (confirmSent)
        //        {
        //            MessageBox.Show("Favorites list sent to your email successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Failed to send favorites list to your email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error sending email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;

        //    }
        //}
    }
}
