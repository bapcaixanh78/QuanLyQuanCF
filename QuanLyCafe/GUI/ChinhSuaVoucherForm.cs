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
using QuanLyCafe.DTO;
using QuanLyCafe.BLL;

namespace QuanLyCafe.GUI
{
    public partial class ChinhSuaVoucherForm : MaterialForm
    {
        VoucherBLL voucherBLL = new VoucherBLL();
        Voucher _voucherChon = null;

        public ChinhSuaVoucherForm()
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

        private void ChinhSuaVoucherForm_Load(object sender, EventArgs e)
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
                pnlTongQuanVoucher.Visible = false;
                CreateBorderRadius();
                LoadDanhSachVoucher();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #region Các hàm khởi tạo
        void CreateBorderRadius()
        {
            // Tạo border radius cho các control
            pnlThemVoucher.Anchor = AnchorStyles.None;
            pnlThemVoucher.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlThemVoucher.Width, pnlThemVoucher.Height, 15, 15)
            );

            picVoucherThem.Anchor = AnchorStyles.None;
            picVoucherThem.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, picVoucherThem.Width, picVoucherThem.Height, 15, 15)
            );
            picVoucher.Anchor = AnchorStyles.None;
            picVoucher.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, picVoucher.Width, picVoucher.Height, 15, 15)
            );

            pnlTongQuanVoucher.Anchor = AnchorStyles.None;
            pnlTongQuanVoucher.Region = Region.FromHrgn(
                CreateRoundRectRgn(
                    0,
                    0,
                    pnlTongQuanVoucher.Width,
                    pnlTongQuanVoucher.Height,
                    15,
                    15
                )
            );

            pnlForm.Anchor = AnchorStyles.None;
            pnlForm.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlForm.Width, pnlForm.Height, 15, 15)
            );
        }

        void LoadDanhSachVoucher()
        {
            DataTable dt;
            dt = voucherBLL.LoadDanhSachVoucherAdmin();
            dgvDanhSachVoucher.DataSource = dt;
            if (ControlForm.FormMain != null)
            {
                ControlForm.FormMain.LoadDanhSachVoucher();
                ControlForm.FormMain.LoadDanhSachHoaDon();
            }
        }

        #endregion

        #region Các hàm sự kiện
        private void dgvDanhSachVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    _voucherChon = null;
                    HienThiThongTinVoucher();
                    return;
                }
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDanhSachVoucher.Rows[e.RowIndex];
                if (string.IsNullOrEmpty(row.Cells["MA"].Value.ToString()))
                {
                    _voucherChon = null;
                    HienThiThongTinVoucher();
                    return;
                }
                string ma = row.Cells["MA"].Value.ToString();
                _voucherChon = voucherBLL.TimKiemVoucherByMaAdmin(ma);
                if (_voucherChon == null)
                {
                    HienThiThongTinVoucher();
                    throw new Exception("Không tìm thấy voucher");
                }
                HienThiThongTinVoucher();
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
                if (_voucherChon == null)
                {
                    return;
                }
                if (ControlForm.ConfirmForm("Bạn có muốn lưu"))
                {
                    int giamGia = int.Parse(txtGiamGia.Text);
                    string moTa = txtMoTa.Text.Trim();
                    int soLuong = int.Parse(txtSoLuong.Text);
                    if (string.IsNullOrEmpty(moTa) || soLuong <= 0 || giamGia < 0 || giamGia > 100)
                    {
                        throw new Exception("Vui lòng nhập thông tin hợp lệ");
                    }
                    Voucher voucher = new Voucher(
                        _voucherChon.Ma,
                        giamGia,
                        moTa,
                        _voucherChon.LuotNhap,
                        soLuong
                    );

                    if (voucherBLL.LuuThongTinVoucher(voucher))
                    {
                        _voucherChon.GiamGia = giamGia;
                        _voucherChon.MoTa = moTa;
                        _voucherChon.SoLuong = soLuong;
                        LoadDanhSachVoucher();

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

        private void btnThemVoucher_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControlForm.ConfirmForm("Bạn có muốn thêm?"))
                {
                    string ma = txtMaThem.Text.Trim();
                    string moTa = txtMoTaThem.Text.Trim();
                    int giamGia = int.Parse(txtGiamGiaThem.Text);
                    int soLuong = int.Parse(txtSoLuongThem.Text);
                    if (
                        string.IsNullOrEmpty(ma)
                        || string.IsNullOrEmpty(moTa)
                        || soLuong <= 0
                        || giamGia < 0
                        || giamGia > 100
                    )
                    {
                        throw new Exception("Vui lòng nhập thông tin hợp lệ");
                    }
                    ma = ma.ToUpper();
                    Voucher timVoucher = voucherBLL.TimKiemVoucherByMa(ma);
                    if (timVoucher != null)
                    {
                        throw new Exception("Voucher đã tồn tại");
                    }

                    Voucher voucher = new Voucher(ma, giamGia, moTa, 0, soLuong);
                    if (voucherBLL.ThemVoucher(voucher))
                    {
                        LoadDanhSachVoucher();
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

        private void btnTimKiemVoucher_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txtTimKiemVoucher.Text.Trim();
                DataTable dt;
                dt = voucherBLL.TimKiemVoucherAdmin(searchValue);
                dgvDanhSachVoucher.DataSource = dt;
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
                if (_voucherChon == null)
                {
                    return;
                }
                if (_voucherChon.HienThi == 1)
                {
                    if (ControlForm.ConfirmForm("Bạn có muốn ẩn không?"))
                    {
                        // Ẩn voucher
                        Voucher voucher = _voucherChon;
                        if (voucherBLL.CapNhatHienThiVoucher(voucher.Ma, 0))
                        {
                            _voucherChon = null;
                            HienThiThongTinVoucher();
                            ReloadTabPageChinhSua();

                            MessageBox.Show("Thành công");
                        }
                        else
                        {
                            MessageBox.Show("Thất bại");
                        }
                    }
                }
                else
                {
                    // Hủy ẩn voucher
                    Voucher voucher = _voucherChon;
                    if (voucherBLL.CapNhatHienThiVoucher(voucher.Ma, 1))
                    {
                        _voucherChon = null;
                        HienThiThongTinVoucher();
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

        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiamGiaThem_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuongThem_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaThem_Leave(object sender, EventArgs e)
        {
            txtMaThem.Text = txtMaThem.Text.ToUpper();
        }
        #endregion

        #region Các hàm phục vụ
        void HienThiThongTinVoucher()
        {
            if (_voucherChon != null)
            {
                pnlTongQuanVoucher.Visible = true;
                txtMa.Text = _voucherChon.Ma;
                txtGiamGia.Text = _voucherChon.GiamGia.ToString();
                txtMoTa.Text = _voucherChon.MoTa;
                txtSoLuong.Text = _voucherChon.SoLuong.ToString();
                txtLuotNhap.Text = _voucherChon.LuotNhap.ToString();
                if (_voucherChon.HienThi == 1)
                {
                    btnXoa.Text = "Ẩn";
                }
                else
                {
                    btnXoa.Text = "Hủy ẩn";
                }
            }
            else
            {
                pnlTongQuanVoucher.Visible = false;
            }
        }

        void ReloadTabPageChinhSua()
        {
            DataTable dt = (DataTable)dgvDanhSachVoucher.DataSource;
            if (dt != null)
            {
                dt.Clear();
            }
            LoadDanhSachVoucher();
            _voucherChon = null;
            txtTimKiemVoucher.Text = null;
            HienThiThongTinVoucher();
        }

        void ReloadTabPageThem()
        {
            txtMaThem.Text = null;
            txtMoTaThem.Text = null;
            txtGiamGiaThem.Text = null;
            txtSoLuongThem.Text = null;
        }
        #endregion
    }
}
