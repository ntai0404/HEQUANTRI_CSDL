using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using QUANLYCUAHANG.Class;
using QUANLYCUAHANG;

namespace QUANLYCUAHANG
{
    internal class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand; // truy vấn các lệnh insert, update,...
        //SqlDataReader reader;  // đọc data trong bảng
        SqlDataAdapter dataBridge; // truy xuất data vào table;



        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public bool CheckLogin(string NhanVien)
        {
            bool isValid = false;
            string query = "SELECT COUNT(*) FROM NhanVien WHERE HoTen = @HoTen or SoDienThoai= @HoTen";
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@HoTen", NhanVien);

                        int count = (int)cmd.ExecuteScalar();
                        isValid = count > 0; // Nhân viên tồn tại nếu count > 0
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return isValid;
        }

        public DataTable GetAll_SanPham()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT IDSanPham, TenSP, IDNhaCungCap, IDLoaiHang, DonGiaNhap, SoLuongCon, SoLuongChoCungCap, MoTa, NguonBan FROM SanPham";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataBridge = new SqlDataAdapter(query, sqlConnection);
                dataBridge.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }


    }
}