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
    public partial class ChinhSuaBanForm : MaterialForm
    {
        BanBLL banBLL = new BanBLL();
        Ban _banChon = null;

        public ChinhSuaBanForm()
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

        private void ChinhSuaBanForm_Load(object sender, EventArgs e)
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
                CreateBorderRadius();
                LoadDanhSachBan();
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
            pnlTongQuanBan.Anchor = AnchorStyles.None;
            pnlTongQuanBan.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlTongQuanBan.Width, pnlTongQuanBan.Height, 15, 15)
            );

            picHienThiBan.Anchor = AnchorStyles.None;
            picHienThiBan.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, picHienThiBan.Width, picHienThiBan.Height, 15, 15)
            );

            picHienThiBanThem.Anchor = AnchorStyles.None;
            picHienThiBanThem.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, picHienThiBanThem.Width, picHienThiBanThem.Height, 15, 15)
            );

            pnlThemBan.Anchor = AnchorStyles.None;
            pnlThemBan.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlThemBan.Width, pnlThemBan.Height, 15, 15)
            );
        }

        void LoadDanhSachBan()
        {
            DataTable dt;
            dt = banBLL.LoadDanhSachBanAdmin();
            dgvDanhSachBan.DataSource = dt;
            if (ControlForm.FormMain != null)
            {
                ControlForm.FormMain.LoadDanhSachBan();
                ControlForm.FormMain.LoadFlowPanelDanhSachBan();
            }
        }
        #endregion

        #region Các hàm sự kiện
        private void dgvDanhSachBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    _banChon = null;
                    HienThiThongTinBan();
                    return;
                }

                DataGridViewRow row = new DataGridViewRow();
                row = dgvDanhSachBan.Rows[e.RowIndex];
                if (string.IsNullOrEmpty(row.Cells["ID"].Value.ToString()))
                {
                    _banChon = null;
                    HienThiThongTinBan();
                    return;
                }
                string ID = row.Cells["ID"].Value.ToString();

                _banChon = banBLL.TimKiemBanByIDAdmin(ID);

                if (_banChon == null)
                {
                    HienThiThongTinBan();
                    throw new Exception("Không tìm thấy bàn");
                }
                if (_banChon.TinhTrang == 0)
                {
                    Image image = Properties.Resources.table_chuadat;
                    picHienThiBan.Image = image;
                }
                else
                {
                    Image image = Properties.Resources.table_dadat;
                    picHienThiBan.Image = image;
                }

                HienThiThongTinBan();
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
                if (_banChon == null)
                {
                    return;
                }
                if (ControlForm.ConfirmForm("Bạn có muốn lưu"))
                {
                    string tenBan = txtTenBan.Text.Trim();
                    if (string.IsNullOrEmpty(tenBan))
                    {
                        throw new Exception("Vui lòng nhập đầy đủ thông tin");
                    }
                    Ban ban = new Ban();
                    ban.TenBan = tenBan;
                    ban.ID = _banChon.ID;

                    if (banBLL.LuuThongTinBan(ban))
                    {
                        Ban getBan = banBLL.TimKiemBanByID(_banChon.ID);
                        getBan.TenBan = tenBan;
                        HienThiThongTinBan();
                        LoadDanhSachBan();
                        if (ControlForm.FormMain != null)
                        {
                            ControlForm.FormMain.LoadFlowPanelDanhSachBan();
                        }
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
                if (_banChon == null)
                {
                    return;
                }
                if (_banChon.HienThi == 1)
                {
                    if (
                        ControlForm.ConfirmForm(
                            "Bạn có muốn ẩn bàn? Sau này có thể khôi phục lại bàn này"
                        )
                    )
                    {
                        if (_banChon.TinhTrang == 1)
                        {
                            throw new Exception("Bàn đang có khách, không thể ẩn");
                        }

                        // Ẩn hiển thị bàn
                        if (banBLL.CapNhatHienThiBan(_banChon.ID, 0))
                        {
                            _banChon = null;
                            HienThiThongTinBan();

                            LoadDanhSachBan();

                            MessageBox.Show("Ẩn bàn thành công");
                        }
                        else
                        {
                            MessageBox.Show("Ẩn bàn thất bại");
                        }
                    }
                }
                else
                {
                    // Hủy Ẩn hiển thị bàn
                    if (banBLL.CapNhatHienThiBan(_banChon.ID, 1))
                    {
                        _banChon = null;
                        HienThiThongTinBan();

                        LoadDanhSachBan();

                        MessageBox.Show("Hủy Ẩn bàn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Hủy Ẩn bàn thất bại");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            try
            {
                string IDBan = txtIDBanThem.Text.Trim();
                string tenBan = txtTenBanThem.Text.Trim();
                if (string.IsNullOrEmpty(tenBan) || string.IsNullOrEmpty(IDBan))
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                if (ControlForm.ConfirmForm("Bạn có muốn thêm?"))
                {
                    Ban banMoi = new Ban(IDBan, tenBan, 0);
                    banBLL.ThemBan(banMoi);
                    LoadDanhSachBan();
                    ReloadTabPageThem();
                    MessageBox.Show("Thành công");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txtIDBanThem_Leave(object sender, EventArgs e)
        {
            txtIDBanThem.Text = txtIDBanThem.Text.ToUpper();
        }

        private void btnTimKiemBan_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txtTimKiemBan.Text.Trim();
                DataTable dt;
                dt = banBLL.TimKiemBan(searchValue);
                dgvDanhSachBan.DataSource = dt;
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
        #endregion

        #region Các hàm phục vụ
        void HienThiThongTinBan()
        {
            if (_banChon != null)
            {
                pnlTongQuanBan.Visible = true;
                txtIDBan.Text = _banChon.ID;
                txtTenBan.Text = _banChon.TenBan;
                txtTinhTrang.Text = _banChon.TinhTrang.ToString();
                if (_banChon.HienThi == 1)
                {
                    btnXoa.Text = "Ẩn";
                } else
                {
                    btnXoa.Text = "Hủy ẩn";
                }
            }
            else
            {
                pnlTongQuanBan.Visible = false;
            }
        }

        void ReloadTabPageChinhSua()
        {
            DataTable dt = (DataTable)dgvDanhSachBan.DataSource;
            if (dt != null)
            {
                dt.Clear();
            }
            LoadDanhSachBan();
            _banChon = null;
            txtTimKiemBan.Text = null;
            HienThiThongTinBan();
        }

        void ReloadTabPageThem()
        {
            txtIDBanThem.Text = null;
            txtTenBanThem.Text = null;
        }

        #endregion

        private void materialTabSelector1_Click(object sender, EventArgs e) { }
    }
}
