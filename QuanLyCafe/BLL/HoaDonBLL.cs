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
    public class HoaDonBLL
    {
        HoaDonDAL dal = new HoaDonDAL();

        public DataTable TimHoaDonByUsername(
            string getDateBatDau,
            string getDateKetThuc,
            string username
        )
        {
            try
            {
                return dal.TimHoaDonByUsername(getDateBatDau, getDateKetThuc, username);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public DataTable TimHoaDon(
         string getDateBatDau,
         string getDateKetThuc
     )
        {
            try
            {
                return dal.TimHoaDon(getDateBatDau, getDateKetThuc);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public int ThemHoaDon(HoaDon hoaDon)
        {
            try
            {
                return dal.ThemHoaDon(hoaDon);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public HoaDon LayThongTinHoaDon(int id)
        {
            try
            {
                return dal.LayThongTinHoaDon(id);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public HoaDon LayThongTinHoaDonByIDDatBan(int idDatBan)
        {
            try
            {
                return dal.LayThongTinHoaDonByIDDatBan(idDatBan);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool CapNhatDungVoucher(int soTien, string voucher, int id)
        {
            try
            {
                return dal.CapNhatDungVoucher(soTien, voucher, id);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool CapNhatDungVoucherNULL(int soTien, int id)
        {
            try
            {
                return dal.CapNhatDungVoucherNULL(soTien, id);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool CapNhatThanhToan(
            DateTime thoiGianThanhToan,
            int tienKhachTra,
            int tienThua,
            int idDatBan
        )
        {
            try
            {
                return dal.CapNhatThanhToan(thoiGianThanhToan, tienKhachTra, tienThua, idDatBan);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool ResetThongTinHoaDon(DateTime thoiGianTao, int thanhTien, int idDatBan)
        {
            try
            {
                return dal.ResetThongTinHoaDon(thoiGianTao, thanhTien, idDatBan);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
