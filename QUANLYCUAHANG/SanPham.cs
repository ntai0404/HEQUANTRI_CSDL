using System;

namespace QUANLYCUAHANG.Class
{
    public class SanPham
    {
        public int IDSanPham { get; set; }
        public string TenSP { get; set; }
        public int IDNhaCungCap { get; set; }
        public int IDLoaiHang { get; set; }
        public decimal DonGiaNhap { get; set; }
        public int SoLuongCon { get; set; }
        public int SoLuongChoCungCap { get; set; }
        public string MoTa { get; set; }
        public string NguonBan { get; set; }

        public SanPham() { }

        public SanPham(int idSanPham, string tenSP, int idNhaCungCap, int idLoaiHang, decimal donGiaNhap, int soLuongCon, int soLuongChoCungCap, string moTa, string nguonBan)
        {
            IDSanPham = idSanPham;
            TenSP = tenSP;
            IDNhaCungCap = idNhaCungCap;
            IDLoaiHang = idLoaiHang;
            DonGiaNhap = donGiaNhap;
            SoLuongCon = soLuongCon;
            SoLuongChoCungCap = soLuongChoCungCap;
            MoTa = moTa;
            NguonBan = nguonBan;
        }
    }
}
