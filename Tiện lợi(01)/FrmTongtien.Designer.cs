namespace Tiện_lợi_01_
{
    partial class FrmTongtien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTongtien));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.msdsdt = new System.Windows.Forms.MaskedTextBox();
            this.txttenkhachhang = new System.Windows.Forms.TextBox();
            this.txtmakhachhang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtgiamgia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lvThanhtoan = new System.Windows.Forms.ListView();
            this.clMakhachhang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenKhachang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMaHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenhang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSoluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGiamgia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDongia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndong = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnSuaThanhToan = new System.Windows.Forms.Button();
            this.btninHD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btntotal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thanh toán";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.msdsdt);
            this.groupBox1.Controls.Add(this.txttenkhachhang);
            this.groupBox1.Controls.Add(this.txtmakhachhang);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(88, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(80, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tên khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Location = new System.Drawing.Point(84, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Mã khách hàng";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // msdsdt
            // 
            this.msdsdt.Location = new System.Drawing.Point(245, 93);
            this.msdsdt.Mask = "(999) 000-0000";
            this.msdsdt.Name = "msdsdt";
            this.msdsdt.Size = new System.Drawing.Size(164, 20);
            this.msdsdt.TabIndex = 36;
            // 
            // txttenkhachhang
            // 
            this.txttenkhachhang.Location = new System.Drawing.Point(245, 56);
            this.txttenkhachhang.Name = "txttenkhachhang";
            this.txttenkhachhang.Size = new System.Drawing.Size(164, 20);
            this.txttenkhachhang.TabIndex = 34;
            // 
            // txtmakhachhang
            // 
            this.txtmakhachhang.Location = new System.Drawing.Point(245, 19);
            this.txtmakhachhang.Name = "txtmakhachhang";
            this.txtmakhachhang.Size = new System.Drawing.Size(164, 20);
            this.txtmakhachhang.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(97, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Số điện thoại";
            // 
            // txtgiamgia
            // 
            this.txtgiamgia.Location = new System.Drawing.Point(101, 55);
            this.txtgiamgia.Name = "txtgiamgia";
            this.txtgiamgia.Size = new System.Drawing.Size(81, 20);
            this.txtgiamgia.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(9, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Giảm giá %";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(297, 52);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(124, 20);
            this.txtdongia.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(218, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Đơn giá";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(535, 23);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(75, 20);
            this.txtSoluong.TabIndex = 30;
            // 
            // txtMahang
            // 
            this.txtMahang.Location = new System.Drawing.Point(97, 19);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(101, 20);
            this.txtMahang.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(448, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 16);
            this.label15.TabIndex = 27;
            this.label15.Text = "Số lượng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(9, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Mã hàng";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Image = global::Tiện_lợi_01_.Properties.Resources.bank_bill_finance_invoice_money_payment_receipt_icon_123239;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(19, 6);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(119, 29);
            this.btnThanhToan.TabIndex = 14;
            this.btnThanhToan.Text = "&ThanhToán ";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTongtien
            // 
            this.txtTongtien.AcceptsReturn = true;
            this.txtTongtien.Location = new System.Drawing.Point(516, 55);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Size = new System.Drawing.Size(127, 20);
            this.txtTongtien.TabIndex = 38;
            this.txtTongtien.TextChanged += new System.EventHandler(this.txtTongtien_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txttenhang);
            this.groupBox2.Controls.Add(this.txtTongtien);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lvThanhtoan);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtMahang);
            this.groupBox2.Controls.Add(this.txtSoluong);
            this.groupBox2.Controls.Add(this.txtgiamgia);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtdongia);
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 286);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh toán";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txttenhang
            // 
            this.txttenhang.Location = new System.Drawing.Point(297, 20);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(138, 20);
            this.txttenhang.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(218, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tên hàng";
            // 
            // lvThanhtoan
            // 
            this.lvThanhtoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMakhachhang,
            this.clTenKhachang,
            this.clSDT,
            this.clMaHang,
            this.clTenhang,
            this.clSoluong,
            this.clGiamgia,
            this.clDongia,
            this.clTongTien});
            this.lvThanhtoan.HideSelection = false;
            this.lvThanhtoan.Location = new System.Drawing.Point(3, 84);
            this.lvThanhtoan.Name = "lvThanhtoan";
            this.lvThanhtoan.Size = new System.Drawing.Size(640, 127);
            this.lvThanhtoan.TabIndex = 41;
            this.lvThanhtoan.UseCompatibleStateImageBehavior = false;
            this.lvThanhtoan.View = System.Windows.Forms.View.Details;
            this.lvThanhtoan.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvThanhtoan_ItemSelectionChanged);
            // 
            // clMakhachhang
            // 
            this.clMakhachhang.Text = "Mã KH";
            this.clMakhachhang.Width = 70;
            // 
            // clTenKhachang
            // 
            this.clTenKhachang.Text = "Tên Khách hàng";
            this.clTenKhachang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTenKhachang.Width = 100;
            // 
            // clSDT
            // 
            this.clSDT.Text = "Điện thoại";
            this.clSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clSDT.Width = 80;
            // 
            // clMaHang
            // 
            this.clMaHang.Text = "Mã Hàng";
            this.clMaHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clTenhang
            // 
            this.clTenhang.Text = "Tên Hàng";
            this.clTenhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTenhang.Width = 80;
            // 
            // clSoluong
            // 
            this.clSoluong.Text = "Số lượng";
            this.clSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clGiamgia
            // 
            this.clGiamgia.Text = "Giảm giá";
            this.clGiamgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clDongia
            // 
            this.clDongia.Text = "Đơn giá";
            this.clDongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clTongTien
            // 
            this.clTongTien.Text = "Tổng tiền";
            this.clTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btntotal);
            this.panel2.Controls.Add(this.txttotal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 30);
            this.panel2.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(401, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Total";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(31, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Nhấn đúp một dòng để xóa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btndong);
            this.panel1.Controls.Add(this.btnhuy);
            this.panel1.Controls.Add(this.btnSuaThanhToan);
            this.panel1.Controls.Add(this.btninHD);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 41);
            this.panel1.TabIndex = 39;
            // 
            // btndong
            // 
            this.btndong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Image = global::Tiện_lợi_01_.Properties.Resources._1486564399_close_81512;
            this.btndong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndong.Location = new System.Drawing.Point(532, 6);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(86, 29);
            this.btndong.TabIndex = 19;
            this.btndong.Text = "&Đóng";
            this.btndong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Image = global::Tiện_lợi_01_.Properties.Resources.bin;
            this.btnhuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhuy.Location = new System.Drawing.Point(247, 7);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(126, 26);
            this.btnhuy.TabIndex = 18;
            this.btnhuy.Text = "&Hủy hóa đơn";
            this.btnhuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnSuaThanhToan
            // 
            this.btnSuaThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThanhToan.Image = global::Tiện_lợi_01_.Properties.Resources.Pencil512_44200;
            this.btnSuaThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaThanhToan.Location = new System.Drawing.Point(157, 7);
            this.btnSuaThanhToan.Name = "btnSuaThanhToan";
            this.btnSuaThanhToan.Size = new System.Drawing.Size(71, 26);
            this.btnSuaThanhToan.TabIndex = 17;
            this.btnSuaThanhToan.Text = "&Sửa ";
            this.btnSuaThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaThanhToan.UseVisualStyleBackColor = true;
            this.btnSuaThanhToan.Click += new System.EventHandler(this.btnSuaThanhToan_Click);
            // 
            // btninHD
            // 
            this.btninHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninHD.Image = global::Tiện_lợi_01_.Properties.Resources.actions_document_print_15785;
            this.btninHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninHD.Location = new System.Drawing.Point(392, 7);
            this.btninHD.Name = "btninHD";
            this.btninHD.Size = new System.Drawing.Size(121, 26);
            this.btninHD.TabIndex = 16;
            this.btninHD.Text = "&In hóa đơn";
            this.btninHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninHD.UseVisualStyleBackColor = true;
            this.btninHD.Click += new System.EventHandler(this.btninHD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(444, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tổng tiền";
            // 
            // txttotal
            // 
            this.txttotal.AcceptsReturn = true;
            this.txttotal.Location = new System.Drawing.Point(468, 6);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(127, 20);
            this.txttotal.TabIndex = 46;
            // 
            // btntotal
            // 
            this.btntotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntotal.Image = global::Tiện_lợi_01_.Properties.Resources.bank_bill_finance_invoice_money_payment_receipt_icon_123239;
            this.btntotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntotal.Location = new System.Drawing.Point(291, 1);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(82, 29);
            this.btntotal.TabIndex = 47;
            this.btntotal.Text = "&Total";
            this.btntotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntotal.UseVisualStyleBackColor = true;
            this.btntotal.Click += new System.EventHandler(this.btntotal_Click);
            // 
            // FrmTongtien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTongtien";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tổng_tiền";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox msdsdt;
        private System.Windows.Forms.TextBox txttenkhachhang;
        private System.Windows.Forms.TextBox txtmakhachhang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtgiamgia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvThanhtoan;
        private System.Windows.Forms.ColumnHeader clMakhachhang;
        private System.Windows.Forms.ColumnHeader clTenKhachang;
        private System.Windows.Forms.ColumnHeader clSDT;
        private System.Windows.Forms.ColumnHeader clMaHang;
        private System.Windows.Forms.ColumnHeader clSoluong;
        private System.Windows.Forms.ColumnHeader clGiamgia;
        private System.Windows.Forms.ColumnHeader clDongia;
        private System.Windows.Forms.ColumnHeader clTongTien;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btninHD;
        private System.Windows.Forms.Button btnSuaThanhToan;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader clTenhang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btntotal;
    }
}