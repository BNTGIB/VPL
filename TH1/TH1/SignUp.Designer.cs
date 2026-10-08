namespace TH1
{
    partial class SignUp
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
            label4 = new Label();
            LB_username = new Label();
            LB_email = new Label();
            LB_password = new Label();
            LB_cfpassword = new Label();
            TB_username = new TextBox();
            TB_email = new TextBox();
            TB_password = new TextBox();
            TB_cfpassword = new TextBox();
            BTN_signup = new Button();
            TB_Diachi = new TextBox();
            TB_sdt = new TextBox();
            LB_diachi = new Label();
            LB_sdt = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(170, 28);
            label4.Name = "label4";
            label4.Size = new Size(179, 46);
            label4.TabIndex = 6;
            label4.Text = "ĐĂNG KÝ";
            // 
            // LB_username
            // 
            LB_username.AutoSize = true;
            LB_username.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_username.Location = new Point(89, 110);
            LB_username.Name = "LB_username";
            LB_username.Size = new Size(78, 20);
            LB_username.TabIndex = 7;
            LB_username.Text = "Username:";
            // 
            // LB_email
            // 
            LB_email.AutoSize = true;
            LB_email.Location = new Point(118, 147);
            LB_email.Name = "LB_email";
            LB_email.Size = new Size(49, 20);
            LB_email.TabIndex = 8;
            LB_email.Text = "Email:";
            // 
            // LB_password
            // 
            LB_password.AutoSize = true;
            LB_password.Location = new Point(94, 270);
            LB_password.Name = "LB_password";
            LB_password.Size = new Size(73, 20);
            LB_password.TabIndex = 9;
            LB_password.Text = "Password:";
            // 
            // LB_cfpassword
            // 
            LB_cfpassword.AutoSize = true;
            LB_cfpassword.Location = new Point(37, 303);
            LB_cfpassword.Name = "LB_cfpassword";
            LB_cfpassword.Size = new Size(130, 20);
            LB_cfpassword.TabIndex = 10;
            LB_cfpassword.Text = "Confirm Password:";
            // 
            // TB_username
            // 
            TB_username.Location = new Point(170, 107);
            TB_username.Name = "TB_username";
            TB_username.Size = new Size(248, 27);
            TB_username.TabIndex = 11;
            // 
            // TB_email
            // 
            TB_email.Location = new Point(170, 140);
            TB_email.Name = "TB_email";
            TB_email.Size = new Size(248, 27);
            TB_email.TabIndex = 12;
            // 
            // TB_password
            // 
            TB_password.Location = new Point(170, 267);
            TB_password.Name = "TB_password";
            TB_password.Size = new Size(248, 27);
            TB_password.TabIndex = 13;
            TB_password.UseSystemPasswordChar = true;
            // 
            // TB_cfpassword
            // 
            TB_cfpassword.Location = new Point(170, 300);
            TB_cfpassword.Name = "TB_cfpassword";
            TB_cfpassword.Size = new Size(248, 27);
            TB_cfpassword.TabIndex = 14;
            TB_cfpassword.UseSystemPasswordChar = true;
            // 
            // BTN_signup
            // 
            BTN_signup.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN_signup.Location = new Point(201, 363);
            BTN_signup.Name = "BTN_signup";
            BTN_signup.Size = new Size(112, 30);
            BTN_signup.TabIndex = 15;
            BTN_signup.Text = "Sign Up";
            BTN_signup.UseVisualStyleBackColor = true;
            BTN_signup.Click += BTN_signup_Click;
            // 
            // TB_Diachi
            // 
            TB_Diachi.Location = new Point(170, 206);
            TB_Diachi.Name = "TB_Diachi";
            TB_Diachi.Size = new Size(248, 27);
            TB_Diachi.TabIndex = 19;
            // 
            // TB_sdt
            // 
            TB_sdt.Location = new Point(170, 173);
            TB_sdt.Name = "TB_sdt";
            TB_sdt.Size = new Size(248, 27);
            TB_sdt.TabIndex = 18;
            // 
            // LB_diachi
            // 
            LB_diachi.AutoSize = true;
            LB_diachi.Location = new Point(106, 209);
            LB_diachi.Name = "LB_diachi";
            LB_diachi.Size = new Size(58, 20);
            LB_diachi.TabIndex = 17;
            LB_diachi.Text = "Địa chỉ:";
            // 
            // LB_sdt
            // 
            LB_sdt.AutoSize = true;
            LB_sdt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_sdt.Location = new Point(125, 180);
            LB_sdt.Name = "LB_sdt";
            LB_sdt.Size = new Size(39, 20);
            LB_sdt.TabIndex = 16;
            LB_sdt.Text = "SĐT:";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 463);
            Controls.Add(TB_Diachi);
            Controls.Add(TB_sdt);
            Controls.Add(LB_diachi);
            Controls.Add(LB_sdt);
            Controls.Add(BTN_signup);
            Controls.Add(TB_cfpassword);
            Controls.Add(TB_password);
            Controls.Add(TB_email);
            Controls.Add(TB_username);
            Controls.Add(LB_cfpassword);
            Controls.Add(LB_password);
            Controls.Add(LB_email);
            Controls.Add(LB_username);
            Controls.Add(label4);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label LB_username;
        private Label LB_email;
        private Label LB_password;
        private Label LB_cfpassword;
        private TextBox TB_username;
        private TextBox TB_email;
        private TextBox TB_password;
        private TextBox TB_cfpassword;
        private Button BTN_signup;
        private TextBox TB_Diachi;
        private TextBox TB_sdt;
        private Label LB_diachi;
        private Label LB_sdt;
    }
}