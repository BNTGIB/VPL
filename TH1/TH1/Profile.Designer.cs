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
            BTN_out = new Button();
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
            TB_email.Location = new Point(191, 176);
            TB_email.Name = "TB_email";
            TB_email.Size = new Size(248, 27);
            TB_email.TabIndex = 16;
            // 
            // TB_username
            // 
            TB_username.Location = new Point(191, 110);
            TB_username.Name = "TB_username";
            TB_username.Size = new Size(248, 27);
            TB_username.TabIndex = 15;
            // 
            // LB_email
            // 
            LB_email.AutoSize = true;
            LB_email.Location = new Point(139, 183);
            LB_email.Name = "LB_email";
            LB_email.Size = new Size(49, 20);
            LB_email.TabIndex = 14;
            LB_email.Text = "Email:";
            // 
            // LB_username
            // 
            LB_username.AutoSize = true;
            LB_username.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_username.Location = new Point(110, 113);
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
            // BTN_out
            // 
            BTN_out.Location = new Point(506, 286);
            BTN_out.Name = "BTN_out";
            BTN_out.Size = new Size(74, 29);
            BTN_out.TabIndex = 19;
            BTN_out.Text = "Log Out";
            BTN_out.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 327);
            Controls.Add(BTN_out);
            Controls.Add(BTN_Save);
            Controls.Add(TB_email);
            Controls.Add(TB_username);
            Controls.Add(LB_email);
            Controls.Add(LB_username);
            Controls.Add(label4);
            Name = "Profile";
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
        private Button BTN_out;
    }
}