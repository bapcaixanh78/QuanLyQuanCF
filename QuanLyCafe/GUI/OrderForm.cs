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
using QuanLyCafe.BLL;
using QuanLyCafe.DTO;

namespace QuanLyCafe.GUI
{
    public partial class OrderForm : MaterialForm
    {
        SuKienBLL suKienBLL = new SuKienBLL();
        SanPhamBLL sanPhamBLL = new SanPhamBLL();
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        LichSuOrderBLL lichSuOrderBLL = new LichSuOrderBLL();
        LichSuOrder _orderDangChon = null;
        SanPham _sanPhamChon = null;
        int _giaTienSauGiamGia = 0;
        string _idDonHangCapNhat = null;

        public OrderForm()
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

        private void OrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (TaiKhoanHienTai.TaiKhoanHienHanh == null || ControlForm.BanDatDangChon == null)
                {
                    System.Environment.Exit(0);
                    return;
                }
                HoaDon getHoaDon = hoaDonBLL.LayThongTinHoaDonByIDDatBan(
                    ControlForm.BanDatDangChon.ID
                );
                ControlForm.HoaDonHienTai = getHoaDon;
                CreateBorderRadius();
                btnXacNhanOrder.Visible = false;
                LoadDanhSachSanPham();
                UpdateLichSuOrder();

                lblThongTinBanDat.Text = $"Mã đặt bàn: {ControlForm.BanDatDangChon.ID}";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #region Các hàm khởi tạo
        void CreateBorderRadius()
        {
            pnlChiTietSanPham.Anchor = AnchorStyles.None;
            pnlChiTietSanPham.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlChiTietSanPham.Width, pnlChiTietSanPham.Height, 15, 15)
            );

