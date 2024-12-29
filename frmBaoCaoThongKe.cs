using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace qltv
{
    public partial class frmBaoCaoThongKe : Form
    {
        public frmBaoCaoThongKe()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frmBaoCaoThongKe_Load);

        }
        string strKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlCommand myCommand;
        private SqlDataAdapter myDataAdapter;
        private DataTable myTable;


        private SqlDataReader myDataReaderSLDauSach;
        private SqlDataReader myDataReaderSLMuon;
        private SqlDataReader myDataReaderSLDG;
        private SqlDataReader myDataReaderSLDGMuon;
        private SqlDataReader myDataReaderSLSQuaHan;
        private SqlDataReader myDataReaderSLDGQuaHan;


        private DataTable ketnoi(string truyvan)
        {
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            dataGridViewDSDGQuaHan.DataSource = myTable;
            return myTable;
        }



        public string luuSLDauSach, luuSLCuon, luuTongGiaTriSach;
        // Tính SL Đầu Sách, SL Cuốn, SL Còn, Tổng GT Sách
        private void slDauSach()
        {
            string strTinhSLDauSach = "select count(MaSach) as TongSLDauSach, sum(SLNhap) as TongSLSach, sum(TriGia) as TongGiaTriSach from tblSach";
            try
            {
                myConnection = new SqlConnection(strKetNoi);
                myConnection.Open();
                myCommand = new SqlCommand(strTinhSLDauSach, myConnection);
                myDataReaderSLDauSach = myCommand.ExecuteReader();

                if (myDataReaderSLDauSach.HasRows)
                {
                    while (myDataReaderSLDauSach.Read())
                    {
                        luuSLDauSach = myDataReaderSLDauSach.GetInt32(0).ToString();
                        luuSLCuon = myDataReaderSLDauSach.GetInt32(1).ToString();
                        luuTongGiaTriSach = myDataReaderSLDauSach.GetInt32(2).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu đầu sách!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (myConnection != null && myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }
            }

        }

        // Tính SL Mượn
        public string luuSLMuon;
        private void slMuon()
        {
            string strTinhSLMuon = "select sum(SLMuon) as Tong from tblHSPhieuMuon";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            myCommand = new SqlCommand(strTinhSLMuon, myConnection);
            myDataReaderSLMuon = myCommand.ExecuteReader();
            while (myDataReaderSLMuon.Read())
            {
                luuSLMuon = myDataReaderSLMuon.GetInt32(0).ToString();
            }

        }

        // Tính SL Độc Giả
        public string luuSLDG;
        private void slDocGia()
        {
            string strTinhSLMuon = "select count(MaDG) as TongSLDG from tblDocGia";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            myCommand = new SqlCommand(strTinhSLMuon, myConnection);
            myDataReaderSLDG = myCommand.ExecuteReader();
            while (myDataReaderSLDG.Read())
            {
                luuSLDG = myDataReaderSLDG.GetInt32(0).ToString();
            }
        }

        // Tính SLDG Đã Mượn sách
        public string luuSLDGMuon;
        private void slDocGiaMuon()
        {
            string strTinhSLMuon = "select (count(distinct(MaDG))) as TongSLDGMuon from tblHSPhieuMuon";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            myCommand = new SqlCommand(strTinhSLMuon, myConnection);
            myDataReaderSLDGMuon = myCommand.ExecuteReader();
            while (myDataReaderSLDGMuon.Read())
            {
                luuSLDGMuon = myDataReaderSLDGMuon.GetInt32(0).ToString();
            }
        }

        //SL sách quá hạn
        //public string luuSLSQuaHan;
        //private void slSachQuaHan()
        //{
        //    string strTinhSLSachQuaHan = "SELECT count(SLMuon) as TongSLQuaHan from tblHSPhieuMuon where CONVERT (datetime, NgayTra, 103) < getdate()";
        //    myConnection = new SqlConnection(strKetNoi);
        //    myConnection.Open();
        //    myCommand = new SqlCommand(strTinhSLSachQuaHan, myConnection);
        //    myDataReaderSLSQuaHan = myCommand.ExecuteReader();
        //    while (myDataReaderSLSQuaHan.Read())
        //    {
        //        luuSLSQuaHan = myDataReaderSLSQuaHan.GetInt32(0).ToString();
        //    }

        //}

        // SL Độc Giả quá hạn
        public string luuSLDGQuaHan;
        private void slDGQuaHan()
        {
            // Điều chỉnh câu lệnh SQL để kiểm tra số ngày trả trễ
            string strTinhSLDGQuaHan = @"
            SELECT COUNT(DISTINCT MaDG) AS TongSLQuaHan
            FROM tblHSPhieuMuon
            WHERE DATEDIFF(DAY, CONVERT(DATETIME, NgayTra, 103), GETDATE()) > 0";

            // Kết nối cơ sở dữ liệu
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();

            myCommand = new SqlCommand(strTinhSLDGQuaHan, myConnection);
            myDataReaderSLDGQuaHan = myCommand.ExecuteReader();

            while (myDataReaderSLDGQuaHan.Read())
            {
                // Lưu lại số lượng độc giả vi phạm
                luuSLDGQuaHan = myDataReaderSLDGQuaHan.GetInt32(0).ToString();
            }

            // Đóng kết nối và DataReader
            myDataReaderSLDGQuaHan.Close();
            myConnection.Close();

        }

        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            txtSLDauSach.ReadOnly = true;
            txtSLCuon.ReadOnly = true;
            txtSLCon.ReadOnly = true;
            txtSLMuon.ReadOnly = true;
            txtTongGiaTriSach.ReadOnly = true;
            //txtSLSachQuaHan.ReadOnly = true;
            txtSLDGQuaHan.ReadOnly = true;
            txtSLDocGia.ReadOnly = true;
            txtSLDGMuon.ReadOnly = true;


            dataGridViewDSDGQuaHan.Hide();

            // Tổng SL Đầu sách, sl nhập, sl còn , tổng giá trị
            slDauSach();
            txtSLDauSach.Text = luuSLDauSach;
            txtSLCuon.Text = luuSLCuon;
            txtTongGiaTriSach.Text = luuTongGiaTriSach;

            // tổng sl mượn
            slMuon();
            txtSLMuon.Text = luuSLMuon;
            int luuSLCon = Convert.ToInt32(luuSLCuon) - Convert.ToInt32(luuSLMuon);
            txtSLCon.Text = luuSLCon.ToString();

            // tổng sl độc giả
            slDocGia();
            txtSLDocGia.Text = luuSLDG;

            // SL  độc giả đã mượn sahcs
            slDocGiaMuon();
            txtSLDGMuon.Text = luuSLDGMuon;


            // SL Sách quá hạn
            //slSachQuaHan();
            //txtSLSachQuaHan.Text = luuSLSQuaHan;

            //SL DG quá hạn
            slDGQuaHan();
            txtSLDGQuaHan.Text = luuSLDGQuaHan;
        }

        private void frmBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            dataGridViewDSDGQuaHan.Hide();
        }

        private void btnXemSLSachQuaHan_Click(object sender, EventArgs e)
        {
            dtpBaocao.Enabled = true;

            // Lấy giá trị ngày từ DateTimePicker
            DateTime selectedDate = dtpBaocao.Value.Date; // Chỉ lấy phần ngày, bỏ qua giờ

            // Tạo chuỗi truy vấn với điều kiện Ngày Mượn trùng với ngày đã chọn và Ngày hiện tại trừ ngày trả > 0
            string strTimSLSQuaHan = $@"
            SELECT 
            MaPhieu AS 'Mã Phiếu', 
            MaDG AS 'Mã DG', 
            MaSach AS 'Mã Sách', 
            NgayMuon AS 'Ngày Mượn', 
            NgayTra AS 'Ngày Trả', 
            DATEDIFF(day, CONVERT(datetime, NgayTra, 103), GETDATE()) AS 'Số Ngày Trả Trễ'
            FROM tblHSPhieuMuon
            WHERE CONVERT(datetime, NgayMuon, 103) = '{selectedDate:yyyy-MM-dd}'
            AND DATEDIFF(day, CONVERT(datetime, NgayTra, 103), GETDATE()) > 0";

            // Kết nối và hiển thị dữ liệu lên DataGridView
            dataGridViewDSDGQuaHan.DataSource = ketnoi(strTimSLSQuaHan);
            dataGridViewDSDGQuaHan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDSDGQuaHan.Show();
        }



        private void btnBaocao_Click(object sender, EventArgs e)
        {
            dtpBaocao.Enabled = true;

            // Truy vấn để lấy dữ liệu thống kê theo tháng
            string query = @"
            SELECT S.TheLoai AS [Thể loại],
               SUM(MT.SLMuon) AS [Số lượng mượn],
               FORMAT(SUM(MT.SLMuon) * 1.0 / SUM(S.SLNhap), '0.###') AS [Tỷ lệ]
            FROM tblSach S
            JOIN tblHSPhieuMuon MT ON S.MaSach = MT.MaSach
            WHERE MONTH(MT.NgayMuon) = " + dtpBaocao.Value.Month + @"
             AND YEAR(MT.NgayMuon) = " + dtpBaocao.Value.Year + @"
            GROUP BY S.TheLoai";

            // Thiết lập DataSource cho DataGridView
            dataGridViewDSDGQuaHan.DataSource = ketnoi(query);
            dataGridViewDSDGQuaHan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDSDGQuaHan.Show();
        }


        //private void btnSLDGQuaHan_Click(object sender, EventArgs e)
        //{
        //    dtpBaocao.Enabled = false;
        //    string strTimSLDGQuaHan = @"SELECT MaDG as 'Mã DG', sum(SLMuon) as 'SL Sách Mượn' from tblHSPhieuMuon where CONVERT (datetime, NgayTra, 103) <= getdate() group by MaDG";
        //    dataGridViewDSDGQuaHan.DataSource = ketnoi(strTimSLDGQuaHan);
        //    dataGridViewDSDGQuaHan.Columns["SL Sách Mượn"].Width = 440;
        //    dataGridViewDSDGQuaHan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dataGridViewDSDGQuaHan.Show();
        //}

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
