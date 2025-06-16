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
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            btnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(432, 50);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Ulam Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(31, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(372, 182);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(170, 323);
            button1.Name = "button1";
            button1.Size = new Size(131, 55);
            button1.TabIndex = 3;
            button1.Text = "No";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(331, 323);
            button2.Name = "button2";
            button2.Size = new Size(131, 55);
            button2.TabIndex = 4;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.YellowGreen;
            button3.ForeColor = Color.DarkGreen;
            button3.Location = new Point(492, 323);
            button3.Name = "button3";
            button3.Size = new Size(135, 55);
            button3.TabIndex = 5;
            button3.Text = "Yes";
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 104);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 6;
            label2.Text = "Main Ingredients:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(553, 139);
            label4.Name = "label4";
            label4.Size = new Size(87, 22);
            label4.TabIndex = 8;
            label4.Text = "Ingredient1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(553, 184);
            label5.Name = "label5";
            label5.Size = new Size(87, 22);
            label5.TabIndex = 9;
            label5.Text = "Ingredient2";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(31, 238);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(723, 69);
            textBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(553, 50);
            label3.Name = "label3";
            label3.Size = new Size(51, 22);
            label3.TabIndex = 11;
            label3.Text = "Name";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.ForeColor = Color.Black;
            btnMenu.Location = new Point(287, 395);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(224, 43);
            btnMenu.TabIndex = 12;
            btnMenu.Text = "Back to Menu";
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // RandomUlam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenu);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
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
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Label label3;
        private Button btnMenu;
    }
}