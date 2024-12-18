using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYCUAHANG
{
    public partial class frmSanpham : Form
    {
        public frmSanpham()
        {
            InitializeComponent();
        }

        Modify modifySanpham;


        private void frmSanpham_Load(object sender, EventArgs e)
        {
            modifySanpham = new Modify();
            try
            {
                // Hiển thị dữ liệu từ bảng HoaDonThanhToan lên dataGV_HDTT
                dvgSanpham.DataSource = modifySanpham.GetAll_SanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }



}