namespace qltv { 
    partial class frmQLDocGia
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
            components = new System.ComponentModel.Container();
            cboGioiTinh = new ComboBox();
            txtEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtTenDG = new TextBox();
            label2 = new Label();
            txtMaDG = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label11 = new Label();
            dtmNgLapThe = new DateTimePicker();
            label12 = new Label();
            cboLoaiDG = new ComboBox();
            label10 = new Label();
            txtGhiChu = new TextBox();
            label9 = new Label();
            txtTenTK = new TextBox();
            label8 = new Label();
            txtMK = new TextBox();
            label7 = new Label();
            lblNhapGioiTinh = new Label();
            lblNhapDiaChi = new Label();
            lblNhapSDT = new Label();
            lblNhapNgaySinh = new Label();
            lblNhapTenDG = new Label();
            dtmNgaySinh = new DateTimePicker();
            txtDiaChi = new TextBox();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            groupBox5 = new GroupBox();
            txtNDTimKiem = new TextBox();
            groupBox4 = new GroupBox();
            radTenDG = new RadioButton();
            radMaDG = new RadioButton();
            btnLoadDS = new Button();
            errTenDG = new ErrorProvider(components);
            errTenTK = new ErrorProvider(components);
            errMK = new ErrorProvider(components);
            errDC = new ErrorProvider(components);
            errEmail = new ErrorProvider(components);
            errGT = new ErrorProvider(components);
            errLoaiDG = new ErrorProvider(components);
            dataGridViewDSDocGia = new DataGridView();
            colMaDG = new DataGridViewTextBoxColumn();
            colTenDG = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colLoaiDG = new DataGridViewTextBoxColumn();
            colGhiChu = new DataGridViewTextBoxColumn();
            colTaiKhoan = new DataGridViewTextBoxColumn();
            colMatKhau = new DataGridViewTextBoxColumn();
            colNgayLapThe = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errTenDG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errTenTK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errMK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errDC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errGT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errLoaiDG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSDocGia).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(449, 28);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(165, 27);
            cboGioiTinh.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(449, 87);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(165, 27);
            txtEmail.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(355, 90);
            label6.Name = "label6";
            label6.Size = new Size(54, 19);
            label6.TabIndex = 0;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 60);
            label5.Name = "label5";
            label5.Size = new Size(70, 19);
            label5.TabIndex = 0;
            label5.Text = "Địa Chỉ: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(355, 31);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 0;
            label4.Text = "Giới Tính :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 91);
            label3.Name = "label3";
            label3.Size = new Size(87, 19);
            label3.TabIndex = 0;
            label3.Text = "Ngày Sinh :";
            // 
            // txtTenDG
            // 
            txtTenDG.Location = new Point(114, 57);
            txtTenDG.Name = "txtTenDG";
            txtTenDG.Size = new Size(169, 27);
            txtTenDG.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 61);
            label2.Name = "label2";
            label2.Size = new Size(104, 19);
            label2.TabIndex = 0;
            label2.Text = "Tên Độc Giả :";
            // 
            // txtMaDG
            // 
            txtMaDG.Location = new Point(114, 28);
            txtMaDG.Name = "txtMaDG";
            txtMaDG.Size = new Size(169, 27);
            txtMaDG.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 31);
            label1.Name = "label1";
            label1.Size = new Size(101, 19);
            label1.TabIndex = 0;
            label1.Text = "Mã Độc Giả :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(dtmNgLapThe);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cboLoaiDG);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtTenTK);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtMK);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblNhapGioiTinh);
            groupBox1.Controls.Add(lblNhapDiaChi);
            groupBox1.Controls.Add(lblNhapSDT);
            groupBox1.Controls.Add(lblNhapNgaySinh);
            groupBox1.Controls.Add(lblNhapTenDG);
            groupBox1.Controls.Add(dtmNgaySinh);
            groupBox1.Controls.Add(cboGioiTinh);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTenDG);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaDG);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(63, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(658, 203);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Độc Giả";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(283, 187);
            label11.Name = "label11";
            label11.Size = new Size(0, 19);
            label11.TabIndex = 17;
            // 
            // dtmNgLapThe
            // 
            dtmNgLapThe.CustomFormat = "dd/MM/yyyy";
            dtmNgLapThe.Format = DateTimePickerFormat.Custom;
            dtmNgLapThe.Location = new Point(312, 174);
            dtmNgLapThe.Name = "dtmNgLapThe";
            dtmNgLapThe.Size = new Size(169, 27);
            dtmNgLapThe.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(206, 180);
            label12.Name = "label12";
            label12.Size = new Size(102, 19);
            label12.TabIndex = 15;
            label12.Text = "Ngày lập thẻ :";
            // 
            // cboLoaiDG
            // 
            cboLoaiDG.FormattingEnabled = true;
            cboLoaiDG.Items.AddRange(new object[] { "X", "Y" });
            cboLoaiDG.Location = new Point(449, 115);
            cboLoaiDG.Name = "cboLoaiDG";
            cboLoaiDG.Size = new Size(164, 27);
            cboLoaiDG.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(355, 120);
            label10.Name = "label10";
            label10.Size = new Size(73, 19);
            label10.TabIndex = 13;
            label10.Text = "Loại ĐG:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(449, 147);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(165, 27);
            txtGhiChu.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(355, 150);
            label9.Name = "label9";
            label9.Size = new Size(70, 19);
            label9.TabIndex = 11;
            label9.Text = "Ghi Chú:";
            // 
            // txtTenTK
            // 
            txtTenTK.Location = new Point(114, 115);
            txtTenTK.Name = "txtTenTK";
            txtTenTK.Size = new Size(169, 27);
            txtTenTK.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 121);
            label8.Name = "label8";
            label8.Size = new Size(64, 19);
            label8.TabIndex = 9;
            label8.Text = "Tên TK:";
            // 
            // txtMK
            // 
            txtMK.Location = new Point(114, 144);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(169, 27);
            txtMK.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 151);
            label7.Name = "label7";
            label7.Size = new Size(80, 19);
            label7.TabIndex = 7;
            label7.Text = "Mật Khẩu:";
            // 
            // lblNhapGioiTinh
            // 
            lblNhapGioiTinh.AutoSize = true;
            lblNhapGioiTinh.Location = new Point(449, 50);
            lblNhapGioiTinh.Name = "lblNhapGioiTinh";
            lblNhapGioiTinh.Size = new Size(0, 19);
            lblNhapGioiTinh.TabIndex = 6;
            // 
            // lblNhapDiaChi
            // 
            lblNhapDiaChi.AutoSize = true;
            lblNhapDiaChi.Location = new Point(449, 89);
            lblNhapDiaChi.Name = "lblNhapDiaChi";
            lblNhapDiaChi.Size = new Size(0, 19);
            lblNhapDiaChi.TabIndex = 6;
            // 
            // lblNhapSDT
            // 
            lblNhapSDT.AutoSize = true;
            lblNhapSDT.Location = new Point(449, 128);
            lblNhapSDT.Name = "lblNhapSDT";
            lblNhapSDT.Size = new Size(0, 19);
            lblNhapSDT.TabIndex = 6;
            // 
            // lblNhapNgaySinh
            // 
            lblNhapNgaySinh.AutoSize = true;
            lblNhapNgaySinh.Location = new Point(114, 92);
            lblNhapNgaySinh.Name = "lblNhapNgaySinh";
            lblNhapNgaySinh.Size = new Size(0, 19);
            lblNhapNgaySinh.TabIndex = 6;
            // 
            // lblNhapTenDG
            // 
            lblNhapTenDG.AutoSize = true;
            lblNhapTenDG.Location = new Point(114, 64);
            lblNhapTenDG.Name = "lblNhapTenDG";
            lblNhapTenDG.Size = new Size(0, 19);
            lblNhapTenDG.TabIndex = 6;
            // 
            // dtmNgaySinh
            // 
            dtmNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtmNgaySinh.Format = DateTimePickerFormat.Custom;
            dtmNgaySinh.Location = new Point(114, 86);
            dtmNgaySinh.Name = "dtmNgaySinh";
            dtmNgaySinh.Size = new Size(169, 27);
            dtmNgaySinh.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(449, 57);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(165, 27);
            txtDiaChi.TabIndex = 4;
            // 
            // btnLuu
            // 
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(466, 368);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(85, 39);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(375, 368);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(85, 39);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(284, 368);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(85, 39);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.CornflowerBlue;
            btnThoat.ForeColor = Color.White;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(290, 116);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(85, 39);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Home";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuy.Location = new Point(557, 368);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(85, 39);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Hủy";
            btnHuy.TextAlign = ContentAlignment.MiddleRight;
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThem
            // 
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(193, 368);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(85, 39);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox5);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(63, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(658, 97);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm đọc giả";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtNDTimKiem);
            groupBox5.Location = new Point(270, 19);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(360, 60);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // txtNDTimKiem
            // 
            txtNDTimKiem.Location = new Point(11, 24);
            txtNDTimKiem.Name = "txtNDTimKiem";
            txtNDTimKiem.Size = new Size(332, 27);
            txtNDTimKiem.TabIndex = 0;
            txtNDTimKiem.TextChanged += txtNDTimKiem_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radTenDG);
            groupBox4.Controls.Add(radMaDG);
            groupBox4.Location = new Point(30, 19);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(190, 60);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm theo";
            // 
            // radTenDG
            // 
            radTenDG.AutoSize = true;
            radTenDG.Location = new Point(104, 24);
            radTenDG.Name = "radTenDG";
            radTenDG.Size = new Size(83, 23);
            radTenDG.TabIndex = 1;
            radTenDG.TabStop = true;
            radTenDG.Text = "Tên ĐG";
            radTenDG.UseVisualStyleBackColor = true;
            // 
            // radMaDG
            // 
            radMaDG.AutoSize = true;
            radMaDG.Location = new Point(18, 24);
            radMaDG.Name = "radMaDG";
            radMaDG.Size = new Size(80, 23);
            radMaDG.TabIndex = 0;
            radMaDG.TabStop = true;
            radMaDG.Text = "Mã ĐG";
            radMaDG.UseVisualStyleBackColor = true;
            // 
            // btnLoadDS
            // 
            btnLoadDS.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoadDS.Location = new Point(381, 116);
            btnLoadDS.Name = "btnLoadDS";
            btnLoadDS.Size = new Size(145, 39);
            btnLoadDS.TabIndex = 1;
            btnLoadDS.Text = "Load danh sách";
            btnLoadDS.TextAlign = ContentAlignment.MiddleRight;
            btnLoadDS.UseVisualStyleBackColor = true;
            btnLoadDS.Click += btnLoadDS_Click;
            // 
            // errTenDG
            // 
            errTenDG.ContainerControl = this;
            // 
            // errTenTK
            // 
            errTenTK.ContainerControl = this;
            // 
            // errMK
            // 
            errMK.ContainerControl = this;
            // 
            // errDC
            // 
            errDC.ContainerControl = this;
            // 
            // errEmail
            // 
            errEmail.ContainerControl = this;
            // 
            // errGT
            // 
            errGT.ContainerControl = this;
            // 
            // errLoaiDG
            // 
            errLoaiDG.ContainerControl = this;
            // 
            // dataGridViewDSDocGia
            // 
            dataGridViewDSDocGia.AllowUserToAddRows = false;
            dataGridViewDSDocGia.AllowUserToDeleteRows = false;
            dataGridViewDSDocGia.AllowUserToResizeRows = false;
            dataGridViewDSDocGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDSDocGia.Columns.AddRange(new DataGridViewColumn[] { colMaDG, colTenDG, colGioiTinh, colNgaySinh, colEmail, colDiaChi, colLoaiDG, colGhiChu, colTaiKhoan, colMatKhau, colNgayLapThe });
            dataGridViewDSDocGia.Location = new Point(6, 26);
            dataGridViewDSDocGia.Name = "dataGridViewDSDocGia";
            dataGridViewDSDocGia.ReadOnly = true;
            dataGridViewDSDocGia.RowHeadersWidth = 62;
            dataGridViewDSDocGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDSDocGia.Size = new Size(1022, 452);
            dataGridViewDSDocGia.TabIndex = 2;
            dataGridViewDSDocGia.CellClick += dataGridViewDSDocGia_CellClick;
            dataGridViewDSDocGia.RowEnter += dataGridViewDSDocGia_RowEnter;
            // 
            // colMaDG
            // 
            colMaDG.DataPropertyName = "MaDG";
            colMaDG.HeaderText = "Mã ĐG";
            colMaDG.MinimumWidth = 6;
            colMaDG.Name = "colMaDG";
            colMaDG.ReadOnly = true;
            colMaDG.Width = 125;
            // 
            // colTenDG
            // 
            colTenDG.DataPropertyName = "TenDG";
            colTenDG.HeaderText = "Tên ĐG";
            colTenDG.MinimumWidth = 8;
            colTenDG.Name = "colTenDG";
            colTenDG.ReadOnly = true;
            colTenDG.Width = 115;
            // 
            // colGioiTinh
            // 
            colGioiTinh.DataPropertyName = "GioiTinhDG";
            colGioiTinh.HeaderText = "Giới Tính";
            colGioiTinh.MinimumWidth = 8;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.ReadOnly = true;
            colGioiTinh.Width = 45;
            // 
            // colNgaySinh
            // 
            colNgaySinh.DataPropertyName = "NgaySinhDG";
            colNgaySinh.HeaderText = "Ngày Sinh";
            colNgaySinh.MinimumWidth = 8;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.ReadOnly = true;
            colNgaySinh.Width = 80;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "EmailDG";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 125;
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "DiaChiDG";
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.MinimumWidth = 8;
            colDiaChi.Name = "colDiaChi";
            colDiaChi.ReadOnly = true;
            colDiaChi.Width = 75;
            // 
            // colLoaiDG
            // 
            colLoaiDG.DataPropertyName = "LoaiDG";
            colLoaiDG.HeaderText = "Loại ĐG";
            colLoaiDG.MinimumWidth = 8;
            colLoaiDG.Name = "colLoaiDG";
            colLoaiDG.ReadOnly = true;
            colLoaiDG.Width = 50;
            // 
            // colGhiChu
            // 
            colGhiChu.DataPropertyName = "GhiChu";
            colGhiChu.HeaderText = "Ghi chú";
            colGhiChu.MinimumWidth = 8;
            colGhiChu.Name = "colGhiChu";
            colGhiChu.ReadOnly = true;
            colGhiChu.Width = 50;
            // 
            // colTaiKhoan
            // 
            colTaiKhoan.DataPropertyName = "TenTaiKhoanDG";
            colTaiKhoan.HeaderText = "Tài khoản";
            colTaiKhoan.MinimumWidth = 8;
            colTaiKhoan.Name = "colTaiKhoan";
            colTaiKhoan.ReadOnly = true;
            colTaiKhoan.Width = 134;
            // 
            // colMatKhau
            // 
            colMatKhau.DataPropertyName = "MatKhauDG";
            colMatKhau.HeaderText = "Mật khẩu";
            colMatKhau.MinimumWidth = 8;
            colMatKhau.Name = "colMatKhau";
            colMatKhau.ReadOnly = true;
            colMatKhau.Width = 50;
            // 
            // colNgayLapThe
            // 
            colNgayLapThe.DataPropertyName = "NgLapThe";
            colNgayLapThe.HeaderText = "Ngày lập thẻ";
            colNgayLapThe.MinimumWidth = 8;
            colNgayLapThe.Name = "colNgayLapThe";
            colNgayLapThe.ReadOnly = true;
            colNgayLapThe.Width = 55;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewDSDocGia);
            groupBox2.Location = new Point(14, 413);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1034, 474);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Độc Giả";
            // 
            // frmQLDocGia
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1060, 899);
            Controls.Add(btnLoadDS);
            Controls.Add(groupBox3);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThoat);
            Controls.Add(groupBox2);
            Controls.Add(btnHuy);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmQLDocGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Quản lý đọc giả";
            Load += frmQLDocGia_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errTenDG).EndInit();
            ((System.ComponentModel.ISupportInitialize)errTenTK).EndInit();
            ((System.ComponentModel.ISupportInitialize)errMK).EndInit();
            ((System.ComponentModel.ISupportInitialize)errDC).EndInit();
            ((System.ComponentModel.ISupportInitialize)errEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)errGT).EndInit();
            ((System.ComponentModel.ISupportInitialize)errLoaiDG).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSDocGia).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtmNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNDTimKiem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radTenDG;
        private System.Windows.Forms.RadioButton radMaDG;
        private System.Windows.Forms.Button btnLoadDS;
        private System.Windows.Forms.Label lblNhapGioiTinh;
        private System.Windows.Forms.Label lblNhapDiaChi;
        private System.Windows.Forms.Label lblNhapSDT;
        private System.Windows.Forms.Label lblNhapNgaySinh;
        private System.Windows.Forms.Label lblNhapTenDG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboLoaiDG;
        private System.Windows.Forms.ErrorProvider errTenDG;
        private System.Windows.Forms.ErrorProvider errTenTK;
        private System.Windows.Forms.ErrorProvider errMK;
        private System.Windows.Forms.ErrorProvider errDC;
        private System.Windows.Forms.ErrorProvider errEmail;
        private System.Windows.Forms.ErrorProvider errGT;
        private System.Windows.Forms.ErrorProvider errLoaiDG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtmNgLapThe;
        private System.Windows.Forms.Label label12;
        private GroupBox groupBox2;
        private DataGridView dataGridViewDSDocGia;
        private DataGridViewTextBoxColumn colMaDG;
        private DataGridViewTextBoxColumn colTenDG;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colLoaiDG;
        private DataGridViewTextBoxColumn colGhiChu;
        private DataGridViewTextBoxColumn colTaiKhoan;
        private DataGridViewTextBoxColumn colMatKhau;
        private DataGridViewTextBoxColumn colNgayLapThe;
    }
}