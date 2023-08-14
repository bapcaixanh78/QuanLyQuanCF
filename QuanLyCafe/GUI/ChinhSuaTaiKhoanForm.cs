using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Util;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Enum.Material;
using ReaLTaiizor.Colors;
using System.IO;
using BC = BCrypt.Net.BCrypt;
using QuanLyCafe.DTO;
using QuanLyCafe.BLL;

namespace QuanLyCafe.GUI
{
    public partial class ChinhSuaTaiKhoanForm : MaterialForm
    {
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        TaiKhoan _taiKhoanChon = null;

        public ChinhSuaTaiKhoanForm()
        {
            InitializeComponent();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void ChinhSuaTaiKhoanForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (TaiKhoanHienTai.TaiKhoanHienHanh == null)
                {
                    System.Environment.Exit(0);
                    return;
                }
                if (TaiKhoanHienTai.TaiKhoanHienHanh.QuyenHan != 2)
                {
                    System.Environment.Exit(0);
                    return;
                }
                CustomFormatDate();
                CreateBorderRadius();
                LoadDanhSachQuyenHan();
                LoadDanhSachTaiKhoan();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #region Các hàm khởi tạo
        // Custom format date
        void CustomFormatDate()
        {
            dtpTuNgay.CustomFormat = "yyyy-MM-dd";
            dtpDenNgay.CustomFormat = "yyyy-MM-dd";
        }

        // Tạo border radius cho các control
        void CreateBorderRadius()
        {
            pnlForm.Anchor = AnchorStyles.None;
            pnlForm.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlForm.Width, pnlForm.Height, 15, 15)
            );
            pnlBaoCao.Anchor = AnchorStyles.None;
            pnlBaoCao.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlBaoCao.Width, pnlBaoCao.Height, 15, 15)
            );

            pnlTongQuan.Anchor = AnchorStyles.None;
            pnlTongQuan.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlTongQuan.Width, pnlTongQuan.Height, 15, 15)
            );
            picTaiKhoan.Anchor = AnchorStyles.None;
            picTaiKhoan.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, picTaiKhoan.Width, picTaiKhoan.Height, 15, 15)
            );

            picTaiKhoanThem.Anchor = AnchorStyles.None;
            picTaiKhoanThem.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, picTaiKhoanThem.Width, picTaiKhoanThem.Height, 15, 15)
            );

            pnlThemTaiKhoan.Anchor = AnchorStyles.None;
            pnlThemTaiKhoan.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlThemTaiKhoan.Width, pnlThemTaiKhoan.Height, 15, 15)
            );
        }

        void LoadDanhSachQuyenHan()
        {
            DataTable dt;
            dt = taiKhoanBLL.LoadDanhSachQuyenHan();

            cboQuyenHan.DataSource = dt;
            cboQuyenHan.DisplayMember = "TEN";
            cboQuyenHan.ValueMember = "ID";

            cboQuyenHanThem.DataSource = dt;
            cboQuyenHanThem.DisplayMember = "TEN";
            cboQuyenHanThem.ValueMember = "ID";
        }

        void LoadDanhSachTaiKhoan()
        {
            DataTable dt;
            dt = taiKhoanBLL.LoadDanhSachTaiKhoan();
            dgvDanhSachTaiKhoan.DataSource = dt;
            if (ControlForm.FormMain != null)
            {
                ControlForm.FormMain.LoadDanhSachTaiKhoan();
            }
        }
        #endregion

        #region Các hàm sự kiện
        private void dgvDanhSachTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    _taiKhoanChon = null;
                    HienThiThongTinTaiKhoan();
                    return;
                }

                DataGridViewRow row = new DataGridViewRow();
                row = dgvDanhSachTaiKhoan.Rows[e.RowIndex];
                if (string.IsNullOrEmpty(row.Cells["USERNAME"].Value.ToString()))
                {
                    _taiKhoanChon = null;
                    HienThiThongTinTaiKhoan();
                    return;
                }
                string username = row.Cells["USERNAME"].Value.ToString();

                _taiKhoanChon = taiKhoanBLL.TimKiemTaiKhoanByUsername(username);
                if (_taiKhoanChon == null)
                {
                    HienThiThongTinTaiKhoan();
                    throw new Exception("Không tìm thấy tài khoản");
                }
               
                HienThiThongTinTaiKhoan();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnTimKiemTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txtTimKiemTaiKhoan.Text.Trim();
                DataTable dt;
                dt = taiKhoanBLL.TimKiemTaiKhoan(searchValue);
                dgvDanhSachTaiKhoan.DataSource = dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (_taiKhoanChon == null)
                {
                    return;
                }
                if (
                    TaiKhoanHienTai.TaiKhoanHienHanh.UserName != _taiKhoanChon.UserName
                    && TaiKhoanHienTai.TaiKhoanHienHanh.QuyenHan <= _taiKhoanChon.QuyenHan
                )
                {
                    throw new Exception("Bạn không có quyền chỉnh sửa tài khoản này");
                }
                if (ControlForm.ConfirmForm("Bạn có muốn lưu"))
                {
                    string firstName = txtFirstName.Text.Trim();
                    string lastName = txtLastName.Text.Trim();
                    string phone = txtPhone.Text.Trim();
                    string cccd = txtCCCD.Text.Trim();
                    string address = txtAddress.Text.Trim();
                    int quyenHan = int.Parse(cboQuyenHan.SelectedValue.ToString());

                    if (
                        string.IsNullOrEmpty(firstName)
                        || string.IsNullOrEmpty(lastName)
                        || string.IsNullOrEmpty(phone)
                        || string.IsNullOrEmpty(cccd)
                        || string.IsNullOrEmpty(address)
                    )
                    {
                        throw new Exception("Vui lòng nhập thông tin hợp lệ");
                    }

                    TaiKhoan taiKhoan = new TaiKhoan(
                        _taiKhoanChon.UserName,
                        _taiKhoanChon.Password,
                        firstName,
                        lastName,
                        phone,
                        cccd,
                        address,
                        quyenHan
                    );
                    if (taiKhoanBLL.LuuThongTinTaiKhoan(taiKhoan))
                    {
                        int quyenHanCu = _taiKhoanChon.QuyenHan;
                        _taiKhoanChon.QuyenHan = quyenHan;
                        _taiKhoanChon.CCCD = cccd;
                        _taiKhoanChon.Phone = phone;
                        _taiKhoanChon.FirstName = firstName;
                        _taiKhoanChon.LastName = lastName;
                        _taiKhoanChon.Address = address;

                        LoadDanhSachTaiKhoan();

                        MessageBox.Show("Thành công");
                        if (
                            _taiKhoanChon.UserName == TaiKhoanHienTai.TaiKhoanHienHanh.UserName
                            && quyenHanCu != quyenHan
                        )
                        {
                            Environment.Exit(1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (_taiKhoanChon == null)
                {
                    return;
                }
                if (
                    TaiKhoanHienTai.TaiKhoanHienHanh.UserName != _taiKhoanChon.UserName
                    && TaiKhoanHienTai.TaiKhoanHienHanh.QuyenHan <= _taiKhoanChon.QuyenHan
                )
                {
                    throw new Exception("Bạn không có quyền chỉnh sửa tài khoản này");
                }
                if (
                    ControlForm.ConfirmForm(
                        "Bạn có muốn xóa không? Hành động này sẽ xóa mọi thứ liên quan đến tài khoản này"
                    )
                )
                {

                    // Kiểm tra xem tài khoản có đang trong ca làm hay không (đang order cho khách)
                   


                    // Kiểm tra xem tài khoản đã được thanh toán tiền chưa
                   
         
                    // xóa tài khoản
                    TaiKhoan taiKhoan = _taiKhoanChon;
                    if (taiKhoanBLL.CapNhatHienThiTaiKhoan(taiKhoan.UserName, 0))
                    {
                        if (_taiKhoanChon.UserName == TaiKhoanHienTai.TaiKhoanHienHanh.UserName)
                        {
                            Environment.Exit(1);
                        }

                        ReloadTabPageChinhSua();

                        MessageBox.Show("Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCapNhatMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                if (_taiKhoanChon == null)
                {
                    return;
                }
                if (
                    TaiKhoanHienTai.TaiKhoanHienHanh.UserName != _taiKhoanChon.UserName
                    && TaiKhoanHienTai.TaiKhoanHienHanh.QuyenHan <= _taiKhoanChon.QuyenHan
                )
                {
                    throw new Exception("Bạn không có quyền chỉnh sửa tài khoản này");
                }
                if (ControlForm.ConfirmForm("Bạn có muốn lưu"))
                {
                    string password = txtPassword.Text.Trim();

                    if (string.IsNullOrEmpty(password))
                    {
                        throw new Exception("Vui lòng nhập thông tin hợp lệ");
                    }

                    string passwordHash = BC.HashPassword(password);
                    TaiKhoan taiKhoan = new TaiKhoan(_taiKhoanChon);
                    taiKhoan.Password = passwordHash;
                    if (taiKhoanBLL.CapNhatMatKhau(taiKhoan))
                    {
                        _taiKhoanChon.Password = password;
                        txtPassword.Text = null;
                        LoadDanhSachTaiKhoan();

                        MessageBox.Show("Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            try
            {
                BaoCao baoCaoMoi = new BaoCao("doanhthuhoadoncanhan", _taiKhoanChon.UserName);
                baoCaoMoi.SetBaoCaoDoanhThu(dtpTuNgay.Value, dtpDenNgay.Value);
                ControlForm.BaoCaoHienTai = baoCaoMoi;
                GUI.ReportViewForm fBaoCao = new GUI.ReportViewForm();
                fBaoCao.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnBaoCaoCaLam_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime getDateTimeBatDau = dtpTuNgay.Value;
                DateTime getFilterDateBatDau = new DateTime(
                    getDateTimeBatDau.Year,
                    getDateTimeBatDau.Month,
                    getDateTimeBatDau.Day
                );

                DateTime getDateTimeKetThuc = dtpDenNgay.Value;
                DateTime getFilterDateKetThuc = new DateTime(
                    getDateTimeKetThuc.Year,
                    getDateTimeKetThuc.Month,
                    getDateTimeKetThuc.Day
                );

                DateTime getCurrentDate = new DateTime(
                    DateTime.Now.Year,
                    DateTime.Now.Month,
                    DateTime.Now.Day
                );
                if (
                    getFilterDateBatDau > getCurrentDate
                    || getFilterDateKetThuc > getCurrentDate
                    || getFilterDateKetThuc < getFilterDateBatDau
                )
                {
                    throw new Exception("Vui lòng chọn ngày hợp lệ");
                }

                BaoCao baoCaoMoi = new BaoCao("calamnhanvien", _taiKhoanChon.UserName);
                baoCaoMoi.SetBaoCaoCaLamNhanVien(dtpTuNgay.Value, dtpDenNgay.Value);
                ControlForm.BaoCaoHienTai = baoCaoMoi;
                ReportViewForm fBaoCao = new ReportViewForm();
                fBaoCao.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControlForm.ConfirmForm("Bạn có muốn thêm?"))
                {
                    string userName = txtUsernameThem.Text.Trim();
                    string password = txtPasswordThem.Text.Trim();
                    string firstName = txtFirstNameThem.Text.Trim();
                    string lastName = txtLastNameThem.Text.Trim();
                    string phone = txtPhoneThem.Text.Trim();
                    string cccd = txtCCCDThem.Text.Trim();
                    string address = txtAddressThem.Text.Trim();
                    int quyenHan = int.Parse(cboQuyenHanThem.SelectedValue.ToString());

                    if (
                        string.IsNullOrEmpty(userName)
                        || string.IsNullOrEmpty(password)
                        || string.IsNullOrEmpty(firstName)
                        || string.IsNullOrEmpty(lastName)
                        || string.IsNullOrEmpty(phone)
                        || string.IsNullOrEmpty(cccd)
                        || string.IsNullOrEmpty(address)
                    )
                    {
                        throw new Exception("Vui lòng nhập thông tin hợp lệ");
                    }
                    if (TaiKhoanHienTai.TaiKhoanHienHanh.QuyenHan < quyenHan)
                    {
                        throw new Exception(
                            "Tài khoản tạo mới phải có quyền hạn thấp hơn hoặc bằng bạn"
                        );
                    }
                    TaiKhoan timTaiKhoan = taiKhoanBLL.TimKiemTaiKhoanByUsername(userName);
                    if (timTaiKhoan != null)
                    {
                        throw new Exception("Tài khoản đã tồn tại");
                    }
                    string passwordHash = BC.HashPassword(password);
                    TaiKhoan taiKhoan = new TaiKhoan(
                        userName,
                        passwordHash,
                        firstName,
                        lastName,
                        phone,
                        cccd,
                        address,
                        quyenHan
                    );
                    if (taiKhoanBLL.ThemTaiKhoan(taiKhoan))
                    {
                      

                        LoadDanhSachTaiKhoan();
                        ReloadTabPageThem();

                        MessageBox.Show("Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tabForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabForm.SelectedTab == tpChinhSua)
                {
                    ReloadTabPageChinhSua();
                }
                else if (tabForm.SelectedTab == tpThem)
                {
                    ReloadTabPageThem();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #endregion

        #region Các hàm phục vụ
        void HienThiThongTinTaiKhoan()
        {
            if (_taiKhoanChon != null)
            {
                pnlBaoCao.Visible = true;
                pnlTongQuan.Visible = true;
                txtUserName.Text = _taiKhoanChon.UserName;
                txtFirstName.Text = _taiKhoanChon.FirstName;
                txtLastName.Text = _taiKhoanChon.LastName;
                txtCCCD.Text = _taiKhoanChon.CCCD;
                txtPhone.Text = _taiKhoanChon.Phone;
                txtAddress.Text = _taiKhoanChon.Address;
                cboQuyenHan.SelectedValue = (_taiKhoanChon.QuyenHan).ToString();
            } else
            {
                pnlBaoCao.Visible = false;
                pnlTongQuan.Visible = false;
            }
        }

        void ReloadTabPageChinhSua()
        {
            DataTable dt = (DataTable)dgvDanhSachTaiKhoan.DataSource;
            if (dt != null)
            {
                dt.Clear();
            }
            LoadDanhSachTaiKhoan();
            _taiKhoanChon = null;
            txtTimKiemTaiKhoan.Text = null;
            HienThiThongTinTaiKhoan();
        }

        void ReloadTabPageThem()
        {
            txtUsernameThem.Text = null;
            txtFirstNameThem.Text = null;
            txtLastNameThem.Text = null;
            txtPhoneThem.Text = null;
            txtCCCDThem.Text = null;
            txtAddressThem.Text = null;
            txtPasswordThem.Text = null;
        }
        #endregion
    }
}
