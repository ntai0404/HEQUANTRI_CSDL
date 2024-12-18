using System;

namespace QUANLYCUAHANG.Class
{
    public class DonHang
    {
        public int IDDonHang { get; set; }
        public int IDKhachHang { get; set; }
        public int IDNhanVien { get; set; }
        public DateTime NgayDatHang { get; set; }
        public DateTime NgayGiaoHang { get; set; }
        public DateTime NgayYeuCauChuyen { get; set; }
        public int IDCtyGiaoHang { get; set; }
        public string DiaChiGiaoHang { get; set; }

        public DonHang() { }

        public DonHang(int idDonHang, int idKhachHang, int idNhanVien, DateTime ngayDatHang, DateTime ngayGiaoHang, DateTime ngayYeuCauChuyen, int idCtyGiaoHang, string diaChiGiaoHang)
        {
            IDDonHang = idDonHang;
            IDKhachHang = idKhachHang;
            IDNhanVien = idNhanVien;
            NgayDatHang = ngayDatHang;
            NgayGiaoHang = ngayGiaoHang;
            NgayYeuCauChuyen = ngayYeuCauChuyen;
            IDCtyGiaoHang = idCtyGiaoHang;
            DiaChiGiaoHang = diaChiGiaoHang;
        }
    }
}
