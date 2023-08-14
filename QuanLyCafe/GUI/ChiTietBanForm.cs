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
    public partial class ChiTietBanForm : MaterialForm
    {
        BanBLL banBLL = new BanBLL();
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        SanPhamBLL sanPhamBLL = new SanPhamBLL();
        BanDatBLL banDatBLL = new BanDatBLL();
        LichSuOrderBLL lichSuOrderBLL = new LichSuOrderBLL();
        int _tongTien = 0;
        int _soMon = 0;
        BanDat _banDat = null;

        public ChiTietBanForm()
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

        private void ChiTietBanForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (TaiKhoanHienTai.TaiKhoanHienHanh == null)
                {
                    System.Environment.Exit(0);
                    return;
                }

                ControlForm.FormChiTietBan = this;

                CreateBorderRadius();
                HienThiThongTinBan();
                UpdateLichSuOrder();
                LoadFlowPanelSanPhamOrder();
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
            pnlChonChucNang.Anchor = AnchorStyles.None;
            pnlChonChucNang.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlChonChucNang.Width, pnlChonChucNang.Height, 15, 15)
            );

            pnlThongTinBanDat.Anchor = AnchorStyles.None;
            pnlThongTinBanDat.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlThongTinBanDat.Width, pnlThongTinBanDat.Height, 15, 15)
            );
        }

        public void HienThiThongTinBan()
        {
            if (ControlForm.BanDangChon != null)
            {
                // lấy thông tin bàn mới nhất
                Ban getBan = banBLL.TimKiemBanByID(ControlForm.BanDangChon.ID);
                ControlForm.BanDangChon = getBan;

                lblTenBan.Text = $"Tên Bàn: {ControlForm.BanDangChon.TenBan}";
                string tinhTrangBan =
                    ControlForm.BanDangChon.TinhTrang == 0 ? "Đang trống" : "Đã đặt";
                lblTinhTrangBan.Text = $"Tình trạng: {tinhTrangBan}";
                // Bàn đang có người đặt
                if (ControlForm.BanDangChon.TinhTrang != 0)
                {
                    // Lấy thông tin lịch sử đặt bàn mới nhất:
                    BanDat banDat = banDatBLL.LayThongTinBanDatMoiNhat(ControlForm.BanDangChon.ID);
                    _banDat = banDat;
                    ControlForm.BanDatDangChon = banDat;
                }

                if (ControlForm.BanDatDangChon != null)
                {
                    btnMoBan.Visible = false;
                    btnOrders.Visible = true;
                    pnlThongTinBanDat.Visible = true;
                    lblThoiGianVaoBan.Text =
                        $"Thời gian vào bàn: {ControlForm.BanDatDangChon.ThoiGianVaoBan}";
                }
                else
                {
                    btnMoBan.Visible = true;
                    btnOrders.Visible = false;
                    pnlThongTinBanDat.Visible = false;
                }
            }
        }

        public void UpdateLichSuOrder()
        {
            if (ControlForm.BanDangChon != null && _banDat != null)
            {
                _tongTien = 0;
                _soMon = 0;

                DataTable dt;
                dt = lichSuOrderBLL.LayThongTinChiTietLichSuOrder(_banDat.ID);
                _soMon = dt.Rows.Count;
                foreach (DataRow dr in dt.Rows)
                {
                    _tongTien += Convert.ToInt32(dr["THANHTIEN_LS"]);
                }
                lblSoMon.Text = _soMon.ToString();
                lblTongTien.Text = _tongTien.ToString();
                lblTongTien.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblTongTien.Text));
                lblThanhTien.Text = _tongTien.ToString();
                lblThanhTien.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblThanhTien.Text));
            }
        }

        #endregion

        #region Các hàm sự kiện
        private void btnMoBan_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControlForm.BanDangChon == null)
                {
                    throw new Exception("Vui lòng chọn bàn");
                }
                // Kiểm tra xem bàn đã đặt hay chưa
                if (!banBLL.KiemTraTinhTrangBanChuaDat(ControlForm.BanDangChon))
                {
                    throw new Exception("Bàn đã được mở rồi");
                }

                if (ControlForm.ConfirmForm("Xác nhận mở bàn?"))
                {
                    DateTime thoiGianHienTai = DateTime.Now;

                    // Thêm lịch sử đặt bàn
                    int idBanDat = banBLL.ThemLichSuDatBan(ControlForm.BanDangChon);

                    // Tạo mới hóa đơn
                    HoaDon hoaDonMoi = new HoaDon();
                    hoaDonMoi.NhanVienHoaDon = TaiKhoanHienTai.TaiKhoanHienHanh.UserName;
                    hoaDonMoi.IDBanDat = idBanDat;
                    hoaDonBLL.ThemHoaDon(hoaDonMoi);

                    HoaDon getHoaDon = hoaDonBLL.LayThongTinHoaDonByIDDatBan(idBanDat);
                    ControlForm.HoaDonHienTai = getHoaDon;

                    // Cập nhật tình trạng bàn
                    if (banBLL.CapNhatTinhTrangBanDat(ControlForm.BanDangChon))
                    {
                        ControlForm.BanDangChon.TinhTrang = 1;

                        HienThiThongTinBan();
                        UpdateLichSuOrder();
                        if (ControlForm.FormMain != null)
                        {
                            ControlForm.FormMain.LoadFlowPanelDanhSachBan();
                        }
                        btnMoBan.Visible = false;
                        btnOrders.Visible = true;
                        pnlThongTinBanDat.Visible = true;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void ChiTietBanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControlForm.BanDangChon = null;
            ControlForm.FormChiTietBan = null;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControlForm.BanDangChon != null && ControlForm.BanDangChon.TinhTrang != 0)
                {
                    ControlForm.BanDatDangChon = _banDat;
                    OrderForm fOrder = new OrderForm();
                    fOrder.ShowDialog();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonForm fHoaDon = new HoaDonForm();
            fHoaDon.ShowDialog();
        }

        #endregion

        #region Các hàm phục vụ

        public void ResetForm()
        {
            ControlForm.BanDatDangChon = null;
            _banDat = null;
            flpDanhSachSanPhamOrder.Controls.Clear();
            HienThiThongTinBan();
        }

        public void LoadFlowPanelSanPhamOrder()
        {
            if (ControlForm.BanDangChon != null && _banDat != null)
            {
                flpDanhSachSanPhamOrder.Controls.Clear();
                _tongTien = 0;
                _soMon = 0;
                DataTable dt;
                dt = lichSuOrderBLL.LayThongTinChiTietLichSuOrder(_banDat.ID);
                _soMon = dt.Rows.Count;
                foreach (DataRow dr in dt.Rows)
                {
                    _tongTien += Convert.ToInt32(dr["THANHTIEN_LS"]);
                }
                lblSoMon.Text = _soMon.ToString();
                lblTongTien.Text = _tongTien.ToString();
                lblTongTien.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblTongTien.Text));
                lblThanhTien.Text = _tongTien.ToString();
                lblThanhTien.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblThanhTien.Text));

                foreach (DataRow dr in dt.Rows)
                {
                    Random random = new Random();
                    int color1 = random.Next(236, 255);
                    int color2 = random.Next(238, 255);
                    int color3 = random.Next(207, 255);
                    MaterialCard card = new ReaLTaiizor.Controls.MaterialCard();
                    card.Width = 657;
                    card.Height = 199;

                    PictureBox pic = new PictureBox();
                    pic.Width = 141;
                    pic.Height = 133;
                    pic.Location = new Point(25, 37);
                    pic.BackColor = Color.FromArgb(color1, color2, color3);
                    pic.Image = sanPhamBLL.GetImageByPath((string)dr["ID_SANPHAM_LS"]);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Anchor = AnchorStyles.None;
                    pic.Region = Region.FromHrgn(
                        CreateRoundRectRgn(0, 0, pic.Width, pic.Height, 15, 15)
                    );
                    card.Controls.Add(pic);

                    Label lblTenSanPham = new Label();
                    lblTenSanPham.AutoSize = false;
                    lblTenSanPham.Width = 400;
                    lblTenSanPham.Text = (string)dr["TEN_SANPHAM_LS"];
                    lblTenSanPham.Font = new Font("Arial", 11, FontStyle.Bold);
                    lblTenSanPham.ForeColor = Color.FromArgb(80, 80, 80);
                    card.Controls.Add(lblTenSanPham);
                    lblTenSanPham.Location = new Point(pic.Width + pic.Location.X + 10, 24);

                    Label lblDonGia = new Label();
                    lblDonGia.AutoSize = false;
                    lblDonGia.Width = 400;
                    lblDonGia.Text = dr["DONGIAGIAM_LS"].ToString();
                    lblDonGia.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblDonGia.Text));

                    lblDonGia.Font = new Font("Arial", 11, FontStyle.Bold);
                    lblDonGia.ForeColor = Color.FromArgb(63, 81, 181);
                    card.Controls.Add(lblDonGia);
                    lblDonGia.Location = new Point(pic.Width + pic.Location.X + 10, 55);

                    Label lblThanhTien = new Label();
                    lblThanhTien.AutoSize = false;
                    lblThanhTien.Width = 400;
                    lblThanhTien.Text = dr["THANHTIEN_LS"].ToString();
                    lblThanhTien.Text = string.Format(
                        "{0:#,##0} VNĐ",
                        double.Parse(lblThanhTien.Text)
                    );
                    lblThanhTien.Font = new Font("Arial", 11, FontStyle.Bold);
                    lblThanhTien.ForeColor = Color.FromArgb(63, 81, 181);
                    card.Controls.Add(lblThanhTien);
                    lblThanhTien.Location = new Point(pic.Width + pic.Location.X + 10, 83);

                    Label lblThoiGian = new Label();
                    lblThoiGian.AutoSize = false;
                    lblThoiGian.Width = 400;
                    lblThoiGian.Text = dr["THOIGIAN_LS"].ToString();
                    lblThoiGian.Font = new Font("Arial", 11, FontStyle.Bold);
                    lblThoiGian.ForeColor = Color.FromArgb(80, 80, 80);
                    card.Controls.Add(lblThoiGian);
                    lblThoiGian.Location = new Point(pic.Width + pic.Location.X + 10, 117);

                    MaterialTextBoxEdit txtSoLuong = new MaterialTextBoxEdit();
                    txtSoLuong.UseTallSize = false;
                    txtSoLuong.ReadOnly = true;
                    txtSoLuong.Text = dr["SOLUONG_LS"].ToString();
                    txtSoLuong.Width = 80;
                    txtSoLuong.Height = 36;
                    txtSoLuong.Location = new Point(pic.Width + pic.Location.X + 10, 153);
                    card.Controls.Add(txtSoLuong);

                    flpDanhSachSanPhamOrder.Controls.Add(card);
                }
            }
        }
        #endregion
    }
}
