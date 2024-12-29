using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing.Printing; // Để sử dụng PrintDocument


namespace qltv
{
    public partial class frmPhieuthutienphat : Form
    {
        public frmPhieuthutienphat()
        {
            InitializeComponent();
        }
        string strKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlDataAdapter myDataAdapter;
        private SqlCommand myCommand;
        private DataTable myTable;



        private DataTable ketnoi(string truyvan)
        {
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            return myTable;
        }


        Bitmap bitmap;
        private readonly object printDocument1;
        private readonly object printPreviewDialog1;



        private void Print_PhieuThu()
        {
            // Khởi tạo PrintDocument
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.DefaultPageSettings.Landscape = false;
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("custom", 970, 234);

            // Đăng ký sự kiện PrintPage
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            // Khởi tạo PrintPreviewDialog
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;

            // Hiển thị Print Preview
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                // In tài liệu
                printDocument1.Print();
            }
        }

        private void txtMaDG_TextChanged_1(object sender, EventArgs e)
        {
            if (txtMaDG.Text == "")
            {
                txtHotenDG.Text = "";
                txtTongno.Text = "";
                txtSotienthu.Text = "";
                return;
            }

            // Lấy tên độc giả từ bảng tblDocGia
            string query = "select TenDG from tblDocGia where MaDG = '" + txtMaDG.Text + "'";
            ketnoi(query);
            var result = myCommand.ExecuteScalar();

            if (result != null)
            {
                txtHotenDG.Text = result.ToString();
            }
            else
            {
                txtHotenDG.Text = "Không tìm thấy độc giả";
            }

            // Lấy tổng nợ từ bảng tblDocGia
            query = "select TongNo from tblDocGia where MaDG = '" + txtMaDG.Text + "'";
            DataTable dtTongNo = ketnoi(query);
            if (dtTongNo.Rows.Count > 0)
            {
                txtTongno.Text = dtTongNo.Rows[0]["TongNo"].ToString();
            }
            else
            {
                txtTongno.Text = "0";
            }

            if (int.TryParse(txtTongno.Text, out int tongno))
            {
                txtSotienthu.Text = tongno.ToString();
                txtConlai.Text = "0"; // Số tiền còn lại luôn là 0
            }
            else
            {
                txtTongno.Text = ""; // Xóa giá trị nếu nhập sai
                txtSotienthu.Text = "";
                txtConlai.Text = "";
            }
        }

        //private void txtSotienthu_TextChanged_1(object sender, EventArgs e)
        //{
        ////    if (string.IsNullOrEmpty(txtTongno.Text))
        ////    {
        ////        txtSotienthu.Text = "";
        ////        txtConlai.Text = "";
        ////        return;
        ////    }

        ////    // Chỉ gán giá trị nếu tổng nợ là số hợp lệ
        ////    if (int.TryParse(txtTongno.Text, out int tongno))
        ////    {
        ////        txtSotienthu.Text = tongno.ToString();
        ////        txtConlai.Text = "0"; // Số tiền còn lại luôn là 0
        ////    }
        ////    else
        ////    {
        ////        txtTongno.Text = ""; // Xóa giá trị nếu nhập sai
        ////        txtSotienthu.Text = "";
        ////        txtConlai.Text = "";
        ////    }
        //}


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(bitmap, 0, 0);
            e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle(12, 9, 926, 50));
            e.Graphics.DrawString("PHIẾU THU TIỀN PHẠT", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(376, 26));
            e.Graphics.DrawString("Mã đọc giả: " + this.txtMaDG.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(32, 86));
            e.Graphics.DrawString("Họ tên độc giả: " + this.txtHotenDG.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(533, 86));
            e.Graphics.DrawString("Tổng nợ: " + this.txtTongno.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(32, 124));
            e.Graphics.DrawString("Tiền thu: " + this.txtSotienthu.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(533, 124));
            e.Graphics.DrawString("Còn lại: " + txtConlai.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(533, 170));
        }
        private void CapNhatTongNoSauKhiThuTien(string maDG, int tienthu)
        {
            // Lấy tổng nợ hiện tại từ cơ sở dữ liệu
            string query = "select TongNo from tblDocGia where MaDG = '" + maDG + "'";
            DataTable dtTongNo = ketnoi(query);
            int tongno = 0;

            if (dtTongNo.Rows.Count > 0)
            {
                tongno = Convert.ToInt32(dtTongNo.Rows[0]["TongNo"]);
            }

            // Tính số tiền còn lại
            int conlai = tongno - tienthu;

            // Cập nhật lại tổng nợ vào cơ sở dữ liệu
            query = "UPDATE tblDocGia SET TongNo = " + conlai + " WHERE MaDG = '" + maDG + "'";
            ketnoi(query);

            // Cập nhật lại giao diện người dùng
            txtTongno.Text = conlai.ToString();
            txtSotienthu.Text = " ";
            txtConlai.Text = " "; // Số tiền còn lại sau khi thu đã được hiển thị ở `txtTongno`
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng nhập số tiền thu hợp lệ
            if (string.IsNullOrEmpty(txtSotienthu.Text) || string.IsNullOrEmpty(txtMaDG.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy số tiền thu và cập nhật tổng nợ
                int tienthu = Convert.ToInt32(txtSotienthu.Text);

                // Tiến hành in phiếu thu
                this.Print_PhieuThu();

                // Cập nhật tổng nợ vào cơ sở dữ liệu
                CapNhatTongNoSauKhiThuTien(txtMaDG.Text, tienthu);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Gọi hàm in phiếu thu (giả sử hàm này đã được định nghĩa)

        }


    }
}
