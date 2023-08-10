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
    public class LichSuCaDAL : Database
    {
        public DataTable LoadDanhSachLichSuCa(string taiKhoan, string getDate)
        {
            try
            {
                string sqlCommand =
                    $"select * from LICHSUCA where cast(THOIGIANVAOCA as date) = '{getDate}' and USERNAME = '{taiKhoan}'";

                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
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
                string sqlCommand =
                    $"select top 1 * from LICHSUCA where cast(THOIGIANVAOCA as date) = '{getDate}'and THOIGIANRACA is NULL and USERNAME = '{taiKhoan}' order by THOIGIANVAOCA desc";

                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt.Rows.Count > 0;
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
                string sqlCommand =
                    $"select * from LICHSUTHANHTOANCA where USERNAME = '{taiKhoan}' and THOIGIAN = '{getDate}'";

                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt.Rows.Count > 0;
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
                LichSuCa lichSuCa = null;
                SqlDataReader rd;
                string sqlCommand =
                    $"select top 1 * from LICHSUCA where cast(THOIGIANVAOCA as date) = '{getDate}'and THOIGIANRACA is NULL and USERNAME = '{taiKhoan}' order by THOIGIANVAOCA desc";

                SqlCommand cmd = CreateCommand(sqlCommand);
                rd = cmd.ExecuteReader();
                bool check = false;
                while (rd.Read())
                {
                    check = true;
                    lichSuCa = new LichSuCa();
                    lichSuCa.ID = (int)rd["ID"];
                    lichSuCa.Username = (string)rd["USERNAME"];
                    lichSuCa.ThoiGianVaoCa = (DateTime)rd["THOIGIANVAOCA"];
                }
                rd.Close();
                if (check)
                {
                    return lichSuCa;
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

        public bool ThemCaLamMoi(string taiKhoan)
        {
            try
            {
                SqlCommand cmd;

                string sqlCommand = $"insert into LICHSUCA (USERNAME) values ('{taiKhoan}')";

                cmd = CreateCommand(sqlCommand);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public bool ThemThanhToanCaLamMoi(string taiKhoan, string getDate, int tongTien, int tongGioLam)
        {
            try
            {
                SqlCommand cmd;

                string sqlCommand = $"insert into LICHSUTHANHTOANCA (USERNAME, THOIGIAN, TONGGIOLAM, TONGTIEN) values ('{taiKhoan}', '{getDate}', '{tongGioLam}', '{tongTien}')";
                cmd = CreateCommand(sqlCommand);
                cmd.ExecuteNonQuery();
                return true;
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
                SqlCommand cmd;

                string sqlCommand =
                    $"update LICHSUCA set TONGGIOLAM = '{tongThoiGianLam}', THOIGIANRACA = '{thoiGianHienTai}' where ID in (select top 1 ID from LICHSUCA where cast(THOIGIANVAOCA as date) = '{getDate}'and THOIGIANRACA is NULL and USERNAME = '{taiKhoan}' order by THOIGIANVAOCA desc)";

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
