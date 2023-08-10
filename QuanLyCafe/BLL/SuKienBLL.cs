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
    public class SuKienBLL
    {
        SuKienDAL dal = new SuKienDAL();

        public SuKien TimKiemSuKienByID(int ID)
        {
            try
            {
                SuKien ketQua = null;
                SuKien[] danhSachSuKien = GetList();
                foreach (var item in danhSachSuKien)
                {
                    if (item.ID == ID)
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

        public SuKien[] GetList()
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

        public DataTable LoadDanhSachSuKien()
        {
            try
            {
                return dal.LoadDanhSachSuKien();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable TimKiemSuKien(string searchValue)
        {
            try
            {
                return dal.TimKiemSuKien(searchValue);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool LuuThongTinSuKien(SuKien suKien)
        {
            try
            {
                return dal.LuuThongTinSuKien(suKien);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool XoaSuKien(SuKien suKien)
        {
            try
            {
                return dal.XoaSuKien(suKien);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool ThemSuKien(SuKien suKien)
        {
            try
            {
                return dal.ThemSuKien(suKien);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public SuKien LayThongTinSuKien(int id)
        {
            try
            {
                return dal.LayThongTinSuKien(id);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
