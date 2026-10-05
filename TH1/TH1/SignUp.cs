using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TH1
{
    public partial class SignUp : Form
    {
        private string filePath = "account.txt";

        public SignUp()
        {
            InitializeComponent();
        }

        private void BTN_signup_Click(object sender, EventArgs e)
        {
            string username = TB_username.Text.Trim();
            string password = TB_password.Text.Trim();
            string email = TB_email.Text.Trim();
            string cfpassword = TB_cfpassword.Text.Trim();

            if (username == "" || password == "" || cfpassword == "" || email == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            else if (password != cfpassword)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
                return;
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            else
            {
                string[] line = File.ReadAllLines(filePath);

                foreach (string line2 in line)
                {
                    string[] path = line2.Split('|');
                    if (path.Length > 0 && (path[0] == username || path[1] == email))
                    {
                        MessageBox.Show("Usename hoặc email đã được tồn tại!");
                        return; 
                    }
                }
            }
            string account = $"{username}|{email}|{password}\n";
            File.AppendAllText(filePath, account);
            MessageBox.Show("Đăng ký tài khoản thành công!");
            Close();
        }
    }
}
