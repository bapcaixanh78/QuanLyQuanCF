using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.DTO;
using QuanLyCafe.DAL;
using System.Data;

namespace QuanLyCafe.BLL
{
    public class BanBLL
    {
        BanDAL dal = new BanDAL();

        public Ban TimKiemBanByID(string ID)
        {
            try
            {
                Ban[] danhSachBan = GetList();
                Ban ketQua = null;
                foreach (var item in danhSachBan)
                {
                    if (item.ID.ToUpper() == ID.ToUpper())
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
        public Ban TimKiemBanByIDAdmin(string ID)
        {
            try
            {
                Ban[] danhSachBan = GetListAdmin();
                Ban ketQua = null;
                foreach (var item in danhSachBan)
                {
                    if (item.ID.ToUpper() == ID.ToUpper())
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

        public Ban[] GetList()
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

        public Ban[] GetListAdmin()
        {
            try
            {
                return dal.GetListAdmin();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable LoadDanhSachBan()
        {
            try
            {
                return dal.LoadDanhSachBan();
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public DataTable LoadDanhSachBanAdmin()
        {
            try
            {
                return dal.LoadDanhSachBanAdmin();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable TimKiemBan(string searchValue)
        {
            try
            {
                return dal.TimKiemBan(searchValue);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool LuuThongTinBan(Ban ban)
        {
            try
            {
                return dal.LuuThongTinBan(ban);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool XoaBan(Ban ban)
        {
            try
            {
                return dal.XoaBan(ban);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool ThemBan(Ban ban)
        {
            try
            {
                return dal.ThemBan(ban);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public bool KiemTraTinhTrangBanChuaDat(Ban ban)
        {
            try
            {
                return dal.KiemTraTinhTrangBanChuaDat(ban);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public int ThemLichSuDatBan(Ban ban)
        {
            try
            {
                return dal.ThemLichSuDatBan(ban);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public bool CapNhatTinhTrangBanDat(Ban ban)
        {
            try
            {
                return dal.CapNhatTinhTrangBanDat(ban);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public bool CapNhatTinhTrangBanTrong(string idBan)
        {
            try
            {
                return dal.CapNhatTinhTrangBanTrong(idBan);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public bool CapNhatHienThiBan(string idBan, int hienThi)
        {
            try
            {
                return dal.CapNhatHienThiBan(idBan, hienThi);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
