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
            dataGridView1 = new DataGridView();
            UlamNameColumn = new DataGridViewTextBoxColumn();
            MainIngredientColumn = new DataGridViewTextBoxColumn();
            DescriptionColumn = new DataGridViewTextBoxColumn();
            btnAddUlam = new Button();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.BackColor = Color.Transparent;
            btnBackToMenu.ForeColor = Color.Black;
            btnBackToMenu.Location = new Point(44, 348);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(130, 54);
            btnBackToMenu.TabIndex = 29;
            btnBackToMenu.Text = "Back to Menu";
            btnBackToMenu.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UlamNameColumn, MainIngredientColumn, DescriptionColumn });
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(44, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(712, 274);
            dataGridView1.TabIndex = 28;
            // 
            // UlamNameColumn
            // 
            UlamNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UlamNameColumn.HeaderText = "Ulam Name";
            UlamNameColumn.MinimumWidth = 6;
            UlamNameColumn.Name = "UlamNameColumn";
            // 
            // MainIngredientColumn
            // 
            MainIngredientColumn.HeaderText = "Main Ingredient";
            MainIngredientColumn.MinimumWidth = 6;
            MainIngredientColumn.Name = "MainIngredientColumn";
            MainIngredientColumn.Width = 125;
            // 
            // DescriptionColumn
            // 
            DescriptionColumn.HeaderText = "Description";
            DescriptionColumn.MinimumWidth = 6;
            DescriptionColumn.Name = "DescriptionColumn";
            DescriptionColumn.Width = 125;
            // 
            // btnAddUlam
            // 
            btnAddUlam.BackColor = Color.Transparent;
            btnAddUlam.ForeColor = Color.Black;
            btnAddUlam.Location = new Point(490, 348);
            btnAddUlam.Name = "btnAddUlam";
            btnAddUlam.Size = new Size(130, 54);
            btnAddUlam.TabIndex = 31;
            btnAddUlam.Text = "Remove from Favorites";
            btnAddUlam.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(626, 348);
            button1.Name = "button1";
            button1.Size = new Size(130, 54);
            button1.TabIndex = 30;
            button1.Text = "View Ulam";
            button1.UseVisualStyleBackColor = false;
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
            // FavoritesList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnBackToMenu);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddUlam);
            Controls.Add(button1);
            Name = "FavoritesList";
            Text = "FavoritesList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackToMenu;
        private DataGridView dataGridView1;
        private Button btnAddUlam;
        private Button button1;
        private Label label1;
        private DataGridViewTextBoxColumn UlamNameColumn;
        private DataGridViewTextBoxColumn MainIngredientColumn;
        private DataGridViewTextBoxColumn DescriptionColumn;
    }
}