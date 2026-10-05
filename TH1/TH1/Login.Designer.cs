namespace TH1
{
    partial class Login
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
            TBusername = new TextBox();
            TBpassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            BTNlogin = new Button();
            BTNcancel = new Button();
            label5 = new Label();
            sign_link = new LinkLabel();
            link_forgotPass = new LinkLabel();
            SuspendLayout();
            // 
            // TBusername
            // 
            TBusername.Location = new Point(158, 108);
            TBusername.Name = "TBusername";
            TBusername.Size = new Size(284, 27);
            TBusername.TabIndex = 0;
            // 
            // TBpassword
            // 
            TBpassword.Location = new Point(158, 177);
            TBpassword.Name = "TBpassword";
            TBpassword.Size = new Size(284, 27);
            TBpassword.TabIndex = 1;
            TBpassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 111);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 180);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(142, 32);
            label4.Name = "label4";
            label4.Size = new Size(237, 46);
            label4.TabIndex = 5;
            label4.Text = "ĐĂNG NHẬP";
            // 
            // BTNlogin
            // 
            BTNlogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNlogin.Location = new Point(197, 246);
            BTNlogin.Name = "BTNlogin";
            BTNlogin.Size = new Size(111, 52);
            BTNlogin.TabIndex = 6;
            BTNlogin.Text = "Login";
            BTNlogin.UseVisualStyleBackColor = true;
            BTNlogin.Click += BTNlogin_Click;
            // 
            // BTNcancel
            // 
            BTNcancel.Location = new Point(420, 312);
            BTNcancel.Name = "BTNcancel";
            BTNcancel.Size = new Size(74, 29);
            BTNcancel.TabIndex = 7;
            BTNcancel.Text = "Cancel";
            BTNcancel.UseVisualStyleBackColor = true;
            BTNcancel.Click += BTNcancel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 255);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 9;
            // 
            // sign_link
            // 
            sign_link.AutoSize = true;
            sign_link.Location = new Point(224, 321);
            sign_link.Name = "sign_link";
            sign_link.Size = new Size(59, 20);
            sign_link.TabIndex = 11;
            sign_link.TabStop = true;
            sign_link.Text = "Sign up";
            sign_link.LinkClicked += sign_link_LinkClicked;
            // 
            // link_forgotPass
            // 
            link_forgotPass.AutoSize = true;
            link_forgotPass.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            link_forgotPass.Location = new Point(328, 207);
            link_forgotPass.Name = "link_forgotPass";
            link_forgotPass.Size = new Size(114, 17);
            link_forgotPass.TabIndex = 12;
            link_forgotPass.TabStop = true;
            link_forgotPass.Text = "Forgot password?";
            link_forgotPass.LinkClicked += link_forgotPass_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 353);
            Controls.Add(link_forgotPass);
            Controls.Add(sign_link);
            Controls.Add(label5);
            Controls.Add(BTNcancel);
            Controls.Add(BTNlogin);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TBpassword);
            Controls.Add(TBusername);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBusername;
        private TextBox TBpassword;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button BTNlogin;
        private Button BTNcancel;
        private Label label5;
        private LinkLabel sign_link;
        private LinkLabel link_forgotPass;
    }
}
