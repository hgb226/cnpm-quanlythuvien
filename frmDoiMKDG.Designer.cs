﻿namespace qltv
{
    partial class frmDoiMKDG
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
            btnThoat = new Button();
            btnDoiMatKhau = new Button();
            chkNhapLaiMatKhau = new CheckBox();
            chkMatKhauMoi = new CheckBox();
            chkMatKhauCu = new CheckBox();
            txtNhapLaiMKMoi = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtMatKhau = new TextBox();
            txtTenTaiKhoan = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(112, 415);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 25;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Location = new Point(12, 415);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(94, 29);
            btnDoiMatKhau.TabIndex = 24;
            btnDoiMatKhau.Text = "Xác nhận";
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // chkNhapLaiMatKhau
            // 
            chkNhapLaiMatKhau.AutoSize = true;
            chkNhapLaiMatKhau.Location = new Point(12, 385);
            chkNhapLaiMatKhau.Name = "chkNhapLaiMatKhau";
            chkNhapLaiMatKhau.Size = new Size(62, 24);
            chkNhapLaiMatKhau.TabIndex = 23;
            chkNhapLaiMatKhau.Text = "Hiện";
            chkNhapLaiMatKhau.UseVisualStyleBackColor = true;
            chkNhapLaiMatKhau.CheckedChanged += chkNhapLaiMatKhau_CheckedChanged;
            // 
            // chkMatKhauMoi
            // 
            chkMatKhauMoi.AutoSize = true;
            chkMatKhauMoi.Location = new Point(12, 272);
            chkMatKhauMoi.Name = "chkMatKhauMoi";
            chkMatKhauMoi.Size = new Size(62, 24);
            chkMatKhauMoi.TabIndex = 22;
            chkMatKhauMoi.Text = "Hiện";
            chkMatKhauMoi.UseVisualStyleBackColor = true;
            chkMatKhauMoi.CheckedChanged += chkMatKhauMoi_CheckedChanged;
            // 
            // chkMatKhauCu
            // 
            chkMatKhauCu.AutoSize = true;
            chkMatKhauCu.Location = new Point(12, 159);
            chkMatKhauCu.Name = "chkMatKhauCu";
            chkMatKhauCu.Size = new Size(62, 24);
            chkMatKhauCu.TabIndex = 21;
            chkMatKhauCu.Text = "Hiện";
            chkMatKhauCu.UseVisualStyleBackColor = true;
            chkMatKhauCu.CheckedChanged += chkMatKhauCu_CheckedChanged;
            // 
            // txtNhapLaiMKMoi
            // 
            txtNhapLaiMKMoi.BorderStyle = BorderStyle.FixedSingle;
            txtNhapLaiMKMoi.Location = new Point(12, 344);
            txtNhapLaiMKMoi.Name = "txtNhapLaiMKMoi";
            txtNhapLaiMKMoi.PasswordChar = '*';
            txtNhapLaiMKMoi.Size = new Size(355, 27);
            txtNhapLaiMKMoi.TabIndex = 20;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhauMoi.Location = new Point(12, 231);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '*';
            txtMatKhauMoi.Size = new Size(355, 27);
            txtMatKhauMoi.TabIndex = 19;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Location = new Point(12, 118);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(355, 27);
            txtMatKhau.TabIndex = 18;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTenTaiKhoan.Location = new Point(12, 43);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(355, 27);
            txtTenTaiKhoan.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 310);
            label4.Name = "label4";
            label4.Size = new Size(164, 20);
            label4.TabIndex = 16;
            label4.Text = "Xác nhận mật khẩu mới";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 197);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 15;
            label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 14;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 13;
            label1.Text = "Tên tài khoản";
            // 
            // frmDoiMKDG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 459);
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
            Name = "frmDoiMKDG";
            Text = "frmDoiMKDG";
            Load += frmDoiMKDG_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Button btnDoiMatKhau;
        private CheckBox chkNhapLaiMatKhau;
        private CheckBox chkMatKhauMoi;
        private CheckBox chkMatKhauCu;
        private TextBox txtNhapLaiMKMoi;
        private TextBox txtMatKhauMoi;
        private TextBox txtMatKhau;
        private TextBox txtTenTaiKhoan;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}