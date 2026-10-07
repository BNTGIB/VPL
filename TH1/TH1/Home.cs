using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TH1
{
    public partial class Home : Form
    {
        private string currentUsername;
        private string filePath = "account.txt";
        private string folderPath = "data";
        public string GetUserPath(string username)
        {
            return Path.Combine(folderPath, username + ".txt");
        }
        public Home(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }
        public void Home_Load(object sender, EventArgs e)
        {
            string userFile = GetUserPath(currentUsername);
        }
        private void BTN_profile_Click(object sender, EventArgs e)
        {
            Profile form_profile = new Profile(currentUsername);
            form_profile.ShowDialog();
        }
    }
}
