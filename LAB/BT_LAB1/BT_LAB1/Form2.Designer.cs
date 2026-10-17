namespace BT_LAB1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            TB_ID = new TextBox();
            TB_SL = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BTN_add = new Button();
            BTN_delete = new Button();
            BTN_Change = new Button();
            BNT_find = new Button();
            TB_find = new TextBox();
            DGB_sanpham = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LB_dvt = new Label();
            comboBox_dvt = new ComboBox();
            MaSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            SL = new DataGridViewTextBoxColumn();
            DVT = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DGB_sanpham).BeginInit();
            SuspendLayout();
            // 
            // TB_ID
            // 
            TB_ID.Location = new Point(116, 71);
            TB_ID.Name = "TB_ID";
            TB_ID.Size = new Size(349, 27);
            TB_ID.TabIndex = 0;
            // 
            // TB_SL
            // 
            TB_SL.Location = new Point(116, 116);
            TB_SL.Name = "TB_SL";
            TB_SL.Size = new Size(349, 27);
            TB_SL.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 9);
            label1.Name = "label1";
            label1.Size = new Size(330, 41);
            label1.TabIndex = 4;
            label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 116);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 6;
            label3.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(520, 120);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 7;
            label4.Text = "Đơn giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(482, 71);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 8;
            label5.Text = "Tên sản phẩm";
            // 
            // BTN_add
            // 
            BTN_add.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            BTN_add.Location = new Point(19, 208);
            BTN_add.Name = "BTN_add";
            BTN_add.Size = new Size(100, 35);
            BTN_add.TabIndex = 9;
            BTN_add.Text = "Thêm";
            BTN_add.UseVisualStyleBackColor = true;
            BTN_add.Click += BTN_add_Click;
            // 
            // BTN_delete
            // 
            BTN_delete.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            BTN_delete.Location = new Point(125, 208);
            BTN_delete.Name = "BTN_delete";
            BTN_delete.Size = new Size(100, 35);
            BTN_delete.TabIndex = 10;
            BTN_delete.Text = "Xoá";
            BTN_delete.UseVisualStyleBackColor = true;
            BTN_delete.Click += BTN_delete_Click;
            // 
            // BTN_Change
            // 
            BTN_Change.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            BTN_Change.Location = new Point(231, 208);
            BTN_Change.Name = "BTN_Change";
            BTN_Change.Size = new Size(100, 35);
            BTN_Change.TabIndex = 11;
            BTN_Change.Text = "Sửa";
            BTN_Change.UseVisualStyleBackColor = true;
            BTN_Change.Click += BTN_Change_Click;
            // 
            // BNT_find
            // 
            BNT_find.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            BNT_find.Location = new Point(821, 208);
            BNT_find.Name = "BNT_find";
            BNT_find.Size = new Size(100, 35);
            BNT_find.TabIndex = 12;
            BNT_find.Text = "Tìm kiếm";
            BNT_find.UseVisualStyleBackColor = true;
            BNT_find.Click += BNT_find_Click;
            // 
            // TB_find
            // 
            TB_find.Location = new Point(385, 214);
            TB_find.Name = "TB_find";
            TB_find.Size = new Size(430, 27);
            TB_find.TabIndex = 13;
            // 
            // DGB_sanpham
            // 
            DGB_sanpham.AllowUserToResizeRows = false;
            DGB_sanpham.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGB_sanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGB_sanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGB_sanpham.ColumnHeadersHeight = 29;
            DGB_sanpham.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, DonGia, SL, DVT });
            DGB_sanpham.Location = new Point(12, 263);
            DGB_sanpham.MultiSelect = false;
            DGB_sanpham.Name = "DGB_sanpham";
            DGB_sanpham.RowHeadersVisible = false;
            DGB_sanpham.RowHeadersWidth = 51;
            DGB_sanpham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGB_sanpham.Size = new Size(946, 447);
            DGB_sanpham.TabIndex = 14;
            DGB_sanpham.CellClick += DGB_sanpham_CellClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(588, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(370, 27);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(588, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(370, 27);
            textBox2.TabIndex = 16;
            // 
            // LB_dvt
            // 
            LB_dvt.AutoSize = true;
            LB_dvt.Location = new Point(27, 163);
            LB_dvt.Name = "LB_dvt";
            LB_dvt.Size = new Size(83, 20);
            LB_dvt.TabIndex = 18;
            LB_dvt.Text = "Đơn bị tính";
            // 
            // comboBox_dvt
            // 
            comboBox_dvt.FormattingEnabled = true;
            comboBox_dvt.Location = new Point(116, 163);
            comboBox_dvt.Name = "comboBox_dvt";
            comboBox_dvt.Size = new Size(215, 28);
            comboBox_dvt.TabIndex = 19;
            // 
            // MaSP
            // 
            MaSP.DataPropertyName = "MaSP";
            MaSP.FillWeight = 15F;
            MaSP.HeaderText = "Mã Sản Phẩm";
            MaSP.MinimumWidth = 6;
            MaSP.Name = "MaSP";
            MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            TenSP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenSP.DataPropertyName = "TenSP";
            TenSP.FillWeight = 24.79312F;
            TenSP.HeaderText = "Tên sản phẩm";
            TenSP.MinimumWidth = 6;
            TenSP.Name = "TenSP";
            TenSP.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.FillWeight = 20F;
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // SL
            // 
            SL.DataPropertyName = "SL";
            SL.FillWeight = 6.78755426F;
            SL.HeaderText = "Số Lượng";
            SL.MinimumWidth = 6;
            SL.Name = "SL";
            SL.ReadOnly = true;
            // 
            // DVT
            // 
            DVT.DataPropertyName = "DVT";
            DVT.FillWeight = 10F;
            DVT.HeaderText = "Đơn vị";
            DVT.MinimumWidth = 6;
            DVT.Name = "DVT";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 722);
            Controls.Add(comboBox_dvt);
            Controls.Add(LB_dvt);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(DGB_sanpham);
            Controls.Add(TB_find);
            Controls.Add(BNT_find);
            Controls.Add(BTN_Change);
            Controls.Add(BTN_delete);
            Controls.Add(BTN_add);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TB_SL);
            Controls.Add(TB_ID);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)DGB_sanpham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_ID;
        private TextBox TB_SL;
        private TextBox TB_Price;
        private TextBox TB_Name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BTN_add;
        private Button BTN_delete;
        private Button BTN_Change;
        private Button BNT_find;
        private TextBox TB_find;
        private DataGridView DGB_sanpham;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label LB_dvt;
        private ComboBox comboBox_dvt;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn DVT;
    }
}