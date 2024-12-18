using System;

namespace QUANLYCUAHANG.Class
{
    public class NhanVien
    {
        public int IDNhanVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgayBatDauLam { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }

        public NhanVien() { }

        public NhanVien(int idNhanVien, string hoTen, DateTime ngaySinh, string gioiTinh, DateTime ngayBatDauLam, string diaChi, string email, string soDienThoai)
        {
            IDNhanVien = idNhanVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            NgayBatDauLam = ngayBatDauLam;
            DiaChi = diaChi;
            Email = email;
            SoDienThoai = soDienThoai;
        }
    }
}
