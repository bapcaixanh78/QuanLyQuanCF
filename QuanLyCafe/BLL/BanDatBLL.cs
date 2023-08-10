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
    public class BanDatBLL
    {
        BanDatDAL dal = new BanDatDAL();

        public BanDat LayThongTinBanDatMoiNhat(string idBan)
        {
            try
            {
                return dal.LayThongTinBanDatMoiNhat(idBan);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public BanDat LayThongTinBanDatByID(int idBanDat)
        {
            try
            {
                return dal.LayThongTinBanDatByID(idBanDat);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public bool CapNhatThoiGianRaBan(int idBanDat)
        {
            try
            {
                return dal.CapNhatThoiGianRaBan(idBanDat);
            }
            catch (Exception err)
            {
                throw err;
            }
        }


    }
}
