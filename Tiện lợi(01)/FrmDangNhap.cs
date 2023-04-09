using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiện_lợi_01_
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string user = "user";
            string pass = "password";
           if (user.Equals(txtTenDangNhap.Text) && pass.Equals(txtMatkhau.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
            }
           else

            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu ");
            }
           
            this.Hide();
            
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
