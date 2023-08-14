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
using QuanLyCafe.DTO;
using QuanLyCafe.BLL;

namespace QuanLyCafe.GUI
{
    public partial class ChinhSuaSanPham : MaterialForm
    {
        SanPhamBLL sanPhamBLL = new SanPhamBLL();
        SuKienBLL suKienBLL = new SuKienBLL();
        SanPham _sanPhamChon = null;

        public ChinhSuaSanPham()
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

        private void ChinhSuaSanPham_Load(object sender, EventArgs e)
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
                pnlTongQuanSanPham.Visible = false;
                FormatDate();
                CreateBorderRadius();
                LoadSuKien();
                LoadDanhSachSanPham();
                LoadLoaiSanPham();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #region Các hàm khởi tạo
        void FormatDate()
        {
            dtpTuNgay.CustomFormat = "yyyy-MM-dd";
            dtpDenNgay.CustomFormat = "yyyy-MM-dd";
        }

        void CreateBorderRadius()
        {
            pnlTongQuanSanPham.Anchor = AnchorStyles.None;
            pnlTongQuanSanPham.Region = Region.FromHrgn(
                CreateRoundRectRgn(
                    0,
                    0,
                    pnlTongQuanSanPham.Width,
                    pnlTongQuanSanPham.Height,
                    15,
                    15
                )
            );
            pnlBaoCao.Anchor = AnchorStyles.None;
            pnlBaoCao.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlBaoCao.Width, pnlBaoCao.Height, 15, 15)
            );

