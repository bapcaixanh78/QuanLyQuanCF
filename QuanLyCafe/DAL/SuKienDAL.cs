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
    public class SuKienDAL : Database
    {
        private SuKien LayThongTinSuKienByRow(DataRow row)
        {
            int ID = (int)row["ID"];
            string moTa = (string)row["MOTA"];
            string ten = (string)row["TEN"];
            int giamGia = (int)row["GIAMGIA"];
            DateTime thoiGianBatDau = (DateTime)row["THOIGIANBATDAU"];
            DateTime thoiGianKetThuc = (DateTime)row["THOIGIANKETTHUC"];
            SuKien suKien = new SuKien(
                ID,
                ten,
                moTa,
                giamGia,
                thoiGianBatDau,
                thoiGianKetThuc
            );
            return suKien;
        }

        public SuKien[] GetList()
        {
            try
            {
                SuKien[] suKien = null;
                DataTable dt = LoadDanhSachSuKien();
                suKien = new SuKien[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SuKien s = LayThongTinSuKienByRow(dt.Rows[i]);
                    suKien[i] = s;
                }
                return suKien;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public DataTable LoadDanhSachSuKien()
        {
            try
            {
                string sqlCommand = $"select * from EVENT";
                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable TimKiemSuKien(string searchValue)
        {
            try
            {
                string sqlCommand = $"select * from EVENT where TEN like N'%{searchValue}%'";

                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool LuuThongTinSuKien(SuKien suKien)
        {
            try
            {
                string sqlCommand =
                    $"update EVENT set THOIGIANBATDAU = '{suKien.ThoiGianBatDau}', THOIGIANKETTHUC = '{suKien.ThoiGianKetThuc}', MOTA = N'{suKien.MoTa}', TEN = N'{suKien.Ten}', GIAMGIA = '{suKien.GiamGia}' where ID = '{suKien.ID}'";
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

        public bool XoaSuKien(SuKien suKien)
        {
            try
            {
                string sqlCommand;
                SqlCommand cmd;
                sqlCommand = $"delete from EVENT where ID = '{suKien.ID}'";
                cmd = CreateCommand(sqlCommand);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool ThemSuKien(SuKien suKien)
        {
            try
            {
                string sqlCommand =
                    $"insert into EVENT (TEN, MOTA, GIAMGIA, THOIGIANBATDAU, THOIGIANKETTHUC) values (N'{suKien.Ten}', N'{suKien.MoTa}', '{suKien.GiamGia}', '{suKien.ThoiGianBatDau}', '{suKien.ThoiGianKetThuc}')";

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

        public SuKien LayThongTinSuKien(int id)
        {
            try
            {
                SuKien suKien = new SuKien();
                SqlDataReader rd;
                string sqlCommand = $"select * from EVENT where ID = '{id}'";
                SqlCommand cmd = CreateCommand(sqlCommand);
                rd = cmd.ExecuteReader();
                bool check = false;
                while (rd.Read())
                {
                    check = true;
                    suKien.ID = (int)rd["ID"];
                    suKien.Ten = (string)rd["TEN"];
                    suKien.MoTa = (string)rd["MOTA"];
                    suKien.GiamGia = (int)rd["GIAMGIA"];
                    suKien.ThoiGianBatDau = (DateTime)rd["THOIGIANBATDAU"];
                    suKien.ThoiGianKetThuc = (DateTime)rd["THOIGIANKETTHUC"];
                }
                rd.Close();
                if (check)
                {
                    return suKien;
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
    }
}
