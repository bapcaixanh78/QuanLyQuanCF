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
using BC = BCrypt.Net.BCrypt;
using QuanLyCafe.DTO;
using QuanLyCafe.BLL;

namespace QuanLyCafe.GUI
{
    public partial class ChinhSuaThongTinForm : MaterialForm
    {
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        LichSuCaBLL lichSuCaBLL = new LichSuCaBLL();
        LichSuThanhToanCaBLL lichSuThanhToanCaBLL = new LichSuThanhToanCaBLL();

        public ChinhSuaThongTinForm()
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

        private void ChinhSuaThongTinForm_Load(object sender, EventArgs e)
        {
            if (TaiKhoanHienTai.TaiKhoanHienHanh == null)
            {
                System.Environment.Exit(0);
                return;
            }
            CustomFormatTime();
            CreateBorderRadius();
            HienThiThongTinProfile();
        }

        #region Các hàm khởi tạo
        // Tạo border radius cho các control
        void CreateBorderRadius()
        {
            pnlThongTinThanhToan.Anchor = AnchorStyles.None;
            pnlThongTinThanhToan.Region = Region.FromHrgn(
                CreateRoundRectRgn(
                    0,
                    0,
                    pnlThongTinThanhToan.Width,
                    pnlThongTinThanhToan.Height,
                    15,
                    15
                )
            );

            pnlLichSuCaLam.Anchor = AnchorStyles.None;
            pnlLichSuCaLam.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlLichSuCaLam.Width, pnlLichSuCaLam.Height, 15, 15)
            );
            pnlThongTinThanhToan.Visible = false;

