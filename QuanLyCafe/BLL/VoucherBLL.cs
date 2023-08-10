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
    public class VoucherBLL
    {
        VoucherDAL dal = new VoucherDAL();

        public Voucher TimKiemVoucherByMa(string ma)
        {
            try
            {
                Voucher ketQua = null;
                Voucher[] danhSachVoucher = GetList();
                foreach (var item in danhSachVoucher)
                {
                    if (item.Ma.ToUpper() == ma.ToUpper())
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
        public Voucher TimKiemVoucherByMaAdmin(string ma)
        {
            try
            {
                Voucher ketQua = null;
                Voucher[] danhSachVoucher = GetListAdmin();
                foreach (var item in danhSachVoucher)
                {
                    if (item.Ma.ToUpper() == ma.ToUpper())
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

        public Voucher[] GetList()
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
        public Voucher[] GetListAdmin()
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

        public DataTable LoadDanhSachVoucher()
        {
            try
            {
                return dal.LoadDanhSachVoucher();
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public DataTable LoadDanhSachVoucherAdmin()
        {
            try
            {
                return dal.LoadDanhSachVoucherAdmin();
            }
            catch (Exception err)
            {
                throw err;
            }
        }


        public DataTable TimKiemVoucher(string searchValue)
        {
            try
            {
                return dal.TimKiemVoucher(searchValue);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public DataTable TimKiemVoucherAdmin(string searchValue)
        {
            try
            {
                return dal.TimKiemVoucherAdmin(searchValue);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool LuuThongTinVoucher(Voucher voucher)
        {
            try
            {
                return dal.LuuThongTinVoucher(voucher);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool XoaVoucher(Voucher voucher)
        {
            try
            {
                return dal.XoaVoucher(voucher);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool ThemVoucher(Voucher voucher)
        {
            try
            {
                return dal.ThemVoucher(voucher);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool KiemTraVoucher(string ma)
        {
            try
            {
                return dal.KiemTraVoucher(ma);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public Voucher LayThongTinVoucher(string ma)
        {
            try
            {
                return dal.LayThongTinVoucher(ma);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public bool CapNhatLuotDungVoucher(int luotNhap, string ma)
        {
            try
            {
                return dal.CapNhatLuotDungVoucher(luotNhap, ma);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public bool CapNhatHienThiVoucher(string ma, int hienThi)
        {
            try
            {
                return dal.CapNhatHienThiVoucher(ma, hienThi);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
