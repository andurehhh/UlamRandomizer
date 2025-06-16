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
            button1 = new Button();
            txtbUlamName = new TextBox();
            txtbMainIngredient = new TextBox();
            btnCancel = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtbDescription
            // 
            txtbDescription.BorderStyle = BorderStyle.FixedSingle;
            txtbDescription.Location = new Point(343, 206);
            txtbDescription.Multiline = true;
            txtbDescription.Name = "txtbDescription";
            txtbDescription.Size = new Size(380, 122);
            txtbDescription.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 183);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 17;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 105);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 16;
            label2.Text = "Main Ingredient:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(593, 358);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 54);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add Ulam";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(29, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 128);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 51);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 11;
            label1.Text = "Ulam Name:";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(116, 204);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 21;
            button1.Text = "Add Picture";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtbUlamName
            // 
            txtbUlamName.BorderStyle = BorderStyle.FixedSingle;
            txtbUlamName.Location = new Point(482, 44);
            txtbUlamName.Name = "txtbUlamName";
            txtbUlamName.Size = new Size(241, 27);
            txtbUlamName.TabIndex = 22;
            txtbUlamName.TextChanged += textBox2_TextChanged;
            // 
            // txtbMainIngredient
            // 
            txtbMainIngredient.BorderStyle = BorderStyle.FixedSingle;
            txtbMainIngredient.Location = new Point(482, 98);
            txtbMainIngredient.Name = "txtbMainIngredient";
            txtbMainIngredient.Size = new Size(241, 27);
            txtbMainIngredient.TabIndex = 23;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(446, 358);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 54);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += button2_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Transparent;
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(29, 358);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(106, 54);
            btnClear.TabIndex = 25;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // AddUlam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnCancel);
            Controls.Add(txtbMainIngredient);
            Controls.Add(txtbUlamName);
            Controls.Add(button1);
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
        private Button button1;
        private TextBox txtbUlamName;
        private TextBox txtbMainIngredient;
        private Button btnCancel;
        private Button btnClear;
    }
}