            panel1.Anchor = AnchorStyles.None;
            panel1.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 15, 15)
            );

            picAvatar.Anchor = AnchorStyles.None;
            picAvatar.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, picAvatar.Width, picAvatar.Height, 15, 15)
            );

            pnlProfile.Anchor = AnchorStyles.None;
            pnlProfile.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlProfile.Width, pnlProfile.Height, 15, 15)
            );

            pnlPassword.Anchor = AnchorStyles.None;
            pnlPassword.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlPassword.Width, pnlPassword.Height, 15, 15)
            );

            dtpThoiGianBatDauDoanhThu.CustomFormat = "yyyy-MM-dd";
            dtpThoiGianKetThucDoanhThu.CustomFormat = "yyyy-MM-dd";

            pnlDoanhThu.Anchor = AnchorStyles.None;
            pnlDoanhThu.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlDoanhThu.Width, pnlDoanhThu.Height, 15, 15)
            );

            pnlThongTinDoanhThu.Anchor = AnchorStyles.None;
            pnlThongTinDoanhThu.Region = Region.FromHrgn(
                CreateRoundRectRgn(
                    0,
                    0,
                    pnlThongTinDoanhThu.Width,
                    pnlThongTinDoanhThu.Height,
                    15,
                    15
                )
            );

            picDoanhThu.Anchor = AnchorStyles.None;
            picDoanhThu.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, picDoanhThu.Width, picDoanhThu.Height, 15, 15)
            );
        }

        // Custom format thời gian
        void CustomFormatTime()
        {
            dtpThoiGian.CustomFormat = "yyyy-MM-dd";
            dtpTuNgayCaLam.CustomFormat = "yyyy-MM-dd";
            dtpDenNgayCaLam.CustomFormat = "yyyy-MM-dd";
            dtpThoiGianBatDauDoanhThu.CustomFormat = "yyyy-MM-dd";
            dtpThoiGianKetThucDoanhThu.CustomFormat = "yyyy-MM-dd";
        }

        void HienThiThongTinProfile()
        {
            TaiKhoan taiKhoan = taiKhoanBLL.LayThongTinCaNhan(
                TaiKhoanHienTai.TaiKhoanHienHanh.UserName
            );
            if (taiKhoan != null)
            {
                lblUserName.Text = "@" + taiKhoan.UserName;
                txtFirstName.Text = taiKhoan.FirstName;
                txtLastName.Text = taiKhoan.LastName;
                txtCCCD.Text = taiKhoan.CCCD;
                txtPhone.Text = taiKhoan.Phone;
                txtAddress.Text = taiKhoan.Address;
            }
        }
        #endregion

        #region Các sự kiện
        private void btnEditThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string phone = txtPhone.Text.Trim();
                string address = txtAddress.Text.Trim();
                string cccd = txtCCCD.Text.Trim();
                if (
                    string.IsNullOrEmpty(firstName)
                    || string.IsNullOrEmpty(lastName)
                    || string.IsNullOrEmpty(phone)
                    || string.IsNullOrEmpty(address)
                    || string.IsNullOrEmpty(cccd)
                )
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                TaiKhoan taiKhoan = new TaiKhoan(
                    TaiKhoanHienTai.TaiKhoanHienHanh.UserName,
                    TaiKhoanHienTai.TaiKhoanHienHanh.Password,
                    firstName,
                    lastName,
                    phone,
                    cccd,
                    address,
                    TaiKhoanHienTai.TaiKhoanHienHanh.QuyenHan
                );
                if (taiKhoanBLL.CapNhatThongTinCaNhan(taiKhoan))
                {
                    TaiKhoanHienTai.TaiKhoanHienHanh.FirstName = firstName;
                    TaiKhoanHienTai.TaiKhoanHienHanh.LastName = lastName;
                    TaiKhoanHienTai.TaiKhoanHienHanh.Phone = phone;
                    TaiKhoanHienTai.TaiKhoanHienHanh.Address = address;
                    TaiKhoanHienTai.TaiKhoanHienHanh.CCCD = cccd;
                    if (ControlForm.FormMain != null)
                    {
                        ControlForm.FormMain.LoadThongTinNhanVien();
                    }

                    MessageBox.Show("Chỉnh sửa thành công");
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa thất bại");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                string taiKhoan = TaiKhoanHienTai.TaiKhoanHienHanh.UserName;
                DateTime getDate = dtpThoiGian.Value;
                DateTime getFilterDate = new DateTime(getDate.Year, getDate.Month, getDate.Day);

                DateTime getCurrentDate = new DateTime(
                    DateTime.Now.Year,
                    DateTime.Now.Month,
                    DateTime.Now.Day
                );
                if (getFilterDate > getCurrentDate)
                {
                    throw new Exception("Vui lòng chọn ngày hợp lệ");
                }

                LoadLichSuCa(taiKhoan, getDate);
                pnlThongTinThanhToan.Visible = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnXemDoanhThu_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime getDateTimeBatDau = dtpThoiGianBatDauDoanhThu.Value;
                DateTime getFilterDateBatDau = new DateTime(
                    getDateTimeBatDau.Year,
                    getDateTimeBatDau.Month,
                    getDateTimeBatDau.Day
                );

                DateTime getDateTimeKetThuc = dtpThoiGianKetThucDoanhThu.Value;
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

                string getDateBatDau = getDateTimeBatDau.ToString("yyyy-MM-dd");
                lblTuNgay.Text = getDateBatDau;
                string getDateKetThuc = getDateTimeKetThuc.ToString("yyyy-MM-dd");
                lblDenNgay.Text = getDateKetThuc;
                int tongHoaDon = 0;
                int tongDoanhThu = 0;
                DataTable dt;

                dt = hoaDonBLL.TimHoaDonByUsername(
                    getDateBatDau,
                    getDateKetThuc,
                    TaiKhoanHienTai.TaiKhoanHienHanh.UserName
                );

                dgvHoaDon.DataSource = dt;
                foreach (DataRow dr in dt.Rows)
                {
                    tongDoanhThu += (int)dr["THANHTIENGIAMGIA"];
                }
                tongHoaDon = dt.Rows.Count;
                lblTongHoaDon.Text = tongHoaDon.ToString();
                lblDoanhThu.Text = (tongDoanhThu).ToString();
                lblDoanhThu.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblDoanhThu.Text));

                pnlThongTinDoanhThu.Visible = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnXuatBaoCaoCaLam_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime getDateTimeBatDau = dtpTuNgayCaLam.Value;
                DateTime getFilterDateBatDau = new DateTime(
                    getDateTimeBatDau.Year,
                    getDateTimeBatDau.Month,
                    getDateTimeBatDau.Day
                );

                DateTime getDateTimeKetThuc = dtpDenNgayCaLam.Value;
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

                BaoCao baoCaoMoi = new BaoCao(
                    "calamnhanvien",
                    TaiKhoanHienTai.TaiKhoanHienHanh.UserName
                );
                baoCaoMoi.SetBaoCaoCaLamNhanVien(dtpTuNgayCaLam.Value, dtpDenNgayCaLam.Value);
                ControlForm.BaoCaoHienTai = baoCaoMoi;
                ReportViewForm fBaoCao = new ReportViewForm();
                fBaoCao.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                string currentPass = txtCurrentPassword.Text.Trim();
                string newPass = txtNewPassword.Text.Trim();
                string confirmNewPass = txtConfirmNewPassword.Text.Trim();

                if (
                    string.IsNullOrEmpty(currentPass)
                    || string.IsNullOrEmpty(newPass)
                    || string.IsNullOrEmpty(confirmNewPass)
                )
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                bool passwordCheck = BC.Verify(
                    currentPass,
                    TaiKhoanHienTai.TaiKhoanHienHanh.Password
                );
                if (!passwordCheck)
                {
                    throw new Exception("Mật khẩu cũ không chính xác");
                }
                if (newPass != confirmNewPass)
                {
                    throw new Exception("Mật khẩu mới không trùng khớp");
                }
                string passwordHash = BC.HashPassword(newPass);
                TaiKhoan taiKhoan = new TaiKhoan(TaiKhoanHienTai.TaiKhoanHienHanh);
                taiKhoan.Password = passwordHash;
                if (taiKhoanBLL.CapNhatMatKhauCaNhan(taiKhoan))
                {
                    txtCurrentPassword.Text = null;
                    txtNewPassword.Text = null;
                    txtConfirmNewPassword.Text = null;

                    TaiKhoanHienTai.TaiKhoanHienHanh.Password = passwordHash;
                    MessageBox.Show("Chỉnh sửa thành công");
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa thất bại");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnTaoBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            try
            {
                BaoCao baoCaoMoi = new BaoCao(
                    "doanhthuhoadoncanhan",
                    TaiKhoanHienTai.TaiKhoanHienHanh.UserName
                );
                baoCaoMoi.SetBaoCaoDoanhThu(
                    dtpThoiGianBatDauDoanhThu.Value,
                    dtpThoiGianKetThucDoanhThu.Value
                );
                ControlForm.BaoCaoHienTai = baoCaoMoi;
                GUI.ReportViewForm fBaoCao = new GUI.ReportViewForm();
                fBaoCao.ShowDialog();
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
                if (tabForm.SelectedTab == tpProfile)
                {
                    ReloadTabPageProfile();
                }
                else if (tabForm.SelectedTab == tpPassword)
                {
                    ReloadTabPagePassword();
                }
                else if (tabForm.SelectedTab == tpCaLam)
                {
                    ReloadTabPageCaLam();
                }
                else if (tabForm.SelectedTab == tpDoanhThuHoaDon)
                {
                    ReloadTabPageDoanhThuHoaDon();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void ChinhSuaThongTinForm_FormClosing(object sender, FormClosingEventArgs e) { }
        #endregion

        #region Các hàm phục vụ
        void LoadLichSuCa(string taiKhoan, DateTime date)
        {
            string getDate = date.ToString("yyyy-MM-dd");
            lblNgay.Text = getDate;
            int tongGioLam = 0;
            DataTable dt;
            dt = lichSuCaBLL.LoadDanhSachLichSuCa(taiKhoan, getDate);
            dgvLichSu.DataSource = dt;
            bool checkNgayLam = false;

            foreach (DataRow dr in dt.Rows)
            {
                checkNgayLam = true;
                tongGioLam += (int)dr["TONGGIOLAM"];
            }
            int tongTien = tongGioLam * HeThong.LuongPartTime;

            lblTongGioLam.Text = tongGioLam.ToString();

            if (checkNgayLam)
            {
                // Kiếm tra nếu lịch sử thanh toán ca chưa có thì thêm vô database
                if (lichSuThanhToanCaBLL.KiemTraThanhToanCaLam(taiKhoan, getDate) == false)
                {
                    lichSuThanhToanCaBLL.ThemThanhToanCaLamMoi(
                        taiKhoan,
                        getDate,
                        tongTien,
                        tongGioLam
                    );
                }

                int thanhToan = 0;
                int tongTienDaThanhToan = 0;
                LichSuThanhToanCa lichSuThanhToanCa =
                    lichSuThanhToanCaBLL.LayThongTinLichSuThanhToanCa(taiKhoan, getDate);
                thanhToan = lichSuThanhToanCa.ThanhToan;
                tongTienDaThanhToan = lichSuThanhToanCa.TongTien;

                if (thanhToan == 1)
                {
                    lblTongTien.Text = (tongTienDaThanhToan).ToString();
                    lblTongTien.Text = string.Format(
                        "{0:#,##0} VNĐ",
                        double.Parse(lblTongTien.Text)
                    );

                    lblDaThanhToan.Visible = true;
                }
                else
                {
                    // Update thông tin lịch sử thanh toán ca
                    lichSuThanhToanCaBLL.CapNhatThongTinLichSuThanhToanCa(
                        taiKhoan,
                        getDate,
                        tongTien,
                        tongGioLam
                    );

                    lblDaThanhToan.Visible = false;
                    lblTongTien.Text = (tongTien).ToString();
                    lblTongTien.Text = string.Format(
                        "{0:#,##0} VNĐ",
                        double.Parse(lblTongTien.Text)
                    );
                }
            }
            else
            {
                lblDaThanhToan.Visible = false;
                lblTongTien.Text = (tongTien).ToString();
                lblTongTien.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblTongTien.Text));
            }
        }

        void ReloadTabPageProfile()
        {
            HienThiThongTinProfile();
        }

        void ReloadTabPagePassword()
        {
            txtCurrentPassword.Text = null;
            txtNewPassword.Text = null;
            txtConfirmNewPassword.Text = null;
        }

        void ReloadTabPageCaLam()
        {
            pnlThongTinThanhToan.Visible = false;
            DataTable dt = (DataTable)dgvLichSu.DataSource;
            if (dt != null)
            {
                dt.Clear();
            }
            dtpThoiGian.Value = DateTime.Now;
            dtpTuNgayCaLam.Value = DateTime.Now;
            dtpDenNgayCaLam.Value = DateTime.Now;
        }

        void ReloadTabPageDoanhThuHoaDon()
        {
            pnlThongTinDoanhThu.Visible = false;
            DataTable dt = (DataTable)dgvHoaDon.DataSource;
            if (dt != null)
            {
                dt.Clear();
            }
            dtpThoiGianBatDauDoanhThu.Value = DateTime.Now;
            dtpThoiGianKetThucDoanhThu.Value = DateTime.Now;
        }

        #endregion
    }
}
