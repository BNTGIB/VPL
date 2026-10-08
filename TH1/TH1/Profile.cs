using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TH1
{
    public partial class Profile : Form
    {
        private string currentUsername;
        private string filePath = "account.txt";
        private string folderPath = "data";
        public string GetUserPath(string username)
        {
            return Path.Combine(folderPath, username + ".txt");
        }

        private bool check_info(List<string> lines, int element, string path_check) {
            foreach (string line in lines)
            {
                string[] path = line.Split('|');
                if (path.Length > element && path[element] == path_check) {
                    return false;
                }
            }
            return true;
        }
        public Profile(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }
        public void Profile_Load(object sender, EventArgs e)
        {
            string userFile = GetUserPath(currentUsername);
            string[] path = File.ReadAllLines(userFile);
            TB_username.Text = path[0];
            TB_email.Text = path[1];
            TB_sdt.Text = path[2];
            TB_Diachi.Text = path[3];
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {

            string newusername = TB_username.Text.Trim();
            string newemail = TB_email.Text.Trim();
            string newsdt = TB_sdt.Text.Trim();
            string newdiachi = TB_Diachi.Text.Trim();

            List<string> lines = File.ReadAllLines(filePath).ToList();
            string userFile = GetUserPath(currentUsername);
            List<string> parts = new List<string> { };

            bool changes = false;
            for (int i = 0; i < lines.Count(); i++)
            {
                parts = lines[i].Split('|').ToList();
                if (parts.Count() == 5 && parts[0] == currentUsername)
                {
                    if (newusername != "" && newusername != parts[0])
                    {
                        if (!check_info(lines, 0, newusername))
                        {
                            MessageBox.Show("Tên tài khoản đã tồn tại");
                            return;
                        }
                            
                        changes = true;
                        parts[0] = newusername;
                        currentUsername = newusername;
                    }

                    if (newemail != "" && newemail != parts[1])
                    {
                        if (!check_info(lines, 1, newemail))
                        {
                            MessageBox.Show("Email đã tồn tại");
                            return;
                        }

                        changes = true;
                        parts[1] = newemail;
                    }

                    if (newsdt != "" && newsdt != parts[2])
                    {
                        if (!check_info(lines, 2, newsdt))
                        {
                            MessageBox.Show("Số điện thoại đã tồn tại");
                            return;
                        }

                        changes = true;
                        parts[2] = newsdt;
                    }

                    if (newdiachi != parts[3])
                    {
                        changes = true;
                        parts[3] = newdiachi=="" ? "(Trống)" : newdiachi;
                    }

                    lines[i] = $"{parts[0]}|{parts[1]}|{parts[2]}|{parts[3]}|{parts[4]}\n";
                    break;
                }
            }
            if (changes)
            {
                File.WriteAllLines(filePath, lines);
                string account2 = $"{parts[0]}\n{parts[1]}\n{parts[2]}\n{parts[3]}\n{parts[4]}\n";
                File.WriteAllText(userFile, account2);
                File.Move(userFile, GetUserPath(newusername));
                MessageBox.Show("Cập nhật thông tin thành công!");
            }
        }
    }

}
