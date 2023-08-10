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
    public class LichSuThanhToanCaBLL
    {
        LichSuThanhToanCaDAL dal = new LichSuThanhToanCaDAL();

        public bool KiemTraThanhToanCaLam(string taiKhoan, string getDate)
        {
            try
            {
                return dal.KiemTraThanhToanCaLam(taiKhoan, getDate);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool ThemThanhToanCaLamMoi(
            string taiKhoan,
            string getDate,
            int tongTien,
            int tongGioLam
        )
        {
            try
            {
                return dal.ThemThanhToanCaLamMoi(taiKhoan, getDate, tongTien, tongGioLam);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public LichSuThanhToanCa LayThongTinLichSuThanhToanCa(string taiKhoan, string getDate)
        {
            try
            {
                return dal.LayThongTinLichSuThanhToanCa(taiKhoan, getDate);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool CapNhatThongTinLichSuThanhToanCa(
            string taiKhoan,
            string getDate,
            int tongTien,
            int tongGioLam
        )
        {
            try
            {
                return dal.CapNhatThongTinLichSuThanhToanCa(
                    taiKhoan,
                    getDate,
                    tongTien,
                    tongGioLam
                );
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool CapNhatTrangThaiLichSuThanhToanCa(string taiKhoan, string getDate)
        {
            try
            {
                return dal.CapNhatTrangThaiLichSuThanhToanCa(taiKhoan, getDate);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable TimLichSuThanhToanCaByUsername(
            string getDateBatDau,
            string getDateKetThuc,
            string taiKhoan
        )
        {
            try
            {
                return dal.TimLichSuThanhToanCaByUsername(getDateBatDau, getDateKetThuc, taiKhoan);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
