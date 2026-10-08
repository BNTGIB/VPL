using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TH1
{
    public partial class QuenMK : Form
    {
        private string filePath = "account.txt";
        private string folderPath = "data";

        public string GetUserPath(string username)
        {
            return Path.Combine(folderPath, username + ".txt");
        }

        public QuenMK()
        {
            InitializeComponent();
        }

        private void BTN__confirm_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Không tồn tại dữ liệu!");
                return;
            }

            string password = TB_password.Text.Trim();
            string email = TB_email.Text.Trim();
            string cfpassword = TB_cfpassword.Text.Trim();

            if (password == "" || cfpassword == "" || email == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            else if (password != cfpassword)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
                return;
            }

            List<string> lines = File.ReadAllLines(filePath).ToList();
            List<string> parts = new List<string> { };

            bool changes = false;
            for (int i=0; i<lines.Count(); i++)
            {
                parts = lines[i].Split('|').ToList();
                if (parts.Count() == 5 && parts[1] == email)
                {
                    changes = true;
                    parts[4] = password;
                    lines[i] = $"{parts[0]}|{parts[1]}|{parts[2]}|{parts[3]}|{parts[4]}\n";
                    break;
                }
            }
            if (!changes)
            {
                MessageBox.Show("Không tồn tại tài khoản với email trên! Nếu chưa có, hãy đăng ký tài khoản");

            }
            else
            {

                File.WriteAllLines(filePath, lines);
                string account2 = $"{parts[0]}\n{parts[1]}\n{parts[2]}\n{parts[3]}\n{parts[4]}\n";
                File.WriteAllText(GetUserPath(parts[0]), account2);
                MessageBox.Show("Đổi mật khẩu thành công!");
                
                Close();
            }
        }
    }
}
