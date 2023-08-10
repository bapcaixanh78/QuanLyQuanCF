using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.DTO;
using QuanLyCafe.DAL;
using System.Data;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyCafe.BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL dal = new TaiKhoanDAL();

        public TaiKhoan TimKiemTaiKhoanByUsername(string userName)
        {
            try
            {
                TaiKhoan ketQua = null;
                TaiKhoan[] danhSachTaiKhoan = GetList();
                foreach (var item in danhSachTaiKhoan)
                {
                    if (item.UserName == userName)
                    {
                        ketQua = item;
                        break;
                    }
                }
                return ketQua;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public TaiKhoan[] GetList()
        {
            try
            {
                return dal.GetList();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable LoadDanhSachTaiKhoan()
        {
            try
            {
                return dal.LoadDanhSachTaiKhoan();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable LoadDanhSachQuyenHan()
        {
            try
            {
                return dal.LoadDanhSachQuyenHan();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable TimKiemTaiKhoan(string searchValue)
        {
            try
            {
                return dal.TimKiemTaiKhoan(searchValue);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool LuuThongTinTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                return dal.LuuThongTinTaiKhoan(taiKhoan);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool CapNhatMatKhau(TaiKhoan taiKhoan)
        {
            try
            {
                return dal.CapNhatMatKhau(taiKhoan);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool XoaTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                return dal.XoaTaiKhoan(taiKhoan);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                return dal.ThemTaiKhoan(taiKhoan);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool CapNhatThongTinCaNhan(TaiKhoan taiKhoan)
        {
            try
            {
                return dal.CapNhatThongTinCaNhan(taiKhoan);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool CapNhatMatKhauCaNhan(TaiKhoan taiKhoan)
        {
            try
            {
                return dal.CapNhatMatKhauCaNhan(taiKhoan);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool CapNhatHienThiTaiKhoan(string username, int hienThi)
        {
            try
            {
                return dal.CapNhatHienThiTaiKhoan(username, hienThi);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public TaiKhoan LayThongTinCaNhan(string username)
        {
            try
            {
                return dal.LayThongTinCaNhan(username);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool KiemTraPasswordLogin(string username, string password)
        {
            try
            {
                TaiKhoan getTaiKhoan = LayThongTinCaNhan(username);
                if (getTaiKhoan == null)
                {
                    return false;
                }
                bool passwordCheck = BC.Verify(password, getTaiKhoan.Password);
                return passwordCheck;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
