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
    public class BanDAL : Database
    {
        private Ban LayThongTinBanByRow(DataRow row)
        {
            Ban ban = new Ban();

            ban.ID = row["ID"].ToString();
            ban.TenBan = row["TEN"].ToString();
            ban.TinhTrang = int.Parse(row["TINHTRANG"].ToString());
            ban.HienThi = int.Parse(row["HIENTHI"].ToString());
            return ban;
        }

        public Ban[] GetList()
        {
            try
            {
                Ban[] ban = null;
                DataTable dt = LoadDanhSachBan();
                ban = new Ban[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Ban s = LayThongTinBanByRow(dt.Rows[i]);
                    ban[i] = s;
                }
                return ban;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public Ban[] GetListAdmin()
        {
            try
            {
                Ban[] ban = null;
                DataTable dt = LoadDanhSachBanAdmin();
                ban = new Ban[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Ban s = LayThongTinBanByRow(dt.Rows[i]);
                    ban[i] = s;
                }
                return ban;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public DataTable LoadDanhSachBan()
        {
            try
            {
                string sqlCommand =
                    $"select * from DANHSACHBAN where HIENTHI = 1";
                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable LoadDanhSachBanAdmin()
        {
            try
            {
                string sqlCommand =
                    $"select * from DANHSACHBAN";
                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable TimKiemBan(string searchValue)
        {
            try
            {
                string sqlCommand =
                    $"select ID, TEN, TINHTRANG, HIENTHI from DANHSACHBAN where TEN like N'%{searchValue}%'";
                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool LuuThongTinBan(Ban ban)
        {
            try
            {
                string sqlCommand =
                    $"update DANHSACHBAN set TEN = N'{ban.TenBan}'where ID = '{ban.ID}'";
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

        public bool XoaBan(Ban ban)
        {
            try
            {
                string sqlCommand;
                SqlCommand cmd;
                sqlCommand = $"delete DANHSACHBAN where ID = '{ban.ID}'";
                cmd = CreateCommand(sqlCommand);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool ThemBan(Ban ban)
        {
            try
            {
                string sqlCommand =
                    $"insert into DANHSACHBAN (ID, TEN) values ('{ban.ID}', N'{ban.TenBan}')";
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

        public bool KiemTraTinhTrangBanChuaDat(Ban ban)
        {
            try
            {
                string sqlCommand;
                SqlDataReader rd;

                SqlCommand cmd;
                sqlCommand = $"select * from DANHSACHBAN where ID = '{ban.ID}' AND TINHTRANG = '1'";
                cmd = CreateCommand(sqlCommand);
                rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    return false;
                }
                rd.Close();
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public int ThemLichSuDatBan(Ban ban)
        {
            try
            {
                string sqlCommand;
                DateTime thoiGianHienTai = DateTime.Now;

                SqlCommand cmd;
                sqlCommand =
                    $"insert into LICHSUDATBAN (ID_BAN, THOIGIANVAOBAN) values ('{ban.ID}', '{thoiGianHienTai}'); SELECT SCOPE_IDENTITY();";
                cmd = CreateCommand(sqlCommand);
                int ID = Convert.ToInt32(cmd.ExecuteScalar());
                return ID;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool CapNhatTinhTrangBanDat(Ban ban)
        {
            try
            {
                string sqlCommand;
                DateTime thoiGianHienTai = DateTime.Now;

                SqlCommand cmd;
                sqlCommand =
                    $"update DANHSACHBAN set TINHTRANG = '1'  where ID = '{ban.ID}'";
                cmd = CreateCommand(sqlCommand);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public bool CapNhatTinhTrangBanTrong(string idBan)
        {
            try
            {
                string sqlCommand;
                DateTime thoiGianHienTai = DateTime.Now;

                SqlCommand cmd;
                sqlCommand =
                    $"update DANHSACHBAN set TINHTRANG = '0' where ID = '{idBan}'";
                cmd = CreateCommand(sqlCommand);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public bool CapNhatHienThiBan(string idBan, int hienThi)
        {
            try
            {
                string sqlCommand =
                    $"update DANHSACHBAN set HIENTHI = '{hienThi}'where ID = '{idBan}'";
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
