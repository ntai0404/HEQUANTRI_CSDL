using System;
using System.Windows.Forms;
using QUANLYCUAHANG.Class;

namespace QUANLYCUAHANG
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string NhanVien = textLogin.Text.Trim();

            if (string.IsNullOrEmpty(NhanVien))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sử dụng lớp Modify để kiểm tra đăng nhập
            Modify modify = new Modify();
            if (modify.CheckLogin(NhanVien))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chuyển sang Form quản lý
                this.Hide();
                Formmain formMain = new Formmain();
                formMain.Show();
            }
            else
            {
                MessageBox.Show("Tên nhân viên không tồn tại hoặc không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Bạn có chắc chắn muốn thoát không?",
                 "Xác nhận thoát",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
             );
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Thoát toàn bộ ứng dụng
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

