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


        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtSotienthu.Text) != Convert.ToInt32(txtTongno.Text) ){
                if (Convert.ToInt32(txtSotienthu.Text) < Convert.ToInt32(txtTongno.Text))
                {
                    MessageBox.Show("Tiền thu nhỏ hơn tiền nợ!");
                    return;
                }
                else
                {
                    MessageBox.Show("Tiền thu lớn hơn tiền nợ!");
                    return;
                }
            }
            this.Print_PhieuThu();
        }
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
                return;
            }
            string query = "set dateformat dmy; select * from tblHSPhieuMuon where MaDG = '" + txtMaDG.Text + "'";
            DataTable temp = ketnoi(query);
            if (temp.Rows.Count == 0)
            {
                txtHotenDG.Text = "";
                txtTongno.Text = "";
                return;
            }
            int cnt = 0;
            int tongngay = 0;
            foreach (DataRow row in temp.Rows)
            {
                TimeSpan dif = DateTime.Now - Convert.ToDateTime(row["NgayTra"].ToString());
                if (dif.Days > 0)
                {
                    tongngay += dif.Days;
                    cnt += (int)row[5];
                }
            }

            query = "select TenDG from tblDocGia where MaDG = '" + txtMaDG.Text + "'";
            ketnoi(query);
            txtHotenDG.Text = myCommand.ExecuteScalar().ToString();
            query = "select GiaTri from thamso where TenTS = 'TienPhat'";
            ketnoi(query);
            int tp = (int)myCommand.ExecuteScalar();
            txtTongno.Text = (cnt * tongngay * tp).ToString();
        }

        private void txtSotienthu_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSotienthu.Text == "")
            {
                txtConlai.Text = "";
                return;
            }
            int tienthu = Convert.ToInt32(txtSotienthu.Text);
            txtConlai.Text = (tienthu - Convert.ToInt32(txtTongno.Text)).ToString();
        }

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


    }
}
