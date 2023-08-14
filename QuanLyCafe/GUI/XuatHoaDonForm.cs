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
    public partial class XuatHoaDonForm : MaterialForm
    {
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        VoucherBLL voucherBLL = new VoucherBLL();
        BanDatBLL banDatBLL = new BanDatBLL();
        BanBLL banBLL = new BanBLL();
        LichSuOrderBLL lichSuOrderBLL = new LichSuOrderBLL();
        HoaDon _hoaDonHienTai = null;
        BanDat _banDatHienTai = null;

        public XuatHoaDonForm()
        {
            try
            {
                InitializeComponent();

                _hoaDonHienTai = ControlForm.HoaDonHienTai;

                GetBanDat();
                if (_hoaDonHienTai != null)
                {

                    lblXuatHoaDon.Text = $"Xuất hóa đơn {_hoaDonHienTai.ID}";

                    ppdXemTruocHoaDon.Document = pdcHoaDon;
                    ppdXemTruocHoaDon.Show();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        void GetBanDat()
        {
            if (_hoaDonHienTai != null)
            {
                _hoaDonHienTai = hoaDonBLL.LayThongTinHoaDon(_hoaDonHienTai.ID);
                _banDatHienTai = banDatBLL.LayThongTinBanDatByID(_hoaDonHienTai.IDBanDat);
            }
        }

        private void pdcHoaDon_PrintPage(
            object sender,
            System.Drawing.Printing.PrintPageEventArgs e
        )
        {
            try
            {
                // Create rectangle for drawing.
                float x = 239;
                float y = 10f;
                float width = 310f;
                float height = 60f;
                RectangleF drawRect = new RectangleF(x, y, width, height);

                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;
                e.Graphics.DrawString(
                    $"{HeThong.TenCuaHang}",
                    new Font("Arial", 20, FontStyle.Bold),
                    Brushes.Black,
                    drawRect,
                    sf
                );

                RectangleF drawRectDiaChi = new RectangleF(x - 15f, y + 20f, 350f, height);
                e.Graphics.DrawString(
                    $"{HeThong.DiaChiCuaHang}",
                    new Font("Arial", 12, FontStyle.Bold),
                    Brushes.Black,
                    drawRectDiaChi,
                    sf
                );

                RectangleF drawRectHoaDonID = new RectangleF(
                    x - 15f,
                    drawRectDiaChi.Top + 20f,
                    350f,
                    height
                );
                e.Graphics.DrawString(
                    $"Receipt No: {_hoaDonHienTai.ID}",
                    new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black,
                    drawRectHoaDonID,
                    sf
                );

                RectangleF drawRectHoaDonDate = new RectangleF(
                    x - 15f,
                    drawRectHoaDonID.Top + 20f,
                    350f,
                    height
                );
                e.Graphics.DrawString(
                    $"Date: {_hoaDonHienTai.ThoiGianTao}",
                    new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black,
                    drawRectHoaDonDate,
                    sf
                );

                RectangleF drawRectHoaDonCashier = new RectangleF(
                    x - 15f,
                    drawRectHoaDonDate.Top + 20f,
                    350f,
                    height
                );
                TaiKhoan getNhanVien = taiKhoanBLL.LayThongTinCaNhan(_hoaDonHienTai.NhanVienHoaDon);
                string fullNameNhanVien = $"{getNhanVien.FirstName} {getNhanVien.LastName}";
                e.Graphics.DrawString(
                    $"Cashier: @{getNhanVien.UserName}",
                    new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black,
                    drawRectHoaDonCashier,
                    sf
                );

                RectangleF drawRectHoaDonDescription = new RectangleF(
                    x - 15f,
                    drawRectHoaDonCashier.Top + 20f,
                    350f,
                    height
                );
                e.Graphics.DrawString(
                    $"Description:",
                    new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black,
                    drawRectHoaDonDescription,
                    sf
                );

                string gachNgang = "================================";
                RectangleF drawRectHoaDonGachNgang = new RectangleF(
                    x - 15f,
                    drawRectHoaDonDescription.Top + 20f,
                    350f,
                    height
                );
                e.Graphics.DrawString(
                    gachNgang,
                    new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black,
                    drawRectHoaDonGachNgang,
                    sf
                );

                DataTable dt;
                dt = lichSuOrderBLL.LayThongTinChiTietLichSuOrder(_banDatHienTai.ID);

                string sanPham;
                float positionY = drawRectHoaDonGachNgang.Top + 40f;
                int tongTien = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    sanPham =
                        $"{dr["SOLUONG_LS"]} - {dr["TEN_SANPHAM_LS"]} - DONGIA: {string.Format("{0:#,##0}", double.Parse(dr["DONGIA_LS"].ToString()))} - GIAM: {string.Format("{0:#,##0}", double.Parse(dr["DONGIAGIAM_LS"].ToString()))} - THANHTIEN: {string.Format("{0:#,##0}", double.Parse(dr["THANHTIEN_LS"].ToString()))}";
                    e.Graphics.DrawString(
                        sanPham,
                        new Font("Arial", 12, FontStyle.Regular),
                        Brushes.Black,
                        new PointF(10f, positionY)
                    );
                    positionY = positionY + 20f;
                    tongTien += (int)dr["THANHTIEN_LS"];
                }
                drawRectHoaDonGachNgang = new RectangleF(x - 15f, positionY, 350f, height);
                e.Graphics.DrawString(
                    gachNgang,
                    new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black,
                    drawRectHoaDonGachNgang,
                    sf
                );

                RectangleF drawRectHoaDonOverview = new RectangleF(
                    x - 15f,
                    drawRectHoaDonGachNgang.Top + 20f,
                    350f,
                    height
                );
                string tongQuan =
                    $"{dt.Rows.Count} Item(s) (VAT included) {string.Format("{0:#,##0}", double.Parse(tongTien.ToString()))}";
                e.Graphics.DrawString(
                    tongQuan,
                    new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black,
                    drawRectHoaDonOverview,
                    sf
                );
                drawRectHoaDonOverview = new RectangleF(
                    x - 100f,
                    drawRectHoaDonOverview.Top + 20f,
                    550f,
                    height
                );
                tongQuan = $"DATE IN: {_banDatHienTai.ThoiGianVaoBan}";
                e.Graphics.DrawString(
                    tongQuan,
                    new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black,
                    drawRectHoaDonOverview,
                    sf
                );
                drawRectHoaDonOverview = new RectangleF(
                    x - 100f,
                    drawRectHoaDonOverview.Top + 20f,
                    550f,
                    height
                );
                tongQuan = $"DATE OUT: {_banDatHienTai.ThoiGianRaBan}";
                e.Graphics.DrawString(
                    tongQuan,
                    new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black,
                    drawRectHoaDonOverview,
                    sf
                );
                if (!string.IsNullOrEmpty(_hoaDonHienTai.VoucherHoaDon))
                {
                    Voucher getVoucher = voucherBLL.LayThongTinVoucher(
                        _hoaDonHienTai.VoucherHoaDon
                    );
                    drawRectHoaDonOverview = new RectangleF(
                        x - 100f,
                        drawRectHoaDonOverview.Top + 20f,
                        550f,
                        height
                    );
                    tongQuan =
                        $"VOUCHER: {_hoaDonHienTai.VoucherHoaDon} (DISCOUNT {getVoucher.GiamGia}%) {string.Format("{0:#,##0}", double.Parse((tongTien - tongTien * getVoucher.GiamGia / 100).ToString()))}";
                    e.Graphics.DrawString(
                        tongQuan,
                        new Font("Arial", 12, FontStyle.Regular),
                        Brushes.Black,
                        drawRectHoaDonOverview,
                        sf
                    );
                }
                drawRectHoaDonOverview = new RectangleF(
                    x - 15f,
                    drawRectHoaDonOverview.Top + 20f,
                    350f,
                    height
                );
                tongQuan =
                    $"CASH: {string.Format("{0:#,##0}", double.Parse(_hoaDonHienTai.TienKhachTra.ToString()))}";
                e.Graphics.DrawString(
                    tongQuan,
                    new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black,
                    drawRectHoaDonOverview,
                    sf
                );
                drawRectHoaDonOverview = new RectangleF(
                    x - 15f,
                    drawRectHoaDonOverview.Top + 20f,
                    350f,
                    height
                );
                tongQuan =
                    $"CHANGE: {string.Format("{0:#,##0}", double.Parse(_hoaDonHienTai.TienThua.ToString()))}";
                e.Graphics.DrawString(
                    tongQuan,
                    new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black,
                    drawRectHoaDonOverview,
                    sf
                );
                drawRectHoaDonOverview = new RectangleF(
                    x - 15f,
                    drawRectHoaDonOverview.Top + 20f,
                    350f,
                    height
                );
                tongQuan = $"Chi xuat hoa don trong ngay";
                e.Graphics.DrawString(
                    tongQuan,
                    new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black,
                    drawRectHoaDonOverview,
                    sf
                );
                drawRectHoaDonOverview = new RectangleF(
                    x - 15f,
                    drawRectHoaDonOverview.Top + 20f,
                    350f,
                    height
                );
                tongQuan = $"Xin cam on quy khach!";
                e.Graphics.DrawString(
                    tongQuan,
                    new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black,
                    drawRectHoaDonOverview,
                    sf
                );
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
