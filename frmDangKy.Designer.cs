namespace qltv
{
    partial class frmDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKy));
            btnThoat = new Button();
            btnThem = new Button();
            txtGhiChu = new TextBox();
            label9 = new Label();
            txtTenTK = new TextBox();
            label8 = new Label();
            txtNhapLaiMK = new TextBox();
            label10 = new Label();
            txtMK = new TextBox();
            label7 = new Label();
            dtmNgaySinh = new DateTimePicker();
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
            txtDiaChi = new TextBox();
            errTenDG = new ErrorProvider(components);
            errEmail = new ErrorProvider(components);
            errDC = new ErrorProvider(components);
            errMK = new ErrorProvider(components);
            errGT = new ErrorProvider(components);
            dtmNgayLapThe = new DateTimePicker();
            cbLoaiDG = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            dataGridViewDSTT = new DataGridView();
            colMaDG = new DataGridViewTextBoxColumn();
            colTenDG = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colDiaChiDG = new DataGridViewTextBoxColumn();
            colGhiChu = new DataGridViewTextBoxColumn();
            colTenTK = new DataGridViewTextBoxColumn();
            colMK = new DataGridViewTextBoxColumn();
            errorLoaiDG = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errTenDG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errDC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errMK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errGT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSTT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorLoaiDG).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.CornflowerBlue;
            btnThoat.ForeColor = Color.Transparent;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(117, 201);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(98, 39);
            btnThoat.TabIndex = 60;
            btnThoat.Text = "Home";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.CornflowerBlue;
            btnThem.ForeColor = Color.Transparent;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(11, 201);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 39);
            btnThem.TabIndex = 59;
            btnThem.Text = "Đăng ký";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtGhiChu
            // 
            txtGhiChu.BorderStyle = BorderStyle.FixedSingle;
            txtGhiChu.Location = new Point(125, 131);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(169, 27);
            txtGhiChu.TabIndex = 58;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 135);
            label9.Name = "label9";
            label9.Size = new Size(67, 19);
            label9.TabIndex = 57;
            label9.Text = "Ghi chú:";
            // 
            // txtTenTK
            // 
            txtTenTK.BorderStyle = BorderStyle.FixedSingle;
            txtTenTK.Enabled = false;
            txtTenTK.Location = new Point(482, 73);
            txtTenTK.Name = "txtTenTK";
            txtTenTK.Size = new Size(169, 27);
            txtTenTK.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(347, 77);
            label8.Name = "label8";
            label8.Size = new Size(104, 19);
            label8.TabIndex = 55;
            label8.Text = "Tên tài khoản:";
            // 
            // txtNhapLaiMK
            // 
            txtNhapLaiMK.BorderStyle = BorderStyle.FixedSingle;
            txtNhapLaiMK.Location = new Point(482, 131);
            txtNhapLaiMK.Name = "txtNhapLaiMK";
            txtNhapLaiMK.Size = new Size(169, 27);
            txtNhapLaiMK.TabIndex = 53;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(347, 135);
            label10.Name = "label10";
            label10.Size = new Size(134, 19);
            label10.TabIndex = 52;
            label10.Text = "Nhập lại mật khẩu:";
            // 
            // txtMK
            // 
            txtMK.BorderStyle = BorderStyle.FixedSingle;
            txtMK.Location = new Point(482, 102);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(169, 27);
            txtMK.TabIndex = 54;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(347, 106);
            label7.Name = "label7";
            label7.Size = new Size(71, 19);
            label7.TabIndex = 51;
            label7.Text = "Mật khẩu";
            // 
            // dtmNgaySinh
            // 
            dtmNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtmNgaySinh.Format = DateTimePickerFormat.Custom;
            dtmNgaySinh.Location = new Point(125, 73);
            dtmNgaySinh.Name = "dtmNgaySinh";
            dtmNgaySinh.Size = new Size(169, 27);
            dtmNgaySinh.TabIndex = 48;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(482, 15);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(169, 27);
            cboGioiTinh.TabIndex = 49;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(125, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(169, 27);
            txtEmail.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 106);
            label6.Name = "label6";
            label6.Size = new Size(54, 19);
            label6.TabIndex = 45;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(347, 48);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 44;
            label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 19);
            label4.Name = "label4";
            label4.Size = new Size(75, 19);
            label4.TabIndex = 43;
            label4.Text = "Giới tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 77);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 42;
            label3.Text = "Ngày sinh:";
            // 
            // txtTenDG
            // 
            txtTenDG.BorderStyle = BorderStyle.FixedSingle;
            txtTenDG.Location = new Point(125, 44);
            txtTenDG.Name = "txtTenDG";
            txtTenDG.Size = new Size(169, 27);
            txtTenDG.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 48);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 41;
            label2.Text = "Tên độc giả:";
            // 
            // txtMaDG
            // 
            txtMaDG.BorderStyle = BorderStyle.FixedSingle;
            txtMaDG.Enabled = false;
            txtMaDG.Location = new Point(125, 15);
            txtMaDG.Name = "txtMaDG";
            txtMaDG.Size = new Size(169, 27);
            txtMaDG.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 40;
            label1.Text = "Mã độc giả:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Location = new Point(482, 44);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(169, 27);
            txtDiaChi.TabIndex = 61;
            // 
            // errTenDG
            // 
            errTenDG.ContainerControl = this;
            // 
            // errEmail
            // 
            errEmail.ContainerControl = this;
            // 
            // errDC
            // 
            errDC.ContainerControl = this;
            // 
            // errMK
            // 
            errMK.ContainerControl = this;
            // 
            // errGT
            // 
            errGT.ContainerControl = this;
            // 
            // dtmNgayLapThe
            // 
            dtmNgayLapThe.CustomFormat = "dd/MM/yyyy";
            dtmNgayLapThe.Enabled = false;
            dtmNgayLapThe.Format = DateTimePickerFormat.Custom;
            dtmNgayLapThe.Location = new Point(125, 160);
            dtmNgayLapThe.Name = "dtmNgayLapThe";
            dtmNgayLapThe.Size = new Size(169, 27);
            dtmNgayLapThe.TabIndex = 64;
            // 
            // cbLoaiDG
            // 
            cbLoaiDG.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoaiDG.FormattingEnabled = true;
            cbLoaiDG.Items.AddRange(new object[] { "X", "Y" });
            cbLoaiDG.Location = new Point(482, 160);
            cbLoaiDG.Name = "cbLoaiDG";
            cbLoaiDG.Size = new Size(169, 27);
            cbLoaiDG.TabIndex = 65;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(347, 164);
            label11.Name = "label11";
            label11.Size = new Size(99, 19);
            label11.TabIndex = 63;
            label11.Text = "Loại độc giả:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 164);
            label12.Name = "label12";
            label12.Size = new Size(98, 19);
            label12.TabIndex = 62;
            label12.Text = "Ngày lập thẻ:";
            // 
            // dataGridViewDSTT
            // 
            dataGridViewDSTT.AllowUserToAddRows = false;
            dataGridViewDSTT.AllowUserToDeleteRows = false;
            dataGridViewDSTT.AllowUserToResizeRows = false;
            dataGridViewDSTT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDSTT.Columns.AddRange(new DataGridViewColumn[] { colMaDG, colTenDG, colGioiTinh, colNgaySinh, colSDT, colDiaChiDG, colGhiChu, colTenTK, colMK });
            dataGridViewDSTT.Location = new Point(-21, 282);
            dataGridViewDSTT.Name = "dataGridViewDSTT";
            dataGridViewDSTT.ReadOnly = true;
            dataGridViewDSTT.RowHeadersWidth = 51;
            dataGridViewDSTT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDSTT.Size = new Size(761, 172);
            dataGridViewDSTT.TabIndex = 66;
            dataGridViewDSTT.Visible = false;
            // 
            // colMaDG
            // 
            colMaDG.DataPropertyName = "MaTT";
            colMaDG.HeaderText = "Mã ĐG";
            colMaDG.MinimumWidth = 6;
            colMaDG.Name = "colMaDG";
            colMaDG.ReadOnly = true;
            colMaDG.Width = 55;
            // 
            // colTenDG
            // 
            colTenDG.DataPropertyName = "TenTT";
            colTenDG.HeaderText = "Tên ĐG";
            colTenDG.MinimumWidth = 6;
            colTenDG.Name = "colTenDG";
            colTenDG.ReadOnly = true;
            colTenDG.Width = 115;
            // 
            // colGioiTinh
            // 
            colGioiTinh.DataPropertyName = "GioiTinhTT";
            colGioiTinh.HeaderText = "Giới Tính";
            colGioiTinh.MinimumWidth = 6;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.ReadOnly = true;
            colGioiTinh.Width = 45;
            // 
            // colNgaySinh
            // 
            colNgaySinh.DataPropertyName = "NgaySinhTT";
            colNgaySinh.HeaderText = "Ngày Sinh";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.ReadOnly = true;
            colNgaySinh.Width = 80;
            // 
            // colSDT
            // 
            colSDT.DataPropertyName = "SDTTT";
            colSDT.HeaderText = "Số ĐT";
            colSDT.MinimumWidth = 6;
            colSDT.Name = "colSDT";
            colSDT.ReadOnly = true;
            colSDT.Width = 85;
            // 
            // colDiaChiDG
            // 
            colDiaChiDG.DataPropertyName = "DiaChiTT";
            colDiaChiDG.HeaderText = "Địa Chỉ";
            colDiaChiDG.MinimumWidth = 6;
            colDiaChiDG.Name = "colDiaChiDG";
            colDiaChiDG.ReadOnly = true;
            colDiaChiDG.Width = 134;
            // 
            // colGhiChu
            // 
            colGhiChu.DataPropertyName = "GhiChu";
            colGhiChu.HeaderText = "Ghi Chú";
            colGhiChu.MinimumWidth = 6;
            colGhiChu.Name = "colGhiChu";
            colGhiChu.ReadOnly = true;
            colGhiChu.Width = 50;
            // 
            // colTenTK
            // 
            colTenTK.DataPropertyName = "TenTaiKhoanTT";
            colTenTK.HeaderText = "Tên TK";
            colTenTK.MinimumWidth = 6;
            colTenTK.Name = "colTenTK";
            colTenTK.ReadOnly = true;
            colTenTK.Width = 50;
            // 
            // colMK
            // 
            colMK.DataPropertyName = "MatKhauTT";
            colMK.HeaderText = "Mật Khẩu";
            colMK.MinimumWidth = 6;
            colMK.Name = "colMK";
            colMK.ReadOnly = true;
            colMK.Width = 50;
            // 
            // errorLoaiDG
            // 
            errorLoaiDG.ContainerControl = this;
            // 
            // frmDangKy
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(680, 250);
            Controls.Add(dataGridViewDSTT);
            Controls.Add(dtmNgayLapThe);
            Controls.Add(cbLoaiDG);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(txtDiaChi);
            Controls.Add(btnThoat);
            Controls.Add(btnThem);
            Controls.Add(txtGhiChu);
            Controls.Add(label9);
            Controls.Add(txtTenTK);
            Controls.Add(label8);
            Controls.Add(txtNhapLaiMK);
            Controls.Add(label10);
            Controls.Add(txtMK);
            Controls.Add(label7);
            Controls.Add(dtmNgaySinh);
            Controls.Add(cboGioiTinh);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTenDG);
            Controls.Add(label2);
            Controls.Add(txtMaDG);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký độc giả";
            Load += frmDangKy_Load;
            ((System.ComponentModel.ISupportInitialize)errTenDG).EndInit();
            ((System.ComponentModel.ISupportInitialize)errEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)errDC).EndInit();
            ((System.ComponentModel.ISupportInitialize)errMK).EndInit();
            ((System.ComponentModel.ISupportInitialize)errGT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSTT).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorLoaiDG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Button btnThem;
        private TextBox txtGhiChu;
        private Label label9;
        private TextBox txtTenTK;
        private Label label8;
        private TextBox txtNhapLaiMK;
        private Label label10;
        private TextBox txtMK;
        private Label label7;
        private DateTimePicker dtmNgaySinh;
        private ComboBox cboGioiTinh;
        private TextBox txtEmail;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtTenDG;
        private Label label2;
        private TextBox txtMaDG;
        private Label label1;
        private TextBox txtDiaChi;
        private ErrorProvider errTenDG;
        private ErrorProvider errEmail;
        private ErrorProvider errDC;
        private ErrorProvider errMK;
        private DateTimePicker dtmNgayLapThe;
        private ComboBox cbLoaiDG;
        private Label label11;
        private Label label12;
        private ErrorProvider errGT;
        private DataGridView dataGridViewDSTT;
        private DataGridViewTextBoxColumn colMaDG;
        private DataGridViewTextBoxColumn colTenDG;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colSDT;
        private DataGridViewTextBoxColumn colDiaChiDG;
        private DataGridViewTextBoxColumn colGhiChu;
        private DataGridViewTextBoxColumn colTenTK;
        private DataGridViewTextBoxColumn colMK;
        private ErrorProvider errorLoaiDG;
    }
}