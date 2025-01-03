﻿using System;
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

namespace qltv
{
    public partial class frmDangKyTT : Form
    {
        public frmDangKyTT()
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
            string cauTruyVan = "select * from tblThuThu";
            dataGridViewDSTT.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSTT.AutoGenerateColumns = false;
            myConnection.Close();
            string maTuDong = "";
            if (myTable.Rows.Count <= 0)
            {
                maTuDong = "TT001";
            }
            else
            {
                int k;
                maTuDong = "TT";
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

        private void frmDangKyTT_Load(object sender, EventArgs e)
        {
            txtMaTT.Text = tangMaTuDong();
            txtTenTK.Text = txtMaTT.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Phương thức kiểm tra Đk
        private int kq;

        private void kTraDK()
        {
            if (txtTenTT.Text == "")
            {
                errTenDG.SetError(txtTenTT, "Vui lòng nhập tên thủ thư");
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


            string mk1, mk2;
            mk1 = txtMK.Text;
            mk2 = txtNhapLaiMK.Text;
            kq = mk1.CompareTo(mk2);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            kTraDK();
            if (txtMaTT.Text.Length > 0 && txtTenTT.Text.Length > 0 && txtDiaChi.Text.Length > 0 && dtmNgaySinh.Text.Length > 0 && cboGioiTinh.Text.Length > 0 && txtTenTK.Text.Length > 0 && txtMK.Text.Length > 0)
            {
                if (kq == 0)
                {
                    try
                    {
                        string themdongsql = "set dateformat dmy; insert into tblThuThu values ('" + txtMaTT.Text + "',N'" + txtTenTT.Text + "',N'" + cboGioiTinh.Text + "','" + dtmNgaySinh.Text + "','" + txtEmail.Text + "',N'" + txtDiaChi.Text + "',N'" + txtGhiChu.Text + "','" + txtTenTK.Text + "','" + txtMK.Text + "')";
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
