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

            setControls(false);
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

    }
}
