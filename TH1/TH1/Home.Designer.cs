namespace TH1
{
    partial class Home
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
            BTN_profile = new Button();
            SuspendLayout();
            // 
            // BTN_profile
            // 
            BTN_profile.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN_profile.Location = new Point(673, 12);
            BTN_profile.Name = "BTN_profile";
            BTN_profile.Size = new Size(115, 53);
            BTN_profile.TabIndex = 20;
            BTN_profile.Text = "Profile";
            BTN_profile.UseVisualStyleBackColor = true;
            BTN_profile.Click += this.BTN_profile_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_profile);
            Name = "Home";
            Text = "Form1";
            Load += this.Home_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BTN_profile;
    }
}