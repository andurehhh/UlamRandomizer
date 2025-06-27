using UlamCommon;

namespace UlamRandomizerGUI
{
    public partial class frmMainMenu : Form
    {
        private Account curr;
        public frmMainMenu(Account CurrentAccount)
        {
            InitializeComponent();
            curr = CurrentAccount;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchUlam display = new SearchUlam(curr);
            display.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUlam Add = new AddUlam(curr);
            Add.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            RandomUlam randomize = new RandomUlam(curr);
            randomize.Show();
        }

        private void btnFavoritesList_Click(object sender, EventArgs e)
        {
            FavoritesList fav = new FavoritesList(curr);
            fav.Show();
            //this.Hide();
        }
    }
}
