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
    public partial class LichSuCaForm : MaterialForm
    {
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        LichSuCaBLL lichSuCaBLL = new LichSuCaBLL();
        LichSuThanhToanCaBLL lichSuThanhToanCaBLL = new LichSuThanhToanCaBLL();

        public LichSuCaForm()
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

        private void LichSuCaForm_Load(object sender, EventArgs e)
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

                dtpThoiGian.CustomFormat = "yyyy-MM-dd";

                pnlThongTinThanhToan.Visible = false;
                LoadDanhSachTaiKhoan();
                CreateBorderRadius();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #region Các hàm khởi tạo
        void CreateBorderRadius()
        {
            pnlForm.Anchor = AnchorStyles.None;
            pnlForm.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlForm.Width, pnlForm.Height, 15, 15)
            );
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
        }

        void LoadDanhSachTaiKhoan()
        {
            DataTable dt;

            dt = taiKhoanBLL.LoadDanhSachTaiKhoan();

            cboTaiKhoan.DataSource = dt;
            cboTaiKhoan.DisplayMember = "USERNAME";
            cboTaiKhoan.ValueMember = "USERNAME";
        }

        #endregion

        #region Các hàm sự kiện
        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                string taiKhoan = cboTaiKhoan.SelectedValue.ToString();
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

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                string taiKhoan = cboTaiKhoan.SelectedValue.ToString();

                string getDate = dtpThoiGian.Value.ToString("yyyy-MM-dd");
                LichSuThanhToanCa layLichSuThanhToanCa =
                    lichSuThanhToanCaBLL.LayThongTinLichSuThanhToanCa(taiKhoan, getDate);
                // Kiểm tra xem đã được thanh toán ca làm hay chưa
                if (layLichSuThanhToanCa.ThanhToan == 1)
                {
                    throw new Exception("Ca làm đã được thanh toán");
                }
                // Cập nhật trạng thái thanh toán
                lichSuThanhToanCaBLL.CapNhatTrangThaiLichSuThanhToanCa(taiKhoan, getDate);

                btnThanhToan.Visible = false;
                lblDaThanhToan.Visible = true;
                MessageBox.Show("Thanh toán thành công");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        #region Các hàm phục vụ
        void LoadLichSuCa(string taiKhoan, DateTime date)
        {
            string getDate = date.ToString("yyyy-MM-dd");
            lblNgay.Text = getDate;
            int tongGioLam = 0;
            DataTable dt;
            string sqlCommand;
            SqlCommand cmd;
            SqlDataReader rd;
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
                    btnThanhToan.Visible = false;
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
                    btnThanhToan.Visible = true;
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
                lblTongTien.Text = (tongTien).ToString();
                lblTongTien.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblTongTien.Text));
                lblDaThanhToan.Visible = false;
            }
        }
        #endregion
    }
}
