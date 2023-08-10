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
using QuanLyCafe.BLL;
using QuanLyCafe.DTO;

namespace QuanLyCafe.GUI
{
    public partial class ChinhSuaSuKienForm : MaterialForm
    {
        SuKienBLL suKienBLL = new SuKienBLL();
        SanPhamBLL sanPhamBLL = new SanPhamBLL();
        SuKien _suKienChon = null;

        public ChinhSuaSuKienForm()
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

        private void ChinhSuaSuKienForm_Load(object sender, EventArgs e)
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
                pnlTongQuanSuKien.Visible = false;
                CustomFormatDate();
                CreateBorderRadius();
                LoadDanhSachSuKien();
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
            dtpBatDau.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            dtpThoiGianBatDauThem.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            dtpThoiGianKetThucThem.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            dtpKetThuc.CustomFormat = "yyyy-MM-dd hh:mm:ss";
        }

        // Tạo border radius cho các control
        void CreateBorderRadius()
        {
            pnlForm.Anchor = AnchorStyles.None;
            pnlForm.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlForm.Width, pnlForm.Height, 15, 15)
            );

            picSuKien.Anchor = AnchorStyles.None;
            picSuKien.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, picSuKien.Width, picSuKien.Height, 15, 15)
            );

            picSuKienThem.Anchor = AnchorStyles.None;
            picSuKienThem.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, picSuKienThem.Width, picSuKienThem.Height, 15, 15)
            );

            pnlThemSuKien.Anchor = AnchorStyles.None;
            pnlThemSuKien.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlThemSuKien.Width, pnlThemSuKien.Height, 15, 15)
            );

            pnlTongQuanSuKien.Anchor = AnchorStyles.None;
            pnlTongQuanSuKien.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlTongQuanSuKien.Width, pnlTongQuanSuKien.Height, 15, 15)
            );
        }

        void LoadDanhSachSuKien()
        {
            DataTable dt;
            dt = suKienBLL.LoadDanhSachSuKien();
            dgvDanhSachSuKien.DataSource = dt;
            if (ControlForm.FormMain != null)
            {
                ControlForm.FormMain.LoadDanhSachSuKien();
                ControlForm.FormMain.LoadDanhSachSanPham();
            }
        }

        #endregion

        #region Các hàm sự kiện
        private void btnTimKiemSuKien_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txtTimKiemSuKien.Text.Trim();

                DataTable dt;
                dt = suKienBLL.TimKiemSuKien(searchValue);
                dgvDanhSachSuKien.DataSource = dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvDanhSachSuKien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {

                    _suKienChon = null;
                    HienThiThongTinSuKien();
                    return;
                }

                DataGridViewRow row = new DataGridViewRow();
                row = dgvDanhSachSuKien.Rows[e.RowIndex];
                if (string.IsNullOrEmpty(row.Cells["ID"].Value.ToString())) {
                    _suKienChon = null;
                    HienThiThongTinSuKien();
                    return;
                }
                int ID = int.Parse(row.Cells["ID"].Value.ToString());

                _suKienChon = suKienBLL.TimKiemSuKienByID(ID);

                if (_suKienChon == null)
                {
                    HienThiThongTinSuKien();
                    throw new Exception("Không tìm thấy sự kiện");
                }

                HienThiThongTinSuKien();
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
                if (_suKienChon == null)
                {
                    return;
                }
                if (ControlForm.ConfirmForm("Bạn có muốn lưu"))
                {
                    int giamGia = int.Parse(txtGiamGia.Text);
                    string moTa = txtMoTa.Text.Trim();
                    string ten = txtTen.Text.Trim();

                    DateTime thoiGianBatDau = dtpBatDau.Value;
                    DateTime thoiGianKetThuc = dtpKetThuc.Value;
                    if (
                        string.IsNullOrEmpty(moTa)
                        || string.IsNullOrEmpty(ten)
                        || giamGia < 0
                        || giamGia > 100
                    )
                    {
                        throw new Exception("Vui lòng nhập thông tin hợp lệ");
                    }
                    if (thoiGianBatDau > thoiGianKetThuc)
                    {
                        throw new Exception("Vui lòng chọn thời gian hợp lệ");
                    }
                    SuKien suKien = new SuKien(
                        _suKienChon.ID,
                        ten,
                        moTa,
                        giamGia,
                        thoiGianBatDau,
                        thoiGianKetThuc
                    );

                    if (suKienBLL.LuuThongTinSuKien(suKien))
                    {
                        _suKienChon.ThoiGianBatDau = thoiGianBatDau;
                        _suKienChon.ThoiGianKetThuc = thoiGianKetThuc;
                        _suKienChon.GiamGia = giamGia;
                        _suKienChon.MoTa = moTa;
                        _suKienChon.Ten = ten;
                        LoadDanhSachSuKien();

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (_suKienChon == null)
                {
                    return;
                }
                if (
                    ControlForm.ConfirmForm(
                        "Bạn có muốn xóa không? Hành động này sẽ cập nhật danh sách sản phẩm đang có sự kiện này"
                    )
                )
                {
                    // Xóa sự kiện
                    SuKien suKien = _suKienChon;
                    if (
                        sanPhamBLL.UpdateHetThoiGianSuKien(suKien.ID) && suKienBLL.XoaSuKien(suKien)
                    )
                    {
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

        private void btnThemSuKien_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControlForm.ConfirmForm("Bạn có muốn thêm?"))
                {
                    string ten = txtTenThem.Text.Trim();
                    string moTa = txtMoTaThem.Text.Trim();
                    int giamGia = int.Parse(txtGiamGiaThem.Text);
                    DateTime thoiGianBatDau = dtpThoiGianBatDauThem.Value;
                    DateTime thoiGianKetThuc = dtpThoiGianKetThucThem.Value;
                    if (
                        string.IsNullOrEmpty(moTa)
                        || string.IsNullOrEmpty(ten)
                        || giamGia < 0
                        || giamGia > 100
                    )
                    {
                        throw new Exception("Vui lòng nhập thông tin hợp lệ");
                    }
                    if (thoiGianKetThuc < thoiGianBatDau)
                    {
                        throw new Exception("Vui lòng chọn thời gian hợp lệ");
                    }
                    SuKien suKien = new SuKien(
                        0,
                        ten,
                        moTa,
                        giamGia,
                        thoiGianBatDau,
                        thoiGianKetThuc
                    );
                    if (suKienBLL.ThemSuKien(suKien))
                    {
                        LoadDanhSachSuKien();
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

        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion

        #region Các hàm phục vụ
        void HienThiThongTinSuKien()
        {
            if (_suKienChon != null)
            {
                pnlTongQuanSuKien.Visible = true;
                txtID.Text = _suKienChon.ID.ToString();
                txtGiamGia.Text = _suKienChon.GiamGia.ToString();
                txtMoTa.Text = _suKienChon.MoTa;
                txtTen.Text = _suKienChon.Ten;
                dtpBatDau.Value = _suKienChon.ThoiGianBatDau;
                dtpKetThuc.Value = _suKienChon.ThoiGianKetThuc;
            } else
            {
                pnlTongQuanSuKien.Visible = false; 
            }
        }

        void ReloadTabPageChinhSua()
        {
            DataTable dt = (DataTable)dgvDanhSachSuKien.DataSource;
            if (dt != null)
            {
                dt.Clear();
            }
            LoadDanhSachSuKien();
            _suKienChon = null;
            txtTimKiemSuKien.Text = null;
            HienThiThongTinSuKien();


        }

        void ReloadTabPageThem()
        {
            txtTenThem.Text = null;
            txtMoTaThem.Text = null;
            txtGiamGiaThem.Text = null;
        }

        #endregion
    }
}
