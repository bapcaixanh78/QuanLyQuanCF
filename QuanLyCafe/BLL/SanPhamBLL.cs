using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.DTO;
using QuanLyCafe.DAL;
using System.Data;
using System.Drawing;
using System.IO;

namespace QuanLyCafe.BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL dal = new SanPhamDAL();

        public Image GetImageByPath(string ID)
        {
            try
            {
                Image image = null;
                SanPham timSanPham = TimKiemSanPhamByID(ID);
                if (timSanPham != null)
                {
                    string imagePath = timSanPham.ImagePath;
                    if (!File.Exists($@"{imagePath}"))
                    {
                        image = null;
                    }
                    else
                    {
                        image = Image.FromFile($@"{imagePath}");
                    }
                }
                return image;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public SanPham TimKiemSanPhamByID(string ID)
        {
            try
            {
                SanPham ketQua = null;
                SanPham[] danhSachSanPham = GetList();
                foreach (var item in danhSachSanPham)
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
        public SanPham TimKiemSanPhamByIDAdmin(string ID)
        {
            try
            {
                SanPham ketQua = null;
                SanPham[] danhSachSanPham = GetListAdmin();
                foreach (var item in danhSachSanPham)
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

        public DataTable LoadDanhSachSanPham()
        {
            try
            {
                return dal.LoadDanhSachSanPham();
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public DataTable LoadDanhSachSanPhamAdmin()
        {
            try
            {
                return dal.LoadDanhSachSanPhamAdmin();
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public DataTable LoadDanhMucSanPham()
        {
            try
            {
                return dal.LoadDanhMucSanPham();
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public SanPham[] GetList()
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
        public SanPham[] GetListAdmin()
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

        public DataTable TimKiemSanPham(string searchValue)
        {
            try
            {
                return dal.TimKiemSanPham(searchValue);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool LuuThongTinSanPham(SanPham sanPham, bool hasSuKien, int suKien)
        {
            try
            {
                return dal.LuuThongTinSanPham(sanPham, hasSuKien, suKien);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool XoaSanPham(SanPham sanPham)
        {
            try
            {
                return dal.XoaSanPham(sanPham);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool ThemSanPham(SanPham sanPham, bool hasSuKien)
        {
            try
            {
                return dal.ThemSanPham(sanPham, hasSuKien);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public bool UpdateHetThoiGianSuKien(int idSuKien)
        {
            try
            {
                return dal.UpdateHetThoiGianSuKien(idSuKien);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public bool CapNhatHienThiSanPham(string idSanPham, int hienThi)
        {
            try
            {
                return dal.CapNhatHienThiSanPham(idSanPham, hienThi);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
