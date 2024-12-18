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
    public partial class Formmain : Form
    {
        public Formmain()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void openCform(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pncenter.Controls.Add(childForm);
            pncenter.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void productbtn_Click(object sender, EventArgs e)
        {
            openCform(new frmSanpham());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
    }
}
