using System;
using System.Drawing;  // Để xử lý hình ảnh
using System.IO;      // Để xử lý lưu và đọc hình ảnh

namespace QUANLYCUAHANG
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
        public byte[] HinhAnh { get; set; }  // Lưu trữ hình ảnh dưới dạng byte[]

        // Phương thức chuyển đổi hình ảnh từ file thành byte[]
        public static byte[] ConvertImageToBytes(string imagePath)
        {
            if (string.IsNullOrEmpty(imagePath)) return null;
            using (Image img = Image.FromFile(imagePath))
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }
    }
}

