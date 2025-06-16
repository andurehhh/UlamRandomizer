namespace UlamRandomizerGUI
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayUlamList display = new DisplayUlamList();
            display.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUlam Add = new AddUlam();
            Add.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            RandomUlam randomize = new RandomUlam();
            randomize.Show();
        }

        private void btnFavoritesList_Click(object sender, EventArgs e)
        {
            FavoritesList fav= new FavoritesList();
            fav.Show();
        }
    }
}
