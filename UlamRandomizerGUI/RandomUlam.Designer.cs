namespace UlamRandomizerGUI
{
    partial class RandomUlam
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button3 = new Button();
            label2 = new Label();
            lblIngredient1 = new Label();
            lblIngredient2 = new Label();
            btnMenu = new Button();
            txtbUlamName = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F);
            label1.Location = new Point(353, 278);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 0;
            label1.Text = "Ulam Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(104, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(597, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(260, 473);
            button1.Name = "button1";
            button1.Size = new Size(131, 55);
            button1.TabIndex = 3;
            button1.Text = "No";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.YellowGreen;
            button3.ForeColor = Color.DarkGreen;
            button3.Location = new Point(416, 473);
            button3.Name = "button3";
            button3.Size = new Size(135, 55);
            button3.TabIndex = 5;
            button3.Text = "Yes";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F);
            label2.Location = new Point(341, 372);
            label2.Name = "label2";
            label2.Size = new Size(121, 18);
            label2.TabIndex = 6;
            label2.Text = "Main Ingredients:";
            // 
            // lblIngredient1
            // 
            lblIngredient1.AutoSize = true;
            lblIngredient1.BorderStyle = BorderStyle.Fixed3D;
            lblIngredient1.Font = new Font("Sitka Banner", 13.7999992F);
            lblIngredient1.Location = new Point(178, 404);
            lblIngredient1.Name = "lblIngredient1";
            lblIngredient1.Size = new Size(114, 35);
            lblIngredient1.TabIndex = 8;
            lblIngredient1.Text = "Ingredient1";
            // 
            // lblIngredient2
            // 
            lblIngredient2.AutoSize = true;
            lblIngredient2.BorderStyle = BorderStyle.Fixed3D;
            lblIngredient2.Font = new Font("Sitka Banner", 13.7999992F);
            lblIngredient2.Location = new Point(489, 404);
            lblIngredient2.Name = "lblIngredient2";
            lblIngredient2.Size = new Size(117, 35);
            lblIngredient2.TabIndex = 9;
            lblIngredient2.Text = "Ingredient2";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.ForeColor = Color.Black;
            btnMenu.Location = new Point(287, 545);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(224, 43);
            btnMenu.TabIndex = 12;
            btnMenu.Text = "Back to Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // txtbUlamName
            // 
            txtbUlamName.Font = new Font("Sitka Banner", 16.1999989F);
            txtbUlamName.Location = new Point(104, 312);
            txtbUlamName.Multiline = true;
            txtbUlamName.Name = "txtbUlamName";
            txtbUlamName.ReadOnly = true;
            txtbUlamName.Size = new Size(610, 57);
            txtbUlamName.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Location = new Point(91, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(623, 245);
            panel1.TabIndex = 14;
            // 
            // RandomUlam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 628);
            Controls.Add(txtbUlamName);
            Controls.Add(btnMenu);
            Controls.Add(lblIngredient2);
            Controls.Add(lblIngredient1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "RandomUlam";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button3;
        private Label label2;
        private Label lblIngredient1;
        private Label lblIngredient2;
        private Button btnMenu;
        private TextBox txtbUlamName;
        private Panel panel1;
    }
}