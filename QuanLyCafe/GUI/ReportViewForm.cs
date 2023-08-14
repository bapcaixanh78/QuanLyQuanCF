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
using Microsoft.Reporting.WinForms;
using QuanLyCafe.BLL;
using QuanLyCafe.DTO;

namespace QuanLyCafe.GUI
{
    public partial class ReportViewForm : MaterialForm
    {
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        LichSuOrderBLL lichSuOrderBLL = new LichSuOrderBLL();
        LichSuThanhToanCaBLL lichSuThanhToanCaBLL = new LichSuThanhToanCaBLL();

        public ReportViewForm()
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

        private void ReportViewForm_Load(object sender, EventArgs e)
        {
            if (TaiKhoanHienTai.TaiKhoanHienHanh == null)
            {
                System.Environment.Exit(0);
                return;
            }
            CreateBorderRadius();
            this.rpvBaoCao.RefreshReport();
        }

        void CreateBorderRadius()
        {
            // Tạo border radius
            pnlForm.Anchor = AnchorStyles.None;
            pnlForm.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlForm.Width, pnlForm.Height, 15, 15)
            );
        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControlForm.BaoCaoHienTai == null)
                {
                    throw new Exception("Không có báo cáo nào được tạo");
                }
                if (ControlForm.BaoCaoHienTai.Loai == "doanhthuhoadon")
                {
                    int tongDoanhThu = 0;
                    int soLuongHoaDon = 0;
                    string getDateBatDau = ControlForm.BaoCaoHienTai.NgayBatDau.ToString(
                        "yyyy-MM-dd"
                    );

                    string getDateKetThuc = ControlForm.BaoCaoHienTai.NgayKetThuc.ToString(
                        "yyyy-MM-dd"
                    );

                    DataTable dt;

                    dt = hoaDonBLL.TimHoaDon(getDateBatDau, getDateKetThuc);
                    foreach (DataRow dr in dt.Rows)
                    {
                        tongDoanhThu += (int)dr["THANHTIENGIAMGIA"];
                        soLuongHoaDon++;
                    }
                    string doanhThuString = string.Format(
                        "{0:#,##0} VNĐ",
                        double.Parse(tongDoanhThu.ToString())
                    );

                    rpvBaoCao.ProcessingMode = ProcessingMode.Local;
                    rpvBaoCao.LocalReport.ReportPath = "rptBaoCaoDoanhThuHoaDon.rdlc";

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "dsHoaDon";
                    rds.Value = dt;

                    ReportParameter[] reportParameter = new ReportParameter[5];

                    reportParameter[0] = new ReportParameter("txtTuNgay", $"{getDateBatDau}");
                    reportParameter[1] = new ReportParameter("txtDenNgay", $"{getDateKetThuc}");
                    reportParameter[2] = new ReportParameter(
                        "txtNguoiIn",
                        $"{TaiKhoanHienTai.TaiKhoanHienHanh.UserName}"
                    );
                    reportParameter[3] = new ReportParameter("txtSoHoaDon", $"{soLuongHoaDon}");
                    reportParameter[4] = new ReportParameter(
                        "txtTongDoanhThu",
                        $"{doanhThuString}"
                    );

                    rpvBaoCao.LocalReport.SetParameters(reportParameter);

                    rpvBaoCao.LocalReport.DataSources.Clear();
                    rpvBaoCao.LocalReport.DataSources.Add(rds);
                    rpvBaoCao.RefreshReport();
                }
                else if (ControlForm.BaoCaoHienTai.Loai == "soluongsanphambanra")
                {
                    int tongDoanhThu = 0;
                    int soLuongHoaDon = 0;
                    string getDateBatDau = ControlForm.BaoCaoHienTai.NgayBatDau.ToString(
                        "yyyy-MM-dd"
                    );

                    string getDateKetThuc = ControlForm.BaoCaoHienTai.NgayKetThuc.ToString(
                        "yyyy-MM-dd"
                    );

                    DataTable dt;

                    dt = lichSuOrderBLL.TimLichSuOrderBySanPham(
                        getDateBatDau,
                        getDateKetThuc,
                        ControlForm.BaoCaoHienTai.IDSanPham
                    );
                    foreach (DataRow dr in dt.Rows)
                    {
                        tongDoanhThu += (int)dr["THANHTIEN"];
                        soLuongHoaDon += (int)dr["SOLUONG"];
                    }
                    string doanhThuString = string.Format(
                        "{0:#,##0} VNĐ",
                        double.Parse(tongDoanhThu.ToString())
                    );

                    rpvBaoCao.ProcessingMode = ProcessingMode.Local;
                    rpvBaoCao.LocalReport.ReportPath = "rptSoLuongSanPhamBanRa.rdlc";

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "dsLichSuOrder";
                    rds.Value = dt;

                    ReportParameter[] reportParameter = new ReportParameter[5];

                    reportParameter[0] = new ReportParameter("txtTuNgay", $"{getDateBatDau}");
                    reportParameter[1] = new ReportParameter("txtDenNgay", $"{getDateKetThuc}");
                    reportParameter[2] = new ReportParameter(
                        "txtNguoiIn",
                        $"{TaiKhoanHienTai.TaiKhoanHienHanh.UserName}"
                    );
                    reportParameter[3] = new ReportParameter("txtSoLuong", $"{soLuongHoaDon}");
                    reportParameter[4] = new ReportParameter("txtTongTien", $"{doanhThuString}");

                    rpvBaoCao.LocalReport.SetParameters(reportParameter);

                    rpvBaoCao.LocalReport.DataSources.Clear();
                    rpvBaoCao.LocalReport.DataSources.Add(rds);
                    rpvBaoCao.RefreshReport();
                }
                else if (ControlForm.BaoCaoHienTai.Loai == "doanhthuhoadoncanhan")
                {
                    int tongDoanhThu = 0;
                    int soLuongHoaDon = 0;
                    string getDateBatDau = ControlForm.BaoCaoHienTai.NgayBatDau.ToString(
                        "yyyy-MM-dd"
                    );

                    string getDateKetThuc = ControlForm.BaoCaoHienTai.NgayKetThuc.ToString(
                        "yyyy-MM-dd"
                    );

                    DataTable dt;

                    dt = hoaDonBLL.TimHoaDonByUsername(
                        getDateBatDau,
                        getDateKetThuc,
                        ControlForm.BaoCaoHienTai.TaiKhoan
                    );
                    foreach (DataRow dr in dt.Rows)
                    {
                        tongDoanhThu += (int)dr["THANHTIENGIAMGIA"];
                        soLuongHoaDon++;
                    }
                    string doanhThuString = string.Format(
                        "{0:#,##0} VNĐ",
                        double.Parse(tongDoanhThu.ToString())
                    );

                    rpvBaoCao.ProcessingMode = ProcessingMode.Local;
                    rpvBaoCao.LocalReport.ReportPath = "rptBaoCaoDoanhThuHoaDon.rdlc";

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "dsHoaDon";
                    rds.Value = dt;

                    ReportParameter[] reportParameter = new ReportParameter[5];

                    reportParameter[0] = new ReportParameter("txtTuNgay", $"{getDateBatDau}");
                    reportParameter[1] = new ReportParameter("txtDenNgay", $"{getDateKetThuc}");
                    reportParameter[2] = new ReportParameter(
                        "txtNguoiIn",
                        $"{TaiKhoanHienTai.TaiKhoanHienHanh.UserName}"
                    );
                    reportParameter[3] = new ReportParameter("txtSoHoaDon", $"{soLuongHoaDon}");
                    reportParameter[4] = new ReportParameter(
                        "txtTongDoanhThu",
                        $"{doanhThuString}"
                    );

                    rpvBaoCao.LocalReport.SetParameters(reportParameter);

                    rpvBaoCao.LocalReport.DataSources.Clear();
                    rpvBaoCao.LocalReport.DataSources.Add(rds);
                    rpvBaoCao.RefreshReport();
                }
                else if (ControlForm.BaoCaoHienTai.Loai == "calamnhanvien")
                {
                    int tongTien = 0;
                    int soLuong = 0;
                    int tongGioLam = 0;
                    string getDateBatDau = ControlForm.BaoCaoHienTai.NgayBatDau.ToString(
                        "yyyy-MM-dd"
                    );

                    string getDateKetThuc = ControlForm.BaoCaoHienTai.NgayKetThuc.ToString(
                        "yyyy-MM-dd"
                    );

                    DataTable dt;

                    dt = lichSuThanhToanCaBLL.TimLichSuThanhToanCaByUsername(
                        getDateBatDau,
                        getDateKetThuc,
                        ControlForm.BaoCaoHienTai.TaiKhoan
                    );
                    foreach (DataRow dr in dt.Rows)
                    {
                        tongTien += (int)dr["TONGTIEN"];
                        tongGioLam += (int)dr["TONGGIOLAM"];
                        soLuong++;
                    }
                    string tongTienString = string.Format(
                        "{0:#,##0} VNĐ",
                        double.Parse(tongTien.ToString())
                    );

                    rpvBaoCao.ProcessingMode = ProcessingMode.Local;
                    rpvBaoCao.LocalReport.ReportPath = "rptCaLamNhanVien.rdlc";

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "dsLichSuThanhToanCa";
                    rds.Value = dt;

                    ReportParameter[] reportParameter = new ReportParameter[5];

                    reportParameter[0] = new ReportParameter("txtTuNgay", $"{getDateBatDau}");
                    reportParameter[1] = new ReportParameter("txtDenNgay", $"{getDateKetThuc}");
                    reportParameter[2] = new ReportParameter(
                        "txtNguoiIn",
                        $"{TaiKhoanHienTai.TaiKhoanHienHanh.UserName}"
                    );
                    reportParameter[3] = new ReportParameter("txtSoLuong", $"{soLuong}");
                    reportParameter[4] = new ReportParameter("txtTongTien", $"{tongTienString}");

                    rpvBaoCao.LocalReport.SetParameters(reportParameter);

                    rpvBaoCao.LocalReport.DataSources.Clear();
                    rpvBaoCao.LocalReport.DataSources.Add(rds);
                    rpvBaoCao.RefreshReport();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void ReportViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControlForm.BaoCaoHienTai = null;
        }
    }
}
