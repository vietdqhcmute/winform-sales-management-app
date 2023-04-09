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
    public partial class FrmHDBanHang : Form
    {
        public FrmHDBanHang()
        {
            InitializeComponent();
        }
        public void XoaDulieuform()
        {
            txtdongia.Text = "";
            txtgiamgia.Text = "";
            txtTenNhanvien.Text = "";
            txttenkhachhang.Text = "";
            txtthanhtien.Text = "";
            btnthemHD.Enabled = true;
            dtpickerngayban.Value = DateTime.Now;
            txtTenhang.Text = "";
            txtsoluong.Text = "";
            
            
                        }
        private void btnthemHD_Click(object sender, EventArgs e)
        {
            float soluong, thanhtien;
            soluong = float.Parse(txtsoluong.Text);
           
           float dongia = float.Parse(txtdongia.Text);

            if (soluong > 10 && soluong <= 15)
            {
                thanhtien = (soluong * dongia) - ((soluong * dongia) * 5 / 100);
                txtgiamgia.Text = "0";
                txtthanhtien.Text = thanhtien.ToString();
            }
            else if (soluong > 5 && soluong <= 10)
            {
                thanhtien = (soluong * dongia) - ((soluong * dongia) * 3 / 100);
                txtgiamgia.Text = "0";
                txtthanhtien.Text = thanhtien.ToString();
            }
            else if (soluong > 15)
            {
                thanhtien = (soluong * dongia) - ((soluong * dongia) * 10 / 100);
                txtgiamgia.Text = "0";
                txtthanhtien.Text = thanhtien.ToString();
            }
            else
            {
                thanhtien = soluong * dongia;
                txtgiamgia.Text = "0";
                txtthanhtien.Text = thanhtien.ToString();
            }
            txttotal.Text += thanhtien.ToString();

            ListViewItem itemHoaDonBan = new System.Windows.Forms.ListViewItem(new string[]
            { dtpickerngayban.Text,txtTenNhanvien.Text, 
                 txttenkhachhang.Text, msdsdt.Text,
                 txtTenhang.Text,txtsoluong.Text, txtgiamgia.Text, 
                txtdongia.Text, txtthanhtien.Text});
            lvHoaDon.Items.AddRange(new System.Windows.Forms.ListViewItem[] { itemHoaDonBan });
            XoaDulieuform();
            MessageBox.Show("Thêm thành công");

        }

        private void lvHoaDon_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            
            int nam, thang, ngay;
            string[] textngaythang = item.SubItems[0].Text.Split('/');
            nam = Convert.ToInt32(textngaythang[0]);
            thang = Convert.ToInt32(textngaythang[0]);
            ngay = Convert.ToInt32(textngaythang[0]);
            dtpickerngayban.Text = new DateTime(nam, thang, ngay).ToString();
            txtTenNhanvien.Text = item.SubItems[1].Text;
            txttenkhachhang.Text = item.SubItems[2].Text;
            msdsdt.Text = item.SubItems[3].Text;  
            txtTenhang.Text = item.SubItems[4].Text;
            txtsoluong.Text = item.SubItems[5].Text;
            txtgiamgia.Text = item.SubItems[6].Text;
            txtdongia.Text = item.SubItems[7].Text;
            txtthanhtien.Text = item.SubItems[8].Text;
            
           
           

        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            int TONGDONG = lvHoaDon.Items.Count;
            for ( int i = 0; i < TONGDONG; i ++)
            {
                if (lvHoaDon.Items[i].Text == dtpickerngayban.Text)
                {
                    
                    lvHoaDon.Items[i].SubItems[1].Text = txtTenNhanvien.Text;
                    lvHoaDon.Items[i].SubItems[2].Text = txttenkhachhang.Text;
                    lvHoaDon.Items[i].SubItems[3].Text = msdsdt.Text;
                    lvHoaDon.Items[i].SubItems[4].Text = txtTenhang.Text;
                    lvHoaDon.Items[i].SubItems[5].Text = txtsoluong.Text;
                    lvHoaDon.Items[i].SubItems[6].Text = txtgiamgia.Text;
                    lvHoaDon.Items[i].SubItems[7].Text = txtdongia.Text;
                    lvHoaDon.Items[i].SubItems[8].Text = txtthanhtien.Text;
                    return;
                }
            }
            
            txtTenNhanvien.Enabled = true;
            XoaDulieuform();
            MessageBox.Show("Cập nhật thành công");
        }

        private void btnhuyHD_Click(object sender, EventArgs e)
        {
            string maHDBan = txtTenNhanvien.Text.Trim();
            if ( maHDBan == "")
            {
                MessageBox.Show("Bạn chưa chọn dòng thông tin cần xóa");
            }
            else
            {
                foreach ( ListViewItem it in lvHoaDon.Items)
                {
                    if (it.SubItems[0].Text == maHDBan)
                    {
                        it.Remove();
                        MessageBox.Show("Xóa thành công");
                        XoaDulieuform();
                        return;
                    }
                }
            }
            
            txtTenNhanvien.Enabled = true;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            XoaDulieuform();
        }

        private void btntimkiemHD_Click(object sender, EventArgs e)
        {
            string output;
            for ( int i = 0; i< lvHoaDon.Items.Count; i++)
            {
                if (lvHoaDon.Items[i].SubItems[0].Text.ToString()== msdsdt.Text.ToString())
                {
                    output = "Hóa Đơn bạn cần tìm : " + "\n" +
                        "Thông tin Hóa Đơn bạn cần tìm " + "\n"
                        + "\n" + " Ngày bán" + lvHoaDon.Items[i].SubItems[0].Text.ToString()
                        + "\n" + " Tên Nv " + lvHoaDon.Items[i].SubItems[1].Text.ToString()
                        + "\n" + "Tên KH" + lvHoaDon.Items[i].SubItems[2].Text.ToString()
                        +"\n" + "SDT" + lvHoaDon.Items[i].SubItems[3].Text.ToString()
                        + "\n" + "Thành tiền" + lvHoaDon.Items[i].SubItems[9].Text.ToString();
                    MessageBox.Show(output, "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin cần tìm");
                }
            }

        }

      

        private void FrmHDBanHang_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            XoaDulieuform();
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
