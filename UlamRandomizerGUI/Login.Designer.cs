namespace UlamRandomizerGUI
{
    partial class Login
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
            txbUserName = new TextBox();
            txbPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRegister = new Button();
            btnLogin = new Button();
            label5 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 26);
            label1.Name = "label1";
            label1.Size = new Size(323, 41);
            label1.TabIndex = 0;
            label1.Text = "Welcome to AnUlam";
            // 
            // txbUserName
            // 
            txbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbUserName.Location = new Point(289, 169);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(311, 34);
            txbUserName.TabIndex = 1;
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbPassword.Location = new Point(289, 233);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(311, 34);
            txbPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(169, 169);
            label2.Name = "label2";
            label2.Size = new Size(107, 24);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(169, 239);
            label3.Name = "label3";
            label3.Size = new Size(101, 24);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Strikeout, GraphicsUnit.Point, 0);
            label4.Location = new Point(457, 270);
            label4.Name = "label4";
            label4.Size = new Size(143, 17);
            label4.TabIndex = 5;
            label4.Text = "Forgot your Password?";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Wheat;
            btnRegister.Location = new Point(463, 317);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(137, 35);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register Here";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += button1_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Wheat;
            btnLogin.Location = new Point(289, 317);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(143, 35);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(342, 79);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 8;
            label5.Text = "Let's Get Started!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 113);
            panel1.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txbPassword);
            Controls.Add(txbUserName);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbUserName;
        private TextBox txbPassword;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRegister;
        private Button btnLogin;
        private Label label5;
        private Panel panel1;
    }
}