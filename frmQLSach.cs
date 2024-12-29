﻿using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace qltv
{
    public partial class frmQLSach : Form
    {
        public frmQLSach()
        {
            InitializeComponent();
        }
        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlDataAdapter myDataAdapter;
        private DataTable myTable;
        private SqlCommand myCommand;

        private DataTable ketnoi(string truyvan)
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            dataGridViewDSSach.DataSource = myTable;
            return myTable;
        }

        private void setControls(bool edit)
        {
            dtmNgNhapSach.Enabled = edit;
            txtTenSach.Enabled = edit;
            cboTheLoai.Enabled = edit;
            txtTacGia.Enabled = edit;
            txtNXB.Enabled = edit;
            txtNamXB.Enabled = edit;
            txtSLNhap.Enabled = edit;
            txtTriGia.Enabled = edit;
            cboTinhTrang.Enabled = edit;
            txtGhiChu.Enabled = edit;
        }

        private void frmQLSach_Load(object sender, EventArgs e)
        {
            string items = ConfigurationManager.AppSettings["ComboBoxItems"];
            if (!string.IsNullOrEmpty(items))
            {
                string[] itemArray = items.Split(',');
                cboTheLoai.Items.AddRange(itemArray);
            }
            string cauTruyVan = "select * from tblSach";
            dataGridViewDSSach.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSSach.AutoGenerateColumns = false;
            myConnection.Close();
            setControls(false);
            dataGridViewDSSach.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaSach.Enabled = false;
            dtmNgNhapSach.Value = DateTime.Now;
        }

        public string NgNhapSach, maSach, tenSach, tacGia, TheLoai, nXB, namXB, slNhap, TriGia, tinhTrang, ghiChu;
        private void dataGridViewDSSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                dtmNgNhapSach.Text = myTable.Rows[row]["NgNhapSach"].ToString();
                NgNhapSach = dtmNgNhapSach.Text;
                txtMaSach.Text = myTable.Rows[row]["MaSach"].ToString();
                maSach = txtMaSach.Text;
                txtTenSach.Text = myTable.Rows[row]["TenSach"].ToString();
                tenSach = txtTenSach.Text;
                cboTheLoai.Text = myTable.Rows[row]["TheLoai"].ToString();
                TheLoai = cboTheLoai.Text;
                txtTacGia.Text = myTable.Rows[row]["TacGia"].ToString();
                tacGia = txtTacGia.Text;
                txtNXB.Text = myTable.Rows[row]["NXB"].ToString();
                nXB = txtNXB.Text;
                txtNamXB.Text = myTable.Rows[row]["NamXB"].ToString();
                namXB = txtNamXB.Text;

                txtSLNhap.Text = myTable.Rows[row]["SLNhap"].ToString();
                slNhap = txtSLNhap.Text;
                txtTriGia.Text = myTable.Rows[row]["TriGia"].ToString();
                TriGia = txtTriGia.Text;
                cboTinhTrang.Text = myTable.Rows[row]["TinhTrang"].ToString();
                tinhTrang = cboTinhTrang.Text;
                txtGhiChu.Text = myTable.Rows[row]["GhiChu"].ToString();
                ghiChu = txtGhiChu.Text;
            }
            catch
            {

            }
        }

        public int xuly;
        private void btnThem_Click(object sender, EventArgs e)
        {

            txtMaSach.Text = tangMaTuDong();
            txtTenSach.Text = "";
            cboTheLoai.Text = "";
            txtTacGia.Text = "";
            txtNXB.Text = "";
            txtSLNhap.Text = "";
            txtNamXB.Text = "";
            txtTriGia.Text = "";
            cboTinhTrang.Text = "";
            txtGhiChu.Text = "";
            setControls(true);
            dtmNgNhapSach.Value = DateTime.Now.Date;
            dataGridViewDSSach.Enabled = false;
            txtTenSach.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            xuly = 0;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cboTinhTrang.Text = "Mới";
            setControls(true);
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            dataGridViewDSSach.Enabled = false;
            txtTenSach.Focus();
            xuly = 1;
        }

        private void xoaSach()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongSql;
                    xoadongSql = "DELETE FROM tblSach WHERE MaSach='" + txtMaSach.Text + "'";
                    ketnoi(xoadongSql);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông Báo");
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại.\nSách này đang được mượn.", "Thông Báo");
                }
            }
            string cauTruyVan = "select * from tblSach";
            dataGridViewDSSach.DataSource = ketnoi(cauTruyVan);
            myConnection.Close();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaSach();
        }

        private void themSach()
        {
            try
            {
                string query = "set dateformat dmy; insert into tblSach values ('" + txtMaSach.Text + "','" + dtmNgNhapSach.Text + "', N'" + txtTenSach.Text + "',N'" + cboTheLoai.Text + "',N'" + txtTacGia.Text + "',N'" + txtNXB.Text + "','" + txtNamXB.Text + "','" + txtSLNhap.Text + "','" + txtTriGia.Text + "',N'" + cboTinhTrang.Text + "',N'" + txtGhiChu.Text + "')";
                ketnoi(query);
                MessageBox.Show("Thêm thành công.", "Thông Báo");
                myConnection.Close();
            }
            catch
            {
                MessageBox.Show("Thêm không thành công.", "Thông Báo");
            }
        }

        private void dataGridViewDSSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.Text = dataGridViewDSSach.CurrentRow.Cells[0].Value.ToString();
            dtmNgNhapSach.Text = dataGridViewDSSach.CurrentRow.Cells[1].Value.ToString();
            txtTenSach.Text = dataGridViewDSSach.CurrentRow.Cells[2].Value.ToString();
            cboTheLoai.Text = dataGridViewDSSach.CurrentRow.Cells[3].Value.ToString();
            txtTacGia.Text = dataGridViewDSSach.CurrentRow.Cells[4].Value.ToString();
            txtNXB.Text = dataGridViewDSSach.CurrentRow.Cells[5].Value.ToString();
            txtNamXB.Text = dataGridViewDSSach.CurrentRow.Cells[6].Value.ToString();
            txtSLNhap.Text = dataGridViewDSSach.CurrentRow.Cells[8].Value.ToString();
            txtTriGia.Text = dataGridViewDSSach.CurrentRow.Cells[7].Value.ToString();
            cboTinhTrang.Text = dataGridViewDSSach.CurrentRow.Cells[9].Value.ToString();
            txtGhiChu.Text = dataGridViewDSSach.CurrentRow.Cells[10].Value.ToString();
        }

        private void suaSach()
        {
            try
            {
                string capnhatdong;
                capnhatdong = "update tblSach set TenSach=N'" + txtTenSach.Text + "',TheLoai=N'" + cboTheLoai.Text + "',TacGia=N'" + txtTacGia.Text + "',NXB=N'" + txtNXB.Text + "',NamXB='" + txtNamXB.Text + "',SLNhap='" + txtSLNhap.Text + "',TriGia='" + txtTriGia.Text + "',TinhTrang=N'" + cboTinhTrang.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaSach='" + txtMaSach.Text + "'";
                ketnoi(capnhatdong);
                myCommand.ExecuteNonQuery();

                MessageBox.Show("Sửa thành công.", "Thông Báo");
            }
            catch
            {
                MessageBox.Show("Sửa thất bại.\nVui lòng kiểm tra lại dữ liệu.", "Thông Báo");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text == "")
            {
                errTenSach.SetError(txtTenSach, "Vui lòng nhập Tên Sách");
            }
            else
            {
                errTenSach.Clear();
            }
            if (cboTheLoai.Text == "")
            {
                errCD.SetError(cboTheLoai, "Vui lòng nhập Chủ Đề");
            }
            else
            {
                errCD.Clear();
            }
            if (txtTacGia.Text == "")
            {
                errTG.SetError(txtTacGia, "Vui lòng nhập Tác Giả");
            }
            else
            {
                errTG.Clear();
            }
            if (txtNXB.Text == "")
            {
                errNXB.SetError(txtNXB, "Vui lòng nhập NXB");
            }
            else
            {
                errNXB.Clear();
            }
            if (txtNamXB.Text == "")
            {
                errNamXB.SetError(txtNamXB, "Vui lòng nhập Năm XB");
            }
            else
            {
                errNXB.Clear();
            }
            if (txtSLNhap.Text == "")
            {
                errSLNhap.SetError(txtSLNhap, "Vui lòng nhập SL");
            }
            else
            {
                errSLNhap.Clear();
            }

            if (txtTriGia.Text == "")
            {
                errTriGia.SetError(txtTriGia, "Vui lòng nhập Đơn Giá");
            }
            else
            {
                errTriGia.Clear();
            }
            if (cboTinhTrang.Text == "")
            {
                errTinhTrang.SetError(cboTinhTrang, "Vui lòng nhập Tình Trạng");
            }
            else
            {
                errTinhTrang.Clear();
            }

            string query = "select GiaTri from thamso where TenTS = 'ThoiGianXB'";
            ketnoi(query);
            int tgXB = Convert.ToInt32(myCommand.ExecuteScalar()); //Lay gia tri thoi gian xuat ban
            if (txtNamXB.Text == "")
            {
                MessageBox.Show("Năm xuất bản không hợp lệ!");
                return;
            }
            else
            {
                if (DateTime.Now.Year - Convert.ToInt32(txtNamXB.Text) > tgXB)
                {
                    MessageBox.Show("Năm xuất bản không hợp lệ!");
                    return;
                }
            }

            int ktSLNhap, ktNamXB, ktTriGia;
            bool isNumberSLNhap = int.TryParse(txtSLNhap.Text, out ktSLNhap);
            bool isNumberTriGia = int.TryParse(txtTriGia.Text, out ktTriGia);
            bool isNumberNamXB = int.TryParse(txtNamXB.Text, out ktNamXB);
            if (isNumberSLNhap == false || isNumberTriGia == false || isNumberNamXB == false)
            {
                MessageBox.Show("Vui lòng nhập số trong các ô:\nSL Nhập.\nNăm XB.\nĐơn Giá.", "Thông Báo");
            }
            if (dtmNgNhapSach.Text.Length > 0 && txtTenSach.Text.Length > 0 && txtTacGia.Text.Length > 0 && txtNXB.Text.Length > 0 && cboTheLoai.Text.Length > 0 && isNumberSLNhap == true && isNumberTriGia == true && cboTinhTrang.Text.Length > 0 && isNumberNamXB == true)
            {
                if (xuly == 0)
                {
                    themSach();
                }
                else if (xuly == 1)
                {
                    suaSach();
                }
                string cauTruyVan = "select * from tblSach";
                dataGridViewDSSach.DataSource = ketnoi(cauTruyVan);
                dataGridViewDSSach.AutoGenerateColumns = false;
                myConnection.Close();
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                setControls(false);
                dataGridViewDSSach.Enabled = true;

                errTenSach.Clear();
                errCD.Clear();
                errTG.Clear();
                errNamXB.Clear();
                errNXB.Clear();
                errTriGia.Clear();
                errSLNhap.Clear();
                errTinhTrang.Clear();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                if (txtTenSach.Text.Length == 0)
                    txtTenSach.Focus();
                else if (cboTheLoai.Text.Length == 0)
                    cboTheLoai.Focus();
                else if (txtTacGia.Text.Length == 0)
                    txtTacGia.Focus();
                else if (txtNXB.Text.Length == 0)
                    txtNXB.Focus();
                else if (txtNamXB.Text.Length == 0)
                    txtNamXB.Focus();
                else if (txtSLNhap.Text.Length == 0)
                    txtSLNhap.Focus();
                else if (txtTriGia.Text.Length == 0)
                    txtTriGia.Focus();
                else if (cboTinhTrang.Text.Length == 0)
                    cboTinhTrang.Focus();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                string dateString = NgNhapSach;
                string format = "dd/MM/yyyy";
                DateTime parsedDate = DateTime.ParseExact(dateString, format, System.Globalization.CultureInfo.InvariantCulture);
                dtmNgNhapSach.Value = parsedDate;
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid date format: {ex.Message}");
            }
            txtMaSach.Text = maSach;
            txtTenSach.Text = tenSach;
            cboTheLoai.Text = TheLoai;
            txtTacGia.Text = tacGia;
            txtNXB.Text = nXB;
            txtSLNhap.Text = slNhap;
            txtTriGia.Text = TriGia;
            cboTinhTrang.Text = tinhTrang;
            txtGhiChu.Text = ghiChu;
            setControls(false);
            dataGridViewDSSach.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            errTenSach.Clear();
            errCD.Clear();
            errTG.Clear();
            errNamXB.Clear();
            errNXB.Clear();
            errTriGia.Clear();
            errSLNhap.Clear();
            errTinhTrang.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadDS_Click(object sender, EventArgs e)
        {
            lblNhapCD.Text = "";
            lblNhapTriGia.Text = "";
            lblNhapSLCon.Text = "";
            lblNhapSLNhap.Text = "";
            lblNhapTenNXB.Text = "";
            lblNhapTenSach.Text = "";
            lblNhapTenTG.Text = "";
            lblNhapTinhTrang.Text = "";
            setControls(false);
            txtNDTimKiem.Text = "";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            string cauTruyVan = "select * from tblSach";
            dataGridViewDSSach.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSSach.AutoGenerateColumns = false;
            myConnection.Close();
        }
        private void timKiemSach()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            if (radMaSach.Checked)
            {
                string timkiemMS = "select * from tblSach where MaSach like '%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemMS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach.DataSource = myTable;
                dataGridViewDSSach.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenSach.Checked)
            {
                string timkiemTS = "select * from tblSach where TenSach like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemTS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach.DataSource = ketnoi(timkiemTS);
                dataGridViewDSSach.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenTG.Checked)
            {
                string timkiemMS = "select * from tblSach where TacGia like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemMS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach.DataSource = myTable;
                dataGridViewDSSach.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenCD.Checked)
            {
                string timkiemMS = "select * from tblSach where TheLoai like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemMS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach.DataSource = myTable;
                dataGridViewDSSach.AutoGenerateColumns = false;
                myConnection.Close();
            }
        }
        private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        {
            timKiemSach();
        }
        public string tangMaTuDong()
        {
            string cauTruyVan = "select * from tblSach";
            dataGridViewDSSach.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSSach.AutoGenerateColumns = false;
            myConnection.Close();
            string maTuDong = "";
            if (myTable.Rows.Count <= 0)
            {
                maTuDong = "MS001";
            }
            else
            {
                int k;
                maTuDong = "MS";
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

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            if (txtThemTheLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thể loại để thêm!", "Thông báo");
            }
            else
            {
                if (cboTheLoai.Items.Contains(txtThemTheLoai.Text))
                {
                    MessageBox.Show("Thể loại đã tồn tại!", "Thông báo");
                    txtThemTheLoai.Text = "";
                }
                else
                {
                    cboTheLoai.Items.Add(txtThemTheLoai.Text);
                    string existingItems = ConfigurationManager.AppSettings["ComboBoxItems"];
                    existingItems = string.IsNullOrEmpty(existingItems) ? txtThemTheLoai.Text : existingItems + "," + txtThemTheLoai.Text;

                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["ComboBoxItems"].Value = existingItems;
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    MessageBox.Show("Thêm thể loại thành công!", "Thông báo");
                    txtThemTheLoai.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtThemTheLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thể loại để xóa!", "Thông báo");
            }
            else if (cboTheLoai.Items.Contains(txtThemTheLoai.Text))
            {
                cboTheLoai.Items.Remove(txtThemTheLoai.Text);

                string items = ConfigurationManager.AppSettings["ComboBoxItems"];
                if (!string.IsNullOrEmpty(items))
                {
                    var itemList = new List<string>(items.Split(','));

                    if (itemList.Contains(txtThemTheLoai.Text))
                    {
                        // Loại bỏ mục đã chọn
                        itemList.Remove(txtThemTheLoai.Text);
                        string updatedItems = string.Join(",", itemList);

                        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config.AppSettings.Settings["ComboBoxItems"].Value = updatedItems;
                        config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection("appSettings");
                        MessageBox.Show("Xóa thể loại thành công!", "Thông báo");
                        txtThemTheLoai.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Thể loại không tồn tại trong danh sách.", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Thể loại không tồn tại trong danh sách.", "Thông báo");
            }
        }
    }
}
