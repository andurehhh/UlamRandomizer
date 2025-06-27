namespace UlamRandomizerGUI
{
    partial class AddUlam
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
            txtbDescription = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnAdd = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnAddPic = new Button();
            txtbUlamName = new TextBox();
            txtbMainIngredient1 = new TextBox();
            btnCancel = new Button();
            btnClear = new Button();
            txbMainIngredient2 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtbDescription
            // 
            txtbDescription.BorderStyle = BorderStyle.FixedSingle;
            txtbDescription.Location = new Point(29, 322);
            txtbDescription.Multiline = true;
            txtbDescription.Name = "txtbDescription";
            txtbDescription.ScrollBars = ScrollBars.Vertical;
            txtbDescription.Size = new Size(794, 169);
            txtbDescription.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F);
            label3.Location = new Point(29, 286);
            label3.Name = "label3";
            label3.Size = new Size(83, 18);
            label3.TabIndex = 17;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F);
            label2.Location = new Point(440, 125);
            label2.Name = "label2";
            label2.Size = new Size(114, 18);
            label2.TabIndex = 16;
            label2.Text = "Main Ingredient:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Wheat;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(693, 536);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 54);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add Ulam";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(29, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(389, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F);
            label1.Location = new Point(440, 50);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 11;
            label1.Text = "Ulam Name:";
            // 
            // btnAddPic
            // 
            btnAddPic.BackColor = Color.Wheat;
            btnAddPic.ForeColor = Color.Black;
            btnAddPic.Location = new Point(324, 207);
            btnAddPic.Name = "btnAddPic";
            btnAddPic.Size = new Size(94, 29);
            btnAddPic.TabIndex = 21;
            btnAddPic.Text = "Add Picture";
            btnAddPic.UseVisualStyleBackColor = false;
            btnAddPic.Click += button1_Click;
            // 
            // txtbUlamName
            // 
            txtbUlamName.BorderStyle = BorderStyle.FixedSingle;
            txtbUlamName.Location = new Point(582, 43);
            txtbUlamName.Name = "txtbUlamName";
            txtbUlamName.Size = new Size(241, 27);
            txtbUlamName.TabIndex = 22;
            txtbUlamName.TextChanged += textBox2_TextChanged;
            // 
            // txtbMainIngredient1
            // 
            txtbMainIngredient1.BorderStyle = BorderStyle.FixedSingle;
            txtbMainIngredient1.Location = new Point(582, 118);
            txtbMainIngredient1.Name = "txtbMainIngredient1";
            txtbMainIngredient1.Size = new Size(241, 27);
            txtbMainIngredient1.TabIndex = 23;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Wheat;
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(29, 551);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 54);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Back to Menu";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += button2_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Wheat;
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(562, 536);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(106, 54);
            btnClear.TabIndex = 25;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txbMainIngredient2
            // 
            txbMainIngredient2.BorderStyle = BorderStyle.FixedSingle;
            txbMainIngredient2.Location = new Point(582, 174);
            txbMainIngredient2.Name = "txbMainIngredient2";
            txbMainIngredient2.Size = new Size(241, 27);
            txbMainIngredient2.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F);
            label4.Location = new Point(440, 181);
            label4.Name = "label4";
            label4.Size = new Size(127, 18);
            label4.TabIndex = 26;
            label4.Text = "Main Ingredient 2:";
            // 
            // AddUlam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(867, 628);
            Controls.Add(txbMainIngredient2);
            Controls.Add(label4);
            Controls.Add(btnClear);
            Controls.Add(btnCancel);
            Controls.Add(txtbMainIngredient1);
            Controls.Add(txtbUlamName);
            Controls.Add(btnAddPic);
            Controls.Add(txtbDescription);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "AddUlam";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbDescription;
        private Label label3;
        private Label label2;
        private Button btnAdd;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnAddPic;
        private TextBox txtbUlamName;
        private TextBox txtbMainIngredient1;
        private Button btnCancel;
        private Button btnClear;
        private TextBox txbMainIngredient2;
        private Label label4;
    }
}