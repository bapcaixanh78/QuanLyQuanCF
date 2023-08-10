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
    public class TaiKhoanDAL : Database
    {
        private TaiKhoan LayThongTinTaiKhoanByRow(DataRow row)
        {
            TaiKhoan taiKhoan = new TaiKhoan();

            taiKhoan.UserName = row["USERNAME"].ToString();
            taiKhoan.Password = row["PASSWORD"].ToString();
            taiKhoan.FirstName = row["FIRSTNAME"].ToString();
            taiKhoan.LastName = row["LASTNAME"].ToString();
            taiKhoan.Phone = row["PHONE"].ToString();
            taiKhoan.CCCD = row["CCCD"].ToString();
            taiKhoan.Address = row["ADDRESS"].ToString();
            taiKhoan.QuyenHan = int.Parse(row["QUYENHAN"].ToString());
            taiKhoan.HienThi = int.Parse(row["HIENTHI"].ToString());
            taiKhoan.ThoiGianTao = (DateTime)row["THOIGIAN_TAO"];

            return taiKhoan;
        }

        public TaiKhoan[] GetList()
        {
            try
            {
                TaiKhoan[] taiKhoan = null;
                DataTable dt = LoadDanhSachTaiKhoan();
                taiKhoan = new TaiKhoan[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TaiKhoan s = LayThongTinTaiKhoanByRow(dt.Rows[i]);
                    taiKhoan[i] = s;
                }
                return taiKhoan;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable LoadDanhSachTaiKhoan()
        {
            try
            {
                string sqlCommand = $"select * from TAIKHOAN";
                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable LoadDanhSachQuyenHan()
        {
            try
            {
                string sqlCommand = $"select * from QUYENHAN";
                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable TimKiemTaiKhoan(string searchValue)
        {
            try
            {
                string sqlCommand = $"select * from TAIKHOAN where USERNAME like '%{searchValue}%'";

                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool LuuThongTinTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                string sqlCommand =
                    $"update TAIKHOAN set FIRSTNAME = N'{taiKhoan.FirstName}',  LASTNAME = N'{taiKhoan.LastName}',PHONE = '{taiKhoan.Phone}', CCCD = '{taiKhoan.CCCD}', ADDRESS = N'{taiKhoan.Address}', QUYENHAN = '{taiKhoan.QuyenHan}' where USERNAME = '{taiKhoan.UserName}'";
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

        public bool CapNhatMatKhau(TaiKhoan taiKhoan)
        {
            try
            {
                string sqlCommand =
                    $"update TAIKHOAN set PASSWORD = '{taiKhoan.Password}' where USERNAME = '{taiKhoan.UserName}'";
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

        public bool XoaTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                string sqlCommand;
                SqlCommand cmd;
                sqlCommand = $"delete from TAIKHOAN where USERNAME = '{taiKhoan.UserName}'";

                cmd = CreateCommand(sqlCommand);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                string sqlCommand =
                    $"insert into TAIKHOAN (USERNAME, PASSWORD, FIRSTNAME, LASTNAME, PHONE, CCCD, ADDRESS, QUYENHAN) values ('{taiKhoan.UserName}', '{taiKhoan.Password}', N'{taiKhoan.FirstName}', N'{taiKhoan.LastName}', '{taiKhoan.Phone}', '{taiKhoan.CCCD}', N'{taiKhoan.Address}', '{taiKhoan.QuyenHan}')";

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

        public TaiKhoan LayThongTinCaNhan(string username)
        {
            try
            {
                TaiKhoan taiKhoan = new TaiKhoan();
                SqlDataReader rd;
                string sqlCommand = $"select * from TAIKHOAN where USERNAME = '{username}'";
                SqlCommand cmd = CreateCommand(sqlCommand);
                rd = cmd.ExecuteReader();
                bool check = false;
                while (rd.Read())
                {
                    check = true;
                    taiKhoan.UserName = (string)rd["USERNAME"];
                    taiKhoan.FirstName = (string)rd["FIRSTNAME"];
                    taiKhoan.LastName = (string)rd["LASTNAME"];
                    taiKhoan.CCCD = (string)rd["CCCD"];
                    taiKhoan.Phone = (string)rd["PHONE"];
                    taiKhoan.QuyenHan = (int)rd["QUYENHAN"];
                    taiKhoan.Address = (string)rd["ADDRESS"];
                    taiKhoan.Password = (string)rd["PASSWORD"];
                }
                rd.Close();
                if (check)
                {
                    return taiKhoan;
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

        public bool CapNhatThongTinCaNhan(TaiKhoan taiKhoan)
        {
            try
            {
                string sqlCommand =
                    $"update TAIKHOAN set FIRSTNAME = N'{taiKhoan.FirstName}', LASTNAME = N'{taiKhoan.LastName}', CCCD = '{taiKhoan.CCCD}', PHONE = '{taiKhoan.Phone}', ADDRESS = N'{taiKhoan.Address}'  where USERNAME = '{taiKhoan.UserName}'";
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

        public bool CapNhatMatKhauCaNhan(TaiKhoan taiKhoan)
        {
            try
            {
                string sqlCommand =
                    $"update TAIKHOAN set PASSWORD = '{taiKhoan.Password}' where USERNAME = '{taiKhoan.UserName}'";
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
        public bool CapNhatHienThiTaiKhoan(string username, int hienThi)
        {
            try
            {
                string sqlCommand =
                    $"update TAIKHOAN set HIENTHI = '{hienThi}'where USERNAME = '{username}'";
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
