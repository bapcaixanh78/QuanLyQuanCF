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
    public class HeThongBLL
    {
        HeThongDAL dal = new HeThongDAL();

        public bool CapNhatThongTin(string tenCuaHang, string diaChi, int luong)
        {
            try
            {     
                return dal.CapNhatThongTin(tenCuaHang, diaChi, luong);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public void LoadHeThong()
        {
            try
            {
                 dal.LoadHeThong();
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
