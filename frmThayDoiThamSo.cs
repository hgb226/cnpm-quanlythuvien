using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qltv
{
    public partial class frmThayDoiThamSo : Form
    {
        public frmThayDoiThamSo()
        {
            InitializeComponent();
        }

        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlCommand myCommand;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thayDoiThamSo(string name, int value)
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            const string query = "UPDATE ThamSo SET GiaTri = @value WHERE TenTS = @name";
            using (var command = new SqlCommand(query, myConnection))
            {
                command.Parameters.Add("@value", SqlDbType.Int).Value = value;
                command.Parameters.AddWithValue("@name", name);
                command.ExecuteNonQuery();
            }
            myConnection.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int countErr = 0;
            for (int i = 0; i < txtTuoiDGMin.Text.Length; i++)
            {
                if ((txtTuoiDGMin.Text[i] < 48 || txtTuoiDGMin.Text[i] > 57) && txtTuoiDGMin.Enabled == true)
                {
                    countErr++;
                }
            }
            for (int i = 0; i < txtTuoiDGMax.Text.Length; i++)
            {
                if (txtTuoiDGMax.Text[i] < 48 || txtTuoiDGMax.Text[i] > 57 && txtTuoiDGMax.Enabled == true)
                {
                    countErr++;
                }
            }
            for (int i = 0; i < txtGiaTriThe.Text.Length; i++)
            {
                if (txtGiaTriThe.Text[i] < 48 || txtGiaTriThe.Text[i] > 57 && txtGiaTriThe.Enabled == true)
                {
                    countErr++;
                }
            }
            for (int i = 0; i < txtThoiGianXB.Text.Length; i++)
            {
                if (txtThoiGianXB.Text[i] < 48 || txtThoiGianXB.Text[i] > 57 && txtThoiGianXB.Enabled == true)
                {
                    countErr++;
                }
            }
            for (int i = 0; i < txtSoSachMuonMax.Text.Length; i++)
            {
                if (txtSoSachMuonMax.Text[i] < 48 || txtSoSachMuonMax.Text[i] > 57 && txtSoSachMuonMax.Enabled == true)
                {
                    countErr++;
                }
            }
            for (int i = 0; i < txtSoNgayMuonMax.Text.Length; i++)
            {
                if (txtSoNgayMuonMax.Text[i] < 48 || txtSoNgayMuonMax.Text[i] > 57 && txtSoNgayMuonMax.Enabled == true)
                {
                    countErr++;
                }
            }

            if (txtTuoiDGMin.Text == "" && txtTuoiDGMin.Enabled == true)
            {
                countErr++;
            }
            if (txtTuoiDGMax.Text == "" && txtTuoiDGMax.Enabled == true)
            {
                countErr++;
            }
            if (txtGiaTriThe.Text == "" && txtGiaTriThe.Enabled == true)
            {
                countErr++;
            }
            if (txtThoiGianXB.Text == "" && txtThoiGianXB.Enabled == true)
            {
                countErr++;
            }
            if (txtSoSachMuonMax.Text == "" && txtSoSachMuonMax.Enabled == true)
            {
                countErr++;
            }
            if (txtSoNgayMuonMax.Text == "" && txtSoNgayMuonMax.Enabled == true)
            {
                countErr++;
            }

            if (countErr > 0)
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ. Vui lòng xem lại!");
                txtTuoiDGMin.Text = "";
                txtTuoiDGMax.Text = "";
                txtGiaTriThe.Text = "";
                txtThoiGianXB.Text = "";
                txtSoSachMuonMax.Text = "";
                txtSoNgayMuonMax.Text = "";
            }
            else
            {
                int soTuoiDGMin, soTuoiDGMax, giaTriThe, thoiGianXB, soSachMuonToiDa, soNgayMuonToiDa;
                if (txtTuoiDGMin.Enabled == true)
                {
                    soTuoiDGMin = int.Parse(txtTuoiDGMin.Text);
                    thayDoiThamSo("SoTuoiDGMin", soTuoiDGMin);
                }
                if (txtTuoiDGMax.Enabled == true)
                {
                    soTuoiDGMax = int.Parse(txtTuoiDGMax.Text);
                    thayDoiThamSo("SoTuoiDGMax", soTuoiDGMax);
                }
                if (txtGiaTriThe.Enabled == true)
                {
                    giaTriThe = int.Parse(txtGiaTriThe.Text);
                    thayDoiThamSo("GiaTriThe", giaTriThe);
                }
                if (txtThoiGianXB.Enabled == true)
                {
                    thoiGianXB = int.Parse(txtThoiGianXB.Text);
                    thayDoiThamSo("ThoiGianXB", thoiGianXB);
                }
                if (txtSoSachMuonMax.Enabled == true)
                {
                    soSachMuonToiDa = int.Parse(txtSoSachMuonMax.Text);
                    thayDoiThamSo("SoSachMuonToiDa", soSachMuonToiDa);
                }
                if (txtSoNgayMuonMax.Enabled == true)
                {
                    soNgayMuonToiDa = int.Parse(txtSoNgayMuonMax.Text);
                    thayDoiThamSo("SoNgayMuonToiDa", soNgayMuonToiDa);
                }

                MessageBox.Show("Thay đổi thành công");
                txtTuoiDGMin.Text = "";
                txtTuoiDGMax.Text = "";
                txtGiaTriThe.Text = "";
                txtThoiGianXB.Text = "";
                txtSoSachMuonMax.Text = "";
                txtSoNgayMuonMax.Text = "";
            }

        }

        private void cbTuoiMin_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTuoiDGMin.Enabled == false)
                txtTuoiDGMin.Enabled = true;
            else
                txtTuoiDGMin.Enabled = false;
        }

        private void cbTuoiMax_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTuoiDGMax.Enabled == false)
                txtTuoiDGMax.Enabled = true;
            else
                txtTuoiDGMax.Enabled = false;
        }

        private void cbThoiHanThe_CheckedChanged(object sender, EventArgs e)
        {
            if (txtGiaTriThe.Enabled == false)
                txtGiaTriThe.Enabled = true;
            else
                txtGiaTriThe.Enabled = false;
        }

        private void cbThoiGianXB_CheckedChanged(object sender, EventArgs e)
        {
            if (txtThoiGianXB.Enabled == false)
                txtThoiGianXB.Enabled = true;
            else
                txtThoiGianXB.Enabled = false;
        }

        private void cbSachMuonMax_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSoSachMuonMax.Enabled == false)
                txtSoSachMuonMax.Enabled = true;
            else
                txtSoSachMuonMax.Enabled = false;
        }

        private void cbNgayMuonMax_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSoNgayMuonMax.Enabled == false)
                txtSoNgayMuonMax.Enabled = true;
            else
                txtSoNgayMuonMax.Enabled = false;
        }
    }
}
