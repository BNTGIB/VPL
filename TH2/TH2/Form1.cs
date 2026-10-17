namespace TH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nguyễn Văn A");
            listBox1.Items.Add("Trần Văn B");
            listBox1.Items.Add("Lê Văn C");

            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nữ");
            comboBox1.Items.Add("Gay");
            comboBox1.Items.Add("Lesbian");
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem is string str)
            {
                MessageBox.Show(comboBox1.SelectedItem.ToString());
            }
        }
    }
}
