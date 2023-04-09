using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiện_lợi_01_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            FrmHDBanHang frm = new FrmHDBanHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuKiemKho_Click(object sender, EventArgs e)
        {
            FrmKiemKho frm = new FrmKiemKho();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            FrmDangNhap frm = new FrmDangNhap();
            frm.MdiParent = this;
            frm.Show();

        }
    }

       
    }

