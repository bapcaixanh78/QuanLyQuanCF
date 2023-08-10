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
    public class VoucherDAL : Database
    {
        private Voucher LayThongTinVoucherByRow(DataRow row)
        {
            Voucher voucher = new Voucher();

            voucher.Ma = row["MA"].ToString();
            voucher.MoTa = row["MOTA"].ToString();
            voucher.GiamGia = int.Parse(row["GIAMGIA"].ToString());
            voucher.LuotNhap = int.Parse(row["LUOTNHAP"].ToString());
            voucher.SoLuong = int.Parse(row["SOLUONG"].ToString());
            voucher.HienThi = int.Parse(row["HIENTHI"].ToString());
            return voucher;
        }

        public Voucher[] GetList()
        {
            try
            {
                Voucher[] voucher = null;
                DataTable dt = LoadDanhSachVoucher();
                voucher = new Voucher[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Voucher s = LayThongTinVoucherByRow(dt.Rows[i]);
                    voucher[i] = s;
                }
                return voucher;
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
                Voucher[] voucher = null;
                DataTable dt = LoadDanhSachVoucherAdmin();
                voucher = new Voucher[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Voucher s = LayThongTinVoucherByRow(dt.Rows[i]);
                    voucher[i] = s;
                }
                return voucher;
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
                string sqlCommand = $"select * from VOUCHER where HIENTHI = 1";
                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
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
                string sqlCommand = $"select * from VOUCHER";
                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
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
                string sqlCommand = $"select * from VOUCHER where MA like '%{searchValue}%' and HIENTHI = 1";

                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
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
                string sqlCommand = $"select * from VOUCHER where MA like '%{searchValue}%'";

                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
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
                string sqlCommand =
                    $"update VOUCHER set MOTA = N'{voucher.MoTa}', SOLUONG = '{voucher.SoLuong}', GIAMGIA = '{voucher.GiamGia}' where MA = '{voucher.Ma}'";
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

        public bool XoaVoucher(Voucher voucher)
        {
            try
            {
                string sqlCommand;
                SqlCommand cmd;
                sqlCommand = $"delete from VOUCHER where MA = '{voucher.Ma}'";
                cmd = CreateCommand(sqlCommand);
                cmd.ExecuteNonQuery();
                return true;
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
                string sqlCommand =
                    $"insert into VOUCHER (MA, MOTA, GIAMGIA, SOLUONG) values ('{voucher.Ma}', N'{voucher.MoTa}', '{voucher.GiamGia}', '{voucher.SoLuong}')";

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

        public bool KiemTraVoucher(string ma)
        {
            try
            {
                SqlCommand cmd;
                SqlDataReader rd;
                string sqlCommand;
                sqlCommand =
                    $"select * from VOUCHER where MA = '{ma}' and LUOTNHAP < SOLUONG and LUOTNHAP >= 0";
                cmd = CreateCommand(sqlCommand);
                rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Close();
                    return true;
                }
                else
                {
                    rd.Close();
                    return false;
                }
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
                Voucher voucher = new Voucher();
                SqlDataReader rd;
                string sqlCommand = $"select * from VOUCHER where MA = '{ma}'";
                SqlCommand cmd = CreateCommand(sqlCommand);
                rd = cmd.ExecuteReader();
                bool check = false;
                while (rd.Read())
                {
                    check = true;
                    string MA = (string)rd["MA"];
                    int GIAMGIA = (int)rd["GIAMGIA"];
                    string MOTA = (string)rd["MOTA"];
                    int SOLUONG = (int)rd["SOLUONG"];
                    int LUOTNHAP = (int)rd["LUOTNHAP"];

                    voucher = new Voucher(MA, GIAMGIA, MOTA, LUOTNHAP, SOLUONG);
                    voucher.HienThi = (int)rd["HIENTHI"];
                }
                rd.Close();
                if (check)
                {
                    return voucher;
                }
                else
                {
                    return null;
                }
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
                string sqlCommand =
                    $"update VOUCHER set LUOTNHAP = LUOTNHAP + '{luotNhap}' where MA = '{ma}'";
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
        public bool CapNhatHienThiVoucher(string ma, int hienThi)
        {
            try
            {
                string sqlCommand =
                    $"update VOUCHER set HIENTHI = '{hienThi}'where MA = '{ma}'";
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
