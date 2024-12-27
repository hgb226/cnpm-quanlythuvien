namespace qltv
{
    partial class frmPhieuthutienphat
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
            txtMaDG = new TextBox();
            txtHotenDG = new TextBox();
            txtTongno = new TextBox();
            txtSotienthu = new TextBox();
            txtConlai = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnPrint = new Button();
            SuspendLayout();
            // 
            // txtMaDG
            // 
            txtMaDG.BorderStyle = BorderStyle.FixedSingle;
            txtMaDG.Location = new Point(402, 85);
            txtMaDG.Margin = new Padding(3, 4, 3, 4);
            txtMaDG.Name = "txtMaDG";
            txtMaDG.Size = new Size(339, 27);
            txtMaDG.TabIndex = 0;
            txtMaDG.TextChanged += txtMaDG_TextChanged_1;
            // 
            // txtHotenDG
            // 
            txtHotenDG.BorderStyle = BorderStyle.FixedSingle;
            txtHotenDG.Enabled = false;
            txtHotenDG.Location = new Point(402, 188);
            txtHotenDG.Margin = new Padding(3, 4, 3, 4);
            txtHotenDG.Name = "txtHotenDG";
            txtHotenDG.Size = new Size(339, 27);
            txtHotenDG.TabIndex = 1;
            // 
            // txtTongno
            // 
            txtTongno.BorderStyle = BorderStyle.FixedSingle;
            txtTongno.Enabled = false;
            txtTongno.Location = new Point(402, 315);
            txtTongno.Margin = new Padding(3, 4, 3, 4);
            txtTongno.Name = "txtTongno";
            txtTongno.Size = new Size(339, 27);
            txtTongno.TabIndex = 2;
            // 
            // txtSotienthu
            // 
            txtSotienthu.BorderStyle = BorderStyle.FixedSingle;
            txtSotienthu.Location = new Point(402, 419);
            txtSotienthu.Margin = new Padding(3, 4, 3, 4);
            txtSotienthu.Name = "txtSotienthu";
            txtSotienthu.Size = new Size(339, 27);
            txtSotienthu.TabIndex = 3;
            txtSotienthu.TextChanged += txtSotienthu_TextChanged_1;
            // 
            // txtConlai
            // 
            txtConlai.BorderStyle = BorderStyle.FixedSingle;
            txtConlai.Enabled = false;
            txtConlai.Location = new Point(402, 531);
            txtConlai.Margin = new Padding(3, 4, 3, 4);
            txtConlai.Name = "txtConlai";
            txtConlai.Size = new Size(339, 27);
            txtConlai.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 85);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã Độc Giả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 188);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 6;
            label2.Text = "Họ và Tên Độc Giả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 315);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 7;
            label3.Text = "Tổng nợ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 429);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 8;
            label4.Text = "Số tiền thu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 535);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 9;
            label5.Text = "Còn lại";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(795, 471);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(86, 63);
            btnPrint.TabIndex = 10;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // frmPhieuthutienphat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(914, 600);
            Controls.Add(btnPrint);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConlai);
            Controls.Add(txtSotienthu);
            Controls.Add(txtTongno);
            Controls.Add(txtHotenDG);
            Controls.Add(txtMaDG);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPhieuthutienphat";
            Text = "Phiếu thu tiền phạt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaDG;
        private TextBox txtHotenDG;
        private TextBox txtTongno;
        private TextBox txtSotienthu;
        private TextBox txtConlai;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnPrint;
    }
}