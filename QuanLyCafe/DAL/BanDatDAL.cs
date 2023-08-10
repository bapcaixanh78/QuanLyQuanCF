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
    public class BanDatDAL : Database
    {
        public BanDat LayThongTinBanDatMoiNhat(string idBan)
        {
            try
            {
                BanDat banDat = new BanDat();
                SqlDataReader rd;
                string sqlCommand =
                    $"select top 1 * from LICHSUDATBAN where ID_BAN = '{idBan}' order by THOIGIANVAOBAN desc";
                SqlCommand cmd = CreateCommand(sqlCommand);
                rd = cmd.ExecuteReader();
                bool check = false;
                while (rd.Read())
                {
                    check = true;
                    banDat.ID = (int)rd["ID"];
                    banDat.Ban = (string)rd["ID_BAN"];
                    banDat.ThoiGianVaoBan = (DateTime)rd["THOIGIANVAOBAN"];
                    if (!string.IsNullOrEmpty(rd["THOIGIANRABAN"].ToString()))
                    {
                        banDat.ThoiGianRaBan = (DateTime)rd["THOIGIANRABAN"];
                    }
                }
                rd.Close();
                if (check)
                {
                    return banDat;
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

        public BanDat LayThongTinBanDatByID(int idBanDat)
        {
            try
            {
                BanDat banDat = new BanDat();
                SqlDataReader rd;
                string sqlCommand =
                    $"select * from LICHSUDATBAN where ID = '{idBanDat}'";
                SqlCommand cmd = CreateCommand(sqlCommand);
                rd = cmd.ExecuteReader();
                bool check = false;
                while (rd.Read())
                {
                    check = true;
                    banDat.ID = (int)rd["ID"];
                    banDat.Ban = (string)rd["ID_BAN"];
                    banDat.ThoiGianVaoBan = (DateTime)rd["THOIGIANVAOBAN"];
                    if (!string.IsNullOrEmpty(rd["THOIGIANRABAN"].ToString()))
                    {
                        banDat.ThoiGianRaBan = (DateTime)rd["THOIGIANRABAN"];
                    }
                }
                rd.Close();
                if (check)
                {
                    return banDat;
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

        public bool CapNhatThoiGianRaBan(int idBanDat)
        {
            try
            {
                DateTime thoiGianRaBan = DateTime.Now;
                string sqlCommand =
                    $"update LICHSUDATBAN set THOIGIANRABAN = '{thoiGianRaBan}' where ID = '{idBanDat}'";

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
