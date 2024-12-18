using System;

namespace QUANLYCUAHANG.Class
{
    public class SP_DonHang
    {
        public int IDDonHang { get; set; }
        public int IDSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGiaBan { get; set; }
        public float TyLeGiamGia { get; set; }

        public SP_DonHang() { }

        public SP_DonHang(int idDonHang, int idSanPham, int soLuong, decimal donGiaBan, float tyLeGiamGia)
        {
            IDDonHang = idDonHang;
            IDSanPham = idSanPham;
            SoLuong = soLuong;
            DonGiaBan = donGiaBan;
            TyLeGiamGia = tyLeGiamGia;
        }
    }
}
