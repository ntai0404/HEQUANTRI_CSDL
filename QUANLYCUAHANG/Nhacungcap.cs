using System;

namespace QUANLYCUAHANG.Class
{
    public class NhaCungCap
    {
        public int IDNhaCungCap { get; set; }
        public string TenCongTy { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Website { get; set; }
        public bool ConGiaoDich { get; set; }

        public NhaCungCap() { }

        public NhaCungCap(int idNhaCungCap, string tenCongTy, string diaChi, string soDienThoai, string website, bool conGiaoDich)
        {
            IDNhaCungCap = idNhaCungCap;
            TenCongTy = tenCongTy;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            Website = website;
            ConGiaoDich = conGiaoDich;
        }
    }
}
