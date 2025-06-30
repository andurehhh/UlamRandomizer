namespace UlamRandomizerGUI
{
    partial class EditSelectedUlam
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
            btnSaveChanges = new Button();
            btnMenu = new Button();
            txbDescription = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txbIngredient1 = new TextBox();
            txbIngredient2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtbUlamName
            // 
            txtbUlamName.BackColor = SystemColors.ButtonFace;
            txtbUlamName.BorderStyle = BorderStyle.FixedSingle;
            txtbUlamName.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbUlamName.Location = new Point(437, 75);
            txtbUlamName.Multiline = true;
            txtbUlamName.Name = "txtbUlamName";
            txtbUlamName.ReadOnly = true;
            txtbUlamName.ScrollBars = ScrollBars.Horizontal;
            txtbUlamName.Size = new Size(214, 48);
            txtbUlamName.TabIndex = 39;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Tahoma", 9F);
            lblDescription.Location = new Point(37, 296);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(83, 18);
            lblDescription.TabIndex = 38;
            lblDescription.Text = "Description:";
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.Wheat;
            btnSaveChanges.ForeColor = Color.Black;
            btnSaveChanges.Location = new Point(466, 538);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(163, 55);
            btnSaveChanges.TabIndex = 37;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Wheat;
            btnMenu.ForeColor = Color.Black;
            btnMenu.Location = new Point(37, 550);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(127, 43);
            btnMenu.TabIndex = 36;
            btnMenu.Text = "Back";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // txbDescription
            // 
            txbDescription.BorderStyle = BorderStyle.FixedSingle;
            txbDescription.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbDescription.Location = new Point(37, 319);
            txbDescription.Multiline = true;
            txbDescription.Name = "txbDescription";
            txbDescription.ScrollBars = ScrollBars.Vertical;
            txbDescription.Size = new Size(583, 185);
            txbDescription.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F);
            label2.Location = new Point(434, 142);
            label2.Name = "label2";
            label2.Size = new Size(121, 18);
            label2.TabIndex = 32;
            label2.Text = "Main Ingredients:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(37, 36);
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
            label1.Location = new Point(433, 52);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 30;
            label1.Text = "Ulam Name:";
            // 
            // txbIngredient1
            // 
            txbIngredient1.BorderStyle = BorderStyle.FixedSingle;
            txbIngredient1.Font = new Font("Sitka Banner", 10.1999989F);
            txbIngredient1.Location = new Point(438, 183);
            txbIngredient1.Name = "txbIngredient1";
            txbIngredient1.Size = new Size(125, 29);
            txbIngredient1.TabIndex = 40;
            // 
            // txbIngredient2
            // 
            txbIngredient2.BorderStyle = BorderStyle.FixedSingle;
            txbIngredient2.Font = new Font("Sitka Banner", 10.1999989F);
            txbIngredient2.Location = new Point(438, 220);
            txbIngredient2.Name = "txbIngredient2";
            txbIngredient2.Size = new Size(125, 29);
            txbIngredient2.TabIndex = 41;
            // 
            // EditSelectedUlam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(688, 628);
            Controls.Add(txbIngredient2);
            Controls.Add(txbIngredient1);
            Controls.Add(txtbUlamName);
            Controls.Add(lblDescription);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnMenu);
            Controls.Add(txbDescription);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "EditSelectedUlam";
            Text = "EditSelectedUlam";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbUlamName;
        private Label lblDescription;
        private Button btnSaveChanges;
        private Button btnMenu;
        private TextBox txbDescription;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txbIngredient1;
        private TextBox txbIngredient2;
    }
}