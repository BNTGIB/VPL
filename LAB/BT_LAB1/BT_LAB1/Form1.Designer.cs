namespace BT_LAB1
{
    partial class Form1
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
            signlink = new Label();
            SuspendLayout();
            // 
            // TBusername
            // 
            TBusername.Location = new Point(91, 86);
            TBusername.Name = "TBusername";
            TBusername.Size = new Size(276, 27);
            TBusername.TabIndex = 0;
            // 
            // TBpassword
            // 
            TBpassword.Location = new Point(91, 130);
            TBpassword.Name = "TBpassword";
            TBpassword.Size = new Size(276, 27);
            TBpassword.TabIndex = 1;
            TBpassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 89);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 137);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(80, 23);
            label4.Name = "label4";
            label4.Size = new Size(237, 46);
            label4.TabIndex = 5;
            label4.Text = "ĐĂNG NHẬP";
            // 
            // BTNlogin
            // 
            BTNlogin.BackColor = SystemColors.ButtonFace;
            BTNlogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNlogin.Location = new Point(167, 178);
            BTNlogin.Name = "BTNlogin";
            BTNlogin.Size = new Size(97, 39);
            BTNlogin.TabIndex = 6;
            BTNlogin.Text = "Đăng Nhập";
            BTNlogin.UseVisualStyleBackColor = false;
            BTNlogin.Click += BTNlogin_Click;
            // 
            // BTNcancel
            // 
            BTNcancel.BackColor = SystemColors.ButtonFace;
            BTNcancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNcancel.Location = new Point(270, 178);
            BTNcancel.Name = "BTNcancel";
            BTNcancel.Size = new Size(97, 39);
            BTNcancel.TabIndex = 7;
            BTNcancel.Text = "Thoát";
            BTNcancel.UseVisualStyleBackColor = false;
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
            // signlink
            // 
            signlink.Location = new Point(0, 0);
            signlink.Name = "signlink";
            signlink.Size = new Size(100, 23);
            signlink.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 263);
            Controls.Add(signlink);
            Controls.Add(label5);
            Controls.Add(BTNcancel);
            Controls.Add(BTNlogin);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TBpassword);
            Controls.Add(TBusername);
            Name = "Form1";
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
        private Label signlink;
    }
}

