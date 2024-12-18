using System;

namespace QUANLYCUAHANG.Class
{
    public class CtyGiaoHang
    {
        public int IDCty { get; set; }
        public string TenCongTy { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }

        public CtyGiaoHang() { }

        public CtyGiaoHang(int idCty, string tenCongTy, string soDienThoai, string diaChi)
        {
            IDCty = idCty;
            TenCongTy = tenCongTy;
            SoDienThoai = soDienThoai;
            DiaChi = diaChi;
        }
    }
}

