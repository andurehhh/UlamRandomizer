namespace UlamRandomizerGUI
{
    partial class ViewFromFav
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
            txtbUlamName = new TextBox();
            lblDescription = new Label();
            btnMenu = new Button();
            txbDescription = new TextBox();
            txtbIngredient2 = new Label();
            txtbIngredient1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtbUlamName
            // 
            txtbUlamName.BackColor = SystemColors.ButtonFace;
            txtbUlamName.BorderStyle = BorderStyle.FixedSingle;
            txtbUlamName.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbUlamName.Location = new Point(428, 72);
            txtbUlamName.Multiline = true;
            txtbUlamName.Name = "txtbUlamName";
            txtbUlamName.ReadOnly = true;
            txtbUlamName.ScrollBars = ScrollBars.Horizontal;
            txtbUlamName.Size = new Size(214, 48);
            txtbUlamName.TabIndex = 40;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Tahoma", 9F);
            lblDescription.Location = new Point(28, 293);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(83, 18);
            lblDescription.TabIndex = 39;
            lblDescription.Text = "Description:";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Wheat;
            btnMenu.ForeColor = Color.Black;
            btnMenu.Location = new Point(28, 547);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(127, 43);
            btnMenu.TabIndex = 36;
            btnMenu.Text = "Back to Menu";
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // txbDescription
            // 
            txbDescription.BorderStyle = BorderStyle.FixedSingle;
            txbDescription.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbDescription.Location = new Point(28, 316);
            txbDescription.Multiline = true;
            txbDescription.Name = "txbDescription";
            txbDescription.ReadOnly = true;
            txbDescription.ScrollBars = ScrollBars.Vertical;
            txbDescription.Size = new Size(583, 185);
            txbDescription.TabIndex = 35;
            // 
            // txtbIngredient2
            // 
            txtbIngredient2.AutoSize = true;
            txtbIngredient2.BackColor = SystemColors.ButtonHighlight;
            txtbIngredient2.BorderStyle = BorderStyle.FixedSingle;
            txtbIngredient2.Font = new Font("Sitka Banner", 10.1999989F);
            txtbIngredient2.Location = new Point(428, 210);
            txtbIngredient2.Name = "txtbIngredient2";
            txtbIngredient2.Size = new Size(88, 26);
            txtbIngredient2.TabIndex = 34;
            txtbIngredient2.Text = "Ingredient2";
            // 
            // txtbIngredient1
            // 
            txtbIngredient1.AutoSize = true;
            txtbIngredient1.BackColor = SystemColors.ButtonHighlight;
            txtbIngredient1.BorderStyle = BorderStyle.FixedSingle;
            txtbIngredient1.Font = new Font("Sitka Banner", 10.1999989F);
            txtbIngredient1.Location = new Point(429, 173);
            txtbIngredient1.Name = "txtbIngredient1";
            txtbIngredient1.Size = new Size(86, 26);
            txtbIngredient1.TabIndex = 33;
            txtbIngredient1.Text = "Ingredient1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F);
            label2.Location = new Point(425, 139);
            label2.Name = "label2";
            label2.Size = new Size(121, 18);
            label2.TabIndex = 32;
            label2.Text = "Main Ingredients:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(28, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F);
            label1.Location = new Point(424, 49);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 30;
            label1.Text = "Ulam Name:";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.LightCoral;
            btnRemove.ForeColor = Color.DarkRed;
            btnRemove.Location = new Point(450, 547);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(192, 43);
            btnRemove.TabIndex = 41;
            btnRemove.Text = "Remove From Favorites";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // ViewFromFav
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(688, 628);
            Controls.Add(btnRemove);
            Controls.Add(txtbUlamName);
            Controls.Add(lblDescription);
            Controls.Add(btnMenu);
            Controls.Add(txbDescription);
            Controls.Add(txtbIngredient2);
            Controls.Add(txtbIngredient1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ViewFromFav";
            Text = "ViewFromFav";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbUlamName;
        private Label lblDescription;
        private Button btnMenu;
        private TextBox txbDescription;
        private Label txtbIngredient2;
        private Label txtbIngredient1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnRemove;
    }
}