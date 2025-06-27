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
    public partial class SearchUlam : Form
    {
        private Account curr;
        public SearchUlam(Account currentUser)
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            dataGridView1.AutoGenerateColumns = false;
            curr = currentUser;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddUlam Add = new AddUlam();
            Add.Show();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            Dispose();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int selectedUlam = Convert.ToInt32(selectedRow.Cells["UlamID"].Value);
            ViewUlam view = new ViewUlam(curr,selectedUlam);

            view.Show();
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtbSearch.Text.Trim();
            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Please enter a search term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                List<Ulam> results = await SpoonacularBL.GetSearchResult(SpoonacularBL.sharedClient, query);
                if (results.Count > 0)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = results;

                    MessageBox.Show("Search Completed!");    

                }
                
                else
                {
                    MessageBox.Show("No ulams found matching your search.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
