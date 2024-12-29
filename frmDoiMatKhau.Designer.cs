namespace qltv
{
    partial class frmDoiMatKhau
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTenTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtNhapLaiMKMoi = new TextBox();
            chkMatKhauCu = new CheckBox();
            chkMatKhauMoi = new CheckBox();
            chkNhapLaiMatKhau = new CheckBox();
            btnDoiMatKhau = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 167);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu mới:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 256);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 3;
            label4.Text = "Xác nhận mật khẩu mới:";
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTenTaiKhoan.Location = new Point(12, 45);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(375, 27);
            txtTenTaiKhoan.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Location = new Point(12, 104);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(375, 27);
            txtMatKhau.TabIndex = 5;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhauMoi.Location = new Point(12, 193);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '*';
            txtMatKhauMoi.Size = new Size(375, 27);
            txtMatKhauMoi.TabIndex = 6;
            // 
            // txtNhapLaiMKMoi
            // 
            txtNhapLaiMKMoi.BorderStyle = BorderStyle.FixedSingle;
            txtNhapLaiMKMoi.Location = new Point(12, 282);
            txtNhapLaiMKMoi.Name = "txtNhapLaiMKMoi";
            txtNhapLaiMKMoi.PasswordChar = '*';
            txtNhapLaiMKMoi.Size = new Size(375, 27);
            txtNhapLaiMKMoi.TabIndex = 7;
            // 
            // chkMatKhauCu
            // 
            chkMatKhauCu.AutoSize = true;
            chkMatKhauCu.Location = new Point(12, 137);
            chkMatKhauCu.Name = "chkMatKhauCu";
            chkMatKhauCu.Size = new Size(62, 24);
            chkMatKhauCu.TabIndex = 8;
            chkMatKhauCu.Text = "Hiện";
            chkMatKhauCu.UseVisualStyleBackColor = true;
            chkMatKhauCu.CheckedChanged += chkMatKhauCu_CheckedChanged;
            // 
            // chkMatKhauMoi
            // 
            chkMatKhauMoi.AutoSize = true;
            chkMatKhauMoi.Location = new Point(12, 226);
            chkMatKhauMoi.Name = "chkMatKhauMoi";
            chkMatKhauMoi.Size = new Size(62, 24);
            chkMatKhauMoi.TabIndex = 9;
            chkMatKhauMoi.Text = "Hiện";
            chkMatKhauMoi.UseVisualStyleBackColor = true;
            chkMatKhauMoi.CheckedChanged += chkMatKhauMoi_CheckedChanged;
            // 
            // chkNhapLaiMatKhau
            // 
            chkNhapLaiMatKhau.AutoSize = true;
            chkNhapLaiMatKhau.Location = new Point(12, 315);
            chkNhapLaiMatKhau.Name = "chkNhapLaiMatKhau";
            chkNhapLaiMatKhau.Size = new Size(62, 24);
            chkNhapLaiMatKhau.TabIndex = 10;
            chkNhapLaiMatKhau.Text = "Hiện";
            chkNhapLaiMatKhau.UseVisualStyleBackColor = true;
            chkNhapLaiMatKhau.CheckedChanged += chkNhapLaiMatKhau_CheckedChanged;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Location = new Point(12, 345);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(94, 29);
            btnDoiMatKhau.TabIndex = 11;
            btnDoiMatKhau.Text = "Xác nhận";
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(107, 345);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 411);
            Controls.Add(btnThoat);
            Controls.Add(btnDoiMatKhau);
            Controls.Add(chkNhapLaiMatKhau);
            Controls.Add(chkMatKhauMoi);
            Controls.Add(chkMatKhauCu);
            Controls.Add(txtNhapLaiMKMoi);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenTaiKhoan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDoiMatKhau";
            Text = "Đổi mật khẩu";
            Load += frmDoiMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTenTaiKhoan;
        private TextBox txtMatKhau;
        private TextBox txtMatKhauMoi;
        private TextBox txtNhapLaiMKMoi;
        private CheckBox chkMatKhauCu;
        private CheckBox chkMatKhauMoi;
        private CheckBox chkNhapLaiMatKhau;
        private Button btnDoiMatKhau;
        private Button btnThoat;
    }
}