            picHienThiSanPham.Anchor = AnchorStyles.None;
            picHienThiSanPham.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, picHienThiSanPham.Width, picHienThiSanPham.Height, 15, 15)
            );

            panel1.Anchor = AnchorStyles.None;
            panel1.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 15, 15)
            );
        }

        void LoadDanhSachSanPham()
        {

            DataTable dt;
            dt = sanPhamBLL.LoadDanhSachSanPham();
            dgvDanhSachSanPham.DataSource = dt;
            dgvDanhSachSanPham.Columns["IMAGE_PATH"].Visible = false;
            lblGiamGia.Visible = false;
        }

        #endregion

        #region Các hàm sự kiện
        private void btnTimKiemSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txtTimKiemSanPham.Text.Trim();

                DataTable dt;
                dt = sanPhamBLL.TimKiemSanPham(searchValue);
                dgvDanhSachSanPham.DataSource = dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    _sanPhamChon = null;
                    HienThiThongTin();
                    return;
                }
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDanhSachSanPham.Rows[e.RowIndex];
                if (string.IsNullOrEmpty(row.Cells["ID"].Value.ToString()))
                {
                    _sanPhamChon = null;
                    HienThiThongTin();
                    return;
                }
                btnCapNhatOrder.Visible = false;
                btnXoaOrder.Visible = false;
                btnXacNhanOrder.Visible = true;
                _idDonHangCapNhat = null;
                lblTitle.Text = "Thêm món";
          
                string ID = row.Cells["ID"].Value.ToString();
                _sanPhamChon = sanPhamBLL.TimKiemSanPhamByID(ID);
                if (_sanPhamChon == null)
                {
                    btnXacNhanOrder.Visible = false;
                    throw new Exception("Không tìm thấy sản phẩm");
                }
                txtSoLuongSanPham.Text = "1";

                Image image = sanPhamBLL.GetImageByPath(_sanPhamChon.ID);
                picHienThiSanPham.Image = image;
                HienThiThongTin();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txtSoLuongSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuongSanPham_Leave(object sender, EventArgs e)
        {
            int tongTien = int.Parse(txtSoLuongSanPham.Text) * (_giaTienSauGiamGia);
            lblTongTien.Text = tongTien.ToString();
            lblTongTien.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblTongTien.Text));
        }

        private void btnXacNhanOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    ControlForm.ConfirmForm("Xác nhận đặt món")
                    && _sanPhamChon != null
                    && ControlForm.BanDatDangChon != null
                )
                {
                    string sqlCommand;
                    string IDSanPham = _sanPhamChon.ID;
                    int donGia = _sanPhamChon.GiaTien;
                    int soLuong = int.Parse(txtSoLuongSanPham.Text);
                    int thanhTien = _giaTienSauGiamGia * soLuong;
                    // Kiểm tra xem đã có đơn món này chưa
                    LichSuOrder checkLichSuOrder = lichSuOrderBLL.LayThongTinLichSuOrder(
                        ControlForm.BanDatDangChon.ID,
                        ControlForm.HoaDonHienTai.ID,
                        IDSanPham
                    );

                    int soLuongHienTai = 0;

                    if (checkLichSuOrder != null)
                    {
                        soLuongHienTai = checkLichSuOrder.SoLuong;
                        soLuong = soLuong + soLuongHienTai;
                        thanhTien = _giaTienSauGiamGia * soLuong;
                        // cập nhật thêm số lượng sản phẩm thông tin order
                        lichSuOrderBLL.CapNhatThongTinOrder(
                            soLuong,
                            donGia,
                            _giaTienSauGiamGia,
                            thanhTien,
                            ControlForm.HoaDonHienTai.ID,
                            ControlForm.BanDatDangChon.ID,
                            IDSanPham
                        );

                        UpdateLichSuOrder();
                        if (ControlForm.FormChiTietBan != null)
                        {
                            ControlForm.FormChiTietBan.LoadFlowPanelSanPhamOrder();
                        }
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                    {
                        // Thêm mới thông tin order
                        LichSuOrder newOrder = new LichSuOrder();
                        newOrder.ThanhTien = thanhTien;
                        newOrder.SoLuong = soLuong;
                        newOrder.DonGia = donGia;
                        newOrder.DonGiaGiam = _giaTienSauGiamGia;
                        newOrder.IDSanPham = IDSanPham;
                        newOrder.IDDatBan = ControlForm.BanDatDangChon.ID;
                        newOrder.IDHoaDon = ControlForm.HoaDonHienTai.ID;
                        lichSuOrderBLL.ThemOrder(newOrder);

                        UpdateLichSuOrder();
                        if (ControlForm.FormChiTietBan != null)
                        {
                            ControlForm.FormChiTietBan.LoadFlowPanelSanPhamOrder();
                        }
                        MessageBox.Show("Thêm thành công");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvLichSuOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    _sanPhamChon = null;
                    HienThiThongTin();
                    return;
                }
                DataGridViewRow row = new DataGridViewRow();
                row = dgvLichSuOrder.Rows[e.RowIndex];
                if (string.IsNullOrEmpty(row.Cells["ID_SANPHAM_LS"].Value.ToString()))
                {
                    _sanPhamChon = null;
                    HienThiThongTin();
                    return;
                }
                lblTitle.Text = "Chỉnh sửa order";
                btnCapNhatOrder.Visible = true;
                btnXoaOrder.Visible = true;

                btnXacNhanOrder.Visible = false;

                string IDSanPham = row.Cells["ID_SANPHAM_LS"].Value.ToString();
                _orderDangChon = lichSuOrderBLL.LayThongTinLichSuOrder(int.Parse(row.Cells["ID_DATBAN_LS"].Value.ToString()), int.Parse(row.Cells["ID_HOADON_LS"].Value.ToString()), IDSanPham);
                _sanPhamChon = sanPhamBLL.TimKiemSanPhamByID(IDSanPham);
                if (_sanPhamChon == null)
                {
                    btnCapNhatOrder.Visible = false;
                    btnXoaOrder.Visible = false;
                    HienThiThongTin();
                    throw new Exception("Không tìm thấy sản phẩm");
                }
                txtSoLuongSanPham.Text = row.Cells["SOLUONG_LS"].Value.ToString();
                picHienThiSanPham.Image = sanPhamBLL.GetImageByPath(IDSanPham);
                HienThiThongTin();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCapNhatOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    ControlForm.ConfirmForm("Xác nhận cập nhật đơn hàng?")
                    && _sanPhamChon != null
                    && _orderDangChon != null
                )
                {
               
                    string IDSanPham = _sanPhamChon.ID;
                    int donGia = _sanPhamChon.GiaTien;
                    int soLuong = int.Parse(txtSoLuongSanPham.Text);
                    int thanhTien = _giaTienSauGiamGia * soLuong;

                    // Cập nhật lại thông tin order
                    lichSuOrderBLL.CapNhatThongTinOrder(soLuong, donGia, _giaTienSauGiamGia, thanhTien, _orderDangChon.IDHoaDon, _orderDangChon.IDDatBan, _orderDangChon.IDSanPham);

              
                    UpdateLichSuOrder();
                    if (ControlForm.FormChiTietBan != null)
                    {
                        ControlForm.FormChiTietBan.LoadFlowPanelSanPhamOrder();
                    }
                    MessageBox.Show("Thành công");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnXoaOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    ControlForm.ConfirmForm("Xác nhận xóa đơn hàng?")
                    && _sanPhamChon != null
                    && _orderDangChon != null
                )
                {
                    // Xóa order
                    lichSuOrderBLL.XoaOrder(ControlForm.HoaDonHienTai.ID, ControlForm.BanDatDangChon.ID, _sanPhamChon.ID);
                   
                    UpdateLichSuOrder();
                    if (ControlForm.FormChiTietBan != null)
                    {
                        ControlForm.FormChiTietBan.LoadFlowPanelSanPhamOrder();
                    }
                    MessageBox.Show("Thành công");
                    _sanPhamChon = null;
                    _idDonHangCapNhat = null;
                    btnCapNhatOrder.Visible = false;
                    btnXoaOrder.Visible = false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #endregion

        #region Các hàm phục vụ
        void UpdateLichSuOrder()
        {

            DataTable dt;
            dt = lichSuOrderBLL.LayThongTinChiTietLichSuOrder(ControlForm.BanDatDangChon.ID);
            dgvLichSuOrder.DataSource = dt;
        }

        void HienThiThongTin()
        {
            if (_sanPhamChon == null)
            {
                pnlChiTietSanPham.Visible = false;
                return;
            }
            pnlChiTietSanPham.Visible = true;
            lblTenSanPham.Text = $"{_sanPhamChon.TenSanPham}";
            lblGiaTien.Text = $"{_sanPhamChon.GiaTien}";

            _giaTienSauGiamGia = _sanPhamChon.GiaTien;
            if (_sanPhamChon.Event != -1)
            {
                SuKien suKien = suKienBLL.LayThongTinSuKien(_sanPhamChon.Event);

                _giaTienSauGiamGia = _giaTienSauGiamGia - _giaTienSauGiamGia * suKien.GiamGia / 100;
                lblGiamGia.Text = $"Giảm giá: {suKien.GiamGia}% ";
                lblGiamGia.Visible = true;
                lblSuKien.Visible = true;
                lblGiaTien.Font = new Font(lblGiaTien.Font, FontStyle.Strikeout | FontStyle.Bold);
                lblSuKien.Text = $"Sự kiện: {suKien.Ten}";
            }
            else
            {
                lblSuKien.Visible = false;
                lblGiamGia.Visible = false;
                lblGiaTien.Font = new Font(lblGiaTien.Font, FontStyle.Bold);
            }
            lblSauGiamGia.Text = _giaTienSauGiamGia.ToString();

            int tongTien = int.Parse(txtSoLuongSanPham.Text) * _giaTienSauGiamGia;
            lblTongTien.Text = tongTien.ToString();
            lblGiaTien.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblGiaTien.Text));

            lblSauGiamGia.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblSauGiamGia.Text));
            lblTongTien.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblTongTien.Text));
        }
        #endregion
    }
}
