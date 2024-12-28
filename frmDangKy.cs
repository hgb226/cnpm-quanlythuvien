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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection; // kết nối tới csdl
        private SqlDataAdapter myDataAdapter;   // Vận chuyển csdl qa DataSet
        private DataTable myTable;  // Dùng để lưu bảng lấy từ c#
        SqlCommand myCommand;   // Thực hiện cách lệnh truy vấn

        // Phương thức kết nối
        private DataTable ketnoi(string truyvan)
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            dataGridViewDSTT.DataSource = myTable;
            return myTable;
        }

        public string tangMaTuDong()
        {
            string cauTruyVan = "select * from tblDocGia";
            dataGridViewDSTT.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSTT.AutoGenerateColumns = false;
            myConnection.Close();
            string maTuDong = "";
            if (myTable.Rows.Count <= 0)
            {
                maTuDong = "DG001";
            }
            else
            {
                int k;
                maTuDong = "DG";
                k = Convert.ToInt32(myTable.Rows[myTable.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                if (k < 10)
                {
                    maTuDong = maTuDong + "00";
                }
                else if (k < 100)
                {
                    maTuDong = maTuDong + "0";
                }
                maTuDong = maTuDong + k.ToString();
            }
            return maTuDong;
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            txtMaDG.Text = tangMaTuDong();
            txtTenTK.Text = txtMaDG.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Phương thức kiểm tra Đk
        private int kq = 1;

        private void kTraDK()
        {
            if (txtTenDG.Text == "")
            {
                errTenDG.SetError(txtTenDG, "Vui lòng nhập tên độc giả");
            }
            else
            {
                errTenDG.Clear();
            }

            if (txtEmail.Text == "")
            {
                errEmail.SetError(txtEmail, "Vui lòng nhập email");
            }
            else
            {
                errEmail.Clear();
            }

            if (txtDiaChi.Text == "")
            {
                errDC.SetError(txtDiaChi, "Vui lòng nhập địa chỉ");
            }
            else
            {
                errDC.Clear();
            }

            if (txtMK.Text == "")
            {
                errMK.SetError(txtMK, "Vui lòng nhập mật khẩu");
            }
            else
            {
                errMK.Clear();
            }

            if (cboGioiTinh.Text == "")
            {
                errGT.SetError(cboGioiTinh, "Vui lòng chọn giới tính");
            }
            else
            {
                errGT.Clear();
            }

            if (cbLoaiDG.Text == "")
            {
                errorLoaiDG.SetError(cbLoaiDG, "Vui lòng chọn loại độc giả");
            }
            else
            {
                errorLoaiDG.Clear();
            }
            string query = "select GiaTri from thamso where TenTS = 'SoTuoiDGMin'";
            ketnoi(query);
            int SoTuoiDGMin = Convert.ToInt32(myCommand.ExecuteScalar()); // Lấy giá trị tuổi độc giả MIN
            query = "select GiaTri from thamso where TenTS = 'SoTuoiDGMax'";
            ketnoi(query);
            int SoTuoiDGMax = Convert.ToInt32(myCommand.ExecuteScalar()); // Lấy giá trị tuổi độc giả MAX
            if (dtmNgaySinh.Text == "")
            {
                MessageBox.Show("Ngày tháng năm sinh không hợp lệ");
                return;
            }
            else
            {
                int TuoiDocGia = DateTime.Now.Year - dtmNgaySinh.Value.Year; // Lấy giá trị tuổi độc giả
                if (SoTuoiDGMin > TuoiDocGia || SoTuoiDGMax < TuoiDocGia)
                {
                    MessageBox.Show("Tuổi độc giả không phù hợp để tạo tài khoản");
                    return;
                }
                else
                {
                    string mk1, mk2;
                    mk1 = txtMK.Text;
                    mk2 = txtNhapLaiMK.Text;
                    kq = mk1.CompareTo(mk2);
                }
            }
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            kTraDK();
            if (txtMaDG.Text.Length > 0 && txtTenDG.Text.Length > 0 && txtDiaChi.Text.Length > 0 && dtmNgaySinh.Text.Length > 0 && cboGioiTinh.Text.Length > 0 && txtTenTK.Text.Length > 0 && txtMK.Text.Length > 0 && txtEmail.Text.Length > 0 && cbLoaiDG.Text.Length > 0)
            {
                if (kq == 0)
                {
                    try
                    {
                        string themdongsql = "set dateformat dmy; insert into tblDocGia values ('" + txtMaDG.Text + "',N'" + txtTenDG.Text + "',N'" + cboGioiTinh.Text + "','" + dtmNgaySinh.Text + "','" + txtEmail.Text + "',N'" + txtDiaChi.Text + "','" + cbLoaiDG.Text + "',N'" + txtGhiChu.Text + "','" + txtTenTK.Text + "','" + txtMK.Text + "', '" + dtmNgayLapThe.Text + "')";
                        ketnoi(themdongsql);
                        MessageBox.Show("Đăng ký thành công", "Thông Báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    this.Close();
                }
                else
                    MessageBox.Show("Vui lòng nhập lại mật khẩu", "Thông Báo");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo");
        }
    }
}
