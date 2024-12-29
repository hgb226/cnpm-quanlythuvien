namespace qltv
{
    partial class frmThayDoiThamSo
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
            btnXacNhan = new Button();
            txtTuoiDGMin = new TextBox();
            label1 = new Label();
            txtTuoiDGMax = new TextBox();
            label2 = new Label();
            txtGiaTriThe = new TextBox();
            label3 = new Label();
            txtThoiGianXB = new TextBox();
            label4 = new Label();
            txtSoSachMuonMax = new TextBox();
            label5 = new Label();
            txtSoNgayMuonMax = new TextBox();
            label6 = new Label();
            cbTuoiMin = new CheckBox();
            cbTuoiMax = new CheckBox();
            cbThoiHanThe = new CheckBox();
            cbThoiGianXB = new CheckBox();
            cbSachMuonMax = new CheckBox();
            cbNgayMuonMax = new CheckBox();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(467, 111);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 38;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(467, 76);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 37;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // txtTuoiDGMin
            // 
            txtTuoiDGMin.BorderStyle = BorderStyle.FixedSingle;
            txtTuoiDGMin.Enabled = false;
            txtTuoiDGMin.Location = new Point(166, 6);
            txtTuoiDGMin.Name = "txtTuoiDGMin";
            txtTuoiDGMin.Size = new Size(189, 27);
            txtTuoiDGMin.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 26;
            label1.Text = "Số tuổi tối thiểu:";
            // 
            // txtTuoiDGMax
            // 
            txtTuoiDGMax.BorderStyle = BorderStyle.FixedSingle;
            txtTuoiDGMax.Enabled = false;
            txtTuoiDGMax.Location = new Point(166, 44);
            txtTuoiDGMax.Name = "txtTuoiDGMax";
            txtTuoiDGMax.Size = new Size(189, 27);
            txtTuoiDGMax.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 47);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 39;
            label2.Text = "Số tuổi tối đa:";
            // 
            // txtGiaTriThe
            // 
            txtGiaTriThe.BorderStyle = BorderStyle.FixedSingle;
            txtGiaTriThe.Enabled = false;
            txtGiaTriThe.Location = new Point(166, 82);
            txtGiaTriThe.Name = "txtGiaTriThe";
            txtGiaTriThe.Size = new Size(189, 27);
            txtGiaTriThe.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 85);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 41;
            label3.Text = "Thời hạn thẻ:";
            // 
            // txtThoiGianXB
            // 
            txtThoiGianXB.BorderStyle = BorderStyle.FixedSingle;
            txtThoiGianXB.Enabled = false;
            txtThoiGianXB.Location = new Point(166, 120);
            txtThoiGianXB.Name = "txtThoiGianXB";
            txtThoiGianXB.Size = new Size(189, 27);
            txtThoiGianXB.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 123);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 43;
            label4.Text = "Khoảng cách năm XB:";
            // 
            // txtSoSachMuonMax
            // 
            txtSoSachMuonMax.BorderStyle = BorderStyle.FixedSingle;
            txtSoSachMuonMax.Enabled = false;
            txtSoSachMuonMax.Location = new Point(166, 158);
            txtSoSachMuonMax.Name = "txtSoSachMuonMax";
            txtSoSachMuonMax.Size = new Size(189, 27);
            txtSoSachMuonMax.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 161);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 45;
            label5.Text = "Số sách mượn tối đa:";
            // 
            // txtSoNgayMuonMax
            // 
            txtSoNgayMuonMax.BorderStyle = BorderStyle.FixedSingle;
            txtSoNgayMuonMax.Enabled = false;
            txtSoNgayMuonMax.Location = new Point(166, 196);
            txtSoNgayMuonMax.Name = "txtSoNgayMuonMax";
            txtSoNgayMuonMax.Size = new Size(189, 27);
            txtSoNgayMuonMax.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 199);
            label6.Name = "label6";
            label6.Size = new Size(151, 20);
            label6.TabIndex = 47;
            label6.Text = "Số ngày mượn tối đa:";
            // 
            // cbTuoiMin
            // 
            cbTuoiMin.AutoSize = true;
            cbTuoiMin.Location = new Point(361, 7);
            cbTuoiMin.Name = "cbTuoiMin";
            cbTuoiMin.Size = new Size(62, 24);
            cbTuoiMin.TabIndex = 49;
            cbTuoiMin.Text = "Hiện";
            cbTuoiMin.UseVisualStyleBackColor = true;
            cbTuoiMin.CheckedChanged += cbTuoiMin_CheckedChanged;
            // 
            // cbTuoiMax
            // 
            cbTuoiMax.AutoSize = true;
            cbTuoiMax.Location = new Point(361, 45);
            cbTuoiMax.Name = "cbTuoiMax";
            cbTuoiMax.Size = new Size(62, 24);
            cbTuoiMax.TabIndex = 50;
            cbTuoiMax.Text = "Hiện";
            cbTuoiMax.UseVisualStyleBackColor = true;
            cbTuoiMax.CheckedChanged += cbTuoiMax_CheckedChanged;
            // 
            // cbThoiHanThe
            // 
            cbThoiHanThe.AutoSize = true;
            cbThoiHanThe.Location = new Point(361, 83);
            cbThoiHanThe.Name = "cbThoiHanThe";
            cbThoiHanThe.Size = new Size(62, 24);
            cbThoiHanThe.TabIndex = 51;
            cbThoiHanThe.Text = "Hiện";
            cbThoiHanThe.UseVisualStyleBackColor = true;
            cbThoiHanThe.CheckedChanged += cbThoiHanThe_CheckedChanged;
            // 
            // cbThoiGianXB
            // 
            cbThoiGianXB.AutoSize = true;
            cbThoiGianXB.Location = new Point(361, 121);
            cbThoiGianXB.Name = "cbThoiGianXB";
            cbThoiGianXB.Size = new Size(62, 24);
            cbThoiGianXB.TabIndex = 52;
            cbThoiGianXB.Text = "Hiện";
            cbThoiGianXB.UseVisualStyleBackColor = true;
            cbThoiGianXB.CheckedChanged += cbThoiGianXB_CheckedChanged;
            // 
            // cbSachMuonMax
            // 
            cbSachMuonMax.AutoSize = true;
            cbSachMuonMax.Location = new Point(361, 159);
            cbSachMuonMax.Name = "cbSachMuonMax";
            cbSachMuonMax.Size = new Size(62, 24);
            cbSachMuonMax.TabIndex = 53;
            cbSachMuonMax.Text = "Hiện";
            cbSachMuonMax.UseVisualStyleBackColor = true;
            cbSachMuonMax.CheckedChanged += cbSachMuonMax_CheckedChanged;
            // 
            // cbNgayMuonMax
            // 
            cbNgayMuonMax.AutoSize = true;
            cbNgayMuonMax.Location = new Point(361, 197);
            cbNgayMuonMax.Name = "cbNgayMuonMax";
            cbNgayMuonMax.Size = new Size(62, 24);
            cbNgayMuonMax.TabIndex = 54;
            cbNgayMuonMax.Text = "Hiện";
            cbNgayMuonMax.UseVisualStyleBackColor = true;
            cbNgayMuonMax.CheckedChanged += cbNgayMuonMax_CheckedChanged;
            // 
            // frmThayDoiThamSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 229);
            Controls.Add(cbNgayMuonMax);
            Controls.Add(cbSachMuonMax);
            Controls.Add(cbThoiGianXB);
            Controls.Add(cbThoiHanThe);
            Controls.Add(cbTuoiMax);
            Controls.Add(cbTuoiMin);
            Controls.Add(txtSoNgayMuonMax);
            Controls.Add(label6);
            Controls.Add(txtSoSachMuonMax);
            Controls.Add(label5);
            Controls.Add(txtThoiGianXB);
            Controls.Add(label4);
            Controls.Add(txtGiaTriThe);
            Controls.Add(label3);
            Controls.Add(txtTuoiDGMax);
            Controls.Add(label2);
            Controls.Add(btnThoat);
            Controls.Add(btnXacNhan);
            Controls.Add(txtTuoiDGMin);
            Controls.Add(label1);
            Name = "frmThayDoiThamSo";
            Text = "Thay Đổi Tham Số";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Button btnXacNhan;
        private TextBox txtTuoiDGMin;
        private Label label1;
        private TextBox txtTuoiDGMax;
        private Label label2;
        private TextBox txtGiaTriThe;
        private Label label3;
        private TextBox txtThoiGianXB;
        private Label label4;
        private TextBox txtSoSachMuonMax;
        private Label label5;
        private TextBox txtSoNgayMuonMax;
        private Label label6;
        private CheckBox cbTuoiMin;
        private CheckBox cbTuoiMax;
        private CheckBox cbThoiHanThe;
        private CheckBox cbThoiGianXB;
        private CheckBox cbSachMuonMax;
        private CheckBox cbNgayMuonMax;
    }
}