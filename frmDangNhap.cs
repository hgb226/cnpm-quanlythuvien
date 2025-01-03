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
using System.Collections;

namespace qltv
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlCommand myCommand;

        private void DongForm(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            this.Show();
        }

        // Phương thức kiểm tra Đk tài khoản
        private int kq = 0;
        private void kTraDK()
        {
            if (txtTenDangNhap.Text.Length > 0 && txtMatKhau.Text.Length > 0)
                kq = 1;
        }

        // Phương thức kiểm tra TKTT
        private int x1 = 0, x2 = 0;
        private void xacThucTKTT()
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string strCauTruyVan = "select count(*) from tblThuThu where TaiKhoanTT=@acc and MatKhauTT=@pass";
            myCommand = new SqlCommand(strCauTruyVan, myConnection);
            myCommand.Parameters.Add(new SqlParameter("@acc", txtTenDangNhap.Text));
            myCommand.Parameters.Add(new SqlParameter("@pass", txtMatKhau.Text));
            x1 = (int)myCommand.ExecuteScalar();
            myConnection.Close();
        }

        // Phương thức kiểm tra TKDG
        private void xacThucTKDG()
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string query = "set dateformat dmy";
            myCommand = new SqlCommand(query, myConnection);
            string strCauTruyVan = "select count(*) from tblDocGia where TenTaiKhoanDG=@acc and MatKhauDG=@pass";
            myCommand = new SqlCommand(strCauTruyVan, myConnection);
            myCommand.Parameters.Add(new SqlParameter("@acc", txtTenDangNhap.Text));
            myCommand.Parameters.Add(new SqlParameter("@pass", txtMatKhau.Text));
            x2 = (int)myCommand.ExecuteScalar();
            if(x2 == 1)
            {
                query = "set dateformat dmy;select NgLapThe from tblDocGia where TenTaiKhoanDG=@acc";
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add(new SqlParameter("@acc", txtTenDangNhap.Text));
                DateTime NgayLapThe  = Convert.ToDateTime(myCommand.ExecuteScalar());
                if (NgayLapThe.AddMonths(6).CompareTo(DateTime.Now) < 0)
                {
                    MessageBox.Show("Thẻ đã quá hạn", "Lỗi");
                    x2 = 0;
                }
            }
            myConnection.Close();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            kTraDK();
            if (kq == 1)
            {
                if (chkQuanTri.Checked)
                {
                    try
                    {
                        xacThucTKTT();
                        if (x1 == 1)
                        {
                            string TenDangNhap = txtTenDangNhap.Text;
                            MessageBox.Show("Đăng nhập thành công", "Thông Báo");
                            frmGiaoDienChinh GiaoDienChinh = new frmGiaoDienChinh(TenDangNhap);
                            GiaoDienChinh.FormClosed += new FormClosedEventHandler(DongForm);
                            this.Hide();
                            GiaoDienChinh.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu\nVui lòng thử lại", "Thông Báo");
                            txtTenDangNhap.Clear();
                            txtMatKhau.Clear();
                            txtTenDangNhap.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (chkDocGia.Checked)
                {
                    try
                    {
                        xacThucTKDG();
                        if (x2 == 1)
                        {
                            string TenDangNhap = txtTenDangNhap.Text;
                            MessageBox.Show("Đăng nhập thành công", "Thông Báo");
                            frmDocGia DG = new frmDocGia(TenDangNhap);
                            DG.FormClosed += new FormClosedEventHandler(DongForm);
                            this.Hide();
                            DG.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu\nVui lòng thử lại", "Thông Báo");
                            txtTenDangNhap.Clear();
                            txtMatKhau.Clear();
                            txtTenDangNhap.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Thông Báo");
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (chkQuanTri.Checked == true)
            {
                frmDangKyTT DKTT = new frmDangKyTT();
                DKTT.Show();
            }
            else if (chkDocGia.Checked == true)
            {
                frmDangKy DK = new frmDangKy();
                DK.Show();
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            chkQuanTri.Checked = true;
        }

        private void chkQuanTri_CheckedChanged(object sender, EventArgs e)
        {
            btnDangKy.Enabled = false;
        }

        private void chkDocGia_CheckedChanged(object sender, EventArgs e)
        {
            btnDangKy.Enabled = true;
        }
    }
}
