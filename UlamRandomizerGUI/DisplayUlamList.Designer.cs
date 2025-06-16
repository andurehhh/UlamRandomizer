namespace UlamRandomizerGUI
{
    partial class DisplayUlamList
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
            UlamNameColumn = new DataGridViewTextBoxColumn();
            MainIngredientColumn = new DataGridViewTextBoxColumn();
            DescriptionColumn = new DataGridViewTextBoxColumn();
            FavoriteBtnColumn = new DataGridViewButtonColumn();
            btnBackToMenu = new Button();
            button1 = new Button();
            btnAddUlam = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UlamNameColumn, MainIngredientColumn, DescriptionColumn, FavoriteBtnColumn });
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(45, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(712, 274);
            dataGridView1.TabIndex = 5;
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
            // FavoriteBtnColumn
            // 
            FavoriteBtnColumn.HeaderText = "Favorite";
            FavoriteBtnColumn.MinimumWidth = 6;
            FavoriteBtnColumn.Name = "FavoriteBtnColumn";
            FavoriteBtnColumn.ToolTipText = "Click to Add to the favorites Tab";
            FavoriteBtnColumn.Width = 125;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.BackColor = Color.Transparent;
            btnBackToMenu.ForeColor = Color.Black;
            btnBackToMenu.Location = new Point(45, 361);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(130, 54);
            btnBackToMenu.TabIndex = 25;
            btnBackToMenu.Text = "Back to Menu";
            btnBackToMenu.UseVisualStyleBackColor = false;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(627, 361);
            button1.Name = "button1";
            button1.Size = new Size(130, 54);
            button1.TabIndex = 26;
            button1.Text = "View Ulam";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnAddUlam
            // 
            btnAddUlam.BackColor = Color.Transparent;
            btnAddUlam.ForeColor = Color.Black;
            btnAddUlam.Location = new Point(491, 361);
            btnAddUlam.Name = "btnAddUlam";
            btnAddUlam.Size = new Size(130, 54);
            btnAddUlam.TabIndex = 27;
            btnAddUlam.Text = "Add Ulam";
            btnAddUlam.UseVisualStyleBackColor = false;
            btnAddUlam.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 23F);
            label1.Location = new Point(304, 20);
            label1.Name = "label1";
            label1.Size = new Size(164, 41);
            label1.TabIndex = 33;
            label1.Text = "All Ulam";
            label1.Click += label1_Click;
            // 
            // DisplayUlam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnAddUlam);
            Controls.Add(button1);
            Controls.Add(btnBackToMenu);
            Controls.Add(dataGridView1);
            Name = "DisplayUlam";
            Text = "DisplayUlam";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnBackToMenu;
        private Button button1;
        private DataGridViewTextBoxColumn UlamNameColumn;
        private DataGridViewTextBoxColumn MainIngredientColumn;
        private DataGridViewTextBoxColumn DescriptionColumn;
        private DataGridViewButtonColumn FavoriteBtnColumn;
        private Button btnAddUlam;
        private Label label1;
    }
}