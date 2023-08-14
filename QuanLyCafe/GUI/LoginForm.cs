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

using BC = BCrypt.Net.BCrypt;
using QuanLyCafe.BLL;
using QuanLyCafe.DTO;

namespace QuanLyCafe.GUI
{
    public partial class LoginForm : MaterialForm
    {
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();

        public LoginForm()
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Tạo border radius
            pnlForm.Anchor = AnchorStyles.None;
            pnlForm.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, pnlForm.Width, pnlForm.Height, 30, 30)
            );
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string taiKhoan = txtUsername.Text.Trim();
                string matKhau = txtPassword.Text.Trim();
                if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }

                if (taiKhoanBLL.KiemTraPasswordLogin(taiKhoan, matKhau))
                {
                    // Cập nhật tài khoản trong chương trình
                    TaiKhoan getTaiKhoan = taiKhoanBLL.TimKiemTaiKhoanByUsername(taiKhoan);
                    TaiKhoanHienTai.TaiKhoanHienHanh = getTaiKhoan;

                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    GUI.MainForm f = new GUI.MainForm();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    throw new Exception("Tài khoản không tồn tại hoặc mật khẩu không chính xác!");
                }
            }
            catch (Exception err)
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar(err.Message);
                SnackBarMessage.Show(this);
            }
        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMatKhau.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
