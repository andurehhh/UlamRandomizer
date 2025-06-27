namespace UlamRandomizerGUI
{
    partial class frmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            btnRandomize = new Button();
            button3 = new Button();
            btnFavoritesList = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.Font = new Font("Mongolian Baiti", 23F);
            label1.Location = new Point(225, 42);
            label1.Name = "label1";
            label1.Size = new Size(354, 41);
            label1.TabIndex = 0;
            label1.Text = "Welcome to anUlam!";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Wheat;
            button1.Font = new Font("Sitka Banner", 10.1999989F);
            button1.Location = new Point(134, 158);
            button1.Name = "button1";
            button1.Size = new Size(254, 73);
            button1.TabIndex = 1;
            button1.Text = "Add Ulam";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnRandomize
            // 
            btnRandomize.BackColor = Color.Wheat;
            btnRandomize.Font = new Font("Sitka Banner", 10.1999989F);
            btnRandomize.Location = new Point(415, 257);
            btnRandomize.Name = "btnRandomize";
            btnRandomize.Size = new Size(254, 73);
            btnRandomize.TabIndex = 2;
            btnRandomize.Text = "Randomize Ulam!";
            btnRandomize.UseVisualStyleBackColor = false;
            btnRandomize.Click += btnRandomize_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Wheat;
            button3.Font = new Font("Sitka Banner", 10.1999989F);
            button3.Location = new Point(415, 158);
            button3.Name = "button3";
            button3.Size = new Size(254, 73);
            button3.TabIndex = 3;
            button3.Text = "Find an Ulam";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnFavoritesList
            // 
            btnFavoritesList.BackColor = Color.Wheat;
            btnFavoritesList.Font = new Font("Sitka Banner", 10.1999989F);
            btnFavoritesList.Location = new Point(134, 257);
            btnFavoritesList.Name = "btnFavoritesList";
            btnFavoritesList.Size = new Size(254, 73);
            btnFavoritesList.TabIndex = 5;
            btnFavoritesList.Text = "See Favorites";
            btnFavoritesList.UseVisualStyleBackColor = false;
            btnFavoritesList.Click += btnFavoritesList_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 116);
            panel1.TabIndex = 6;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 439);
            Controls.Add(btnFavoritesList);
            Controls.Add(button3);
            Controls.Add(btnRandomize);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "frmMainMenu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btnRandomize;
        private Button button3;
        private Button btnFavoritesList;
        private Panel panel1;
    }
}
