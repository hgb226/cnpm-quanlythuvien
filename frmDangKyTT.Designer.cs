namespace qltv
{
    partial class frmDangKyTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKyTT));
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
            cboGioiTinh = new ComboBox();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtTenTT = new TextBox();
            label2 = new Label();
            txtMaTT = new TextBox();
            label1 = new Label();
            label10 = new Label();
            txtNhapLaiMK = new TextBox();
            btnThem = new Button();
            btnThoat = new Button();
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
            errTenDG = new ErrorProvider(components);
            errEmail = new ErrorProvider(components);
            errDC = new ErrorProvider(components);
            errTenTK = new ErrorProvider(components);
            errMK = new ErrorProvider(components);
            errGT = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSTT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errTenDG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errDC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errTenTK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errMK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errGT).BeginInit();
            SuspendLayout();
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(134, 141);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(169, 27);
            txtGhiChu.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 145);
            label9.Name = "label9";
            label9.Size = new Size(70, 19);
            label9.TabIndex = 36;
            label9.Text = "Ghi Chú:";
            // 
            // txtTenTK
            // 
            txtTenTK.Enabled = false;
            txtTenTK.Location = new Point(478, 80);
            txtTenTK.Name = "txtTenTK";
            txtTenTK.Size = new Size(169, 27);
            txtTenTK.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(371, 85);
            label8.Name = "label8";
            label8.Size = new Size(64, 19);
            label8.TabIndex = 34;
            label8.Text = "Tên TK:";
            // 
            // txtMK
            // 
            txtMK.Location = new Point(478, 109);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(169, 27);
            txtMK.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(371, 115);
            label7.Name = "label7";
            label7.Size = new Size(80, 19);
            label7.TabIndex = 32;
            label7.Text = "Mật Khẩu:";
            // 
            // lblNhapGioiTinh
            // 
            lblNhapGioiTinh.AutoSize = true;
            lblNhapGioiTinh.Location = new Point(461, 45);
            lblNhapGioiTinh.Name = "lblNhapGioiTinh";
            lblNhapGioiTinh.Size = new Size(0, 19);
            lblNhapGioiTinh.TabIndex = 30;
            // 
            // lblNhapDiaChi
            // 
            lblNhapDiaChi.AutoSize = true;
            lblNhapDiaChi.Location = new Point(126, 114);
            lblNhapDiaChi.Name = "lblNhapDiaChi";
            lblNhapDiaChi.Size = new Size(0, 19);
            lblNhapDiaChi.TabIndex = 29;
            // 
            // lblNhapSDT
            // 
            lblNhapSDT.AutoSize = true;
            lblNhapSDT.Location = new Point(126, 153);
            lblNhapSDT.Name = "lblNhapSDT";
            lblNhapSDT.Size = new Size(0, 19);
            lblNhapSDT.TabIndex = 28;
            // 
            // lblNhapNgaySinh
            // 
            lblNhapNgaySinh.AutoSize = true;
            lblNhapNgaySinh.Location = new Point(126, 87);
            lblNhapNgaySinh.Name = "lblNhapNgaySinh";
            lblNhapNgaySinh.Size = new Size(0, 19);
            lblNhapNgaySinh.TabIndex = 31;
            // 
            // lblNhapTenDG
            // 
            lblNhapTenDG.AutoSize = true;
            lblNhapTenDG.Location = new Point(126, 59);
            lblNhapTenDG.Name = "lblNhapTenDG";
            lblNhapTenDG.Size = new Size(0, 19);
            lblNhapTenDG.TabIndex = 27;
            // 
            // dtmNgaySinh
            // 
            dtmNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtmNgaySinh.Format = DateTimePickerFormat.Custom;
            dtmNgaySinh.Location = new Point(134, 81);
            dtmNgaySinh.Name = "dtmNgaySinh";
            dtmNgaySinh.Size = new Size(169, 27);
            dtmNgaySinh.TabIndex = 23;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(478, 23);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(169, 27);
            cboGioiTinh.TabIndex = 24;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(478, 52);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(169, 27);
            txtDiaChi.TabIndex = 25;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(134, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(169, 27);
            txtEmail.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 115);
            label6.Name = "label6";
            label6.Size = new Size(54, 19);
            label6.TabIndex = 20;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(371, 55);
            label5.Name = "label5";
            label5.Size = new Size(70, 19);
            label5.TabIndex = 19;
            label5.Text = "Địa Chỉ: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 26);
            label4.Name = "label4";
            label4.Size = new Size(79, 19);
            label4.TabIndex = 18;
            label4.Text = "Giới Tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 85);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 17;
            label3.Text = "Ngày Sinh:";
            // 
            // txtTenTT
            // 
            txtTenTT.Location = new Point(134, 52);
            txtTenTT.Name = "txtTenTT";
            txtTenTT.Size = new Size(169, 27);
            txtTenTT.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 55);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 16;
            label2.Text = "Tên Thủ Thư:";
            // 
            // txtMaTT
            // 
            txtMaTT.Enabled = false;
            txtMaTT.Location = new Point(134, 23);
            txtMaTT.Name = "txtMaTT";
            txtMaTT.Size = new Size(169, 27);
            txtMaTT.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(95, 19);
            label1.TabIndex = 15;
            label1.Text = "Mã Thủ Thư:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(371, 144);
            label10.Name = "label10";
            label10.Size = new Size(101, 19);
            label10.TabIndex = 32;
            label10.Text = "Nhập lại MK:";
            // 
            // txtNhapLaiMK
            // 
            txtNhapLaiMK.Location = new Point(478, 138);
            txtNhapLaiMK.Name = "txtNhapLaiMK";
            txtNhapLaiMK.Size = new Size(169, 27);
            txtNhapLaiMK.TabIndex = 33;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.CornflowerBlue;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(228, 184);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 39);
            btnThem.TabIndex = 38;
            btnThem.Text = "Đăng Ký";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.CornflowerBlue;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(355, 184);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(98, 39);
            btnThoat.TabIndex = 39;
            btnThoat.Text = "Home";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // dataGridViewDSTT
            // 
            dataGridViewDSTT.AllowUserToAddRows = false;
            dataGridViewDSTT.AllowUserToDeleteRows = false;
            dataGridViewDSTT.AllowUserToResizeRows = false;
            dataGridViewDSTT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDSTT.Columns.AddRange(new DataGridViewColumn[] { colMaDG, colTenDG, colGioiTinh, colNgaySinh, colSDT, colDiaChiDG, colGhiChu, colTenTK, colMK });
            dataGridViewDSTT.Location = new Point(12, 272);
            dataGridViewDSTT.Name = "dataGridViewDSTT";
            dataGridViewDSTT.ReadOnly = true;
            dataGridViewDSTT.RowHeadersWidth = 51;
            dataGridViewDSTT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDSTT.Size = new Size(761, 172);
            dataGridViewDSTT.TabIndex = 40;
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
            // errTenTK
            // 
            errTenTK.ContainerControl = this;
            // 
            // errMK
            // 
            errMK.ContainerControl = this;
            // 
            // errGT
            // 
            errGT.ContainerControl = this;
            // 
            // frmDangKyTT
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(693, 238);
            Controls.Add(dataGridViewDSTT);
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
            Controls.Add(lblNhapGioiTinh);
            Controls.Add(lblNhapDiaChi);
            Controls.Add(lblNhapSDT);
            Controls.Add(lblNhapNgaySinh);
            Controls.Add(lblNhapTenDG);
            Controls.Add(dtmNgaySinh);
            Controls.Add(cboGioiTinh);
            Controls.Add(txtDiaChi);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTenTT);
            Controls.Add(label2);
            Controls.Add(txtMaTT);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Name = "frmDangKyTT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Ký";
            Load += frmDangKyTT_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSTT).EndInit();
            ((System.ComponentModel.ISupportInitialize)errTenDG).EndInit();
            ((System.ComponentModel.ISupportInitialize)errEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)errDC).EndInit();
            ((System.ComponentModel.ISupportInitialize)errTenTK).EndInit();
            ((System.ComponentModel.ISupportInitialize)errMK).EndInit();
            ((System.ComponentModel.ISupportInitialize)errGT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNhapGioiTinh;
        private System.Windows.Forms.Label lblNhapDiaChi;
        private System.Windows.Forms.Label lblNhapSDT;
        private System.Windows.Forms.Label lblNhapNgaySinh;
        private System.Windows.Forms.Label lblNhapTenDG;
        private System.Windows.Forms.DateTimePicker dtmNgaySinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNhapLaiMK;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridViewDSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMK;
        private System.Windows.Forms.ErrorProvider errTenDG;
        private System.Windows.Forms.ErrorProvider errEmail;
        private System.Windows.Forms.ErrorProvider errDC;
        private System.Windows.Forms.ErrorProvider errTenTK;
        private System.Windows.Forms.ErrorProvider errMK;
        private System.Windows.Forms.ErrorProvider errGT;
    }
}