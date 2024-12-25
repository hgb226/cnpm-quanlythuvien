

namespace qltv
{
    public partial class frmGiaoDienChinh : Form
    {
        public frmGiaoDienChinh()
        {
            InitializeComponent();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLSach QLSach = new frmQLSach();
            QLSach.Show();
            this.Hide();
        }

        private void quánLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLDocGia QLDocGia  = new frmQLDocGia();
            QLDocGia.Show();
            this.Hide();
        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLMuonTra QLMuonTra  = new frmQLMuonTra();
            QLMuonTra.Show();
            this.Hide();
        }

        private void phiếuThuTiềnPhạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuthutienphat TienPhat = new frmPhieuthutienphat();
            TienPhat.Show();
            this.Hide();
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoThongKe BaoCao = new frmBaoCaoThongKe();
            BaoCao.Show();
            this.Hide();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau MatKhau = new frmDoiMatKhau();
            MatKhau.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
