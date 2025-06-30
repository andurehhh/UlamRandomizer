namespace UlamRandomizerGUI
{
    partial class FavoritesList
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
            btnBackToMenu = new Button();
            btnRemoveUlam = new Button();
            button1 = new Button();
            label1 = new Label();
            dgFavorites = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            UlamNameColumn = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnEditUlam = new Button();
            btnRandomizeList = new Button();
            ((System.ComponentModel.ISupportInitialize)dgFavorites).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.BackColor = Color.Wheat;
            btnBackToMenu.ForeColor = Color.Black;
            btnBackToMenu.Location = new Point(42, 518);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(130, 54);
            btnBackToMenu.TabIndex = 29;
            btnBackToMenu.Text = "Back to Menu";
            btnBackToMenu.UseVisualStyleBackColor = false;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // btnRemoveUlam
            // 
            btnRemoveUlam.BackColor = Color.Wheat;
            btnRemoveUlam.ForeColor = Color.Black;
            btnRemoveUlam.Location = new Point(584, 518);
            btnRemoveUlam.Name = "btnRemoveUlam";
            btnRemoveUlam.Size = new Size(82, 54);
            btnRemoveUlam.TabIndex = 31;
            btnRemoveUlam.Text = "Remove Favorite";
            btnRemoveUlam.UseVisualStyleBackColor = false;
            btnRemoveUlam.Click += btnRemoveUlam_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Wheat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(672, 518);
            button1.Name = "button1";
            button1.Size = new Size(82, 54);
            button1.TabIndex = 30;
            button1.Text = "View Ulam";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 23F);
            label1.Location = new Point(323, 19);
            label1.Name = "label1";
            label1.Size = new Size(164, 41);
            label1.TabIndex = 32;
            label1.Text = "Favorites";
            // 
            // dgFavorites
            // 
            dgFavorites.AllowUserToAddRows = false;
            dgFavorites.AllowUserToDeleteRows = false;
            dgFavorites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgFavorites.Columns.AddRange(new DataGridViewColumn[] { Id, UlamNameColumn, Type });
            dgFavorites.Location = new Point(42, 107);
            dgFavorites.Name = "dgFavorites";
            dgFavorites.ReadOnly = true;
            dgFavorites.RowHeadersWidth = 51;
            dgFavorites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgFavorites.Size = new Size(712, 377);
            dgFavorites.TabIndex = 33;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Ulam ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // UlamNameColumn
            // 
            UlamNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UlamNameColumn.DataPropertyName = "UlamName";
            UlamNameColumn.HeaderText = "Ulam Name";
            UlamNameColumn.MinimumWidth = 6;
            UlamNameColumn.Name = "UlamNameColumn";
            UlamNameColumn.ReadOnly = true;
            // 
            // Type
            // 
            Type.DataPropertyName = "Type";
            Type.HeaderText = "Ulam Origin";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 82);
            panel1.TabIndex = 34;
            // 
            // btnEditUlam
            // 
            btnEditUlam.BackColor = Color.Wheat;
            btnEditUlam.ForeColor = Color.Black;
            btnEditUlam.Location = new Point(492, 518);
            btnEditUlam.Name = "btnEditUlam";
            btnEditUlam.Size = new Size(82, 54);
            btnEditUlam.TabIndex = 35;
            btnEditUlam.Text = "Edit   Ulam";
            btnEditUlam.UseVisualStyleBackColor = false;
            btnEditUlam.Click += btnEditUlam_Click;
            // 
            // btnRandomizeList
            // 
            btnRandomizeList.BackColor = Color.Wheat;
            btnRandomizeList.ForeColor = Color.Black;
            btnRandomizeList.Location = new Point(313, 518);
            btnRandomizeList.Name = "btnRandomizeList";
            btnRandomizeList.Size = new Size(98, 54);
            btnRandomizeList.TabIndex = 36;
            btnRandomizeList.Text = "Randomize";
            btnRandomizeList.UseVisualStyleBackColor = false;
            btnRandomizeList.Click += btnRandomizeList_Click;
            // 
            // FavoritesList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 628);
            Controls.Add(btnRandomizeList);
            Controls.Add(btnEditUlam);
            Controls.Add(dgFavorites);
            Controls.Add(btnBackToMenu);
            Controls.Add(btnRemoveUlam);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "FavoritesList";
            Text = "FavoritesList";
            ((System.ComponentModel.ISupportInitialize)dgFavorites).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBackToMenu;
        private Button btnRemoveUlam;
        private Button button1;
        private Label label1;
        private DataGridView dgFavorites;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn UlamNameColumn;
        private DataGridViewTextBoxColumn Type;
        private Panel panel1;
        private Button btnEditUlam;
        private Button btnRandomizeList;
    }
}