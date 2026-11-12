using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace BT_LAB1
{
    public partial class Home : Form
    {
        List<SanPham> listSp = new List<SanPham>()
        {
            new SanPham("SP001", "Gymnastic Rings", "200000 VND", 1, "Cái"),
            new SanPham("SP002", "Traps", "100000 VND", 1, "Cái"),
            new SanPham("SP003", "Pallets", "80000 VND", 1, "Cái")
        };

        private bool selectItem(string ID)
        {
            foreach (SanPham item in listSp)
            {
                if (item.MaSP.Equals(ID))
                {
                    TB_ID.Text = ID;
                    TB_Name.Text = item.TenSP;
                    TB_Price.Text = item.DonGia;
                    TB_SL.Text = item.SL.ToString();
                    TB_DVT.Text = item.DVT;
                    comboBox_dvt.SelectedItem = item.DVT;

                    return true;
                }
            }
            MessageBox.Show("Không tìm thấy sản phẩm: " + ID, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
        private void DeleteItem(string ID)
        {
            listSp.RemoveAll(item => item.getMasp() == ID);
        }
        private void Lock_TextBox()
        {
            TB_ID.ReadOnly = true;
            TB_Name.ReadOnly = true;
            TB_Price.ReadOnly = true;
            TB_SL.ReadOnly = true;
            TB_DVT.ReadOnly = true;
            TB_DVT.Visible = true;
        }

        bool isAdding = false;
        bool isEdit = false;

        private string New_ID()
        {
            string result = "SP";
            int newest = listSp.Count();
            if (newest < 100) result += "0";
            if (newest < 10) result += "0";
            result += newest.ToString();
            return result;
        }
        private void loadGrid()
        {
            DGB_sanpham.DataSource = null;
            DGB_sanpham.DataSource = listSp;
        }
        public Home()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DGB_sanpham.AutoGenerateColumns = false;
            string[] list_dvt = { "Thùng", "Hộp", "Túi", "Chai", "Cái" };
            comboBox_dvt.DataSource = list_dvt;

            loadGrid();
            Lock_TextBox();

        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
            if (isEdit) return;
            if (!isAdding)
            {
                MessageBox.Show("Nhập thông tin sản phẩm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isAdding = true;
                TB_Name.ReadOnly = false;
                TB_Price.ReadOnly = false;
                TB_SL.ReadOnly = false;
                TB_DVT.Visible = false;

                TB_ID.Text = New_ID();
                TB_Name.Text = TB_Price.Text = TB_SL.Text = "";
                BTN_add.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                TB_DVT.Text = comboBox_dvt.SelectedItem.ToString();
                int cout_Null = 0;
                if (TB_Name.Text == "") cout_Null++;
                if (TB_Price.Text == "") cout_Null++;
                if (TB_SL.Text == "") cout_Null++;

                if (cout_Null < 3 && cout_Null > 0)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (cout_Null <= 0)
                {
                    try
                    {
                        listSp.Add(new SanPham(TB_ID.Text, TB_Name.Text, TB_Price.Text, Convert.ToInt32(TB_SL.Text), comboBox_dvt.SelectedItem.ToString()));
                        MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadGrid();
                        Lock_TextBox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                Lock_TextBox();
                isAdding = false;
                BTN_add.BackColor = SystemColors.Control;
            }
        }

        private void BTN_delete_Click(object sender, EventArgs e)
        {
            if (DGB_sanpham.SelectedRows.Count >= 0)
            {
                foreach (DataGridViewRow row in DGB_sanpham.SelectedRows)
                {
                    DeleteItem(row.Cells[0].Value.ToString());
                }
                loadGrid();
            }
        }

        private void BTN_Change_Click(object sender, EventArgs e)
        {
            if (DGB_sanpham.SelectedRows.Count == 0 || isAdding) return;

            if (!isEdit)
            {
                MessageBox.Show("Nhập thông tin muốn thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isEdit = true;
                TB_Name.ReadOnly = false;
                TB_Price.ReadOnly = false;
                TB_SL.ReadOnly = false;
                TB_DVT.Visible = false;
                BTN_Change.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                TB_DVT.Text = comboBox_dvt.SelectedItem.ToString();
                int cout_Null = 0;
                if (TB_Name.Text == "") cout_Null++;
                if (TB_Price.Text == "") cout_Null++;
                if (TB_SL.Text == "") cout_Null++;

                if (cout_Null > 0)
                {
                    MessageBox.Show("Vui lòng không để trống thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        DeleteItem(TB_ID.Text);
                        listSp.Add(new SanPham(TB_ID.Text, TB_Name.Text, TB_Price.Text, Convert.ToInt32(TB_SL.Text), comboBox_dvt.SelectedItem.ToString()));
                        MessageBox.Show("Sửa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                Lock_TextBox();
                isEdit = false;
                BTN_Change.BackColor = SystemColors.Control;
            }
        }

        private void BNT_find_Click(object sender, EventArgs e)
        {
            if (TB_find.Text != "")
            {
                if (selectItem(TB_find.Text))
                {
                    MessageBox.Show("Đã tìm thấy sản phẩm " + TB_find.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void TB_find_TextChanged(object sender, EventArgs e)
        {
            if (TB_find.Text == "")
                LB_getID.Visible = true;
            else
                LB_getID.Visible = false;
        }

        private void DGB_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !isEdit)
            {
                DataGridViewRow row = DGB_sanpham.Rows[e.RowIndex];
                TB_ID.Text = row.Cells["MaSP"].Value.ToString();
                TB_Name.Text = row.Cells["TenSP"].Value.ToString();
                TB_Price.Text = row.Cells["DonGia"].Value.ToString();
                TB_SL.Text = row.Cells["SL"].Value.ToString();
                TB_DVT.Text = row.Cells["DVT"].Value.ToString();
                comboBox_dvt.SelectedItem = row.Cells["DVT"].Value.ToString();
            }
        }
        
    }
}
