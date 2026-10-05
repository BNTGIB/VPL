namespace TH1
{
    partial class QuenMK
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
            TB_email = new TextBox();
            LB_email = new Label();
            TB_cfpassword = new TextBox();
            TB_password = new TextBox();
            LB_cfpassword = new Label();
            LB_password = new Label();
            label4 = new Label();
            BTN__confirm = new Button();
            SuspendLayout();
            // 
            // TB_email
            // 
            TB_email.Location = new Point(178, 110);
            TB_email.Name = "TB_email";
            TB_email.Size = new Size(248, 27);
            TB_email.TabIndex = 16;
            // 
            // LB_email
            // 
            LB_email.AutoSize = true;
            LB_email.Location = new Point(123, 117);
            LB_email.Name = "LB_email";
            LB_email.Size = new Size(49, 20);
            LB_email.TabIndex = 14;
            LB_email.Text = "Email:";
            // 
            // TB_cfpassword
            // 
            TB_cfpassword.Location = new Point(178, 242);
            TB_cfpassword.Name = "TB_cfpassword";
            TB_cfpassword.Size = new Size(248, 27);
            TB_cfpassword.TabIndex = 20;
            TB_cfpassword.UseSystemPasswordChar = true;
            // 
            // TB_password
            // 
            TB_password.Location = new Point(178, 172);
            TB_password.Name = "TB_password";
            TB_password.Size = new Size(248, 27);
            TB_password.TabIndex = 19;
            TB_password.UseSystemPasswordChar = true;
            // 
            // LB_cfpassword
            // 
            LB_cfpassword.AutoSize = true;
            LB_cfpassword.Location = new Point(42, 245);
            LB_cfpassword.Name = "LB_cfpassword";
            LB_cfpassword.Size = new Size(130, 20);
            LB_cfpassword.TabIndex = 18;
            LB_cfpassword.Text = "Confirm Password:";
            // 
            // LB_password
            // 
            LB_password.AutoSize = true;
            LB_password.Location = new Point(65, 175);
            LB_password.Name = "LB_password";
            LB_password.Size = new Size(107, 20);
            LB_password.TabIndex = 17;
            LB_password.Text = "New Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(89, 29);
            label4.Name = "label4";
            label4.Size = new Size(360, 46);
            label4.TabIndex = 22;
            label4.Text = "ĐẶT LẠI MẬT KHẨU";
            // 
            // BTN__confirm
            // 
            BTN__confirm.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN__confirm.Location = new Point(208, 306);
            BTN__confirm.Name = "BTN__confirm";
            BTN__confirm.Size = new Size(95, 39);
            BTN__confirm.TabIndex = 23;
            BTN__confirm.Text = "Confirm";
            BTN__confirm.UseVisualStyleBackColor = true;
            BTN__confirm.Click += BTN__confirm_Click;
            // 
            // QuenMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 385);
            Controls.Add(BTN__confirm);
            Controls.Add(label4);
            Controls.Add(TB_cfpassword);
            Controls.Add(TB_password);
            Controls.Add(LB_cfpassword);
            Controls.Add(LB_password);
            Controls.Add(TB_email);
            Controls.Add(LB_email);
            Name = "QuenMK";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_email;
        private Label LB_email;
        private TextBox TB_cfpassword;
        private TextBox TB_password;
        private Label LB_cfpassword;
        private Label LB_password;
        private Label label4;
        private Button BTN__confirm;
    }
}