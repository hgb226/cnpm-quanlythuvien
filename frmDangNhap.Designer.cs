namespace qltv
{
    partial class frmDangNhap
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
            lblTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnDangKy = new Button();
            chkQuanTri = new RadioButton();
            chkDocGia = new RadioButton();
            SuspendLayout();
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Times New Roman", 10F);
            lblTenDangNhap.Location = new Point(12, 9);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(110, 19);
            lblTenDangNhap.TabIndex = 1;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.Location = new Point(12, 36);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(306, 27);
            txtTenDangNhap.TabIndex = 0;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(12, 71);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(76, 19);
            lblMatKhau.TabIndex = 1;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Location = new Point(12, 98);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(306, 27);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.CornflowerBlue;
            btnDangNhap.ForeColor = Color.Transparent;
            btnDangNhap.Location = new Point(12, 164);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(110, 53);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.CornflowerBlue;
            btnDangKy.DialogResult = DialogResult.Cancel;
            btnDangKy.ForeColor = Color.Transparent;
            btnDangKy.Location = new Point(216, 164);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(102, 53);
            btnDangKy.TabIndex = 4;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // chkQuanTri
            // 
            chkQuanTri.AutoSize = true;
            chkQuanTri.Location = new Point(12, 133);
            chkQuanTri.Name = "chkQuanTri";
            chkQuanTri.Size = new Size(81, 23);
            chkQuanTri.TabIndex = 8;
            chkQuanTri.TabStop = true;
            chkQuanTri.Text = "Thủ thư";
            chkQuanTri.UseVisualStyleBackColor = true;
            chkQuanTri.CheckedChanged += chkQuanTri_CheckedChanged;
            // 
            // chkDocGia
            // 
            chkDocGia.AutoSize = true;
            chkDocGia.Location = new Point(116, 133);
            chkDocGia.Name = "chkDocGia";
            chkDocGia.Size = new Size(83, 23);
            chkDocGia.TabIndex = 8;
            chkDocGia.TabStop = true;
            chkDocGia.Text = "Độc giả";
            chkDocGia.UseVisualStyleBackColor = true;
            chkDocGia.CheckedChanged += chkDocGia_CheckedChanged;
            // 
            // frmDangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            CancelButton = btnDangKy;
            ClientSize = new Size(330, 229);
            Controls.Add(chkDocGia);
            Controls.Add(chkQuanTri);
            Controls.Add(btnDangKy);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTenDangNhap);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmDangNhap";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập tài khoản";
            Load += frmDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.RadioButton chkQuanTri;
        private System.Windows.Forms.RadioButton chkDocGia;
    }
}