            pnlForm.Anchor = AnchorStyles.None;
            pnlForm.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlForm.Width, pnlForm.Height, 15, 15)
            );

            pnlThemSanPham.Anchor = AnchorStyles.None;
            pnlThemSanPham.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlThemSanPham.Width, pnlThemSanPham.Height, 15, 15)
            );

            picHienThiSanPham.Anchor = AnchorStyles.None;
            picHienThiSanPham.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, picHienThiSanPham.Width, picHienThiSanPham.Height, 15, 15)
            );

            picHienThiSanPhamThem.Anchor = AnchorStyles.None;
            picHienThiSanPhamThem.Region = Region.FromHrgn(
                CreateRoundRectRgn(
                    0,
                    0,
                    picHienThiSanPhamThem.Width,
                    picHienThiSanPhamThem.Height,
                    15,
                    15
                )
            );
        }

        void LoadDanhSachSanPham()
        {
            DataTable dt;
            dt = sanPhamBLL.LoadDanhSachSanPhamAdmin();
            dgvDanhSachSanPham.DataSource = dt;
            if (ControlForm.FormMain != null)
            {
                ControlForm.FormMain.LoadDanhSachSanPham();
                ControlForm.FormMain.LoadFlowPanelSanPham();
            }
        }

        void LoadLoaiSanPham()
        {
            DataTable dt;
            dt = sanPhamBLL.LoadDanhMucSanPham();

            cboLoai.DataSource = dt;
            cboLoai.DisplayMember = "TEN";
            cboLoai.ValueMember = "ID";

            cboLoaiThem.DataSource = dt;
            cboLoaiThem.DisplayMember = "TEN";
            cboLoaiThem.ValueMember = "ID";
        }

        void LoadSuKien()
        {
            DataTable dt;
            dt = suKienBLL.LoadDanhSachSuKien();
  
            cboSuKien.DataSource = dt;
            cboSuKien.DisplayMember = "TEN";
            cboSuKien.ValueMember = "ID";

            cboSuKienThem.DataSource = dt;
            cboSuKienThem.DisplayMember = "TEN";
            cboSuKienThem.ValueMember = "ID";
        }

        #endregion

        #region Các hàm sự kiện
        private void dgvDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    _sanPhamChon = null;
                    HienThiSanPham();
                    return;
                }

                DataGridViewRow row = new DataGridViewRow();
                row = dgvDanhSachSanPham.Rows[e.RowIndex];
                if (string.IsNullOrEmpty(row.Cells["ID"].Value.ToString()))
                {
                    _sanPhamChon = null;
                    HienThiSanPham();
                    return;
                }
                string ID = row.Cells["ID"].Value.ToString();
                string imagePath = row.Cells["IMAGE_PATH"].Value.ToString();

                _sanPhamChon = sanPhamBLL.TimKiemSanPhamByIDAdmin(ID);
                if (_sanPhamChon == null)
                {
                    HienThiSanPham();
                    throw new Exception("Không tìm thấy sản phẩm");
                }
                Image image = sanPhamBLL.GetImageByPath(_sanPhamChon.ID);
                picHienThiSanPham.Image = image;
                HienThiSanPham();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (_sanPhamChon == null)
                {
                    return;
                }
                OpenFileDialog fileOpen = new OpenFileDialog();
                fileOpen.Title = "Open Image file";
                fileOpen.Filter = "Files|*.jpg;*.jpeg;*.png";

                if (fileOpen.ShowDialog() == DialogResult.OK)
                {
                    picHienThiSanPham.Image = Image.FromFile(fileOpen.FileName);
                    txtImagePath.Text = fileOpen.FileName;
                }
                fileOpen.Dispose();
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
                if (_sanPhamChon == null)
                {
                    return;
                }
                if (ControlForm.ConfirmForm("Bạn có muốn lưu?"))
                {
                    string tenSanPham = txtTenSanPham.Text.Trim();
                    int giaTien = int.Parse(txtGiaTien.Text);
                    string moTa = txtMoTa.Text.Trim();
                    string imagePath = txtImagePath.Text.Trim();
                    int suKien = -1;
                    if (cboSuKien.SelectedIndex != -1)
                    {
                        suKien = int.Parse(cboSuKien.SelectedValue.ToString());
                    }
                    string loaiSanPham = (cboLoai.SelectedValue.ToString());

                    if (
                        string.IsNullOrEmpty(tenSanPham)
                        || string.IsNullOrEmpty(moTa)
                        || string.IsNullOrEmpty(imagePath)
                    )
                    {
                        throw new Exception("Vui lòng nhập thông tin hợp lệ");
                    }
                    SuKien getSuKien = suKienBLL.TimKiemSuKienByID(suKien);
                    SanPham sanPham = new SanPham(
                        _sanPhamChon.ID,
                        loaiSanPham,
                        moTa,
                        tenSanPham,
                        giaTien,
                        suKien,
                        imagePath
                    );
                    if (sanPhamBLL.LuuThongTinSanPham(sanPham, chkKhongThemSuKien.Checked, suKien))
                    {
                        LoadDanhSachSanPham();
                        _sanPhamChon.CapNhatSanPham(loaiSanPham, moTa, giaTien, suKien, imagePath);
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

        private void btnUploadImageThem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileOpenThem = new OpenFileDialog();
                fileOpenThem.Title = "Open Image file";
                fileOpenThem.Filter = "Files|*.jpg;*.jpeg;*.png";

                if (fileOpenThem.ShowDialog() == DialogResult.OK)
                {
                    picHienThiSanPhamThem.Image = Image.FromFile(fileOpenThem.FileName);
                    txtImagePathThem.Text = fileOpenThem.FileName;
                }
                fileOpenThem.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txtIDThem_Leave(object sender, EventArgs e)
        {
            txtIDThem.Text = txtIDThem.Text.ToUpper();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControlForm.ConfirmForm("Bạn có muốn thêm?"))
                {
                    string IDSanPham = txtIDThem.Text.Trim();
                    string tenSanPham = txtTenSanPhamThem.Text.Trim();
                    int giaTien = int.Parse(txtGiaTienThem.Text);
                    string moTa = txtMoTaThem.Text.Trim();
                    string imagePath = txtImagePathThem.Text.Trim();
                    int suKien = int.Parse(cboSuKienThem.SelectedValue.ToString());
                    string loaiSanPham = (cboLoaiThem.SelectedValue.ToString());

                    if (
                        string.IsNullOrEmpty(tenSanPham)
                        || string.IsNullOrEmpty(moTa)
                        || string.IsNullOrEmpty(imagePath)
                        || string.IsNullOrEmpty(IDSanPham)
                    )
                    {
                        throw new Exception("Vui lòng nhập thông tin hợp lệ");
                    }
                    IDSanPham = IDSanPham.ToUpper();
                    SanPham timSanPham = sanPhamBLL.TimKiemSanPhamByID(IDSanPham);
                    if (timSanPham != null)
                    {
                        throw new Exception("Sản phẩm đã tồn tại");
                    }
                    SuKien getSuKien = suKienBLL.TimKiemSuKienByID(suKien);
                    SanPham sanPham = new SanPham(
                        IDSanPham,
                        loaiSanPham,
                        moTa,
                        tenSanPham,
                        giaTien,
                        suKien,
                        imagePath
                    );
                    if (sanPhamBLL.ThemSanPham(sanPham, chkKhongThemSuKienThem.Checked))
                    {
                        LoadDanhSachSanPham();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (_sanPhamChon == null)
                {
                    return;
                }
                if (_sanPhamChon.HienThi == 1)
                {

               
                if (
                    ControlForm.ConfirmForm(
                        "Bạn có muốn ẩn sản phẩm? Hành động này sẽ ẩn tất cả mọi thứ liên quan đến nó"
                    )
                )
                {

                    // Kiểm tra xem sản phẩm có đang được order hay không?
              
                    // ẩn sản phẩm

                    SanPham sanPham = _sanPhamChon;
                    if (sanPhamBLL.CapNhatHienThiSanPham(sanPham.ID, 0))
                    {
                            _sanPhamChon = null;
                            HienThiSanPham();
                            LoadDanhSachSanPham();

                        MessageBox.Show("Ẩn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Ẩn thất bại");
                    }
                }
                } else
                {
                    // hủy ẩn sản phẩm

                    SanPham sanPham = _sanPhamChon;
                    if (sanPhamBLL.CapNhatHienThiSanPham(sanPham.ID, 1))
                    {
                        _sanPhamChon = null;
                        HienThiSanPham();
                        LoadDanhSachSanPham();

                        MessageBox.Show("Hủy Ẩn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Hủy Ẩn thất bại");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

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

        private void txtGiaTienThem_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBaoCaoSoLuongBanRa_Click(object sender, EventArgs e)
        {
            try
            {
                if (_sanPhamChon == null)
                {
                    throw new Exception("Vui lòng chọn sản phẩm muốn báo cáo");
                }
                DateTime getDateTimeBatDau = dtpTuNgay.Value;
                DateTime getFilterDateBatDau = new DateTime(
                    getDateTimeBatDau.Year,
                    getDateTimeBatDau.Month,
                    getDateTimeBatDau.Day
                );

                DateTime getDateTimeKetThuc = dtpDenNgay.Value;
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

                BaoCao baoCaoMoi = new BaoCao(
                    "soluongsanphambanra",
                    TaiKhoanHienTai.TaiKhoanHienHanh.UserName
                );
                baoCaoMoi.IDSanPham = _sanPhamChon.ID;
                baoCaoMoi.SetBaoCaoCaLamNhanVien(dtpTuNgay.Value, dtpDenNgay.Value);
                ControlForm.BaoCaoHienTai = baoCaoMoi;
                ReportViewForm fBaoCao = new ReportViewForm();
                fBaoCao.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        #region Các hàm phục vụ

        void HienThiSanPham()
        {
            if (_sanPhamChon != null)
            {
                pnlTongQuanSanPham.Visible = true;
                pnlBaoCao.Visible = true;

                txtID.Text = _sanPhamChon.ID;
                txtTenSanPham.Text = _sanPhamChon.TenSanPham;
                txtGiaTien.Text = _sanPhamChon.GiaTien.ToString();
                txtImagePath.Text = _sanPhamChon.ImagePath;
                txtMoTa.Text = _sanPhamChon.MoTa;
                if (_sanPhamChon.Event != -1)
                {
                    chkKhongThemSuKien.Checked = false;
                    cboSuKien.SelectedValue = int.Parse((_sanPhamChon.Event).ToString());
                }
                else
                {
                    chkKhongThemSuKien.Checked = true;
                    cboSuKien.SelectedIndex = -1;
                }
                cboLoai.SelectedValue = ((_sanPhamChon.LoaiSanPham).ToString());
                if (_sanPhamChon.HienThi == 1)
                {
                    btnXoa.Text = "Ẩn";
                } else
                {
                    btnXoa.Text = "Hủy Ẩn";
                }
            } else
            {
                pnlTongQuanSanPham.Visible = false;
                pnlBaoCao.Visible = false;
             
            }
        }

        void ReloadTabPageChinhSua()
        {
            DataTable dt = (DataTable)dgvDanhSachSanPham.DataSource;
            if (dt != null)
            {
                dt.Clear();
            }
            LoadDanhSachSanPham();
            _sanPhamChon = null;
            txtTimKiemSanPham.Text = null;
            HienThiSanPham();

        }

        void ReloadTabPageThem()
        {
            picHienThiSanPhamThem.Image = null;
            txtIDThem.Text = null;
            txtTenSanPhamThem.Text = null;
            txtGiaTienThem.Text = null;
            txtMoTaThem.Text = null;
            txtImagePathThem.Text = null;
        }
        #endregion

        private void pnlTongQuanSanPham_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
