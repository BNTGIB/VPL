using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {

            string newusername = TB_username.Text.Trim();
            string newemail= TB_email.Text.Trim();

            List<string> lines = File.ReadAllLines(filePath).ToList();
            string userFile = GetUserPath(currentUsername);
            List<string> parts = new List<string> { };

            bool changes = false;
            for (int i = 0; i < lines.Count(); i++)
            {
                parts = lines[i].Split('|').ToList();
                if (parts.Count() == 3 && parts[0] == currentUsername)
                {
                    if (newusername != "") 
                    {
                        changes = true;
                        parts[0] = newusername;
                    }
                    if (newemail != "")
                    {
                        changes = true;
                        parts[1] = newemail;
                    }

                    lines[i] = $"{parts[0]}|{parts[1]}|{parts[2]}\n";
                    break;
                }
            }
            if (changes)
            {
                File.WriteAllLines(filePath, lines);
                string account2 = $"{parts[0]}\n{parts[1]}\n{parts[2]}";
                File.WriteAllText(userFile, account2);
                MessageBox.Show("Cập nhật thông tin thành công!");
                Close();
            }
        }
    }

}
