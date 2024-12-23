using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qltv
{
    public partial class frmQLMuonTra : Form
    {
        public frmQLMuonTra()
        {
            InitializeComponent();
        }
        // Khai báo
        string strKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlDataAdapter myDataAdapter;
        private SqlCommand myCommand;
        private DataTable myTable;
        private DataTable myTableSach;
        private DataTable myTableDG;
        private SqlDataReader myDataReaderSach;
        private SqlDataReader myDataReaderSLSachDaMuon;
        // Kết nối tới sql
        private DataTable ketnoi(string truyvan)
        {
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            dataGridViewDSMuon0.DataSource = myTable;
            return myTable;
        }

        // Kết nối tới tblSach
        private DataTable ketnoitblSach(string truyvan)
        {
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTableSach = new DataTable();
            myDataAdapter.Fill(myTableSach);
            return myTableSach;
        }
        private DataTable ketnoitblDocGia(string truyvan)
        {
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTableDG = new DataTable();
            myDataAdapter.Fill(myTableDG);
            return myTableDG;
        }
        private void setControlsMuon(bool edit)
        {
            cboMaDG0.Enabled = edit;
            cboMaSach0.Enabled = edit;
            txtSLMuon0.Enabled = edit;
            txtGhiChu0.Enabled = edit;
            dtmNgayTra0.Enabled = edit;
            dtmNgayMuon0.Enabled = edit;
            cboTinhTrang0.Enabled = edit;
        }
        private void setControlsTra(bool edit)
        {
            txtMaPhieu1.Enabled = edit;
            txtMaDG1.Enabled = edit;
            txtMaSach1.Enabled = edit;
            txtSLMuon1.Enabled = edit;
            dtmNgayMuon1.Enabled = edit;
            dtmNgayTra1.Enabled = edit;
            txtGhiChu1.Enabled = edit;
            txtTinhTrang1.Enabled = edit;
        }

        private void frmQLMuonTra_Load_1(object sender, EventArgs e)
        {
            string cauTruyVan = "select * from tblHSPhieuMuon";
            dataGridViewDSMuon0.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSMuon0.AutoGenerateColumns = false;

            dataGridViewDSMuon1.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSMuon1.AutoGenerateColumns = false;
            myConnection.Close();

            radMaDG.Checked = true;
            radMaDG1.Checked = true;

            btnChoMuon0.Text = "Cho Mượn";
            btnChoMuon0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnChoMuon0.Enabled = false;
            btnHuy0.Enabled = false;
            txtMaPhieu0.Enabled = false;

            txtTTMaSach.Enabled = false;
            txtTTTenSach.Enabled = false;
            txtTTSLCon.Enabled = false;
            txtTTTenTG.Enabled = false;

            setControlsMuon(false);
            setControlsTra(false);
        }

        private void btnLoadDanhSach0_Click(object sender, EventArgs e)
        {
            txtNDTimKiem.Text = "";
            btnNhap.Enabled = true;
            btnChoMuon0.Enabled = false;
            btnHuy0.Enabled = false;
            setControlsMuon(false);

            string cauTruyVanLoad = "select * from tblHSPhieuMuon";
            dataGridViewDSMuon0.DataSource = ketnoi(cauTruyVanLoad);
            dataGridViewDSMuon0.AutoGenerateColumns = false;
            myConnection.Close();
        }

        private void btnLoadDS1_Click_1(object sender, EventArgs e)
        {
            string cauTruyVan = "select * from tblHSPhieuMuon";
            dataGridViewDSMuon1.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSMuon1.AutoGenerateColumns = false;
            myConnection.Close();
        }
    }
}
