using System.Configuration;
using System.Data.SqlClient;

namespace qltv
{
    public partial class frmDoiMKDG : Form
    {
        public frmDoiMKDG(string TenDangNhap)
        {
            InitializeComponent();
            TenDangNhapString = TenDangNhap;
        }
        public string TenDangNhapString = "";

        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (!KiemTraInput())
                return;

            if (!txtMatKhauMoi.Text.Equals(txtNhapLaiMKMoi.Text))
            {
                MessageBox.Show("Mật khẩu mới không khớp nhau.", "Thông báo");
                XoaTxtNhapMatKhauMoi();
                return;
            }

            try
            {
                using (var connection = new SqlConnection(chuoiKetNoi))
                {
                    connection.Open();
                    if (KiemTraUser(connection))
                    {
                        CapNhatMatKhau(connection);
                        MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo");
                        XoaTatCaTxt();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.\nVui lòng nhập lại.", "Thông báo");
                        XoaTatCaTxt();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool KiemTraInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenTaiKhoan.Text))
            {
                ShowThongBao("Bạn chưa nhập tên tài khoản.", txtTenTaiKhoan);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                ShowThongBao("Bạn chưa nhập mật khẩu.", txtMatKhau);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhauMoi.Text))
            {
                ShowThongBao("Bạn chưa nhập mật khẩu mới.", txtMatKhauMoi);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNhapLaiMKMoi.Text))
            {
                ShowThongBao("Bạn chưa nhập lại mật khẩu mới.", txtNhapLaiMKMoi);
                return false;
            }
            return true;
        }

        private void ShowThongBao(string message, Control control)
        {
            MessageBox.Show(message, "Thông Báo");
            control.Focus();
        }

        private bool KiemTraUser(SqlConnection connection)
        {
            const string query = "SELECT COUNT(*) FROM tblDocGia WHERE TenTaiKhoanDG = @acc AND MatKhauDG = @pass";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@acc", txtTenTaiKhoan.Text);
                command.Parameters.AddWithValue("@pass", txtMatKhau.Text);
                return (int)command.ExecuteScalar() == 1;
            }
        }

        private void CapNhatMatKhau(SqlConnection connection)
        {
            const string query = "UPDATE tblDocGia SET MatKhauDG = @newPass WHERE TenTaiKhoanDG = @acc";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@newPass", txtMatKhauMoi.Text);
                command.Parameters.AddWithValue("@acc", txtTenTaiKhoan.Text);
                command.ExecuteNonQuery();
            }
        }

        private void XoaTxtNhapMatKhauMoi()
        {
            txtMatKhauMoi.Clear();
            txtNhapLaiMKMoi.Clear();
            txtMatKhauMoi.Focus();
        }

        private void XoaTatCaTxt()
        {
            txtTenTaiKhoan.Clear();
            txtMatKhau.Clear();
            txtMatKhauMoi.Clear();
            txtNhapLaiMKMoi.Clear();
            txtTenTaiKhoan.Focus();
        }

        private void chkMatKhauCu_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chkMatKhauCu.Checked ? '\0' : '*';
        }

        private void chkMatKhauMoi_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauMoi.PasswordChar = chkMatKhauMoi.Checked ? '\0' : '*';
        }

        private void chkNhapLaiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapLaiMKMoi.PasswordChar = chkNhapLaiMatKhau.Checked ? '\0' : '*';
        }

        private void btnThoat_Click(object sender, EventArgs e) => Close();

        private void frmDoiMKDG_Load(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Text = TenDangNhapString;
            txtTenTaiKhoan.Enabled = false;
        }
    }
}
