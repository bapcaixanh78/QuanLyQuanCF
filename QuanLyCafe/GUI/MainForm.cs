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
    public partial class MainForm : MaterialForm
    {
        SanPhamBLL sanPhamBLL = new SanPhamBLL();
        SuKienBLL suKienBLL = new SuKienBLL();
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        BanBLL banBLL = new BanBLL();
        VoucherBLL voucherBLL = new VoucherBLL();
        HeThongBLL heThongBLL = new HeThongBLL();
        LichSuCaBLL lichSuCaBLL = new LichSuCaBLL();
        bool _isClickLocThucAn = false;
        bool _isClickLocKhac = false;
        bool _isClickLocNuoc = false;
        bool _isClickBanChuaDat = false;
        bool _isClickBanDaDat = false;
        int _ketQuaTimThaySanPham = 0;
        int _ketQuaTimThayBan = 0;

        Timer _timerThoiGianHienTai;

        public MainForm()
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (TaiKhoanHienTai.TaiKhoanHienHanh == null)
                {
                    System.Environment.Exit(0);
                    return;
                }

                ControlForm.FormMain = this;

                CreateBoderRadiusControl();

                // Các hàm khởi tạo vào hệ thống
                LoadHeThong();
                LoadDanhSachVoucher();
                LoadDanhSachTaiKhoan();
                LoadDanhSachHoaDon();
                LoadDanhSachSuKien();

                LoadDanhSachSanPham();
                //LoadDanhSachBanDat();
                LoadDanhSachBan();
                LoadThongTinNhanVien();
                LoadThoiGianHienTai();

                // Hiển thị danh sách sản phẩm
                LoadFlowPanelSanPham();
                // Hiển thị danh sách bàn
                LoadFlowPanelDanhSachBan();
                // Hiển thị danh sách sự kiện
                LoadFlowPanelDanhSachSuKien();
                // Hiển thị danh sách voucher
                LoadFlowPanelDanhSachVoucher();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #region Các hàm khởi tạo hệ thống
        void CreateBoderRadiusControl()
        {
            // Tạo border radius cho các control
            pnlForm.Anchor = AnchorStyles.None;
            pnlForm.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlForm.Width, pnlForm.Height, 15, 15)
            );

            picBanChuaDat.Anchor = AnchorStyles.None;
            picBanChuaDat.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, picBanChuaDat.Width, picBanChuaDat.Height, 15, 15)
            );

            pnlWelcomeBack.Anchor = AnchorStyles.None;
            pnlWelcomeBack.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlWelcomeBack.Width, pnlWelcomeBack.Height, 30, 30)
            );

            pnlDanhSachSuKien.Anchor = AnchorStyles.None;
            pnlDanhSachSuKien.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlDanhSachSuKien.Width, pnlDanhSachSuKien.Height, 30, 30)
            );

            pnlDanhSachVoucher.Anchor = AnchorStyles.None;
            pnlDanhSachVoucher.Region = Region.FromHrgn(
                CreateRoundRectRgn(
                    0,
                    0,
                    pnlDanhSachVoucher.Width,
                    pnlDanhSachVoucher.Height,
                    30,
                    30
                )
            );

            picBanDaDat.Anchor = AnchorStyles.None;
            picBanDaDat.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, picBanDaDat.Width, picBanDaDat.Height, 15, 15)
            );

            pnlVoucher.Anchor = AnchorStyles.None;
            pnlVoucher.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlVoucher.Width, pnlVoucher.Height, 15, 15)
            );
        }

        void LoadHeThong()
        {
            heThongBLL.LoadHeThong();
        }

        public void LoadDanhSachVoucher() { }

        public void LoadDanhSachTaiKhoan() { }

        public void LoadDanhSachHoaDon() { }

        public void LoadDanhSachSuKien()
        {
            DataTable dt;
            dt = suKienBLL.LoadDanhSachSuKien();

            DataRow emptyRow = dt.NewRow();
            emptyRow["ID"] = "-1";
            emptyRow["TEN"] = "Trống";
            dt.Rows.InsertAt(emptyRow, 0);

            cboDanhSachSuKien.DataSource = dt;
            cboDanhSachSuKien.DisplayMember = "TEN";
            cboDanhSachSuKien.ValueMember = "ID";
            cboDanhSachSuKien.SelectedIndex = 0;
            UpdateSuKien();
        }

        void UpdateSuKien()
        {
            DateTime today = DateTime.Now;
            SuKien[] danhSachSuKien = suKienBLL.GetList();
            foreach (var item in danhSachSuKien)
            {
                // Kiểm tra xem nếu thời gian kết thúc sự kiện đã qua thì set sự kiện = NULL
                if (today >= item.ThoiGianKetThuc)
                {
                    sanPhamBLL.UpdateHetThoiGianSuKien(item.ID);
                }
            }
        }

        void LoadThoiGianHienTai()
        {
            lblThoiGianHienTai.Text = $"{DateTime.Now}";
            _timerThoiGianHienTai = new Timer();
            _timerThoiGianHienTai.Tick += _timerThoiGianHienTai_Tick;
            _timerThoiGianHienTai.Interval = 1000;
            _timerThoiGianHienTai.Enabled = false;
            _timerThoiGianHienTai.Start();
        }

        public void LoadThongTinNhanVien()
        {
            if (TaiKhoanHienTai.TaiKhoanHienHanh.QuyenHan == 1)
            {
                flpDanhSachQuanLy.Visible = false;
            }
            else
            {
                flpDanhSachQuanLy.Visible = true;
            }
            lblHoTenNhanVien.Text =
                $"{TaiKhoanHienTai.TaiKhoanHienHanh.FirstName} {TaiKhoanHienTai.TaiKhoanHienHanh.LastName}";
            string chucVu =
                TaiKhoanHienTai.TaiKhoanHienHanh.QuyenHan == 1 ? "Nhân viên cửa hàng" : "Quản lý";
            lblChucVuNhanVien.Text = chucVu;
            lblHoTenNhanVien.Location = new Point(
                (lblHoTenNhanVien.Parent.ClientSize.Width / 2) - (lblHoTenNhanVien.Width / 2),
                114
            );
            lblChucVuNhanVien.Location = new Point(
                (lblChucVuNhanVien.Parent.ClientSize.Width / 2) - (lblChucVuNhanVien.Width / 2),
                141
            );
        }

        public void LoadFlowPanelDanhSachSuKien()
        {
            flpDanhSachSuKien.Controls.Clear();
            SuKien[] danhSachSuKien = suKienBLL.GetList();
            foreach (var item in danhSachSuKien)
            {
                MaterialCard card = new ReaLTaiizor.Controls.MaterialCard();
                card.Width = 409;
                card.Height = 128;

                card.Location = new Point(14, 14);

                Label lblTenSuKien = new Label();
                lblTenSuKien.AutoSize = false;
                lblTenSuKien.Width = 390;
                lblTenSuKien.Text = $"Tên: {item.Ten}";
                lblTenSuKien.Font = new Font("Arial", 11, FontStyle.Bold);
                lblTenSuKien.Location = new Point(17, 14);
                card.Controls.Add(lblTenSuKien);

                Label lblGiamGia = new Label();
                lblGiamGia.AutoSize = false;
                lblGiamGia.Width = 390;
                lblGiamGia.Text = $"Giảm giá: {item.GiamGia}%";
                lblGiamGia.Font = new Font("Arial", 11, FontStyle.Bold);
                lblGiamGia.Location = new Point(17, 40);
                card.Controls.Add(lblGiamGia);

                Label lblBatDau = new Label();
                lblBatDau.AutoSize = false;
                lblBatDau.Width = 390;
                lblBatDau.Text = $"Bắt đầu: {item.ThoiGianBatDau}";
                lblBatDau.Font = new Font("Arial", 11, FontStyle.Bold);
                lblBatDau.Location = new Point(17, 65);
                card.Controls.Add(lblBatDau);

                Label lblKetThuc = new Label();
                lblKetThuc.AutoSize = false;
                lblKetThuc.Width = 390;
                lblKetThuc.Text = $"Kết thúc: {item.ThoiGianKetThuc}";
                lblKetThuc.Font = new Font("Arial", 11, FontStyle.Bold);
                lblKetThuc.Location = new Point(17, 93);
                card.Controls.Add(lblKetThuc);

                flpDanhSachSuKien.Controls.Add(card);
            }
        }

        public void LoadFlowPanelDanhSachSuKienTimKiem(List<string> danhSachTimKiem)
        {
            flpDanhSachSuKien.Controls.Clear();
            SuKien[] danhSachSuKien = suKienBLL.GetList();

            foreach (var item in danhSachSuKien)
            {
                if (danhSachTimKiem.Contains(item.ID.ToString()))
                {
                    MaterialCard card = new ReaLTaiizor.Controls.MaterialCard();
                    card.Width = 409;
                    card.Height = 128;

                    card.Location = new Point(14, 14);

                    Label lblTenSuKien = new Label();
                    lblTenSuKien.AutoSize = false;
                    lblTenSuKien.Width = 390;
                    lblTenSuKien.Text = $"Tên: {item.Ten}";
                    lblTenSuKien.Font = new Font("Arial", 11, FontStyle.Bold);
                    lblTenSuKien.Location = new Point(17, 14);
                    card.Controls.Add(lblTenSuKien);

                    Label lblGiamGia = new Label();
                    lblGiamGia.AutoSize = false;
                    lblGiamGia.Width = 390;
                    lblGiamGia.Text = $"Giảm giá: {item.GiamGia}%";
                    lblGiamGia.Font = new Font("Arial", 11, FontStyle.Bold);
                    lblGiamGia.Location = new Point(17, 40);
                    card.Controls.Add(lblGiamGia);

                    Label lblBatDau = new Label();
                    lblBatDau.AutoSize = false;
                    lblBatDau.Width = 390;
                    lblBatDau.Text = $"Bắt đầu: {item.ThoiGianBatDau}";
                    lblBatDau.Font = new Font("Arial", 11, FontStyle.Bold);
                    lblBatDau.Location = new Point(17, 65);
                    card.Controls.Add(lblBatDau);

                    Label lblKetThuc = new Label();
                    lblKetThuc.AutoSize = false;
                    lblKetThuc.Width = 390;
                    lblKetThuc.Text = $"Kết thúc: {item.ThoiGianKetThuc}";
                    lblKetThuc.Font = new Font("Arial", 11, FontStyle.Bold);
                    lblKetThuc.Location = new Point(17, 93);
                    card.Controls.Add(lblKetThuc);

                    flpDanhSachSuKien.Controls.Add(card);
                }
            }
        }

        public void LoadFlowPanelDanhSachVoucher()
        {
            flpDanhSachVoucher.Controls.Clear();
            Voucher[] danhSachVoucher = voucherBLL.GetList();
            foreach (var item in danhSachVoucher)
            {
                MaterialCard card = new ReaLTaiizor.Controls.MaterialCard();
                card.Width = 405;
                card.Height = 128;

                card.Location = new Point(14, 14);

                Label lblMa = new Label();
                lblMa.AutoSize = false;
                lblMa.Width = 390;
                lblMa.Text = $"Mã: {item.Ma}";
                lblMa.Font = new Font("Arial", 11, FontStyle.Bold);
                lblMa.Location = new Point(17, 14);
                card.Controls.Add(lblMa);

                Label lblGiamGia = new Label();
                lblGiamGia.AutoSize = false;
                lblGiamGia.Width = 390;
                lblGiamGia.Text = $"Giảm giá: {item.GiamGia}%";
                lblGiamGia.Font = new Font("Arial", 11, FontStyle.Bold);
                lblGiamGia.Location = new Point(17, 40);
                card.Controls.Add(lblGiamGia);

                Label lblLuotNhap = new Label();
                lblLuotNhap.AutoSize = false;
                lblLuotNhap.Width = 390;
                lblLuotNhap.Text = $"Lượt nhập: {item.LuotNhap}";
                lblLuotNhap.Font = new Font("Arial", 11, FontStyle.Bold);
                lblLuotNhap.Location = new Point(17, 65);
                card.Controls.Add(lblLuotNhap);

                Label lblSoLuong = new Label();
                lblSoLuong.AutoSize = false;
                lblSoLuong.Width = 390;
                lblSoLuong.Text = $"Số Lượng: {item.SoLuong}";
                lblSoLuong.Font = new Font("Arial", 11, FontStyle.Bold);
                lblSoLuong.Location = new Point(17, 93);
                card.Controls.Add(lblSoLuong);

                flpDanhSachVoucher.Controls.Add(card);
            }
        }

        public void LoadFlowPanelDanhSachVoucherTimKiem(List<string> danhSachTimKiem)
        {
            flpDanhSachVoucher.Controls.Clear();
            Voucher[] danhSachVoucher = voucherBLL.GetList();

            foreach (var item in danhSachVoucher)
            {
                if (danhSachTimKiem.Contains(item.Ma))
                {
                    MaterialCard card = new ReaLTaiizor.Controls.MaterialCard();
                    card.Width = 405;
                    card.Height = 128;

                    card.Location = new Point(14, 14);

                    Label lblMa = new Label();
                    lblMa.AutoSize = false;
                    lblMa.Width = 390;
                    lblMa.Text = $"Mã: {item.Ma}";
                    lblMa.Font = new Font("Arial", 11, FontStyle.Bold);
                    lblMa.Location = new Point(17, 14);
                    card.Controls.Add(lblMa);

                    Label lblGiamGia = new Label();
                    lblGiamGia.AutoSize = false;
                    lblGiamGia.Width = 390;
                    lblGiamGia.Text = $"Giảm giá: {item.GiamGia}%";
                    lblGiamGia.Font = new Font("Arial", 11, FontStyle.Bold);
                    lblGiamGia.Location = new Point(17, 40);
                    card.Controls.Add(lblGiamGia);

                    Label lblLuotNhap = new Label();
                    lblLuotNhap.AutoSize = false;
                    lblLuotNhap.Width = 390;
                    lblLuotNhap.Text = $"Lượt nhập: {item.LuotNhap}";
                    lblLuotNhap.Font = new Font("Arial", 11, FontStyle.Bold);
                    lblLuotNhap.Location = new Point(17, 65);
                    card.Controls.Add(lblLuotNhap);

                    Label lblSoLuong = new Label();
                    lblSoLuong.AutoSize = false;
                    lblSoLuong.Width = 390;
                    lblSoLuong.Text = $"Số Lượng: {item.SoLuong}";
                    lblSoLuong.Font = new Font("Arial", 11, FontStyle.Bold);
                    lblSoLuong.Location = new Point(17, 93);
                    card.Controls.Add(lblSoLuong);

                    flpDanhSachVoucher.Controls.Add(card);
                }
            }
        }

        public void LoadFlowPanelSanPham()
        {
            _ketQuaTimThaySanPham = 0;
            flpDanhSachSanPham.Controls.Clear();
            SanPham[] danhSachSanPham = sanPhamBLL.GetList();

            foreach (var item in danhSachSanPham)
            {
                _ketQuaTimThaySanPham++;
                Random random = new Random();
                int color1 = random.Next(236, 255);
                int color2 = random.Next(238, 255);
                int color3 = random.Next(207, 255);
                MaterialCard card = new ReaLTaiizor.Controls.MaterialCard();
                card.Width = 290;
                card.Height = 250;
                card.Tag = item.ID;
                PictureBox pic = new PictureBox();
                pic.Width = 290;
                pic.Height = 140;
                pic.Location = new Point(0, 0);
                pic.BackColor = Color.FromArgb(color1, color2, color3);

                PictureBox picSanPham = new PictureBox();
                picSanPham.Width = 195;
                picSanPham.Height = 100;
                picSanPham.BackColor = Color.FromArgb(color1, color2, color3);
                picSanPham.Image = sanPhamBLL.GetImageByPath(item.ID);
                picSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Controls.Add(picSanPham);
                picSanPham.Location = new Point(
                    (picSanPham.Parent.ClientSize.Width / 2) - (picSanPham.Width / 2),
                    (picSanPham.Parent.ClientSize.Height / 2) - (picSanPham.Height / 2)
                );

                Label lblTenSanPham = new Label();
                lblTenSanPham.AutoSize = false;
                lblTenSanPham.Width = 290;
                lblTenSanPham.TextAlign = ContentAlignment.MiddleCenter;
                lblTenSanPham.Text = item.TenSanPham;
                lblTenSanPham.Font = new Font("Arial", 12, FontStyle.Bold);
                card.Controls.Add(lblTenSanPham);
                lblTenSanPham.Location = new Point(
                    (lblTenSanPham.Parent.ClientSize.Width / 2) - (lblTenSanPham.Width / 2),
                    picSanPham.Height + 50
                );

                Label lblGiaTien = new Label();
                lblGiaTien.TextAlign = ContentAlignment.MiddleCenter;
                lblGiaTien.AutoSize = false;
                lblGiaTien.Width = 290;
                lblGiaTien.Text = item.GiaTien.ToString();
                lblGiaTien.Font = new Font("Arial", 10, FontStyle.Regular);
                lblGiaTien.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblGiaTien.Text));

                card.Controls.Add(lblGiaTien);
                lblGiaTien.Location = new Point(
                    (lblGiaTien.Parent.ClientSize.Width / 2) - (lblGiaTien.Width / 2),
                    picSanPham.Height + 50 + lblTenSanPham.Height
                );

                if (item.Event != -1)
                {
                    SuKien suKien = suKienBLL.LayThongTinSuKien(item.Event);
                    lblGiaTien.Font = new Font(lblGiaTien.Font, FontStyle.Strikeout);
                    Label lblGiaTienGiamGia = new Label();
                    lblGiaTienGiamGia.TextAlign = ContentAlignment.MiddleCenter;
                    lblGiaTienGiamGia.AutoSize = false;
                    lblGiaTienGiamGia.Width = 290;
                    lblGiaTienGiamGia.Text = (
                        item.GiaTien - item.GiaTien * suKien.GiamGia / 100
                    ).ToString();
                    lblGiaTienGiamGia.Font = new Font("Arial", 10, FontStyle.Regular);
                    lblGiaTienGiamGia.Text = string.Format(
                        "{0:#,##0} VNĐ",
                        double.Parse(lblGiaTienGiamGia.Text)
                    );

                    card.Controls.Add(lblGiaTienGiamGia);
                    lblGiaTienGiamGia.Location = new Point(
                        (lblGiaTienGiamGia.Parent.ClientSize.Width / 2)
                            - (lblGiaTienGiamGia.Width / 2),
                        lblGiaTien.Height + lblGiaTien.Location.Y
                    );
                }

                card.Controls.Add(pic);

                flpDanhSachSanPham.Controls.Add(card);
            }
            lblKetQuaTimThay.Text = $"Có {_ketQuaTimThaySanPham} kết quả tìm thấy";
        }

        void LoadFlowPanelLocSanPham(string loaiSanPham)
        {
            _ketQuaTimThaySanPham = 0;
            flpDanhSachSanPham.Controls.Clear();
            SanPham[] danhSachSanPham = sanPhamBLL.GetList();
            foreach (var item in danhSachSanPham)
            {
                if (item.LoaiSanPham == loaiSanPham)
                {
                    _ketQuaTimThaySanPham++;
                    Random random = new Random();
                    int color1 = random.Next(236, 255);
                    int color2 = random.Next(238, 255);
                    int color3 = random.Next(207, 255);
                    MaterialCard card = new ReaLTaiizor.Controls.MaterialCard();
                    card.Width = 290;
                    card.Height = 250;
                    card.Tag = item.ID;
                    PictureBox pic = new PictureBox();
                    pic.Width = 290;
                    pic.Height = 140;
                    pic.Location = new Point(0, 0);
                    pic.BackColor = Color.FromArgb(color1, color2, color3);

                    PictureBox picSanPham = new PictureBox();
                    picSanPham.Width = 195;
                    picSanPham.Height = 100;
                    picSanPham.BackColor = Color.FromArgb(color1, color2, color3);
                    picSanPham.Image = sanPhamBLL.GetImageByPath(item.ID);
                    picSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Controls.Add(picSanPham);
                    picSanPham.Location = new Point(
                        (picSanPham.Parent.ClientSize.Width / 2) - (picSanPham.Width / 2),
                        (picSanPham.Parent.ClientSize.Height / 2) - (picSanPham.Height / 2)
                    );

                    Label lblTenSanPham = new Label();
                    lblTenSanPham.AutoSize = false;
                    lblTenSanPham.Width = 290;
                    lblTenSanPham.TextAlign = ContentAlignment.MiddleCenter;
                    lblTenSanPham.Text = item.TenSanPham;
                    lblTenSanPham.Font = new Font("Arial", 12, FontStyle.Bold);
                    card.Controls.Add(lblTenSanPham);
                    lblTenSanPham.Location = new Point(
                        (lblTenSanPham.Parent.ClientSize.Width / 2) - (lblTenSanPham.Width / 2),
                        picSanPham.Height + 50
                    );

                    Label lblGiaTien = new Label();
                    lblGiaTien.TextAlign = ContentAlignment.MiddleCenter;
                    lblGiaTien.AutoSize = false;
                    lblGiaTien.Width = 290;
                    lblGiaTien.Text = item.GiaTien.ToString();
                    lblGiaTien.Font = new Font("Arial", 10, FontStyle.Bold);
                    lblGiaTien.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblGiaTien.Text));

                    card.Controls.Add(lblGiaTien);
                    lblGiaTien.Location = new Point(
                        (lblGiaTien.Parent.ClientSize.Width / 2) - (lblGiaTien.Width / 2),
                        picSanPham.Height + 50 + lblTenSanPham.Height
                    );
                    if (item.Event != -1)
                    {
                        SuKien suKien = suKienBLL.LayThongTinSuKien(item.Event);

                        lblGiaTien.Font = new Font(lblGiaTien.Font, FontStyle.Strikeout);
                        Label lblGiaTienGiamGia = new Label();
                        lblGiaTienGiamGia.TextAlign = ContentAlignment.MiddleCenter;
                        lblGiaTienGiamGia.AutoSize = false;
                        lblGiaTienGiamGia.Width = 290;
                        lblGiaTienGiamGia.Text = (
                            item.GiaTien - item.GiaTien * suKien.GiamGia / 100
                        ).ToString();
                        lblGiaTienGiamGia.Font = new Font("Arial", 10, FontStyle.Regular);
                        lblGiaTienGiamGia.Text = string.Format(
                            "{0:#,##0} VNĐ",
                            double.Parse(lblGiaTienGiamGia.Text)
                        );

                        card.Controls.Add(lblGiaTienGiamGia);
                        lblGiaTienGiamGia.Location = new Point(
                            (lblGiaTienGiamGia.Parent.ClientSize.Width / 2)
                                - (lblGiaTienGiamGia.Width / 2),
                            lblGiaTien.Height + lblGiaTien.Location.Y
                        );
                    }
                    card.Controls.Add(pic);

                    flpDanhSachSanPham.Controls.Add(card);
                }
            }
            lblKetQuaTimThay.Text = $"Có {_ketQuaTimThaySanPham} kết quả tìm thấy";
        }

        void LoadFlowPanelLocSanPhamTheoSuKien(int IDSuKien)
        {
            if (IDSuKien == -1)
            {
                LoadFlowPanelSanPham();
                return;
            }
            _ketQuaTimThaySanPham = 0;
            flpDanhSachSanPham.Controls.Clear();
            SanPham[] danhSachSanPham = sanPhamBLL.GetList();
            foreach (var item in danhSachSanPham)
            {
                if (item.Event != -1 && item.Event == IDSuKien)
                {
                    _ketQuaTimThaySanPham++;
                    Random random = new Random();
                    int color1 = random.Next(236, 255);
                    int color2 = random.Next(238, 255);
                    int color3 = random.Next(207, 255);
                    MaterialCard card = new ReaLTaiizor.Controls.MaterialCard();
                    card.Width = 290;
                    card.Height = 250;
                    card.Tag = item.ID;
                    PictureBox pic = new PictureBox();
                    pic.Width = 290;
                    pic.Height = 140;
                    pic.Location = new Point(0, 0);
                    pic.BackColor = Color.FromArgb(color1, color2, color3);

                    PictureBox picSanPham = new PictureBox();
                    picSanPham.Width = 195;
                    picSanPham.Height = 100;
                    picSanPham.BackColor = Color.FromArgb(color1, color2, color3);
                    picSanPham.Image = sanPhamBLL.GetImageByPath(item.ID);
                    picSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Controls.Add(picSanPham);
                    picSanPham.Location = new Point(
                        (picSanPham.Parent.ClientSize.Width / 2) - (picSanPham.Width / 2),
                        (picSanPham.Parent.ClientSize.Height / 2) - (picSanPham.Height / 2)
                    );

                    Label lblTenSanPham = new Label();
                    lblTenSanPham.AutoSize = false;
                    lblTenSanPham.Width = 290;
                    lblTenSanPham.TextAlign = ContentAlignment.MiddleCenter;
                    lblTenSanPham.Text = item.TenSanPham;
                    lblTenSanPham.Font = new Font("Arial", 12, FontStyle.Bold);
                    card.Controls.Add(lblTenSanPham);
                    lblTenSanPham.Location = new Point(
                        (lblTenSanPham.Parent.ClientSize.Width / 2) - (lblTenSanPham.Width / 2),
                        picSanPham.Height + 50
                    );

                    Label lblGiaTien = new Label();
                    lblGiaTien.TextAlign = ContentAlignment.MiddleCenter;
                    lblGiaTien.AutoSize = false;
                    lblGiaTien.Width = 290;
                    lblGiaTien.Text = item.GiaTien.ToString();
                    lblGiaTien.Font = new Font("Arial", 10, FontStyle.Bold);
                    lblGiaTien.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblGiaTien.Text));

                    card.Controls.Add(lblGiaTien);
                    lblGiaTien.Location = new Point(
                        (lblGiaTien.Parent.ClientSize.Width / 2) - (lblGiaTien.Width / 2),
                        picSanPham.Height + 50 + lblTenSanPham.Height
                    );
                    if (item.Event != -1)
                    {
                        SuKien suKien = suKienBLL.LayThongTinSuKien(item.Event);

                        lblGiaTien.Font = new Font(lblGiaTien.Font, FontStyle.Strikeout);
                        Label lblGiaTienGiamGia = new Label();
                        lblGiaTienGiamGia.TextAlign = ContentAlignment.MiddleCenter;
                        lblGiaTienGiamGia.AutoSize = false;
                        lblGiaTienGiamGia.Width = 290;
                        lblGiaTienGiamGia.Text = (
                            item.GiaTien - item.GiaTien * suKien.GiamGia / 100
                        ).ToString();
                        lblGiaTienGiamGia.Font = new Font("Arial", 10, FontStyle.Regular);
                        lblGiaTienGiamGia.Text = string.Format(
                            "{0:#,##0} VNĐ",
                            double.Parse(lblGiaTienGiamGia.Text)
                        );

                        card.Controls.Add(lblGiaTienGiamGia);
                        lblGiaTienGiamGia.Location = new Point(
                            (lblGiaTienGiamGia.Parent.ClientSize.Width / 2)
                                - (lblGiaTienGiamGia.Width / 2),
                            lblGiaTien.Height + lblGiaTien.Location.Y
                        );
                    }
                    card.Controls.Add(pic);

                    flpDanhSachSanPham.Controls.Add(card);
                }
            }
            lblKetQuaTimThay.Text = $"Có {_ketQuaTimThaySanPham} kết quả tìm thấy";
        }

        void LoadFlowPanelTimSanPham(List<string> danhSachTimKiem)
        {
            _ketQuaTimThaySanPham = 0;
            flpDanhSachSanPham.Controls.Clear();
            SanPham[] danhSachSanPham = sanPhamBLL.GetList();
            foreach (var item in danhSachSanPham)
            {
                if (danhSachTimKiem.Contains(item.ID))
                {
                    _ketQuaTimThaySanPham++;
                    Random random = new Random();
                    int color1 = random.Next(236, 255);
                    int color2 = random.Next(238, 255);
                    int color3 = random.Next(207, 255);
                    MaterialCard card = new ReaLTaiizor.Controls.MaterialCard();
                    card.Width = 290;
                    card.Height = 250;
                    card.Tag = item.ID;
                    PictureBox pic = new PictureBox();
                    pic.Width = 290;
                    pic.Height = 140;
                    pic.Location = new Point(0, 0);
                    pic.BackColor = Color.FromArgb(color1, color2, color3);

                    PictureBox picSanPham = new PictureBox();
                    picSanPham.Width = 195;
                    picSanPham.Height = 100;
                    picSanPham.BackColor = Color.FromArgb(color1, color2, color3);
                    picSanPham.Image = sanPhamBLL.GetImageByPath(item.ID);
                    picSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Controls.Add(picSanPham);
                    picSanPham.Location = new Point(
                        (picSanPham.Parent.ClientSize.Width / 2) - (picSanPham.Width / 2),
                        (picSanPham.Parent.ClientSize.Height / 2) - (picSanPham.Height / 2)
                    );

                    Label lblTenSanPham = new Label();
                    lblTenSanPham.AutoSize = false;
                    lblTenSanPham.Width = 290;
                    lblTenSanPham.TextAlign = ContentAlignment.MiddleCenter;
                    lblTenSanPham.Text = item.TenSanPham;
                    lblTenSanPham.Font = new Font("Arial", 12, FontStyle.Bold);
                    card.Controls.Add(lblTenSanPham);
                    lblTenSanPham.Location = new Point(
                        (lblTenSanPham.Parent.ClientSize.Width / 2) - (lblTenSanPham.Width / 2),
                        picSanPham.Height + 50
                    );

                    Label lblGiaTien = new Label();
                    lblGiaTien.TextAlign = ContentAlignment.MiddleCenter;
                    lblGiaTien.AutoSize = false;
                    lblGiaTien.Width = 290;
                    lblGiaTien.Text = item.GiaTien.ToString();
                    lblGiaTien.Font = new Font("Arial", 10, FontStyle.Bold);
                    lblGiaTien.Text = string.Format("{0:#,##0} VNĐ", double.Parse(lblGiaTien.Text));

                    card.Controls.Add(lblGiaTien);
                    lblGiaTien.Location = new Point(
                        (lblGiaTien.Parent.ClientSize.Width / 2) - (lblGiaTien.Width / 2),
                        picSanPham.Height + 50 + lblTenSanPham.Height
                    );
                    if (item.Event != -1)
                    {
                        SuKien suKien = suKienBLL.LayThongTinSuKien(item.Event);

                        lblGiaTien.Font = new Font(lblGiaTien.Font, FontStyle.Strikeout);
                        Label lblGiaTienGiamGia = new Label();
                        lblGiaTienGiamGia.TextAlign = ContentAlignment.MiddleCenter;
                        lblGiaTienGiamGia.AutoSize = false;
                        lblGiaTienGiamGia.Width = 290;
                        lblGiaTienGiamGia.Text = (
                            item.GiaTien - item.GiaTien * suKien.GiamGia / 100
                        ).ToString();
                        lblGiaTienGiamGia.Font = new Font("Arial", 10, FontStyle.Regular);
                        lblGiaTienGiamGia.Text = string.Format(
                            "{0:#,##0} VNĐ",
                            double.Parse(lblGiaTienGiamGia.Text)
                        );

                        card.Controls.Add(lblGiaTienGiamGia);
                        lblGiaTienGiamGia.Location = new Point(
                            (lblGiaTienGiamGia.Parent.ClientSize.Width / 2)
                                - (lblGiaTienGiamGia.Width / 2),
                            lblGiaTien.Height + lblGiaTien.Location.Y
                        );
                    }
                    card.Controls.Add(pic);

                    flpDanhSachSanPham.Controls.Add(card);
                }
            }
            lblKetQuaTimThay.Text = $"Có {_ketQuaTimThaySanPham} kết quả tìm thấy";
        }

        public void LoadFlowPanelDanhSachBan()
        {
            _ketQuaTimThayBan = 0;
            flpDanhSachBan.Controls.Clear();
            Ban[] danhSachBan = banBLL.GetList();
            foreach (var item in danhSachBan)
            {
                _ketQuaTimThayBan++;

                MaterialCard card = new ReaLTaiizor.Controls.MaterialCard();
                card.Width = 290;
                card.Height = 250;
                card.Tag = item.ID;
                PictureBox pic = new PictureBox();
                pic.Width = 290;
                pic.Height = 140;
                pic.Location = new Point(0, 0);

                PictureBox picSanPham = new PictureBox();
                picSanPham.Width = 195;
                picSanPham.Height = 100;
                if (item.TinhTrang == 0)
                {
                    picSanPham.Image = Properties.Resources.table_chuadat;
                    pic.BackColor = Color.FromArgb(254, 249, 207);
                    picSanPham.BackColor = Color.FromArgb(254, 249, 207);
                }
                else
                {
                    picSanPham.Image = Properties.Resources.table_dadat;
                    pic.BackColor = Color.FromArgb(242, 252, 219);
                    picSanPham.BackColor = Color.FromArgb(242, 252, 219);
                }
                picSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Controls.Add(picSanPham);
                picSanPham.Location = new Point(
                    (picSanPham.Parent.ClientSize.Width / 2) - (picSanPham.Width / 2),
                    (picSanPham.Parent.ClientSize.Height / 2) - (picSanPham.Height / 2)
                );

                Label lblTenSanPham = new Label();
                lblTenSanPham.AutoSize = false;
                lblTenSanPham.Width = 290;
                lblTenSanPham.TextAlign = ContentAlignment.MiddleCenter;
                lblTenSanPham.Text = item.TenBan;
                lblTenSanPham.Font = new Font("Arial", 12, FontStyle.Bold);
                card.Controls.Add(lblTenSanPham);
                lblTenSanPham.Location = new Point(
                    (lblTenSanPham.Parent.ClientSize.Width / 2) - (lblTenSanPham.Width / 2),
                    picSanPham.Height + 50
                );
                MaterialButton buttonDetail = new MaterialButton();
                buttonDetail.Text = "Chi tiết";
                buttonDetail.CharacterCasing = MaterialButton.CharacterCasingEnum.Title;
                buttonDetail.Cursor = Cursors.Hand;
                buttonDetail.Tag = item.ID;
                buttonDetail.Click += new EventHandler(ChiTietBan_Click);
                card.Controls.Add(buttonDetail);
                buttonDetail.Location = new Point(
                    (buttonDetail.Parent.ClientSize.Width / 2) - (buttonDetail.Width / 2),
                    lblTenSanPham.Location.Y + lblTenSanPham.Height
                );

                card.Controls.Add(pic);

                flpDanhSachBan.Controls.Add(card);
            }
            lblKetQuaTimThayBan.Text = $"Có {_ketQuaTimThayBan} kết quả tìm thấy";
        }

        void LoadFlowPanelDanhSachBanLoc(int tinhTrang)
        {
            _ketQuaTimThayBan = 0;
            flpDanhSachBan.Controls.Clear();
            Ban[] danhSachBan = banBLL.GetList();
            foreach (var item in danhSachBan)
            {
                if (item.TinhTrang == tinhTrang)
                {
                    _ketQuaTimThayBan++;

                    MaterialCard card = new ReaLTaiizor.Controls.MaterialCard();
                    card.Width = 290;
                    card.Height = 250;
                    card.Tag = item.ID;
                    PictureBox pic = new PictureBox();
                    pic.Width = 290;
                    pic.Height = 140;
                    pic.Location = new Point(0, 0);

                    PictureBox picSanPham = new PictureBox();
                    picSanPham.Width = 195;
                    picSanPham.Height = 100;
                    if (item.TinhTrang == 0)
                    {
                        picSanPham.Image = Properties.Resources.table_chuadat;
                        pic.BackColor = Color.FromArgb(254, 249, 207);
                        picSanPham.BackColor = Color.FromArgb(254, 249, 207);
                    }
                    else
                    {
                        picSanPham.Image = Properties.Resources.table_dadat;
                        pic.BackColor = Color.FromArgb(242, 252, 219);
                        picSanPham.BackColor = Color.FromArgb(242, 252, 219);
                    }
                    picSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Controls.Add(picSanPham);
                    picSanPham.Location = new Point(
                        (picSanPham.Parent.ClientSize.Width / 2) - (picSanPham.Width / 2),
                        (picSanPham.Parent.ClientSize.Height / 2) - (picSanPham.Height / 2)
                    );

                    Label lblTenSanPham = new Label();
                    lblTenSanPham.AutoSize = false;
                    lblTenSanPham.Width = 290;
                    lblTenSanPham.TextAlign = ContentAlignment.MiddleCenter;
                    lblTenSanPham.Text = item.TenBan;
                    lblTenSanPham.Font = new Font("Arial", 12, FontStyle.Bold);
                    card.Controls.Add(lblTenSanPham);
                    lblTenSanPham.Location = new Point(
                        (lblTenSanPham.Parent.ClientSize.Width / 2) - (lblTenSanPham.Width / 2),
                        picSanPham.Height + 50
                    );
                    MaterialButton buttonDetail = new MaterialButton();
                    buttonDetail.Text = "Chi tiết";
                    buttonDetail.CharacterCasing = MaterialButton.CharacterCasingEnum.Title;
                    buttonDetail.Cursor = Cursors.Hand;
                    buttonDetail.Tag = item.ID;
                    buttonDetail.Click += new EventHandler(ChiTietBan_Click);
                    card.Controls.Add(buttonDetail);
                    buttonDetail.Location = new Point(
                        (buttonDetail.Parent.ClientSize.Width / 2) - (buttonDetail.Width / 2),
                        lblTenSanPham.Location.Y + lblTenSanPham.Height
                    );

                    card.Controls.Add(pic);

                    flpDanhSachBan.Controls.Add(card);
                }
            }
            lblKetQuaTimThayBan.Text = $"Có {_ketQuaTimThayBan} kết quả tìm thấy";
        }

        void LoadFlowPanelDanhSachBanTimKiem(List<string> danhSachTimKiem)
        {
            _ketQuaTimThayBan = 0;
            flpDanhSachBan.Controls.Clear();
            Ban[] danhSachBan = banBLL.GetList();
            foreach (var item in danhSachBan)
            {
                if (danhSachTimKiem.Contains(item.ID))
                {
                    _ketQuaTimThayBan++;

                    MaterialCard card = new ReaLTaiizor.Controls.MaterialCard();
                    card.Width = 290;
                    card.Height = 250;
                    card.Tag = item.ID;
                    PictureBox pic = new PictureBox();
                    pic.Width = 290;
                    pic.Height = 140;
                    pic.Location = new Point(0, 0);

                    PictureBox picSanPham = new PictureBox();
                    picSanPham.Width = 195;
                    picSanPham.Height = 100;
                    if (item.TinhTrang == 0)
                    {
                        picSanPham.Image = Properties.Resources.table_chuadat;
                        pic.BackColor = Color.FromArgb(254, 249, 207);
                        picSanPham.BackColor = Color.FromArgb(254, 249, 207);
                    }
                    else
                    {
                        picSanPham.Image = Properties.Resources.table_dadat;
                        pic.BackColor = Color.FromArgb(242, 252, 219);
                        picSanPham.BackColor = Color.FromArgb(242, 252, 219);
                    }
                    picSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Controls.Add(picSanPham);
                    picSanPham.Location = new Point(
                        (picSanPham.Parent.ClientSize.Width / 2) - (picSanPham.Width / 2),
                        (picSanPham.Parent.ClientSize.Height / 2) - (picSanPham.Height / 2)
                    );

                    Label lblTenSanPham = new Label();
                    lblTenSanPham.AutoSize = false;
                    lblTenSanPham.Width = 290;
                    lblTenSanPham.TextAlign = ContentAlignment.MiddleCenter;
                    lblTenSanPham.Text = item.TenBan;
                    lblTenSanPham.Font = new Font("Arial", 12, FontStyle.Bold);
                    card.Controls.Add(lblTenSanPham);
                    lblTenSanPham.Location = new Point(
                        (lblTenSanPham.Parent.ClientSize.Width / 2) - (lblTenSanPham.Width / 2),
                        picSanPham.Height + 50
                    );
                    MaterialButton buttonDetail = new MaterialButton();
                    buttonDetail.Text = "Chi tiết";
                    buttonDetail.CharacterCasing = MaterialButton.CharacterCasingEnum.Title;
                    buttonDetail.Cursor = Cursors.Hand;
                    buttonDetail.Tag = item.ID;
                    buttonDetail.Click += new EventHandler(ChiTietBan_Click);
                    card.Controls.Add(buttonDetail);
                    buttonDetail.Location = new Point(
                        (buttonDetail.Parent.ClientSize.Width / 2) - (buttonDetail.Width / 2),
                        lblTenSanPham.Location.Y + lblTenSanPham.Height
                    );

                    card.Controls.Add(pic);

                    flpDanhSachBan.Controls.Add(card);
                }
            }
            lblKetQuaTimThayBan.Text = $"Có {_ketQuaTimThayBan} kết quả tìm thấy";
        }

        public void LoadDanhSachBan() { }

        public void LoadDanhSachSanPham() { }

        #endregion

        #region Các sự kiện
        // Timer cập nhật thời gian hiện tại
        private void _timerThoiGianHienTai_Tick(object sender, EventArgs e)
        {
            lblThoiGianHienTai.Text = $"{DateTime.Now}";
        }

        // Sự kiện Click xem chi tiết bàn trong danh sách bàn
        private void ChiTietBan_Click(object sender, EventArgs e)
        {
            ControlForm.BanDangChon = null;
            ControlForm.BanDatDangChon = null;
            MaterialButton button = (MaterialButton)sender;
            ChiTietBanForm fChiTietBan = new ChiTietBanForm();
            Ban timBan = banBLL.TimKiemBanByID((string)button.Tag);
            ControlForm.BanDangChon = timBan;
            fChiTietBan.ShowDialog();
        }

        // Sự kiện Click Lọc loại Thức Ăn trong danh sách sản phẩm
        private void picBtnThucAnLoc_Click(object sender, EventArgs e)
        {
            if (_isClickLocThucAn)
            {
                LoadFlowPanelSanPham();
            }
            else
            {
                LoadFlowPanelLocSanPham("DOAN");
            }
            _isClickLocThucAn = !_isClickLocThucAn;
            if (_isClickLocThucAn)
            {
                picBtnKhacLoc.Visible = false;
                picBtnNuocLoc.Visible = false;
            }
            else
            {
                picBtnKhacLoc.Visible = true;
                picBtnNuocLoc.Visible = true;
            }
        }

        // Lọc Khác trong Sản Phẩm
        private void picBtnKhacLoc_Click(object sender, EventArgs e)
        {
            if (_isClickLocKhac)
            {
                LoadFlowPanelSanPham();
            }
            else
            {
                LoadFlowPanelLocSanPham("KHAC");
            }
            _isClickLocKhac = !_isClickLocKhac;
            if (_isClickLocKhac)
            {
                picBtnThucAnLoc.Visible = false;
                picBtnNuocLoc.Visible = false;
            }
            else
            {
                picBtnThucAnLoc.Visible = true;
                picBtnNuocLoc.Visible = true;
            }
        }

        // Lọc Nước trong Sản Phẩm
        private void picBtnNuocLoc_Click(object sender, EventArgs e)
        {
            if (_isClickLocNuoc)
            {
                LoadFlowPanelSanPham();
            }
            else
            {
                LoadFlowPanelLocSanPham("THUCUONG");
            }
            _isClickLocNuoc = !_isClickLocNuoc;
            if (_isClickLocNuoc)
            {
                picBtnThucAnLoc.Visible = false;
                picBtnKhacLoc.Visible = false;
            }
            else
            {
                picBtnThucAnLoc.Visible = true;
                picBtnKhacLoc.Visible = true;
            }
        }

        // Tìm kiếm sản phẩm theo tên sản phẩm
        private void btnTimKiemSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txtTimKiemSanPham.Text.Trim();
                _isClickLocKhac = false;
                _isClickLocThucAn = false;
                _isClickLocNuoc = false;
                picBtnKhacLoc.Visible = true;
                picBtnThucAnLoc.Visible = true;
                picBtnNuocLoc.Visible = true;

                List<string> danhSachSanPhamTimKiem = new List<string>();
                DataTable dt;
                dt = sanPhamBLL.TimKiemSanPham(searchValue);
                foreach (DataRow dr in dt.Rows)
                {
                    string ID = (string)dr["ID"];
                    danhSachSanPhamTimKiem.Add(ID);
                }
                // Hiển thị Item tìm thấy
                LoadFlowPanelTimSanPham(danhSachSanPhamTimKiem);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        // Lọc bàn chưa đặt trong Danh Sách Bàn
        private void picBanChuaDat_Click(object sender, EventArgs e)
        {
            if (_isClickBanChuaDat)
            {
                LoadFlowPanelDanhSachBan();
            }
            else
            {
                LoadFlowPanelDanhSachBanLoc(0);
            }
            _isClickBanChuaDat = !_isClickBanChuaDat;
            if (_isClickBanChuaDat)
            {
                picBanDaDat.Visible = false;
                lblBanDaDat.Visible = false;
            }
            else
            {
                picBanDaDat.Visible = true;
                lblBanDaDat.Visible = true;
            }
        }

        // Lọc bàn đã đặt trong danh sách bàn
        private void picBanDaDat_Click(object sender, EventArgs e)
        {
            if (_isClickBanDaDat)
            {
                LoadFlowPanelDanhSachBan();
            }
            else
            {
                LoadFlowPanelDanhSachBanLoc(1);
            }
            _isClickBanDaDat = !_isClickBanDaDat;
            if (_isClickBanDaDat)
            {
                picBanChuaDat.Visible = false;
                lblBanChuaDat.Visible = false;
            }
            else
            {
                picBanChuaDat.Visible = true;
                lblBanChuaDat.Visible = true;
            }
        }

        // Tìm kiếm bàn theo tên bàn
        private void btnTimKiemBan_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txtTimKiemBan.Text.Trim();
                _isClickBanChuaDat = false;
                _isClickBanDaDat = false;
                picBanChuaDat.Visible = true;
                lblBanChuaDat.Visible = true;
                picBanDaDat.Visible = true;
                lblBanDaDat.Visible = true;

                List<string> danhSachBanTimKiem = new List<string>();

                DataTable dt;
                dt = banBLL.TimKiemBan(searchValue);
                foreach (DataRow dr in dt.Rows)
                {
                    string ID = (string)dr["ID"];
                    danhSachBanTimKiem.Add(ID);
                }
                // Hiển thị Item tìm thấy
                LoadFlowPanelDanhSachBanTimKiem(danhSachBanTimKiem);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txtTimKiemBan_Click(object sender, EventArgs e) { }

        // Tìm sản phẩm theo sự kiện
        private void cboDanhSachSuKien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboDanhSachSuKien.SelectedValue is int)
                {
                    if (cboDanhSachSuKien.SelectedIndex != -1)
                    {
                        _isClickLocKhac = false;
                        _isClickLocNuoc = false;
                        _isClickLocThucAn = false;
                        picBtnThucAnLoc.Visible = true;
                        picBtnKhacLoc.Visible = true;
                        picBtnNuocLoc.Visible = true;
                        LoadFlowPanelLocSanPhamTheoSuKien(
                            int.Parse(cboDanhSachSuKien.SelectedValue.ToString())
                        );
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        // Bắt đầu ca làm nhân viên
        private void btnBatDauCa_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime thoiGianHienTai = DateTime.Now;
                string getDate = thoiGianHienTai.ToString("yyyy-MM-dd");
                // Kiểm tra xem có đang trong ca làm hay không
                if (lichSuCaBLL.KiemTraVaoCaLam(TaiKhoanHienTai.TaiKhoanHienHanh.UserName, getDate))
                {
                    throw new Exception("Bạn đang trong ca làm");
                }
                // Tạo mới ca làm
                lichSuCaBLL.ThemCaLamMoi(TaiKhoanHienTai.TaiKhoanHienHanh.UserName);
                btnKetThucCa.Visible = true;
                btnBatDauCa.Visible = false;
                MessageBox.Show("Vào ca thành công");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        // Kết thúc ca làm
        private void btnKetThucCa_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime thoiGianHienTai = DateTime.Now;
                string getDate = thoiGianHienTai.ToString("yyyy-MM-dd");
                // Kiểm tra xem có đang trong ca làm hay không
                if (
                    !lichSuCaBLL.KiemTraVaoCaLam(TaiKhoanHienTai.TaiKhoanHienHanh.UserName, getDate)
                )
                {
                    throw new Exception("Bạn chưa vào ca làm");
                }
                // Lấy thông tin ca làm hiện tại
                LichSuCa caLamHienTai = lichSuCaBLL.LayCaLamMoiNhat(TaiKhoanHienTai.TaiKhoanHienHanh.UserName, getDate);

                // Kết thúc ca làm

                TimeSpan tongThoiGianLam = thoiGianHienTai.Subtract(
                    caLamHienTai.ThoiGianVaoCa
                );
                lichSuCaBLL.KetThucCaLam(
                    tongThoiGianLam.Hours,
                    thoiGianHienTai,
                    TaiKhoanHienTai.TaiKhoanHienHanh.UserName,
                    getDate
                );

                btnBatDauCa.Visible = true;
                btnKetThucCa.Visible = false;
                MessageBox.Show("Kết thúc ca thành công");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        // Chỉnh sửa thông tin cá nhân
        private void btnEditThongTin_Click(object sender, EventArgs e)
        {
            ChinhSuaThongTinForm fChinhSuaThongTin = new ChinhSuaThongTinForm();
            fChinhSuaThongTin.ShowDialog();
        }

        private void pnlQuanLyVoucher_Click(object sender, EventArgs e)
        {
            ChinhSuaVoucherForm f = new ChinhSuaVoucherForm();
            f.ShowDialog();
        }

        private void pnlQuanLyEvent_Click(object sender, EventArgs e)
        {
            ChinhSuaSuKienForm f = new ChinhSuaSuKienForm();
            f.ShowDialog();
        }

        private void pnlQuanLyHeThong_Click(object sender, EventArgs e)
        {
            ChinhSuaHeThongForm f = new ChinhSuaHeThongForm();
            f.ShowDialog();
        }

        private void pnlQuanLyLichSuCa_Click(object sender, EventArgs e)
        {
            LichSuCaForm f = new LichSuCaForm();
            f.ShowDialog();
        }

        private void pnlQuanLyDoanhThu_Click(object sender, EventArgs e)
        {
            DoanhThuForm f = new DoanhThuForm();
            f.ShowDialog();
        }

        private void pnlQuanLySanPham_Click(object sender, EventArgs e)
        {
            ChinhSuaSanPham f = new ChinhSuaSanPham();
            f.ShowDialog();
        }

        private void pnlQuanLyBan_Click(object sender, EventArgs e)
        {
            ChinhSuaBanForm f = new ChinhSuaBanForm();
            f.ShowDialog();
        }

        private void pnlQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            ChinhSuaTaiKhoanForm f = new ChinhSuaTaiKhoanForm();
            f.ShowDialog();
        }

        private void tabMainForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabMainForm.SelectedTab == tpTrangChu)
                {
                    ReloadTabPageTrangChu();
                }
                else if (tabMainForm.SelectedTab == tpSanPham)
                {
                    ReloadTabPageSanPham();
                }
                else if (tabMainForm.SelectedTab == tpBanDat)
                {
                    ReloadTabPageBanDat();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnTimKiemSuKien_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txtTimKiemSuKien.Text.Trim();

                List<string> danhSachSuKienTimKiem = new List<string>();
                DataTable dt;
                dt = suKienBLL.TimKiemSuKien(searchValue);
                foreach (DataRow dr in dt.Rows)
                {
                    string ID = dr["ID"].ToString();
                    danhSachSuKienTimKiem.Add(ID);
                }
                // Hiển thị Item tìm thấy
                LoadFlowPanelDanhSachSuKienTimKiem(danhSachSuKienTimKiem);
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

                List<string> danhSachTimKiem = new List<string>();
                DataTable dt;
                dt = voucherBLL.TimKiemVoucher(searchValue);
                foreach (DataRow dr in dt.Rows)
                {
                    string Ma = (string)dr["MA"];
                    danhSachTimKiem.Add(Ma);
                }
                // Hiển thị Item tìm thấy
                LoadFlowPanelDanhSachVoucherTimKiem(danhSachTimKiem);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DateTime thoiGianHienTai = DateTime.Now;
                string getDate = thoiGianHienTai.ToString("yyyy-MM-dd");
                // Kiểm tra xem có đang trong ca làm hay không
                if (lichSuCaBLL.KiemTraVaoCaLam(TaiKhoanHienTai.TaiKhoanHienHanh.UserName, getDate))
                {
                    throw new Exception("Bạn đang trong ca làm, vui lòng kết thúc ca");
                }
                if (!ControlForm.ConfirmForm("Xác nhận thoát chương trình"))
                {
                    e.Cancel = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                e.Cancel = true;
            }
        }

        private void btnTimKiemHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txtTimKiemMaHoaDon.Text.Trim();
                if (string.IsNullOrEmpty(searchValue))
                {
                    throw new Exception("Vui lòng nhập mã hóa đơn");
                }
                HoaDon getHoaDon = hoaDonBLL.LayThongTinHoaDon(int.Parse(searchValue));

                if (getHoaDon == null)
                {
                    throw new Exception("Hóa đơn không tồn tại hoặc chưa thanh toán");
                }

                ControlForm.HoaDonHienTai = getHoaDon;
                GUI.XuatHoaDonForm fXuatHoaDon = new GUI.XuatHoaDonForm();
                fXuatHoaDon.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void picLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Các hàm phục vụ
        void ReloadTabPageTrangChu()
        {
            LoadDanhSachSuKien();
            LoadDanhSachVoucher();
            LoadFlowPanelDanhSachSuKien();
            LoadFlowPanelDanhSachVoucher();
            txtTimKiemSuKien.Text = null;
            txtTimKiemVoucher.Text = null;
        }

        void ReloadTabPageSanPham()
        {
            LoadDanhSachSuKien();
            LoadDanhSachSanPham();
            LoadFlowPanelSanPham();
            txtTimKiemSanPham.Text = null;
            _isClickLocKhac = false;
            _isClickLocNuoc = false;
            _isClickLocThucAn = false;
            picBtnThucAnLoc.Visible = true;
            picBtnKhacLoc.Visible = true;
            picBtnNuocLoc.Visible = true;
        }

        void ReloadTabPageBanDat()
        {
            LoadFlowPanelDanhSachBan();
            txtTimKiemBan.Text = null;
            _isClickBanChuaDat = false;
            _isClickBanDaDat = false;
            picBanChuaDat.Visible = true;
            lblBanChuaDat.Visible = true;
            picBanDaDat.Visible = true;
            lblBanDaDat.Visible = true;
        }

        #endregion

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
