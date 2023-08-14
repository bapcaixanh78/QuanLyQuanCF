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
    public partial class HoaDonForm : MaterialForm
    {
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        VoucherBLL voucherBLL = new VoucherBLL();
        BanBLL banBLL = new BanBLL();
        BanDatBLL banDatBLL = new BanDatBLL();
        LichSuOrderBLL lichSuOrderBLL = new LichSuOrderBLL();

        public HoaDonForm()
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

        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (
                    TaiKhoanHienTai.TaiKhoanHienHanh == null
                    || ControlForm.BanDangChon == null
                    || ControlForm.BanDatDangChon == null
                )
                {
                    System.Environment.Exit(0);
                    return;
                }

                CreateBorderRadius();
                CapNhatHoaDon();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #region Các hàm khởi tạo
        void CreateBorderRadius()
        {
            pnlThongTinBanDat.Anchor = AnchorStyles.None;
            pnlThongTinBanDat.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlThongTinBanDat.Width, pnlThongTinBanDat.Height, 15, 15)
            );
        }

        void CapNhatHoaDon()
        {
            // Lấy thông tin hóa đơn hiện tại
            HoaDon hoaDon = hoaDonBLL.LayThongTinHoaDonByIDDatBan(ControlForm.BanDatDangChon.ID);

            if (hoaDon.ThanhToan == 0)
            {
                // lấy thông tin danh sách các order của hóa đơn
                DataTable dt;
                SqlCommand cmd;
                dt = lichSuOrderBLL.LayThongTinTatCaLichSuOrder(hoaDon.ID);
                int thanhTien = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    thanhTien += (int)dr["THANHTIEN"];
                }
                // Reset lại thông tin hóa đơn
                hoaDonBLL.ResetThongTinHoaDon(
                    hoaDon.ThoiGianTao,
                    thanhTien,
                    ControlForm.BanDatDangChon.ID
                );
                HienThiThongTinHoaDon();
            }
        }
        #endregion

        #region Các hàm phục vụ
        void HienThiThongTinHoaDon()
        {
            HoaDon hoaDon = hoaDonBLL.LayThongTinHoaDonByIDDatBan(ControlForm.BanDatDangChon.ID);

            lblMaDatBan.Text = $"Mã đặt bàn: {hoaDon.IDBanDat}";
            lblMaHoaDon.Text = $"Mã hóa đơn: {hoaDon.ID}";
            lblThoiGianHienTai.Text = $"Thời gian tạo: {hoaDon.ThoiGianTao}";
            lblTongTien.Text = hoaDon.ThanhTien.ToString();
            lblTongTien.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblTongTien.Text));
            lblThanhTien.Text = hoaDon.ThanhTienGiamGia.ToString();
            lblThanhTien.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblThanhTien.Text));

            if (hoaDon.ThanhToan == 1)
            {
                // Ẩn và hiển thị các control sau khi thanh toán thành công
                foreach (Control c in pnlTongQuanHoaDon.Controls)
                {
                    if ((string)c.Tag == "CHUATHANHTOAN")
                    {
                        c.Visible = false;
                    }
                }
                txtVoucher.Visible = false;
                txtSoTienKhachTra.Visible = false;

                lblDaThanhToan.Visible = true;
                btnInHoaDon.Visible = true;
            }
        }

        #endregion

        #region Các hàm sự kiện
        private void btnCheckVoucher_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControlForm.BanDangChon == null || ControlForm.BanDatDangChon == null)
                {
                    throw new Exception("Bàn không tồn tại!");
                }

                HoaDon getHoaDon = hoaDonBLL.LayThongTinHoaDonByIDDatBan(
                    ControlForm.BanDatDangChon.ID
                );
                if (getHoaDon == null)
                {
                    throw new Exception("Hóa đơn không tồn tại!");
                }
                if (getHoaDon.ThanhToan == 1)
                {
                    throw new Exception("Bàn đã thanh toán hóa đơn");
                }
                if (string.IsNullOrEmpty(txtVoucher.Text.Trim()))
                {
                    throw new Exception("Vui lòng nhập Voucher");
                }

                // Kiểm tra xem có tồn tại voucher
                if (voucherBLL.KiemTraVoucher(txtVoucher.Text.Trim()))
                {
                    Voucher voucher = voucherBLL.LayThongTinVoucher(txtVoucher.Text.Trim());
                    int giamGiaVoucher = voucher.GiamGia;
                    // Cập nhật lại số tiền của hóa đơn
                    int thanhTienGiamGia =
                        getHoaDon.ThanhTien - getHoaDon.ThanhTien * giamGiaVoucher / 100;

                    // Hiển thị các control sau khi dùng voucher
                    lblThongBaoVoucher.Visible = true;
                    lblThongBaoVoucher.Text =
                        $"Voucher: {txtVoucher.Text.ToUpper()} - Giảm giá: {giamGiaVoucher}%";
                    lblThanhTien.Text = thanhTienGiamGia.ToString();
                    lblThanhTien.Text = string.Format(
                        "{0:#,##0} VNĐ",
                        double.Parse(lblThanhTien.Text)
                    );
                    // Cập nhật lại hóa đơn trong database
                    hoaDonBLL.CapNhatDungVoucher(
                        thanhTienGiamGia,
                        txtVoucher.Text.Trim(),
                        ControlForm.BanDatDangChon.ID
                    );

                    MessageBox.Show("Áp dụng voucher thành công");
                }
                else
                {
                    // Hủy áp mã voucher
                    int thanhTienGiamGia = getHoaDon.ThanhTien;

                    // Cập nhật lại hóa đơn trong database
                    hoaDonBLL.CapNhatDungVoucherNULL(
                        thanhTienGiamGia,
                        ControlForm.BanDatDangChon.ID
                    );

                    lblThanhTien.Text = (thanhTienGiamGia).ToString();
                    lblThanhTien.Text = string.Format(
                        "{0:#,##0} VNĐ",
                        double.Parse(lblThanhTien.Text)
                    );

                    lblThongBaoVoucher.Visible = false;
                    throw new Exception("Không tồn tại voucher này");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControlForm.BanDangChon == null || ControlForm.BanDatDangChon == null)
                {
                    throw new Exception("Bàn không tồn tại!");
                }
                HoaDon getHoaDon = hoaDonBLL.LayThongTinHoaDonByIDDatBan(
                    ControlForm.BanDatDangChon.ID
                );

                if (getHoaDon == null)
                {
                    throw new Exception("Hóa đơn không tồn tại!");
                }
                if (getHoaDon.ThanhToan == 1)
                {
                    throw new Exception("Bàn đã thanh toán hóa đơn");
                }

                if (string.IsNullOrEmpty(txtSoTienKhachTra.Text.Trim()))
                {
                    throw new Exception("Vui lòng nhập số tiền khách trả");
                }
                int soTienKhachTra = int.Parse(txtSoTienKhachTra.Text.Trim());

                if (soTienKhachTra < getHoaDon.ThanhTienGiamGia)
                {
                    throw new Exception("Khách không đủ tiền");
                }
                if (!string.IsNullOrEmpty(getHoaDon.VoucherHoaDon) &&  !voucherBLL.KiemTraVoucher(getHoaDon.VoucherHoaDon))
                {
                    throw new Exception("Voucher không tồn tại");
                }
                // Cập nhật hóa đơn trong database
                int tienThua = soTienKhachTra - getHoaDon.ThanhTienGiamGia;
                hoaDonBLL.CapNhatThanhToan(
                    DateTime.Now,
                    soTienKhachTra,
                    tienThua,
                    ControlForm.BanDatDangChon.ID
                );

                // Cập nhật thời gian ra bàn cho lịch sử đặt bàn
                banDatBLL.CapNhatThoiGianRaBan(ControlForm.BanDatDangChon.ID);

                // Cập nhật lượt dùng voucher
                voucherBLL.CapNhatLuotDungVoucher(1, getHoaDon.VoucherHoaDon);

                // Cập nhật lại trạng thái bàn trống
                banBLL.CapNhatTinhTrangBanTrong(ControlForm.BanDangChon.ID);

     
                // Ẩn và hiển thị các control sau khi thanh toán thành công
                foreach (Control c in pnlTongQuanHoaDon.Controls)
                {
                    if ((string)c.Tag == "CHUATHANHTOAN")
                    {
                        c.Visible = false;
                    }
                }
                txtVoucher.Visible = false;
                txtSoTienKhachTra.Visible = false;

                lblDaThanhToan.Visible = true;
                btnInHoaDon.Visible = true;

                HoaDon getHoaDonBaoCao = hoaDonBLL.LayThongTinHoaDonByIDDatBan(ControlForm.BanDatDangChon.ID);
                ControlForm.HoaDonHienTai = getHoaDonBaoCao;

                // Hiển thị form thanh toán thành công
                GUI.ThanhToanThanhCongForm fThanhToanThanhCong = new GUI.ThanhToanThanhCongForm();
                fThanhToanThanhCong.ShowDialog();

    

                // Khởi tạo lại trạng thái bàn
                if (ControlForm.FormChiTietBan != null)
                {
                    ControlForm.FormChiTietBan.ResetForm();
                }
                if (ControlForm.FormMain != null)
                {
                    ControlForm.FormMain.LoadDanhSachBan();
                    ControlForm.FormMain.LoadFlowPanelDanhSachBan();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txtSoTienKhachTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (ControlForm.BanDangChon != null)
            {
                GUI.XuatHoaDonForm fXuatHoaDon = new GUI.XuatHoaDonForm();
                fXuatHoaDon.ShowDialog();
            }
        }

        #endregion
    }
}
