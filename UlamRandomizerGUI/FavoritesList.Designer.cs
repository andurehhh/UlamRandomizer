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
            ((System.ComponentModel.ISupportInitialize)dgFavorites).BeginInit();
            SuspendLayout();
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.BackColor = Color.Transparent;
            btnBackToMenu.ForeColor = Color.Black;
            btnBackToMenu.Location = new Point(42, 490);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(130, 54);
            btnBackToMenu.TabIndex = 29;
            btnBackToMenu.Text = "Back to Menu";
            btnBackToMenu.UseVisualStyleBackColor = false;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // btnRemoveUlam
            // 
            btnRemoveUlam.BackColor = Color.Transparent;
            btnRemoveUlam.ForeColor = Color.Black;
            btnRemoveUlam.Location = new Point(488, 490);
            btnRemoveUlam.Name = "btnRemoveUlam";
            btnRemoveUlam.Size = new Size(130, 54);
            btnRemoveUlam.TabIndex = 31;
            btnRemoveUlam.Text = "Remove from Favorites";
            btnRemoveUlam.UseVisualStyleBackColor = false;
            btnRemoveUlam.Click += btnRemoveUlam_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(624, 490);
            button1.Name = "button1";
            button1.Size = new Size(130, 54);
            button1.TabIndex = 30;
            button1.Text = "View Ulam";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 23F);
            label1.Location = new Point(298, 12);
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
            dgFavorites.Columns.AddRange(new DataGridViewColumn[] { Id, UlamNameColumn });
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
            // FavoritesList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 628);
            Controls.Add(dgFavorites);
            Controls.Add(label1);
            Controls.Add(btnBackToMenu);
            Controls.Add(btnRemoveUlam);
            Controls.Add(button1);
            Name = "FavoritesList";
            Text = "FavoritesList";
            ((System.ComponentModel.ISupportInitialize)dgFavorites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackToMenu;
        private Button btnRemoveUlam;
        private Button button1;
        private Label label1;
        private DataGridView dgFavorites;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn UlamNameColumn;
    }
}