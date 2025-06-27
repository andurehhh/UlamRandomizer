namespace UlamRandomizerGUI
{
    partial class Register
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
            btnRegister = new Button();
            label3 = new Label();
            label2 = new Label();
            txbLast = new TextBox();
            label1 = new Label();
            txbFirst = new TextBox();
            cmbGender = new ComboBox();
            label4 = new Label();
            dtpBirthday = new DateTimePicker();
            label5 = new Label();
            txbUser = new TextBox();
            label6 = new Label();
            txbPass = new TextBox();
            label7 = new Label();
            txbConfPass = new TextBox();
            label8 = new Label();
            txbEmail = new TextBox();
            btnBack = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(362, 352);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(154, 40);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Register Here";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(31, 223);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 11;
            label3.Text = "Gender:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(31, 164);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 10;
            label2.Text = "Last Name:";
            // 
            // txbLast
            // 
            txbLast.Font = new Font("Microsoft Sans Serif", 10.2F);
            txbLast.Location = new Point(166, 164);
            txbLast.Name = "txbLast";
            txbLast.Size = new Size(241, 27);
            txbLast.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F);
            label1.Location = new Point(31, 117);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 16;
            label1.Text = "First Name:";
            // 
            // txbFirst
            // 
            txbFirst.Font = new Font("Microsoft Sans Serif", 10.2F);
            txbFirst.Location = new Point(166, 117);
            txbFirst.Name = "txbFirst";
            txbFirst.Size = new Size(241, 27);
            txbFirst.TabIndex = 15;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Non-Binary", "Prefer not to Tell" });
            cmbGender.Location = new Point(166, 218);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(241, 31);
            cmbGender.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(31, 280);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 18;
            label4.Text = "Birthday:";
            // 
            // dtpBirthday
            // 
            dtpBirthday.CustomFormat = "";
            dtpBirthday.Format = DateTimePickerFormat.Short;
            dtpBirthday.Location = new Point(166, 272);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(241, 30);
            dtpBirthday.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.Location = new Point(444, 117);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 23;
            label5.Text = "Username:";
            label5.Click += label5_Click;
            // 
            // txbUser
            // 
            txbUser.Font = new Font("Microsoft Sans Serif", 10.2F);
            txbUser.Location = new Point(600, 114);
            txbUser.Name = "txbUser";
            txbUser.Size = new Size(276, 27);
            txbUser.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F);
            label6.Location = new Point(444, 223);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 21;
            label6.Text = "Password:";
            // 
            // txbPass
            // 
            txbPass.Font = new Font("Microsoft Sans Serif", 10.2F);
            txbPass.Location = new Point(600, 217);
            txbPass.Name = "txbPass";
            txbPass.Size = new Size(276, 27);
            txbPass.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F);
            label7.Location = new Point(442, 279);
            label7.Name = "label7";
            label7.Size = new Size(152, 20);
            label7.TabIndex = 25;
            label7.Text = "Confirm Password:";
            // 
            // txbConfPass
            // 
            txbConfPass.Font = new Font("Microsoft Sans Serif", 10.2F);
            txbConfPass.Location = new Point(600, 272);
            txbConfPass.Name = "txbConfPass";
            txbConfPass.Size = new Size(276, 27);
            txbConfPass.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F);
            label8.Location = new Point(444, 167);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 27;
            label8.Text = "Email:";
            // 
            // txbEmail
            // 
            txbEmail.Font = new Font("Microsoft Sans Serif", 10.2F);
            txbEmail.Location = new Point(600, 164);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(276, 27);
            txbEmail.TabIndex = 26;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(362, 398);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(154, 40);
            btnBack.TabIndex = 28;
            btnBack.Text = "Back to Menu";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Mongolian Baiti", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(54, 33);
            label9.Name = "label9";
            label9.Size = new Size(416, 40);
            label9.TabIndex = 29;
            label9.Text = "Let's Create your Account!";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(label9);
            Controls.Add(btnBack);
            Controls.Add(label8);
            Controls.Add(txbEmail);
            Controls.Add(label7);
            Controls.Add(txbConfPass);
            Controls.Add(label5);
            Controls.Add(txbUser);
            Controls.Add(label6);
            Controls.Add(txbPass);
            Controls.Add(dtpBirthday);
            Controls.Add(label4);
            Controls.Add(cmbGender);
            Controls.Add(label1);
            Controls.Add(txbFirst);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txbLast);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label label3;
        private Label label2;
        private TextBox txbLast;
        private Label label1;
        private TextBox txbFirst;
        private ComboBox cmbGender;
        private Label label4;
        private DateTimePicker dtpBirthday;
        private Label label5;
        private TextBox txbUser;
        private Label label6;
        private TextBox txbPass;
        private Label label7;
        private TextBox txbConfPass;
        private Label label8;
        private TextBox txbEmail;
        private Button btnBack;
        private Label label9;
    }
}