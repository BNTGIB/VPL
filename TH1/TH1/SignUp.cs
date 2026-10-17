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
        private string folderPath = "data";

        public string GetUserPath(string username)
        {
            return Path.Combine(folderPath, username);
        }

        public SignUp()
        {
            InitializeComponent();
        }
        private void SignUp_Load(object sender, EventArgs e)
        {
            string[] sex_items = { "Nam", "Nữ", "Không tiết lộ" };
            cB_sex.Items.AddRange(sex_items);
            cB_sex.SelectedItem = "Không tiết lộ";
        }

        private void BTN_signup_Click(object sender, EventArgs e)
        {
            string username = TB_username.Text.Trim();
            string email = TB_email.Text.Trim();
            string sdt = TB_sdt.Text.Trim();
            string diachi = TB_Diachi.Text.Trim();
            diachi = diachi == "" ? "(Trống)" : diachi;
            string password = TB_password.Text.Trim();
            string cfpassword = TB_cfpassword.Text.Trim();
            string? g = cB_sex.SelectedItem.ToString();
            string giotinh = g;

            LB_lack_username.Visible = false;
            LB_lack_email.Visible = false;
            LB_lack_sdt.Visible = false;
            LB_lack_password.Visible = false;

            if (username == "" || password == "" || cfpassword == "" || email == "" || sdt == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                if (username == "")
                {
                    LB_lack_username.Visible = true;
                }
                if (email == "")
                {
                    LB_lack_email.Visible = true;
                }
                if (sdt == "")
                {
                    LB_lack_sdt.Visible = true;
                }
                if (password == "")
                {
                    LB_lack_password.Visible = true;
                }
                return;
            }
            else if (password != cfpassword)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
                LB_wrong_cfpassword.Visible = true;
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
                    if (path.Length > 4 && (path[0] == username || path[1] == email))
                    {
                        MessageBox.Show("Usename hoặc email đã được tồn tại!");
                        return;
                    }
                    else if (path.Length > 4 && path[2] == sdt)
                    {
                        MessageBox.Show("Số điện thoại đã được đăng ký ở tài khoản khác!");
                        return;
                    }
                }
            }
            string account = $"{username}|{email}|{sdt}|{diachi}|{password}\n";
            File.AppendAllText(filePath, account);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string file = GetUserPath(username + ".txt");
            string account2 = $"{username}\n{email}\n{sdt}\n{diachi}\n{password}";
            File.AppendAllText(file, account2);

            MessageBox.Show("Đăng ký tài khoản thành công!");
            Close();
        }

        private void cB_sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
