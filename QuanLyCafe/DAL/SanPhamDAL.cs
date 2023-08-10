using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.DTO;
using System.Data.SqlClient;

namespace QuanLyCafe.DAL
{
    public class SanPhamDAL : Database
    {
        public DataTable LoadDanhSachSanPham()
        {
            try
            {
                string sqlCommand = $"select * from DANHSACHSANPHAM where HIENTHI = 1";
                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
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
                string sqlCommand = $"select * from DANHSACHSANPHAM";
                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
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
                string sqlCommand = $"select * from DANHMUCSANPHAM";
                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private SanPham LayThongTinSanPhamByRow(DataRow row)
        {
            SanPham sanPham = new SanPham();

            sanPham.ID = row["ID"].ToString();
            sanPham.LoaiSanPham = row["LOAISANPHAM"].ToString();
            sanPham.TenSanPham = row["TEN"].ToString();
            sanPham.GiaTien = int.Parse(row["GIATIEN"].ToString());
            if (!row.IsNull("EVENT"))
            {
                sanPham.Event = int.Parse(row["EVENT"].ToString());
            }
            else
            {
                sanPham.Event = -1;
            }

            sanPham.MoTa = row["MOTA"].ToString();
            sanPham.ImagePath = row["IMAGE_PATH"].ToString();
            sanPham.HienThi = int.Parse(row["HIENTHI"].ToString());
            return sanPham;
        }

        public SanPham[] GetList()
        {
            try
            {
                SanPham[] sanPham = null;
                DataTable dt = LoadDanhSachSanPham();
                sanPham = new SanPham[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SanPham s = LayThongTinSanPhamByRow(dt.Rows[i]);
                    sanPham[i] = s;
                }
                return sanPham;
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
                SanPham[] sanPham = null;
                DataTable dt = LoadDanhSachSanPhamAdmin();
                sanPham = new SanPham[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SanPham s = LayThongTinSanPhamByRow(dt.Rows[i]);
                    sanPham[i] = s;
                }
                return sanPham;
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
                string sqlCommand =
                    $"select * from DANHSACHSANPHAM where TEN like N'%{searchValue}%'";
                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
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
                string sqlCommand;
                // Không thêm sự kiện
                if (hasSuKien)
                {
                    sqlCommand =
                        $"update DANHSACHSANPHAM set TEN = N'{sanPham.TenSanPham}', GIATIEN = '{sanPham.GiaTien}', EVENT = NULL, MOTA = N'{sanPham.MoTa}', IMAGE_PATH = '{sanPham.ImagePath}', LOAISANPHAM = '{sanPham.LoaiSanPham}' where ID = '{sanPham.ID}'";
                }
                else
                {
                    if (suKien == -1)
                    {
                        sqlCommand =
                            $"update DANHSACHSANPHAM set TEN = N'{sanPham.TenSanPham}', GIATIEN = '{sanPham.GiaTien}', EVENT = NULL, MOTA = N'{sanPham.MoTa}', IMAGE_PATH = '{sanPham.ImagePath}', LOAISANPHAM = '{sanPham.LoaiSanPham}' where ID = '{sanPham.ID}'";
                    }
                    else
                    {
                        sqlCommand =
                            $"update DANHSACHSANPHAM set TEN = N'{sanPham.TenSanPham}', GIATIEN = '{sanPham.GiaTien}', EVENT = '{suKien}', MOTA = N'{sanPham.MoTa}', IMAGE_PATH = '{sanPham.ImagePath}', LOAISANPHAM = '{sanPham.LoaiSanPham}' where ID = '{sanPham.ID}'";
                    }
                }

                SqlCommand cmd;
                cmd = CreateCommand(sqlCommand);
                cmd.ExecuteNonQuery();
                return true;
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
                string sqlCommand;
                SqlCommand cmd;
                sqlCommand = $"delete DANHSACHSANPHAM where ID = '{sanPham.ID}'";
                cmd = CreateCommand(sqlCommand);
                cmd.ExecuteNonQuery();
                return true;
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
                string sqlCommand;
                if (hasSuKien)
                {
                    sqlCommand =
                        $"insert into DANHSACHSANPHAM (ID, TEN, GIATIEN, EVENT, MOTA, IMAGE_PATH, LOAISANPHAM) values ('{sanPham.ID}', N'{sanPham.TenSanPham}', '{sanPham.GiaTien}', NULL, N'{sanPham.MoTa}', '{sanPham.ImagePath}', '{sanPham.LoaiSanPham}')";
                }
                else
                {
                    sqlCommand =
                        $"insert into DANHSACHSANPHAM (ID, TEN, GIATIEN, EVENT, MOTA, IMAGE_PATH, LOAISANPHAM) values ('{sanPham.ID}', N'{sanPham.TenSanPham}', '{sanPham.GiaTien}', '{sanPham.Event}', N'{sanPham.MoTa}', '{sanPham.ImagePath}', '{sanPham.LoaiSanPham}')";
                }
                SqlCommand cmd;
                cmd = CreateCommand(sqlCommand);
                cmd.ExecuteNonQuery();
                return true;
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
                string sqlCommand;
                SqlCommand cmd;
                sqlCommand = $"update DANHSACHSANPHAM set EVENT = NULL where EVENT = '{idSuKien}'";

                cmd = CreateCommand(sqlCommand);
                cmd.ExecuteNonQuery();
                return true;
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
                string sqlCommand =
                    $"update DANHSACHSANPHAM set HIENTHI = '{hienThi}'where ID = '{idSanPham}'";
                SqlCommand cmd;
                cmd = CreateCommand(sqlCommand);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
