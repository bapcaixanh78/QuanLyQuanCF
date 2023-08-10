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
    public class LichSuThanhToanCaDAL : Database
    {
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

        public bool ThemThanhToanCaLamMoi(
            string taiKhoan,
            string getDate,
            int tongTien,
            int tongGioLam
        )
        {
            try
            {
                SqlCommand cmd;

                string sqlCommand =
                    $"insert into LICHSUTHANHTOANCA (USERNAME, THOIGIAN, TONGGIOLAM, TONGTIEN) values ('{taiKhoan}', '{getDate}', '{tongGioLam}', '{tongTien}')";
                cmd = CreateCommand(sqlCommand);
                cmd.ExecuteNonQuery();
                return true;
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
                LichSuThanhToanCa result = new LichSuThanhToanCa();
                SqlDataReader rd;
                string sqlCommand =
                    $"select * from LICHSUTHANHTOANCA where USERNAME = '{taiKhoan}' and THOIGIAN = '{getDate}'";
                SqlCommand cmd = CreateCommand(sqlCommand);
                rd = cmd.ExecuteReader();
                bool check = false;
                while (rd.Read())
                {
                    check = true;
                    result = new LichSuThanhToanCa();
                    result.ID = (int)rd["ID"];
                    result.Username = (string)rd["USERNAME"];
                    result.ThoiGian = (DateTime)rd["THOIGIAN"];
                    result.TongGioLam = (int)rd["TONGGIOLAM"];
                    result.TongTien = (int)rd["TONGTIEN"];
                    result.ThanhToan = (int)rd["THANHTOAN"];
                    DateTime thoiGianThanhToan = new DateTime();
                    if (!string.IsNullOrEmpty(rd["THOIGIAN_THANHTOAN"].ToString()))
                    {
                        thoiGianThanhToan = (DateTime)rd["THOIGIAN_THANHTOAN"];
                    }
                    result.ThoiGianThanhToan = thoiGianThanhToan;
                }
                rd.Close();
                if (check)
                {
                    return result;
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

        public bool CapNhatThongTinLichSuThanhToanCa(
            string taiKhoan,
            string getDate,
            int tongTien,
            int tongGioLam
        )
        {
            try
            {
                SqlCommand cmd;

                string sqlCommand =
                    $"update LICHSUTHANHTOANCA set TONGGIOLAM = '{tongGioLam}', TONGTIEN = '{tongTien}' where USERNAME = '{taiKhoan}' and THOIGIAN = '{getDate}'";
                cmd = CreateCommand(sqlCommand);
                cmd.ExecuteNonQuery();
                return true;
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
                SqlCommand cmd;

                string sqlCommand =
                    $"update LICHSUTHANHTOANCA set THANHTOAN = '1', THOIGIAN_THANHTOAN = '{DateTime.Now}' where USERNAME = '{taiKhoan}' and THOIGIAN = '{getDate}'";
                cmd = CreateCommand(sqlCommand);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public DataTable TimLichSuThanhToanCaByUsername(string getDateBatDau, string getDateKetThuc, string taiKhoan)
        {
            try
            {
                string sqlCommand =
                        $"select * from LICHSUTHANHTOANCA where cast(THOIGIAN as date) >= '{getDateBatDau}' and cast(THOIGIAN as date) <= '{getDateKetThuc}' and USERNAME = '{taiKhoan}'";
                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
