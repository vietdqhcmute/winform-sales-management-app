namespace Tiện_lợi_01_
{
    partial class FrmHDBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHDBanHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msdsdt = new System.Windows.Forms.MaskedTextBox();
            this.txttenkhachhang = new System.Windows.Forms.TextBox();
            this.txtTenNhanvien = new System.Windows.Forms.TextBox();
            this.dtpickerngayban = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnthemHD = new System.Windows.Forms.Button();
            this.btntimkiemHD = new System.Windows.Forms.Button();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.btnluuHD = new System.Windows.Forms.Button();
            this.btnhuyHD = new System.Windows.Forms.Button();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.clNgayban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenNhanvien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTENKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenhang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSoluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clgiamgia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDongia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clThanhtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtgiamgia = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 135);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.msdsdt);
            this.groupBox1.Controls.Add(this.txttenkhachhang);
            this.groupBox1.Controls.Add(this.txtTenNhanvien);
            this.groupBox1.Controls.Add(this.dtpickerngayban);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(27, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // msdsdt
            // 
            this.msdsdt.Location = new System.Drawing.Point(452, 56);
            this.msdsdt.Mask = "(999) 000-0000";
            this.msdsdt.Name = "msdsdt";
            this.msdsdt.Size = new System.Drawing.Size(164, 20);
            this.msdsdt.TabIndex = 22;
            // 
            // txttenkhachhang
            // 
            this.txttenkhachhang.Location = new System.Drawing.Point(452, 22);
            this.txttenkhachhang.Name = "txttenkhachhang";
            this.txttenkhachhang.Size = new System.Drawing.Size(164, 20);
            this.txttenkhachhang.TabIndex = 21;
            // 
            // txtTenNhanvien
            // 
            this.txtTenNhanvien.Location = new System.Drawing.Point(117, 52);
            this.txtTenNhanvien.Name = "txtTenNhanvien";
            this.txtTenNhanvien.Size = new System.Drawing.Size(154, 20);
            this.txtTenNhanvien.TabIndex = 20;
            // 
            // dtpickerngayban
            // 
            this.dtpickerngayban.CustomFormat = "dd/MM/yyyy";
            this.dtpickerngayban.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickerngayban.Location = new System.Drawing.Point(117, 19);
            this.dtpickerngayban.Name = "dtpickerngayban";
            this.dtpickerngayban.Size = new System.Drawing.Size(154, 20);
            this.dtpickerngayban.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(331, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(337, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(25, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(25, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh mục hóa đơn";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtsoluong);
            this.panel6.Controls.Add(this.txtgiamgia);
            this.panel6.Controls.Add(this.txtdongia);
            this.panel6.Controls.Add(this.txtthanhtien);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.txtTenhang);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 135);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(688, 64);
            this.panel6.TabIndex = 4;
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(326, 35);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.ReadOnly = true;
            this.txtthanhtien.Size = new System.Drawing.Size(124, 20);
            this.txtthanhtien.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(238, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Thành tiền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(463, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Giảm giá %";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(238, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Đơn giá";
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(99, 3);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(102, 20);
            this.txtTenhang.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(10, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 16);
            this.label15.TabIndex = 12;
            this.label15.Text = "Số lượng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(12, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 16);
            this.label14.TabIndex = 11;
            this.label14.Text = "Tên hàng";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnclose);
            this.panel9.Controls.Add(this.btnthemHD);
            this.panel9.Controls.Add(this.btntimkiemHD);
            this.panel9.Controls.Add(this.btnSuaHD);
            this.panel9.Controls.Add(this.btndong);
            this.panel9.Controls.Add(this.btnluuHD);
            this.panel9.Controls.Add(this.btnhuyHD);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 387);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(688, 50);
            this.panel9.TabIndex = 23;
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = global::Tiện_lợi_01_.Properties.Resources._1486564399_close_81512;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(589, 10);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(86, 29);
            this.btnclose.TabIndex = 20;
            this.btnclose.Text = "&Đóng";
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnthemHD
            // 
            this.btnthemHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemHD.Image = global::Tiện_lợi_01_.Properties.Resources.plus_40632__1_;
            this.btnthemHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemHD.Location = new System.Drawing.Point(11, 10);
            this.btnthemHD.Name = "btnthemHD";
            this.btnthemHD.Size = new System.Drawing.Size(86, 29);
            this.btnthemHD.TabIndex = 16;
            this.btnthemHD.Text = "&Thêm ";
            this.btnthemHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthemHD.UseVisualStyleBackColor = true;
            this.btnthemHD.Click += new System.EventHandler(this.btnthemHD_Click);
            // 
            // btntimkiemHD
            // 
            this.btntimkiemHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiemHD.Image = global::Tiện_lợi_01_.Properties.Resources.Search_find_locate_1542;
            this.btntimkiemHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimkiemHD.Location = new System.Drawing.Point(471, 10);
            this.btntimkiemHD.Name = "btntimkiemHD";
            this.btntimkiemHD.Size = new System.Drawing.Size(105, 29);
            this.btntimkiemHD.TabIndex = 5;
            this.btntimkiemHD.Text = "&Tìm kiếm ";
            this.btntimkiemHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntimkiemHD.UseVisualStyleBackColor = true;
            this.btntimkiemHD.Click += new System.EventHandler(this.btntimkiemHD_Click);
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHD.Image = global::Tiện_lợi_01_.Properties.Resources.Pencil512_44200;
            this.btnSuaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaHD.Location = new System.Drawing.Point(126, 8);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(86, 29);
            this.btnSuaHD.TabIndex = 15;
            this.btnSuaHD.Text = "&Sửa ";
            this.btnSuaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaHD.UseVisualStyleBackColor = true;
            this.btnSuaHD.Click += new System.EventHandler(this.btnSuaHD_Click);
            // 
            // btndong
            // 
            this.btndong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Image = global::Tiện_lợi_01_.Properties.Resources._1486564399_close_81512;
            this.btndong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndong.Location = new System.Drawing.Point(739, 3);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(86, 38);
            this.btndong.TabIndex = 14;
            this.btndong.Text = "&Đóng";
            this.btndong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnluuHD
            // 
            this.btnluuHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluuHD.Image = global::Tiện_lợi_01_.Properties.Resources.Save_37110;
            this.btnluuHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluuHD.Location = new System.Drawing.Point(241, 9);
            this.btnluuHD.Name = "btnluuHD";
            this.btnluuHD.Size = new System.Drawing.Size(86, 29);
            this.btnluuHD.TabIndex = 11;
            this.btnluuHD.Text = "&Lưu ";
            this.btnluuHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluuHD.UseVisualStyleBackColor = true;
            // 
            // btnhuyHD
            // 
            this.btnhuyHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuyHD.Image = global::Tiện_lợi_01_.Properties.Resources.bin;
            this.btnhuyHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhuyHD.Location = new System.Drawing.Point(356, 10);
            this.btnhuyHD.Name = "btnhuyHD";
            this.btnhuyHD.Size = new System.Drawing.Size(86, 29);
            this.btnhuyHD.TabIndex = 12;
            this.btnhuyHD.Text = "&Hủy ";
            this.btnhuyHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhuyHD.UseVisualStyleBackColor = true;
            this.btnhuyHD.Click += new System.EventHandler(this.btnhuyHD_Click);
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clNgayban,
            this.clTenNhanvien,
            this.clTENKH,
            this.clSDT,
            this.clTenhang,
            this.clSoluong,
            this.clgiamgia,
            this.clDongia,
            this.clThanhtien});
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(0, 193);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(688, 147);
            this.lvHoaDon.TabIndex = 25;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            this.lvHoaDon.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvHoaDon_ItemSelectionChanged);
            // 
            // clNgayban
            // 
            this.clNgayban.Text = "Ngày bán";
            this.clNgayban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clTenNhanvien
            // 
            this.clTenNhanvien.Text = "Tên nhân viên";
            this.clTenNhanvien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTenNhanvien.Width = 100;
            // 
            // clTENKH
            // 
            this.clTENKH.Text = "Tên khách hàng ";
            this.clTENKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTENKH.Width = 100;
            // 
            // clSDT
            // 
            this.clSDT.Text = "Số điện thoại";
            this.clSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clSDT.Width = 100;
            // 
            // clTenhang
            // 
            this.clTenhang.Text = "Tên Hàng ";
            this.clTenhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clSoluong
            // 
            this.clSoluong.Text = "Số lượng";
            this.clSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clgiamgia
            // 
            this.clgiamgia.Text = "Giảm giá";
            this.clgiamgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clDongia
            // 
            this.clDongia.Text = "Đơn giá";
            this.clDongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clThanhtien
            // 
            this.clThanhtien.Text = "Thành tiền ";
            this.clThanhtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clThanhtien.Width = 70;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Controls.Add(this.txttotal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 47);
            this.panel2.TabIndex = 41;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Image = global::Tiện_lợi_01_.Properties.Resources.bank_bill_finance_invoice_money_payment_receipt_icon_123239;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(342, 6);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(119, 29);
            this.btnThanhToan.TabIndex = 16;
            this.btnThanhToan.Text = "&ThanhToán ";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // txttotal
            // 
            this.txttotal.AcceptsReturn = true;
            this.txttotal.Location = new System.Drawing.Point(556, 9);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(127, 20);
            this.txttotal.TabIndex = 46;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(483, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Total";
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
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(326, 6);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(119, 20);
            this.txtdongia.TabIndex = 26;
            // 
            // txtgiamgia
            // 
            this.txtgiamgia.Location = new System.Drawing.Point(568, 10);
            this.txtgiamgia.Name = "txtgiamgia";
            this.txtgiamgia.Size = new System.Drawing.Size(100, 20);
            this.txtgiamgia.TabIndex = 27;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(99, 35);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(100, 20);
            this.txtsoluong.TabIndex = 28;
            // 
            // FrmHDBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(688, 437);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lvHoaDon);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHDBanHang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmHDBanHang";
            this.Load += new System.EventHandler(this.FrmHDBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpickerngayban;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnluuHD;
        private System.Windows.Forms.Button btnhuyHD;
        private System.Windows.Forms.Button btntimkiemHD;
        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.ColumnHeader clTenhang;
        private System.Windows.Forms.ColumnHeader clSoluong;
        private System.Windows.Forms.ColumnHeader clgiamgia;
        private System.Windows.Forms.ColumnHeader clThanhtien;
        private System.Windows.Forms.ColumnHeader clNgayban;
        private System.Windows.Forms.ColumnHeader clTenNhanvien;
        private System.Windows.Forms.ColumnHeader clSDT;
        private System.Windows.Forms.TextBox txtTenNhanvien;
        private System.Windows.Forms.ColumnHeader clDongia;
        private System.Windows.Forms.MaskedTextBox msdsdt;
        private System.Windows.Forms.TextBox txttenkhachhang;
        private System.Windows.Forms.Button btnSuaHD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.ColumnHeader clTENKH;
        private System.Windows.Forms.Button btnthemHD;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtgiamgia;
        private System.Windows.Forms.TextBox txtdongia;
    }
}