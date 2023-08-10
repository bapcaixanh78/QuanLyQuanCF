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
    public class HeThongDAL : Database
    {
        public bool CapNhatThongTin(string tenCuaHang, string diaChi, int luong)
        {
            try
            {
                string sqlCommand;
                SqlCommand cmd;
                sqlCommand =
                    $"update HETHONG set TENCUAHANG = @TEN, DIACHICUAHANG = @DIACHI, LUONG_PARTTIME = @LUONG where ID = 1";

                cmd = CreateCommand(sqlCommand);
                cmd.Parameters.AddWithValue("@TEN", tenCuaHang);

                cmd.Parameters.AddWithValue("@DIACHI", diaChi);

                cmd.Parameters.AddWithValue("@LUONG", luong);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void LoadHeThong()
        {
            try
            {
                string sqlCommand;
                SqlCommand cmd;
                SqlDataReader rd;
                sqlCommand = $"select * from HETHONG where ID = '1'";
                cmd = CreateCommand(sqlCommand);
                rd = cmd.ExecuteReader();
                if (!rd.HasRows)
                {
                    int idHeThongMoi = 1;
                    string tenCuaHangMoi = "Ten";
                    string diaChiCuaHangMoi = "DiaChi";
                    int luongPartTimeMoi = 0;
                    sqlCommand =
                        $"insert into HETHONG (ID, TENCUAHANG, DIACHICUAHANG, LUONG_PARTTIME) values ('{idHeThongMoi}', N'{tenCuaHangMoi}', N'{diaChiCuaHangMoi}', '{luongPartTimeMoi}')";
                    cmd = CreateCommand(sqlCommand);
                    cmd.ExecuteNonQuery();
                    HeThong.SetHeThong(
                        idHeThongMoi,
                        tenCuaHangMoi,
                        diaChiCuaHangMoi,
                        luongPartTimeMoi
                    );
                }
                else
                {
                    while (rd.Read())
                    {
                        int idHeThongMoi = (int)rd["ID"];
                        string tenCuaHangMoi = (string)rd["TENCUAHANG"];
                        string diaChiCuaHangMoi = (string)rd["DIACHICUAHANG"];
                        int luongPartTimeMoi = (int)rd["LUONG_PARTTIME"];
                        HeThong.ID = (int)rd["ID"]; 
                        HeThong.TenCuaHang = (string)rd["TENCUAHANG"];
                        HeThong.DiaChiCuaHang = (string)rd["DIACHICUAHANG"];
                        HeThong.LuongPartTime = (int)rd["LUONG_PARTTIME"];
                       
                    }
                }
                rd.Close();
           
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
