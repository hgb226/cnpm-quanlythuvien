namespace qltv
{
    partial class frmBaoCaoThongKe
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
            txtSLDauSach = new TextBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTongGiaTriSach = new TextBox();
            txtSLCon = new TextBox();
            txtSLMuon = new TextBox();
            txtSLCuon = new TextBox();
            groupBox2 = new GroupBox();
            dtpBaocao = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtSLDGQuaHan = new TextBox();
            txtSLDGMuon = new TextBox();
            txtSLDocGia = new TextBox();
            btnHome = new Button();
            btnBaocao = new Button();
            btnXemSLSachQuaHan = new Button();
            dataGridViewDSDGQuaHan = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSDGQuaHan).BeginInit();
            SuspendLayout();
            // 
            // txtSLDauSach
            // 
            txtSLDauSach.BackColor = SystemColors.Window;
            txtSLDauSach.BorderStyle = BorderStyle.FixedSingle;
            txtSLDauSach.Enabled = false;
            txtSLDauSach.Location = new Point(143, 22);
            txtSLDauSach.Name = "txtSLDauSach";
            txtSLDauSach.ReadOnly = true;
            txtSLDauSach.Size = new Size(100, 23);
            txtSLDauSach.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTongGiaTriSach);
            groupBox1.Controls.Add(txtSLCon);
            groupBox1.Controls.Add(txtSLMuon);
            groupBox1.Controls.Add(txtSLCuon);
            groupBox1.Controls.Add(txtSLDauSach);
            groupBox1.Location = new Point(26, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(734, 118);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thống Kê Sách";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(482, 56);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 10;
            label5.Text = "Tổng Giá Trị";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(513, 27);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 9;
            label4.Text = "SL Còn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 86);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 8;
            label3.Text = "SL Mượn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 56);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "SL Cuốn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 27);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 6;
            label1.Text = "SL Đầu Sách";
            // 
            // txtTongGiaTriSach
            // 
            txtTongGiaTriSach.BackColor = SystemColors.Window;
            txtTongGiaTriSach.BorderStyle = BorderStyle.FixedSingle;
            txtTongGiaTriSach.Enabled = false;
            txtTongGiaTriSach.Location = new Point(565, 51);
            txtTongGiaTriSach.Name = "txtTongGiaTriSach";
            txtTongGiaTriSach.ReadOnly = true;
            txtTongGiaTriSach.Size = new Size(100, 23);
            txtTongGiaTriSach.TabIndex = 4;
            // 
            // txtSLCon
            // 
            txtSLCon.BackColor = SystemColors.Window;
            txtSLCon.BorderStyle = BorderStyle.FixedSingle;
            txtSLCon.Enabled = false;
            txtSLCon.Location = new Point(565, 22);
            txtSLCon.Name = "txtSLCon";
            txtSLCon.ReadOnly = true;
            txtSLCon.Size = new Size(100, 23);
            txtSLCon.TabIndex = 3;
            // 
            // txtSLMuon
            // 
            txtSLMuon.BackColor = SystemColors.Window;
            txtSLMuon.BorderStyle = BorderStyle.FixedSingle;
            txtSLMuon.Enabled = false;
            txtSLMuon.Location = new Point(143, 80);
            txtSLMuon.Name = "txtSLMuon";
            txtSLMuon.ReadOnly = true;
            txtSLMuon.Size = new Size(100, 23);
            txtSLMuon.TabIndex = 2;
            // 
            // txtSLCuon
            // 
            txtSLCuon.BackColor = SystemColors.Window;
            txtSLCuon.BorderStyle = BorderStyle.FixedSingle;
            txtSLCuon.Enabled = false;
            txtSLCuon.Location = new Point(143, 51);
            txtSLCuon.Name = "txtSLCuon";
            txtSLCuon.ReadOnly = true;
            txtSLCuon.Size = new Size(100, 23);
            txtSLCuon.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpBaocao);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtSLDGQuaHan);
            groupBox2.Controls.Add(txtSLDGMuon);
            groupBox2.Controls.Add(txtSLDocGia);
            groupBox2.Location = new Point(26, 146);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(734, 94);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thống Kê Độc Giả";
            // 
            // dtpBaocao
            // 
            dtpBaocao.CustomFormat = "dd/MM/yyyy";
            dtpBaocao.Enabled = false;
            dtpBaocao.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBaocao.Format = DateTimePickerFormat.Custom;
            dtpBaocao.Location = new Point(528, 56);
            dtpBaocao.Name = "dtpBaocao";
            dtpBaocao.ShowUpDown = true;
            dtpBaocao.Size = new Size(100, 22);
            dtpBaocao.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(421, 62);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 10;
            label8.Text = "Thời gian báo cáo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(422, 28);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 9;
            label9.Text = "SL ĐG Vi Phạm";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 63);
            label11.Name = "label11";
            label11.Size = new Size(90, 15);
            label11.TabIndex = 7;
            label11.Text = "SL ĐG Đã Mượn";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(66, 28);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 6;
            label12.Text = "SL Độc Giả";
            // 
            // txtSLDGQuaHan
            // 
            txtSLDGQuaHan.BackColor = SystemColors.Window;
            txtSLDGQuaHan.BorderStyle = BorderStyle.FixedSingle;
            txtSLDGQuaHan.Enabled = false;
            txtSLDGQuaHan.Location = new Point(528, 20);
            txtSLDGQuaHan.Name = "txtSLDGQuaHan";
            txtSLDGQuaHan.ReadOnly = true;
            txtSLDGQuaHan.Size = new Size(100, 23);
            txtSLDGQuaHan.TabIndex = 3;
            // 
            // txtSLDGMuon
            // 
            txtSLDGMuon.BackColor = SystemColors.Window;
            txtSLDGMuon.BorderStyle = BorderStyle.FixedSingle;
            txtSLDGMuon.Enabled = false;
            txtSLDGMuon.Location = new Point(143, 54);
            txtSLDGMuon.Name = "txtSLDGMuon";
            txtSLDGMuon.ReadOnly = true;
            txtSLDGMuon.Size = new Size(100, 23);
            txtSLDGMuon.TabIndex = 1;
            // 
            // txtSLDocGia
            // 
            txtSLDocGia.BackColor = SystemColors.Window;
            txtSLDocGia.BorderStyle = BorderStyle.FixedSingle;
            txtSLDocGia.Enabled = false;
            txtSLDocGia.Location = new Point(143, 20);
            txtSLDocGia.Name = "txtSLDocGia";
            txtSLDocGia.ReadOnly = true;
            txtSLDocGia.Size = new Size(100, 23);
            txtSLDocGia.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(592, 246);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(99, 34);
            btnHome.TabIndex = 12;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnBaocao
            // 
            btnBaocao.Location = new Point(105, 246);
            btnBaocao.Name = "btnBaocao";
            btnBaocao.Size = new Size(110, 34);
            btnBaocao.TabIndex = 13;
            btnBaocao.Text = "Báo Cáo (THÁNG)";
            btnBaocao.UseVisualStyleBackColor = true;
            btnBaocao.Click += btnBaocao_Click;
            // 
            // btnXemSLSachQuaHan
            // 
            btnXemSLSachQuaHan.Location = new Point(321, 246);
            btnXemSLSachQuaHan.Name = "btnXemSLSachQuaHan";
            btnXemSLSachQuaHan.Size = new Size(155, 34);
            btnXemSLSachQuaHan.TabIndex = 14;
            btnXemSLSachQuaHan.Text = "DS Sách Mượn Quá Hạn";
            btnXemSLSachQuaHan.UseVisualStyleBackColor = true;
            btnXemSLSachQuaHan.Click += btnXemSLSachQuaHan_Click;
            // 
            // dataGridViewDSDGQuaHan
            // 
            dataGridViewDSDGQuaHan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDSDGQuaHan.Location = new Point(10, 286);
            dataGridViewDSDGQuaHan.Name = "dataGridViewDSDGQuaHan";
            dataGridViewDSDGQuaHan.RowHeadersWidth = 51;
            dataGridViewDSDGQuaHan.Size = new Size(779, 278);
            dataGridViewDSDGQuaHan.TabIndex = 16;
            // 
            // frmBaoCaoThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 574);
            Controls.Add(dataGridViewDSDGQuaHan);
            Controls.Add(btnXemSLSachQuaHan);
            Controls.Add(btnBaocao);
            Controls.Add(btnHome);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmBaoCaoThongKe";
            Text = "Báo cáo thống kê";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSDGQuaHan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSLDauSach;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTongGiaTriSach;
        private TextBox txtSLCon;
        private TextBox txtSLMuon;
        private TextBox txtSLCuon;
        private GroupBox groupBox2;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private TextBox txtSLDGQuaHan;
        private TextBox txtSLDGMuon;
        private TextBox txtSLDocGia;
        private Button btnHome;
        private Button btnBaocao;
        private Button btnXemSLSachQuaHan;
        private DataGridView dataGridViewDSDGQuaHan;
        private DateTimePicker dtpBaocao;
    }
}