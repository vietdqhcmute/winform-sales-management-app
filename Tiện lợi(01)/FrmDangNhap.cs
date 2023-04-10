using System;
using System.Windows.Forms;

namespace Tiện_lợi_01_
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void showFormHoaDon()
        {
            FrmHDBanHang frm = new FrmHDBanHang();
            frm.Show();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string user = "user";
            string pass = "pass";
           if (user.Equals(txtTenDangNhap.Text) && pass.Equals(txtMatkhau.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();

                showFormHoaDon();
            }
           else

            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu ");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
