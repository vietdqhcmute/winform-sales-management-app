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
    public partial class FrmKiemKho : Form
    {
        public FrmKiemKho()
        {
            InitializeComponent();
        }
        public void Xoadulieuform()
        {
            txtdongiaban.Text = "";
            txtdongianhap.Text = "";
            
            txtmahang.Text = "";
            txtsoluong.Text = "";
            txttenhang.Text = "";
                
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem itemKiemKho = new System.Windows.Forms.ListViewItem(new string[]
                {txtmahang.Text,txttenhang.Text,txtsoluong.Text,txtdongianhap.Text,txtdongiaban.Text
            });
            lvKiemKho.Items.AddRange(new System.Windows.Forms.ListViewItem[] { itemKiemKho });
            Xoadulieuform();
            MessageBox.Show("Thêm thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int tongdong = lvKiemKho.Items.Count;
            for(int i = 0; i < tongdong; i ++)
            {
                if (lvKiemKho.Items[i].Text == txtmahang.Text)
                {
                    lvKiemKho.Items[i].SubItems[0].Text = txtmahang.Text;
                    lvKiemKho.Items[i].SubItems[1].Text = txttenhang.Text;
                    lvKiemKho.Items[i].SubItems[2].Text = txtsoluong.Text;
                    lvKiemKho.Items[i].SubItems[3].Text = txtdongianhap.Text;
                    lvKiemKho.Items[i].SubItems[4].Text = txtdongiaban.Text;
                    return;

                }
            }
            txtmahang.Enabled = true;
            Xoadulieuform();
            MessageBox.Show("Cập nhật thành công ");
        }

        private void lvKiemKho_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            txtmahang.Text = item.SubItems[0].Text;
            txttenhang.Text = item.SubItems[1].Text;
            txtsoluong.Text = item.SubItems[2].Text;
            txtdongianhap.Text = item.SubItems[3].Text;
            txtdongiaban.Text = item.SubItems[4].Text;
            txtmahang.Enabled = false;
            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHang = txtmahang.Text.Trim();
            if ( maHang == "")
            {
                MessageBox.Show(" Bạn chưa chọn thông tin cần xóa");

            }
            else
            {
                foreach ( ListViewItem it in lvKiemKho.Items)
                {
                    if (it.SubItems[0].Text == maHang)
                    {
                        it.Remove();
                        MessageBox.Show("Xóa thành công");
                        Xoadulieuform();
                        return;
                    }
                }
            }
            txtmahang.Enabled = true;

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Xoadulieuform();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string output;
            for (int i = 0; i < lvKiemKho.Items.Count;i ++)
            {
                if (lvKiemKho.Items[i].SubItems[0].Text.ToString() == txtmahang.Text.ToString())
                {
                    output = "Sản phẩm bạn tìm đang còn trong kho hàng " + "\n" + "Thông tin sản phẩm bạn cần tìm :" + "Mã số sản phẩm :"
                        + lvKiemKho.Items[i].SubItems[0].Text.ToString() + "\n" + "Tên sản phẩm :" + lvKiemKho.Items[i].SubItems[1].Text.ToString()
                        + "\n" + "Số lượng :" + lvKiemKho.Items[i].SubItems[2].Text.ToString() + "\n" + "Gía nhập : " + lvKiemKho.Items[i].SubItems[3].Text.ToString()
                        + "\n" + "Gía bán : " + lvKiemKho.Items[i].SubItems[4].Text.ToString();
                    MessageBox.Show(output, "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm cần tím ");

                }
            }    
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
