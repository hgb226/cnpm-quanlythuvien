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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            lblTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnDangKy = new Button();
            picLockDangNhap = new PictureBox();
            chkQuanTri = new RadioButton();
            chkDocGia = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)picLockDangNhap).BeginInit();
            SuspendLayout();
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Times New Roman", 10F);
            lblTenDangNhap.Location = new Point(170, 17);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(110, 19);
            lblTenDangNhap.TabIndex = 1;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.Location = new Point(174, 35);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(191, 27);
            txtTenDangNhap.TabIndex = 0;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(170, 75);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(76, 19);
            lblMatKhau.TabIndex = 1;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Location = new Point(174, 93);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(191, 27);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.CornflowerBlue;
            btnDangNhap.Location = new Point(173, 160);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(87, 27);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.CornflowerBlue;
            btnDangKy.DialogResult = DialogResult.Cancel;
            btnDangKy.Location = new Point(278, 160);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(87, 27);
            btnDangKy.TabIndex = 4;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // picLockDangNhap
            // 
            picLockDangNhap.BorderStyle = BorderStyle.FixedSingle;
            picLockDangNhap.Image = (Image)resources.GetObject("picLockDangNhap.Image");
            picLockDangNhap.Location = new Point(12, 17);
            picLockDangNhap.Name = "picLockDangNhap";
            picLockDangNhap.Size = new Size(147, 170);
            picLockDangNhap.SizeMode = PictureBoxSizeMode.Zoom;
            picLockDangNhap.TabIndex = 0;
            picLockDangNhap.TabStop = false;
            // 
            // chkQuanTri
            // 
            chkQuanTri.AutoSize = true;
            chkQuanTri.Location = new Point(188, 127);
            chkQuanTri.Name = "chkQuanTri";
            chkQuanTri.Size = new Size(85, 23);
            chkQuanTri.TabIndex = 8;
            chkQuanTri.TabStop = true;
            chkQuanTri.Text = "Thủ Thư";
            chkQuanTri.UseVisualStyleBackColor = true;
            chkQuanTri.CheckedChanged += chkQuanTri_CheckedChanged;
            // 
            // chkDocGia
            // 
            chkDocGia.AutoSize = true;
            chkDocGia.Location = new Point(280, 127);
            chkDocGia.Name = "chkDocGia";
            chkDocGia.Size = new Size(87, 23);
            chkDocGia.TabIndex = 8;
            chkDocGia.TabStop = true;
            chkDocGia.Text = "Độc Giả";
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
            ClientSize = new Size(390, 204);
            Controls.Add(chkDocGia);
            Controls.Add(chkQuanTri);
            Controls.Add(btnDangKy);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTenDangNhap);
            Controls.Add(picLockDangNhap);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmDangNhap";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            Load += frmDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)picLockDangNhap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picLockDangNhap;
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