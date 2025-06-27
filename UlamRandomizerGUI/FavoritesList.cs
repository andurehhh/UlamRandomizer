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
            int ulamSelected = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            ViewUlam view = new ViewUlam(curr, ulamSelected);
            view.Show();

        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private async void LoadFavorites()
        {
            AccountBusinessLogic ABL = new AccountBusinessLogic();
            List<Ulam> Favorites = await ABL.GetFavoriteAll(curr);

            dgFavorites.DataSource = null;
            dgFavorites.DataSource = Favorites;
        }

        private void btnRemoveUlam_Click(object sender, EventArgs e)
        {
            AccountBusinessLogic ABL = new AccountBusinessLogic();
            try
            {
                ABL.RemoveFavorite(curr.Id, Convert.ToInt32(dgFavorites.SelectedRows[0].Cells["Id"].Value));
                MessageBox.Show("Ulam removed from favorites successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
