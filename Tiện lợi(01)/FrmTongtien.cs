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
    public partial class FrmTongtien : Form
    {
        public FrmTongtien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void XoaDulieuform()
        {
            txtdongia.Text = "";
            txtgiamgia.Text = "";
            txtMahang.Text = "";
            txtmakhachhang.Text = "";
            txttenhang.Text = "";
            txtSoluong.Text = "";
            txttenkhachhang.Text = "";
            msdsdt.Text = "";
            btnThanhToan.Enabled = true;
            txttotal.Text = "";
            txtTongtien.Text = "";
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            float soluong,donggia,giamgia, chietkhau,thanhtoan,tongtien;
            soluong = float.Parse(txtSoluong.Text);
            donggia = float.Parse(txtdongia.Text);
            giamgia = float.Parse(txtgiamgia.Text);
           string total;
            total = clTongTien.Text;
          

            if (soluong > 15)
            {
                thanhtoan = (((10 * donggia) + (5 * donggia) + ((soluong - 15) * donggia)));

                txtTongtien.Text = thanhtoan.ToString();
                chietkhau = thanhtoan * giamgia / 100;
                txtTongtien.Text = chietkhau.ToString();
                tongtien = thanhtoan - chietkhau;
                txtTongtien.Text += tongtien.ToString();
               
            }
            else if (soluong > 10 && soluong <= 15)
            {
                thanhtoan = ((10 * donggia) + ((soluong - 10) * donggia));
                txtTongtien.Text = thanhtoan.ToString();
                chietkhau = thanhtoan * giamgia / 100;
                txtTongtien.Text = chietkhau.ToString();
                tongtien = thanhtoan - chietkhau;
                txtTongtien.Text += tongtien.ToString();
              
            }
            else 
            {
                tongtien = (donggia * soluong);
                txtTongtien.Text += tongtien.ToString();
                
            }
            
            
            ListViewItem itemThanhtoan = new System.Windows.Forms.ListViewItem(new string[]
             {txtmakhachhang.Text,txttenkhachhang.Text,msdsdt.Text, txtMahang.Text, txttenhang.Text, txtSoluong.Text,
             txtgiamgia.Text,txtdongia.Text,txtTongtien.Text});
            lvThanhtoan.Items.AddRange(new System.Windows.Forms.ListViewItem[] { itemThanhtoan });
            
            XoaDulieuform();
            


        }

        private void lvThanhtoan_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
            
            var items = e.Item;
            txtmakhachhang.Text = items.SubItems[0].Text;
            txttenkhachhang.Text = items.SubItems[1].Text;
            msdsdt.Text = items.SubItems[2].Text;
            txtMahang.Text = items.SubItems[3].Text;
            txttenhang.Text = items.SubItems[4].Text;
            txtSoluong.Text = items.SubItems[5].Text;
            txtgiamgia.Text = items.SubItems[6].Text;
            txtdongia.Text = items.SubItems[7].Text;
            txtTongtien.Text = items.SubItems[8].Text;
     
            txtmakhachhang.Enabled = false;
            txtMahang.Enabled = false;
        }

        private void btnSuaThanhToan_Click(object sender, EventArgs e)
        {
            int tongdong = lvThanhtoan.Items.Count;
            for ( int i = 0; i < tongdong; i++)
            {
                if (lvThanhtoan.Items[i].Text == txtmakhachhang.Text)
                 {
                    lvThanhtoan.Items[i].SubItems[1].Text = txttenkhachhang.Text;
                    lvThanhtoan.Items[i].SubItems[2].Text = msdsdt.Text;
                    lvThanhtoan.Items[i].SubItems[3].Text = txtMahang.Text;
                    lvThanhtoan.Items[i].SubItems[4].Text = txttenhang.Text;
                    lvThanhtoan.Items[i].SubItems[5].Text = txtSoluong.Text;
                    lvThanhtoan.Items[i].SubItems[6].Text = txtgiamgia.Text;
                    lvThanhtoan.Items[i].SubItems[7].Text = txtdongia.Text;
                    lvThanhtoan.Items[i].SubItems[8].Text = txtTongtien.Text;
                    return;
                }
            }
            txtMahang.Enabled = true;
            txtmakhachhang.Enabled = true;
            XoaDulieuform();
            MessageBox.Show("Cập nhật thành công");

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            string maThanhToan = txtmakhachhang.Text.Trim();
            if (maThanhToan == "")
            {
                MessageBox.Show("Bạn chưa chọn dòng thông tin cần xóa");
            }
            else
            {
                foreach (ListViewItem it in lvThanhtoan.Items)
                {
                    if (it.SubItems[0].Text == maThanhToan)
                    {
                        it.Remove();
                        MessageBox.Show("Xóa thành công");
                        XoaDulieuform();
                        return;
                    }
                }
            }
            txtMahang.Enabled = true;
            txtmakhachhang.Enabled = true;
           
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            XoaDulieuform();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btninHD_Click(object sender, EventArgs e)
        {

        }

        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btntotal_Click(object sender, EventArgs e)
        {
         
        }
    }
}
