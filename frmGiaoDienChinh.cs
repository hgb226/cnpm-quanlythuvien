

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
        }

        private void quánLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLDocGia QLDocGia = new frmQLDocGia();
            QLDocGia.Show();
        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLMuonTra QLMuonTra = new frmQLMuonTra();
            QLMuonTra.Show();
        }

        private void phiếuThuTiềnPhạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuthutienphat TienPhat = new frmPhieuthutienphat();
            TienPhat.Show();
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoThongKe BaoCao = new frmBaoCaoThongKe();
            BaoCao.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau MatKhau = new frmDoiMatKhau();
            MatKhau.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngKýThủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangKyTT frmDangKyTT = new frmDangKyTT();
            frmDangKyTT.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmThayDoiThamSo frmThayDoiThamSo = new frmThayDoiThamSo();
            frmThayDoiThamSo.Show();
        }
    }
}
