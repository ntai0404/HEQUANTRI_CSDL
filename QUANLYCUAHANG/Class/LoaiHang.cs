using System;

namespace QUANLYCUAHANG.Class
{
    public class LoaiHang
    {
        public int IDLoaiHang { get; set; }
        public string TenLoaiHang { get; set; }
        public string MoTa { get; set; }

        public LoaiHang() { }

        public LoaiHang(int idLoaiHang, string tenLoaiHang, string moTa)
        {
            IDLoaiHang = idLoaiHang;
            TenLoaiHang = tenLoaiHang;
            MoTa = moTa;
        }
    }
}
