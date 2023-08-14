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
    public partial class DoanhThuForm : MaterialForm
    {
        DoanhThuBLL doanhThuBLL = new DoanhThuBLL();
        int _tongHoaDon = 0;
        int _tongDoanhThu = 0;

        public DoanhThuForm()
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

        private void DoanhThuForm_Load(object sender, EventArgs e)
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
                FormatDate();
                CreateBorderRadius();
                pnlThongTinDoanhThu.Visible = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #region Các hàm khởi tạo
        void FormatDate()
        {
            dtpThoiGianBatDau.CustomFormat = "yyyy-MM-dd";
            dtpThoiGianKetThuc.CustomFormat = "yyyy-MM-dd";
        }

        void CreateBorderRadius()
        {
            pnlForm.Anchor = AnchorStyles.None;
            pnlForm.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlForm.Width, pnlForm.Height, 15, 15)
            );

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
        #endregion

        #region Các hàm sự kiện
        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime getDateTimeBatDau = dtpThoiGianBatDau.Value;
                DateTime getFilterDateBatDau = new DateTime(
                    getDateTimeBatDau.Year,
                    getDateTimeBatDau.Month,
                    getDateTimeBatDau.Day
                );

                DateTime getDateTimeKetThuc = dtpThoiGianKetThuc.Value;
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
                string getDateKetThuc = getDateTimeKetThuc.ToString("yyyy-MM-dd");
                DataTable dt;
                Dictionary<string, string> resultDoanhThu = doanhThuBLL.LoadDoanhThu(
                    getDateBatDau,
                    getDateKetThuc
                );
                dt = doanhThuBLL.LoadDoanhThuDataTable(getDateBatDau, getDateKetThuc);
                dgvHoaDon.DataSource = dt;
                lblTuNgay.Text = resultDoanhThu["tuNgay"];
                lblDenNgay.Text = resultDoanhThu["denNgay"];

                lblTongHoaDon.Text = resultDoanhThu["tongHoaDon"];
                lblDoanhThu.Text = resultDoanhThu["tongDoanhThu"];
                lblDoanhThu.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblDoanhThu.Text));

                pnlThongTinDoanhThu.Visible = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                BaoCao baoCaoMoi = new BaoCao("doanhthuhoadon", TaiKhoanHienTai.TaiKhoanHienHanh.UserName);
                baoCaoMoi.SetBaoCaoDoanhThu(dtpThoiGianBatDau.Value, dtpThoiGianKetThuc.Value);
                ControlForm.BaoCaoHienTai = baoCaoMoi;
                GUI.ReportViewForm fBaoCao = new GUI.ReportViewForm();
                fBaoCao.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        #endregion
    }
}
