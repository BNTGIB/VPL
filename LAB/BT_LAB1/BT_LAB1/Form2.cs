using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BT_LAB1
{
    public partial class Form2 : Form
    {
        List<SanPham> listSp = new List<SanPham>()
        {
            new SanPham("SP001", "Gymnastic Rings", "200000 VND", 1, "Cái"),
            new SanPham("SP002", "Traps", "100000 VND", 1, "Cái"),
            new SanPham("SP003", "Pallets", "80000 VND", 1, "Cái")
        };

        private void loadGrid()
        {
            DGB_sanpham.DataSource = listSp;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DGB_sanpham.AutoGenerateColumns = false;
            string[] list_dvt = { "Thùng", "Hộp", "Túi", "Chai", "Cái" };
            comboBox_dvt.DataSource = list_dvt;

            loadGrid();

        }

        private void BTN_add_Click(object sender, EventArgs e)
        {

        }

        private void BTN_delete_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Change_Click(object sender, EventArgs e)
        {

        }

        private void BNT_find_Click(object sender, EventArgs e)
        {

        }

        private void DGB_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGB_sanpham.Rows[e.RowIndex];
                TB_ID.Text = row.Cells["MaSP"].Value.ToString();
                TB_Name.Text = row.Cells["TenSP"].Value.ToString();
                TB_Price.Text = row.Cells["DonGia"].Value.ToString();
                TB_SL.Text = row.Cells["SL"].Value.ToString();
            }
        }
    }
}
