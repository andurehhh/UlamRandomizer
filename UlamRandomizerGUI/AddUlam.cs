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
    public partial class AddUlam : Form
    {
        private Account curr;
        public AddUlam(Account CurrentAccount)
        {
            curr = CurrentAccount;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccountBusinessLogic ABL = new AccountBusinessLogic();
            try
            {
                Ulam newUlam = BusinessLogic.CreateUlamObj(txtbUlamName.Text, txtbMainIngredient1.Text, txbMainIngredient2.Text, txtbDescription.Text);
                int newUlamID=ABL.GetUlamID(newUlam);
                ABL.AddCustomUlamToFavorite(curr.Id, newUlamID);
                MessageBox.Show("Ulam Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Ulam Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)//add Pic
        {
            uploadPicture();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void uploadPicture()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            txtbUlamName.Clear();
            txtbMainIngredient1.Clear();
            txbMainIngredient2.Clear();
            txtbDescription.Clear();
        }
    }
}
