namespace TH1
{
    partial class Profile
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
            TB_email = new TextBox();
            TB_username = new TextBox();
            LB_email = new Label();
            LB_username = new Label();
            BTN_Save = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            TB_Diachi = new TextBox();
            TB_sdt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(230, 26);
            label4.Name = "label4";
            label4.Size = new Size(158, 46);
            label4.TabIndex = 6;
            label4.Text = "PROFILE";
            // 
            // TB_email
            // 
            TB_email.Location = new Point(194, 124);
            TB_email.Name = "TB_email";
            TB_email.Size = new Size(244, 27);
            TB_email.TabIndex = 16;
            // 
            // TB_username
            // 
            TB_username.Location = new Point(194, 91);
            TB_username.Name = "TB_username";
            TB_username.Size = new Size(244, 27);
            TB_username.TabIndex = 15;
            // 
            // LB_email
            // 
            LB_email.AutoSize = true;
            LB_email.Location = new Point(142, 131);
            LB_email.Name = "LB_email";
            LB_email.Size = new Size(49, 20);
            LB_email.TabIndex = 14;
            LB_email.Text = "Email:";
            // 
            // LB_username
            // 
            LB_username.AutoSize = true;
            LB_username.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_username.Location = new Point(113, 94);
            LB_username.Name = "LB_username";
            LB_username.Size = new Size(78, 20);
            LB_username.TabIndex = 13;
            LB_username.Text = "Username:";
            // 
            // BTN_Save
            // 
            BTN_Save.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN_Save.Location = new Point(250, 241);
            BTN_Save.Name = "BTN_Save";
            BTN_Save.Size = new Size(112, 30);
            BTN_Save.TabIndex = 18;
            BTN_Save.Text = "Save";
            BTN_Save.UseVisualStyleBackColor = true;
            BTN_Save.Click += BTN_Save_Click;
            // 
            // TB_Diachi
            // 
            TB_Diachi.Location = new Point(194, 194);
            TB_Diachi.Name = "TB_Diachi";
            TB_Diachi.Size = new Size(244, 27);
            TB_Diachi.TabIndex = 23;
            // 
            // TB_sdt
            // 
            TB_sdt.Location = new Point(194, 161);
            TB_sdt.Name = "TB_sdt";
            TB_sdt.Size = new Size(244, 27);
            TB_sdt.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 197);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 21;
            label1.Text = "Địa Chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(149, 164);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 20;
            label2.Text = "SĐT:";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 327);
            Controls.Add(TB_Diachi);
            Controls.Add(TB_sdt);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(BTN_Save);
            Controls.Add(TB_email);
            Controls.Add(TB_username);
            Controls.Add(LB_email);
            Controls.Add(LB_username);
            Controls.Add(label4);
            ForeColor = SystemColors.ControlText;
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Profile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox TB_email;
        private TextBox TB_username;
        private Label LB_email;
        private Label LB_username;
        private Button BTN_Save;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox TB_Diachi;
        private TextBox TB_sdt;
        private Label label1;
        private Label label2;
    }
}