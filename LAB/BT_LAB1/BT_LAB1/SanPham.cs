using System;
using System.Collections.Generic;
using System.Text;

namespace BT_LAB1
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DonGia { get; set; }
        public string DVT { get; set; }
        public int SL { get; set; }

        public SanPham(string masp , string tensp="", string dongia="", int sl=0, string dvt = "")
        {
            MaSP = masp;
            TenSP = tensp;
            DonGia = dongia;
            SL = sl;
            DVT = dvt;
        }
    }
}
