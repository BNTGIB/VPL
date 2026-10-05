using System.IO;

using BT_LAB1;

namespace BT_LAB1
{

    public partial class Form1 : Form
    {
        public Form1()
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
                if (username == "admin")
                {
                    if (password == "123456")
                    {
                        //MessageBox.Show("Đăng nhập thành công!");
                        Hide();
                        Form2 form2 = new Form2();
                        form2.ShowDialog();
                        Show();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không chính xác!");
                    }
                    return;
                }

            }
        }

    }
}
