namespace UlamRandomizerGUI
{
    partial class SearchUlam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            UlamID = new DataGridViewTextBoxColumn();
            UlamName = new DataGridViewTextBoxColumn();
            btnBackToMenu = new Button();
            button1 = new Button();
            btnAddUlam = new Button();
            label1 = new Label();
            txtbSearch = new TextBox();
            btnSearch = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UlamID, UlamName });
            dataGridView1.Location = new Point(40, 140);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(712, 377);
            dataGridView1.TabIndex = 5;
            // 
            // UlamID
            // 
            UlamID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            UlamID.DataPropertyName = "Id";
            UlamID.HeaderText = "Ulam ID";
            UlamID.MinimumWidth = 6;
            UlamID.Name = "UlamID";
            UlamID.Width = 92;
            // 
            // UlamName
            // 
            UlamName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UlamName.DataPropertyName = "UlamName";
            UlamName.HeaderText = "Ulam Name";
            UlamName.MinimumWidth = 6;
            UlamName.Name = "UlamName";
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.BackColor = Color.Wheat;
            btnBackToMenu.ForeColor = Color.Black;
            btnBackToMenu.Location = new Point(40, 539);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(130, 54);
            btnBackToMenu.TabIndex = 25;
            btnBackToMenu.Text = "Back to Menu";
            btnBackToMenu.UseVisualStyleBackColor = false;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Wheat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(622, 539);
            button1.Name = "button1";
            button1.Size = new Size(130, 54);
            button1.TabIndex = 26;
            button1.Text = "View Ulam";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAddUlam
            // 
            btnAddUlam.BackColor = Color.Wheat;
            btnAddUlam.ForeColor = Color.Black;
            btnAddUlam.Location = new Point(486, 539);
            btnAddUlam.Name = "btnAddUlam";
            btnAddUlam.Size = new Size(130, 54);
            btnAddUlam.TabIndex = 27;
            btnAddUlam.Text = "Add Ulam To Favorites";
            btnAddUlam.UseVisualStyleBackColor = false;
            btnAddUlam.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 23F);
            label1.Location = new Point(40, 25);
            label1.Name = "label1";
            label1.Size = new Size(278, 41);
            label1.TabIndex = 33;
            label1.Text = "Search an Ulam:";
            // 
            // txtbSearch
            // 
            txtbSearch.Font = new Font("Segoe UI", 12F);
            txtbSearch.Location = new Point(40, 74);
            txtbSearch.Name = "txtbSearch";
            txtbSearch.Size = new Size(584, 34);
            txtbSearch.TabIndex = 34;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(630, 69);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(122, 41);
            btnSearch.TabIndex = 35;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtbSearch);
            panel1.Location = new Point(0, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 122);
            panel1.TabIndex = 36;
            // 
            // SearchUlam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 628);
            Controls.Add(btnAddUlam);
            Controls.Add(button1);
            Controls.Add(btnBackToMenu);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "SearchUlam";
            Text = "DisplayUlam";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnBackToMenu;
        private Button button1;
        private Button btnAddUlam;
        private Label label1;
        private TextBox txtbSearch;
        private Button btnSearch;
        private DataGridViewTextBoxColumn UlamID;
        private DataGridViewTextBoxColumn UlamName;
        private Panel panel1;
    }
}