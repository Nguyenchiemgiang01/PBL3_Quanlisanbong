﻿namespace Do_An_PLB03.GUI
{
    partial class FormDatSan
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtDanhSachDatSan = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSDTKhachHang = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenSan = new System.Windows.Forms.TextBox();
            this.txtMaLoaiSan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpNgayGioTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayGioNhan = new System.Windows.Forms.DateTimePicker();
            this.txtSoGio = new System.Windows.Forms.TextBox();
            this.cbbTenSan = new System.Windows.Forms.ComboBox();
            this.cbbLoaiSan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXemChiTiet = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnDong = new FontAwesome.Sharp.IconButton();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.btnDatSan = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDanhSachDatSan)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặt Sân";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 601);
            this.panel1.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox6.Controls.Add(this.btnXemChiTiet);
            this.groupBox6.Controls.Add(this.dtDanhSachDatSan);
            this.groupBox6.Location = new System.Drawing.Point(930, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(273, 558);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh sách đặt sân trong ngày";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // dtDanhSachDatSan
            // 
            this.dtDanhSachDatSan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtDanhSachDatSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDanhSachDatSan.Location = new System.Drawing.Point(6, 25);
            this.dtDanhSachDatSan.Name = "dtDanhSachDatSan";
            this.dtDanhSachDatSan.RowHeadersWidth = 51;
            this.dtDanhSachDatSan.RowTemplate.Height = 24;
            this.dtDanhSachDatSan.Size = new System.Drawing.Size(261, 458);
            this.dtDanhSachDatSan.TabIndex = 0;
            this.dtDanhSachDatSan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDanhSachDatSan_CellClick);
            this.dtDanhSachDatSan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDanhSachDatSan_CellContentClick);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Controls.Add(this.btnTimKiem);
            this.groupBox5.Controls.Add(this.txtSDT);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(9, 181);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(589, 112);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm kiếm khách hàng";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(10, 62);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(189, 22);
            this.txtSDT.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số điện thoại:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.btnDong);
            this.groupBox4.Controls.Add(this.btnHuy);
            this.groupBox4.Controls.Add(this.btnDatSan);
            this.groupBox4.Location = new System.Drawing.Point(613, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(311, 269);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBox1.Location = new System.Drawing.Point(19, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 20);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "chuyển đến nhận sân";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.txtSDTKhachHang);
            this.groupBox3.Controls.Add(this.txtTenKhachHang);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(9, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(589, 175);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin đăng kí";
            // 
            // txtSDTKhachHang
            // 
            this.txtSDTKhachHang.Location = new System.Drawing.Point(276, 93);
            this.txtSDTKhachHang.Name = "txtSDTKhachHang";
            this.txtSDTKhachHang.Size = new System.Drawing.Size(189, 22);
            this.txtSDTKhachHang.TabIndex = 8;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(10, 93);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(189, 22);
            this.txtTenKhachHang.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(272, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Số điện thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(6, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Họ và tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.txtGia);
            this.groupBox2.Controls.Add(this.txtTenSan);
            this.groupBox2.Controls.Add(this.txtMaLoaiSan);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(613, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 272);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin loại sân";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(15, 234);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(189, 22);
            this.txtGia.TabIndex = 9;
            // 
            // txtTenSan
            // 
            this.txtTenSan.Location = new System.Drawing.Point(20, 151);
            this.txtTenSan.Name = "txtTenSan";
            this.txtTenSan.Size = new System.Drawing.Size(189, 22);
            this.txtTenSan.TabIndex = 9;
            // 
            // txtMaLoaiSan
            // 
            this.txtMaLoaiSan.Location = new System.Drawing.Point(10, 76);
            this.txtMaLoaiSan.Name = "txtMaLoaiSan";
            this.txtMaLoaiSan.Size = new System.Drawing.Size(189, 22);
            this.txtMaLoaiSan.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(11, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Giá:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(11, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tên sân:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(6, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã loại sân:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtpNgayGioTra);
            this.groupBox1.Controls.Add(this.dtpNgayGioNhan);
            this.groupBox1.Controls.Add(this.txtSoGio);
            this.groupBox1.Controls.Add(this.cbbTenSan);
            this.groupBox1.Controls.Add(this.cbbLoaiSan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Location = new System.Drawing.Point(9, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng kí";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(195, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Tên sân:";
            // 
            // dtpNgayGioTra
            // 
            this.dtpNgayGioTra.CustomFormat = "dd/MM/yyyy  hh:mm tt";
            this.dtpNgayGioTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayGioTra.Location = new System.Drawing.Point(370, 116);
            this.dtpNgayGioTra.Name = "dtpNgayGioTra";
            this.dtpNgayGioTra.Size = new System.Drawing.Size(202, 22);
            this.dtpNgayGioTra.TabIndex = 7;
            // 
            // dtpNgayGioNhan
            // 
            this.dtpNgayGioNhan.CustomFormat = "dd/MM/yyyy  hh:mm tt";
            this.dtpNgayGioNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayGioNhan.Location = new System.Drawing.Point(370, 43);
            this.dtpNgayGioNhan.Name = "dtpNgayGioNhan";
            this.dtpNgayGioNhan.Size = new System.Drawing.Size(202, 22);
            this.dtpNgayGioNhan.TabIndex = 6;
            // 
            // txtSoGio
            // 
            this.txtSoGio.Location = new System.Drawing.Point(3, 118);
            this.txtSoGio.Name = "txtSoGio";
            this.txtSoGio.Size = new System.Drawing.Size(158, 22);
            this.txtSoGio.TabIndex = 5;
            this.txtSoGio.Text = "0";
            this.txtSoGio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSoGio_MouseClick);
            this.txtSoGio.TextChanged += new System.EventHandler(this.txtSoGio_TextChanged);
            this.txtSoGio.Leave += new System.EventHandler(this.txtSoGio_Leave);
            this.txtSoGio.MouseLeave += new System.EventHandler(this.txtSoGio_MouseLeave);
            // 
            // cbbTenSan
            // 
            this.cbbTenSan.FormattingEnabled = true;
            this.cbbTenSan.Location = new System.Drawing.Point(199, 41);
            this.cbbTenSan.Name = "cbbTenSan";
            this.cbbTenSan.Size = new System.Drawing.Size(151, 24);
            this.cbbTenSan.TabIndex = 4;
            this.cbbTenSan.SelectedIndexChanged += new System.EventHandler(this.cbbTenSan_SelectedIndexChanged);
            this.cbbTenSan.SelectionChangeCommitted += new System.EventHandler(this.cbbLoaiSan_SelectionChangeCommitted);
            // 
            // cbbLoaiSan
            // 
            this.cbbLoaiSan.FormattingEnabled = true;
            this.cbbLoaiSan.Location = new System.Drawing.Point(10, 41);
            this.cbbLoaiSan.Name = "cbbLoaiSan";
            this.cbbLoaiSan.Size = new System.Drawing.Size(151, 24);
            this.cbbLoaiSan.TabIndex = 4;
            this.cbbLoaiSan.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiSan_SelectedIndexChanged);
            this.cbbLoaiSan.SelectionChangeCommitted += new System.EventHandler(this.cbbLoaiSan_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(366, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày giờ trả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số giờ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(366, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày giờ nhận:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại sân:";
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnXemChiTiet.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.btnXemChiTiet.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnXemChiTiet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXemChiTiet.IconSize = 40;
            this.btnXemChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemChiTiet.Location = new System.Drawing.Point(54, 489);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(178, 45);
            this.btnXemChiTiet.TabIndex = 9;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 40;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(299, 39);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(138, 45);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDong.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnDong.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnDong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDong.IconSize = 40;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(84, 200);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(170, 45);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnHuy.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuy.IconSize = 40;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(84, 126);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(170, 45);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnDatSan
            // 
            this.btnDatSan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDatSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatSan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDatSan.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnDatSan.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnDatSan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDatSan.IconSize = 40;
            this.btnDatSan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatSan.Location = new System.Drawing.Point(84, 66);
            this.btnDatSan.Name = "btnDatSan";
            this.btnDatSan.Size = new System.Drawing.Size(170, 45);
            this.btnDatSan.TabIndex = 6;
            this.btnDatSan.Text = "Đặt Sân";
            this.btnDatSan.UseVisualStyleBackColor = false;
            this.btnDatSan.Click += new System.EventHandler(this.btnDatSan_Click);
            // 
            // FormDatSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1215, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatSan";
            this.Text = "FormDatSan";
            this.Load += new System.EventHandler(this.FormDatSan_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDanhSachDatSan)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDTKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbLoaiSan;
        private System.Windows.Forms.TextBox txtSoGio;
        private System.Windows.Forms.DateTimePicker dtpNgayGioNhan;
        private System.Windows.Forms.GroupBox groupBox6;
        private FontAwesome.Sharp.IconButton btnXemChiTiet;
        private System.Windows.Forms.DataGridView dtDanhSachDatSan;
        private FontAwesome.Sharp.IconButton btnDong;
        private FontAwesome.Sharp.IconButton btnHuy;
        private FontAwesome.Sharp.IconButton btnDatSan;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenSan;
        private System.Windows.Forms.TextBox txtMaLoaiSan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayGioTra;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbTenSan;
    }
}