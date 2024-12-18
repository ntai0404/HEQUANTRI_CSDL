using System;

namespace QUANLYCUAHANG.Class
{
    public class KhachHang
    {
        public int IDKhachHang { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }

        public KhachHang() { }

        public KhachHang(int idKhachHang, string hoTen, string gioiTinh, string diaChi, string email, string soDienThoai)
        {
            IDKhachHang = idKhachHang;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            Email = email;
            SoDienThoai = soDienThoai;
        }
    }
}

