using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qltv
{
    public partial class frmQLDocGia : Form
    {
        public frmQLDocGia()
        {
            InitializeComponent();
        }

        // Khai báo 
        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection; // kết nối tới csdl
        private SqlDataAdapter myDataAdapter;   // Vận chuyển csdl qa DataSet
        private DataTable myTable;  // Dùng để lưu bảng lấy từ c#
        private SqlCommand myCommand;   // Thực hiện cách lệnh truy vấn

        // Phương thức kết nối
        private DataTable ketnoi(string truyvan)
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();

            myCommand = new SqlCommand(truyvan, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);

            myTable = new DataTable();
            myDataAdapter.Fill(myTable);

            return myTable;
        }

        private void setControls(bool edit)
        {
            txtTenDG.Enabled = edit;
            dtmNgaySinh.Enabled = edit;
            cboGioiTinh.Enabled = edit;
            txtDiaChi.Enabled = edit;
            txtEmail.Enabled = edit;
            txtTenTK.Enabled = edit;
            txtMK.Enabled = edit;
            txtGhiChu.Enabled = edit;
            cboLoaiDG.Enabled = edit;
            dtmNgLapThe.Enabled = edit;
        }

        // Load
        private void frmQLDocGia_Load(object sender, EventArgs e)
        {
            string cauTruyVan = "select * from tblDocGia";
            dataGridViewDSDocGia.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSDocGia.AutoGenerateColumns = false;

            myConnection.Close();

            setControls(true);
            dataGridViewDSDocGia.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaDG.Enabled = false;

        }

        public string maDG, tenDG, gioiTinhDG, ngaySinhDG, diaChiDG, emailDG, loaiDG, ghiChu, tenTK, mK, NgLapThe;
        private void dataGridViewDSDocGia_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                DataRow currentRow = myTable.Rows[row]; // Lấy hàng hiện tại để giảm truy vấn lặp lại

                // Gán giá trị từ DataRow
                txtMaDG.Text = maDG = currentRow["MaDG"].ToString();
                txtTenDG.Text = tenDG = currentRow["TenDG"].ToString();
                cboGioiTinh.Text = gioiTinhDG = currentRow["GioiTinhDG"].ToString();
                dtmNgaySinh.Text = ngaySinhDG = Convert.ToDateTime(currentRow["NgaySinhDG"]).ToString("yyyy-MM-dd");
                txtEmail.Text = emailDG = currentRow["EmailDG"].ToString();
                txtDiaChi.Text = diaChiDG = currentRow["DiaChiDG"].ToString();
                cboLoaiDG.Text = loaiDG = currentRow["LoaiDG"].ToString();
                txtGhiChu.Text = ghiChu = currentRow["GhiChu"].ToString();
                txtTenTK.Text = tenTK = currentRow["TenTaiKhoanDG"].ToString();
                txtMK.Text = mK = currentRow["MatKhauDG"].ToString();
                dtmNgLapThe.Text = NgLapThe = Convert.ToDateTime(currentRow["NgLapThe"]).ToString("yyyy-MM-dd");
            }
            catch
            {

            }
        }

        private void dataGridViewDSDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDG.Text = dataGridViewDSDocGia.CurrentRow.Cells[0].Value.ToString();
            txtTenDG.Text = dataGridViewDSDocGia.CurrentRow.Cells[1].Value.ToString();
            cboGioiTinh.Text = dataGridViewDSDocGia.CurrentRow.Cells[2].Value.ToString();
            dtmNgaySinh.Text = dataGridViewDSDocGia.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dataGridViewDSDocGia.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dataGridViewDSDocGia.CurrentRow.Cells[5].Value.ToString();
            cboLoaiDG.Text = dataGridViewDSDocGia.CurrentRow.Cells[6].Value.ToString();
            txtGhiChu.Text = dataGridViewDSDocGia.CurrentRow.Cells[7].Value.ToString();
            txtTenTK.Text = dataGridViewDSDocGia.CurrentRow.Cells[8].Value.ToString();
            txtMK.Text = dataGridViewDSDocGia.CurrentRow.Cells[9].Value.ToString();
            dtmNgLapThe.Text = dataGridViewDSDocGia.CurrentRow.Cells[10].Value.ToString();
        }

        // Biến kiểm tra
        struct ValidationRule
        {
            public Control Control;       // Đối tượng Control cần kiểm tra
            public ErrorProvider Error;   // ErrorProvider tương ứng
            public string ErrorMessage;   // Thông báo lỗi

            public ValidationRule(Control control, ErrorProvider error, string errorMessage)
            {
                Control = control;
                Error = error;
                ErrorMessage = errorMessage;
            }
        }

        // Phương thức xử lý tương ứng
        public int xuly;

        // Phương thức tăng mã DG tự động
        public string setMaDG()
        {
            string cauTruyVan = "SELECT COUNT(*) AS row_count FROM tblDocGia;";
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();

            myCommand = new SqlCommand(cauTruyVan, myConnection);
            int rowCount = (int)myCommand.ExecuteScalar();

            myConnection.Close();
            string maTuDong = "";
            if (rowCount <= 0)
            {
                maTuDong = "DG001";
            }
            else
            {
                maTuDong = "DG";
                rowCount++;
                maTuDong += rowCount.ToString("D3");
            }
            return maTuDong;
        }

        // Thêm đọc giả
        private void btnThem_Click(object sender, EventArgs e)
        {
            setControls(true);
            txtMaDG.Text = setMaDG();
            txtTenDG.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            cboGioiTinh.Text = "";
            dtmNgaySinh.Text = "";
            cboLoaiDG.Text = "";
            txtGhiChu.Text = "";
            txtTenTK.Text = txtMaDG.Text;
            txtTenTK.Enabled = false;
            txtMK.Text = "";
            dtmNgLapThe.Text = "";
            txtTenDG.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            xuly = 0;
            dataGridViewDSDocGia.Enabled = false;
        }
        private void themDG()
        {

            try
            {
                string query = "set dateformat dmy; insert into tblDocGia values ('" + txtMaDG.Text + "','" + txtTenDG.Text + "', N'" + gioiTinhDG + "',N'" + dtmNgaySinh.Text + "',N'" + txtEmail.Text + "',N'" + txtDiaChi.Text + "','" + loaiDG + "','" + txtGhiChu.Text + "','" + txtTenTK.Text + "',N'" + txtMK.Text + "',N'" + dtmNgLapThe.Text + "')";
                ketnoi(query);
                MessageBox.Show("Thêm thành công.", "Thông Báo");
                myConnection.Close();
            }
            catch (Exception)
            {

            }
        }

        // Sủa thông tin đọc giả 
        private void btnSua_Click(object sender, EventArgs e)
        {
            setControls(true);
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            txtTenDG.Focus();
            //dataGridViewDSDocGia.Enabled = false;
            //txtTenTK.Enabled = false;
            xuly = 1;
        }

        // Xóa đọc giả 
        private void xoaDG()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongsql = "delete from tblDocGia where MaDG='" + txtMaDG.Text + "'";
                    ketnoi(xoadongsql);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông Báo");
                    //btnXoa.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại.\nĐộc Giả này đang mượn sách.", "Thông Báo");
                }
            }
            string cauTruyVan = "select * from tblDocGia";
            dataGridViewDSDocGia.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSDocGia.AutoGenerateColumns = false;
            myConnection.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaDG();
        }

        // Hàm kiểm tra Input
        private bool ValidateInputs()
        {
            // Danh sách các quy tắc kiểm tra
            var rules = new List<ValidationRule>
            {
                new ValidationRule(txtTenDG, errTenDG, "Vui lòng nhập Tên DG"),
                new ValidationRule(txtEmail, errEmail, "Vui lòng nhập Email"),
                new ValidationRule(txtDiaChi, errDC, "Vui lòng nhập Địa chỉ"),
                new ValidationRule(txtTenTK, errTenTK, "Vui lòng nhập Tên TK"),
                new ValidationRule(txtMK, errMK, "Vui lòng nhập MK"),
                new ValidationRule(cboGioiTinh, errGT, "Vui lòng chọn Giới Tính"),
                new ValidationRule(cboLoaiDG, errLoaiDG, "Vui lòng nhập Loại ĐG")
            };

            bool isValid = true;

            // Duyệt qua từng quy tắc và kiểm tra dữ liệu
            foreach (var rule in rules)
            {
                if (string.IsNullOrWhiteSpace(rule.Control.Text))
                {
                    rule.Error.SetError(rule.Control, rule.ErrorMessage);
                    isValid = false;
                }
                else rule.Error.Clear();

            }

            return isValid;
        }

        // Hàm kiểm tra tuổi hợp lệ
        private bool IsValidAge(DateTime birthDate)
        {
            int tuoiMin = GetThamSo("SoTuoiDGMin");
            int tuoiMax = GetThamSo("SoTuoiDGMax");

            int age = DateTime.Now.Year - birthDate.Year;
            if (birthDate > DateTime.Now.AddYears(-age)) age--;

            return age >= tuoiMin && age <= tuoiMax;
        }

        // Hàm lấy giá trị tham số từ bảng ThamSo
        private int GetThamSo(string tenThamSo)
        {
            string query = $"SELECT giatri FROM ThamSo WHERE Tents = '{tenThamSo}'";
            ketnoi(query);
            return Convert.ToInt32(myCommand.ExecuteScalar());
        }

        // Hàm cập nhật DataGridView
        private void LoadDataGridView()
        {
            string query = "SELECT * FROM tblDocGia";
            dataGridViewDSDocGia.DataSource = ketnoi(query);
            dataGridViewDSDocGia.AutoGenerateColumns = false;
            myConnection.Close();
        }

        // Hàm đặt lại trạng thái điều khiển
        private void ResetControls()
        {
            txtMaDG.Text = setMaDG();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            setControls(false);
            dataGridViewDSDocGia.Enabled = true;
        }

        // xử lý dành cho nút lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào 
            bool isValid = ValidateInputs();
            if (!isValid) return; // Dừng nếu dữ liệu không hợp lệ

            // Kiểm tra tuổi hợp lệ
            if (!IsValidAge(dtmNgaySinh.Value))
            {
                MessageBox.Show("Số tuổi không hợp lệ!", "Thông Báo");
                return;
            }

            // Xử lý thêm hoặc sửa dữ liệu
            try
            {
                if (xuly == 0) themDG(); // Thêm mới
                else if (xuly == 1) // Cập nhật
                {
                    string query = " set dateformat dmy;"
                                   + " update tblDocGia set TenDG=N'" + txtTenDG.Text
                                   + "',GioiTinhDG=N'" + gioiTinhDG
                                   + "',NgaySinhDG='" + dtmNgaySinh.Text
                                   + "',EmailDG='" + txtEmail.Text
                                   + "',DiaChiDG='" + txtDiaChi.Text
                                   + "',LoaiDG='" + loaiDG
                                   + "',GhiChu=N'" + txtGhiChu.Text
                                   + "',MatKhauDG=N'" + txtMK.Text
                                   + "' where MaDG='" + txtMaDG.Text + "'";

                    ketnoi(query);
                    myCommand.ExecuteNonQuery();

                    MessageBox.Show("Sửa thành công.", "Thông Báo");
                }

                // Cập nhật DataGridView
                LoadDataGridView();
                ResetControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xử lý dữ liệu: {ex.Message}", "Thông Báo");
            }
        }

        // Xử lý dành cho nút hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            setControls(false);
            dataGridViewDSDocGia.Enabled = true;
            errMK.Clear();
            errEmail.Clear();
            errTenTK.Clear();
            errTenDG.Clear();
            errDC.Clear();
            errLoaiDG.Clear();
            errGT.Clear();
        }

        // Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Tìm kiếm 
        private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            //btnSua.Enabled = false;
            if (radMaDG.Checked)
            {
                string timkiem = "select * from tblDocGia where MaDG like '%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiem);
                myCommand.ExecuteNonQuery();
                dataGridViewDSDocGia.DataSource = ketnoi(timkiem);
                dataGridViewDSDocGia.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenDG.Checked)
            {
                string timkiem = "select * from tblDocGia where TenDG like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiem);
                myCommand.ExecuteNonQuery();
                dataGridViewDSDocGia.DataSource = ketnoi(timkiem);
                dataGridViewDSDocGia.AutoGenerateColumns = false;
                myConnection.Close();
            }
        }

        // Phương thức nút Load DS
        private void btnLoadDS_Click(object sender, EventArgs e)
        {
            lblNhapTenDG.Text = "";
            lblNhapNgaySinh.Text = "";
            lblNhapGioiTinh.Text = "";
            lblNhapSDT.Text = "";
            lblNhapDiaChi.Text = "";
            setControls(false);
            txtNDTimKiem.Text = "";
            string cauTruyVan = "select * from tblDocGia";
            dataGridViewDSDocGia.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSDocGia.AutoGenerateColumns = false;
            myConnection.Close();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }


    }
}
