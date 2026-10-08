using System.IO;


namespace TH1
{
    public partial class Login : Form
    {
        private string filePath = "account.txt";
        private string folderPath = "data";

        public string GetUserPath(string username)
        {
            return Path.Combine(folderPath, username + ".txt");
        }
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNcancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            string username = TBusername.Text.Trim();
            string password = TBpassword.Text.Trim();
            if (username.Length != 0 || password.Length != 0)
            {
                if (!File.Exists(GetUserPath(username)))
                {
                    MessageBox.Show("Tên tài khoản không tồn tại!");
                    return;
                }
                else if (File.ReadAllLines(GetUserPath(username))[File.ReadAllLines(GetUserPath(username)).Length - 1] != password)
                {
                    MessageBox.Show("Mật khẩu không chính xác!");
                    return;
                }
                Hide();
                Home form_home = new Home(username);
                form_home.ShowDialog();
            }
        }

        private void signlink_Click(object sender, EventArgs e)
        {
            Hide();
            SignUp form2 = new SignUp();
            form2.ShowDialog();
            Show();
        }

        private void sign_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            SignUp form2 = new SignUp();
            form2.ShowDialog();
            Show();
        }

        private void link_forgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            QuenMK form3 = new QuenMK();
            form3.ShowDialog();
            Show();
        }
    }
}
