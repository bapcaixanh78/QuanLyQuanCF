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
    public class LichSuCaBLL
    {
        LichSuCaDAL dal = new LichSuCaDAL();

        public DataTable LoadDanhSachLichSuCa(string taiKhoan, string getDate)
        {
            try
            {
                return dal.LoadDanhSachLichSuCa(taiKhoan, getDate);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public LichSuCa LayCaLamMoiNhat(string taiKhoan, string getDate)
        {
            try
            {
                return dal.LayCaLamMoiNhat(taiKhoan, getDate);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool KiemTraVaoCaLam(string taiKhoan, string getDate)
        {
            try
            {
                return dal.KiemTraVaoCaLam(taiKhoan, getDate);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

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

        public bool ThemCaLamMoi(string taiKhoan)
        {
            try
            {
                return dal.ThemCaLamMoi(taiKhoan);
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

        public bool KetThucCaLam(
            int tongThoiGianLam,
            DateTime thoiGianHienTai,
            string taiKhoan,
            string getDate
        )
        {
            try
            {
                return dal.KetThucCaLam(tongThoiGianLam, thoiGianHienTai, taiKhoan, getDate);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
