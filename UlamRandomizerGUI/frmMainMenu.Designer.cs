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
            button4 = new Button();
            btnFavoritesList = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
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
            button1.Location = new Point(324, 118);
            button1.Name = "button1";
            button1.Size = new Size(163, 29);
            button1.TabIndex = 1;
            button1.Text = "Add Ulam";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnRandomize
            // 
            btnRandomize.Location = new Point(324, 318);
            btnRandomize.Name = "btnRandomize";
            btnRandomize.Size = new Size(163, 71);
            btnRandomize.TabIndex = 2;
            btnRandomize.Text = "Randomize Ulam!";
            btnRandomize.UseVisualStyleBackColor = true;
            btnRandomize.Click += btnRandomize_Click;
            // 
            // button3
            // 
            button3.Location = new Point(324, 211);
            button3.Name = "button3";
            button3.Size = new Size(163, 29);
            button3.TabIndex = 3;
            button3.Text = "See List of Ulam";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(324, 153);
            button4.Name = "button4";
            button4.Size = new Size(163, 29);
            button4.TabIndex = 4;
            button4.Text = "Edit Ulam";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnFavoritesList
            // 
            btnFavoritesList.Location = new Point(324, 246);
            btnFavoritesList.Name = "btnFavoritesList";
            btnFavoritesList.Size = new Size(163, 29);
            btnFavoritesList.TabIndex = 5;
            btnFavoritesList.Text = "See Favorites";
            btnFavoritesList.UseVisualStyleBackColor = true;
            btnFavoritesList.Click += btnFavoritesList_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 439);
            Controls.Add(btnFavoritesList);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnRandomize);
            Controls.Add(button1);
            Controls.Add(label1);
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
        private Button button4;
        private Button btnFavoritesList;
    }
}
