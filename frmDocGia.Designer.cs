namespace qltv
{
    partial class frmDocGia
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
            groupBox3 = new GroupBox();
            grpTimKiem = new GroupBox();
            txtNDTimKiem = new TextBox();
            groupBox4 = new GroupBox();
            radTenCD = new RadioButton();
            radTenTG = new RadioButton();
            radTenSach = new RadioButton();
            radMaSach = new RadioButton();
            dataGridViewDSSach0 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            colTenSach = new DataGridViewTextBoxColumn();
            colTenLoai = new DataGridViewTextBoxColumn();
            colTenTG = new DataGridViewTextBoxColumn();
            colMaNXB = new DataGridViewTextBoxColumn();
            colNamXB = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colTriGia = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            menuStrip1 = new MenuStrip();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            groupBox3.SuspendLayout();
            grpTimKiem.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSSach0).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grpTimKiem);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(33, 45);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(701, 96);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm Sách";
            // 
            // grpTimKiem
            // 
            grpTimKiem.Controls.Add(txtNDTimKiem);
            grpTimKiem.Location = new Point(435, 19);
            grpTimKiem.Name = "grpTimKiem";
            grpTimKiem.Size = new Size(243, 60);
            grpTimKiem.TabIndex = 1;
            grpTimKiem.TabStop = false;
            grpTimKiem.Text = "Nhập thông tin cần Tìm Kiếm";
            // 
            // txtNDTimKiem
            // 
            txtNDTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtNDTimKiem.Location = new Point(11, 24);
            txtNDTimKiem.Name = "txtNDTimKiem";
            txtNDTimKiem.Size = new Size(218, 27);
            txtNDTimKiem.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radTenCD);
            groupBox4.Controls.Add(radTenTG);
            groupBox4.Controls.Add(radTenSach);
            groupBox4.Controls.Add(radMaSach);
            groupBox4.Location = new Point(31, 19);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(387, 60);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm Theo";
            // 
            // radTenCD
            // 
            radTenCD.AutoSize = true;
            radTenCD.Location = new Point(296, 24);
            radTenCD.Name = "radTenCD";
            radTenCD.Size = new Size(82, 23);
            radTenCD.TabIndex = 3;
            radTenCD.TabStop = true;
            radTenCD.Text = "Tên CD";
            radTenCD.UseVisualStyleBackColor = true;
            // 
            // radTenTG
            // 
            radTenTG.AutoSize = true;
            radTenTG.Location = new Point(208, 24);
            radTenTG.Name = "radTenTG";
            radTenTG.Size = new Size(80, 23);
            radTenTG.TabIndex = 2;
            radTenTG.TabStop = true;
            radTenTG.Text = "Tên TG";
            radTenTG.UseVisualStyleBackColor = true;
            // 
            // radTenSach
            // 
            radTenSach.AutoSize = true;
            radTenSach.Location = new Point(111, 24);
            radTenSach.Name = "radTenSach";
            radTenSach.Size = new Size(91, 23);
            radTenSach.TabIndex = 1;
            radTenSach.TabStop = true;
            radTenSach.Text = "Tên Sách";
            radTenSach.UseVisualStyleBackColor = true;
            // 
            // radMaSach
            // 
            radMaSach.AutoSize = true;
            radMaSach.Location = new Point(18, 24);
            radMaSach.Name = "radMaSach";
            radMaSach.Size = new Size(88, 23);
            radMaSach.TabIndex = 0;
            radMaSach.TabStop = true;
            radMaSach.Text = "Mã Sách";
            radMaSach.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDSSach0
            // 
            dataGridViewDSSach0.AllowUserToAddRows = false;
            dataGridViewDSSach0.AllowUserToDeleteRows = false;
            dataGridViewDSSach0.AllowUserToResizeRows = false;
            dataGridViewDSSach0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDSSach0.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, colTenSach, colTenLoai, colTenTG, colMaNXB, colNamXB, colSoLuong, colTriGia, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewDSSach0.Location = new Point(16, 27);
            dataGridViewDSSach0.Name = "dataGridViewDSSach0";
            dataGridViewDSSach0.RowHeadersWidth = 51;
            dataGridViewDSSach0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDSSach0.Size = new Size(707, 176);
            dataGridViewDSSach0.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "MaSach";
            dataGridViewTextBoxColumn1.HeaderText = "Mã Sách";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 60;
            // 
            // colTenSach
            // 
            colTenSach.DataPropertyName = "TenSach";
            colTenSach.HeaderText = "Tên Sách";
            colTenSach.MinimumWidth = 6;
            colTenSach.Name = "colTenSach";
            colTenSach.ReadOnly = true;
            colTenSach.Width = 140;
            // 
            // colTenLoai
            // 
            colTenLoai.DataPropertyName = "TheLoai";
            colTenLoai.HeaderText = "Chủ Đề";
            colTenLoai.MinimumWidth = 6;
            colTenLoai.Name = "colTenLoai";
            colTenLoai.ReadOnly = true;
            colTenLoai.Width = 80;
            // 
            // colTenTG
            // 
            colTenTG.DataPropertyName = "TacGia";
            colTenTG.HeaderText = "Tác Giả";
            colTenTG.MinimumWidth = 6;
            colTenTG.Name = "colTenTG";
            colTenTG.ReadOnly = true;
            colTenTG.Width = 125;
            // 
            // colMaNXB
            // 
            colMaNXB.DataPropertyName = "NXB";
            colMaNXB.HeaderText = "NXB";
            colMaNXB.MinimumWidth = 6;
            colMaNXB.Name = "colMaNXB";
            colMaNXB.ReadOnly = true;
            colMaNXB.Width = 125;
            // 
            // colNamXB
            // 
            colNamXB.DataPropertyName = "NamXB";
            colNamXB.HeaderText = "Năm XB";
            colNamXB.MinimumWidth = 6;
            colNamXB.Name = "colNamXB";
            colNamXB.Width = 125;
            // 
            // colSoLuong
            // 
            colSoLuong.DataPropertyName = "SLNhap";
            colSoLuong.HeaderText = "SL Nhập";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            colSoLuong.ReadOnly = true;
            colSoLuong.Width = 50;
            // 
            // colTriGia
            // 
            colTriGia.DataPropertyName = "TriGia";
            colTriGia.HeaderText = "Đơn Giá";
            colTriGia.MinimumWidth = 6;
            colTriGia.Name = "colTriGia";
            colTriGia.ReadOnly = true;
            colTriGia.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "TinhTrang";
            dataGridViewTextBoxColumn2.HeaderText = "Tình Trạng";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "GhiChu";
            dataGridViewTextBoxColumn3.HeaderText = "Ghi Chú";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewDSSach0);
            groupBox1.Location = new Point(12, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(739, 209);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Sách";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.PowderBlue;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { changePasswordToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(767, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(114, 24);
            changePasswordToolStripMenuItem.Text = "Đổi Mật Khẩu";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(61, 24);
            exitToolStripMenuItem.Text = "Thoát";
            // 
            // frmDocGia
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(767, 385);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 163);
            MainMenuStrip = menuStrip1;
            Name = "frmDocGia";
            Text = "Độc Giả";
            groupBox3.ResumeLayout(false);
            grpTimKiem.ResumeLayout(false);
            grpTimKiem.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSSach0).EndInit();
            groupBox1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.TextBox txtNDTimKiem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radTenCD;
        private System.Windows.Forms.RadioButton radTenTG;
        private System.Windows.Forms.RadioButton radTenSach;
        private System.Windows.Forms.RadioButton radMaSach;
        private System.Windows.Forms.DataGridView dataGridViewDSSach0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}