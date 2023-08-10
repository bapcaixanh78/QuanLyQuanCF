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
    public class HoaDonDAL : Database
    {

        public DataTable TimHoaDonByUsername(string getDateBatDau, string getDateKetThuc, string username)
        {
            try
            {
                string sqlCommand =
                    $"select * from HOADON where cast(THOIGIAN_TAO as date) >= '{getDateBatDau}' and cast(THOIGIAN_TAO as date) <= '{getDateKetThuc}' and NHANVIEN = '{username}'";
                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public DataTable TimHoaDon(string getDateBatDau, string getDateKetThuc)
        {
            try
            {
                string sqlCommand =
                    $"select * from HOADON where cast(THOIGIAN_TAO as date) >= '{getDateBatDau}' and cast(THOIGIAN_TAO as date) <= '{getDateKetThuc}'";
                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public int ThemHoaDon(HoaDon hoaDon)
        {
            try
            {
                DateTime thoiGianHienTai = DateTime.Now;

                string sqlCommand =
                    $"insert into HOADON (ID_DATBAN, NHANVIEN, THOIGIAN_TAO) values ('{hoaDon.IDBanDat}', '{hoaDon.NhanVienHoaDon}', '{thoiGianHienTai}'); SELECT SCOPE_IDENTITY();";
                SqlCommand cmd;
                cmd = CreateCommand(sqlCommand);
                int ID = Convert.ToInt32(cmd.ExecuteScalar());
                return ID;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public HoaDon LayThongTinHoaDon(int id)
        {
            try
            {
                HoaDon hoaDon = new HoaDon();
                SqlDataReader rd;
                string sqlCommand = $"select * from HOADON where ID = '{id}'";
                SqlCommand cmd = CreateCommand(sqlCommand);
                rd = cmd.ExecuteReader();
                bool check = false;
                while (rd.Read())
                {
                    check = true;
                    int ID = (int)rd["ID"];
                    string VOUCHER = rd["VOUCHER"].ToString();
                    string NHANVIEN = (string)rd["NHANVIEN"];
                    int THANHTIEN = (int)rd["THANHTIEN"];
                    int THANHTIENGIAMGIA = (int)rd["THANHTIENGIAMGIA"];
                    int THANHTOAN = (int)rd["THANHTOAN"];
                    DateTime THOIGIAN_TAO = (DateTime)rd["THOIGIAN_TAO"];
                    DateTime THOIGIAN_THANHTOAN = new DateTime();
                    if (!string.IsNullOrEmpty(rd["THOIGIAN_THANHTOAN"].ToString())) {
                        THOIGIAN_THANHTOAN = (DateTime)rd["THOIGIAN_THANHTOAN"];
                    }
                     
                    int KHACHTRA = (int)rd["KHACHTRA"];
                    int TIENTHUA = (int)rd["TIENTHUA"];
                    hoaDon = new HoaDon(
                        ID,
                        VOUCHER,
                        NHANVIEN,
                        THANHTIEN,
                        THANHTOAN,
                        THANHTIENGIAMGIA,
                        KHACHTRA,
                        TIENTHUA,
                        THOIGIAN_TAO,
                        THOIGIAN_THANHTOAN
                    );
                    hoaDon.IDBanDat = (int)rd["ID_DATBAN"];
                }
                rd.Close();
                if (check)
                {
                    return hoaDon;
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

        public HoaDon LayThongTinHoaDonByIDDatBan(int idDatBan)
        {
            try
            {
                HoaDon hoaDon = new HoaDon();
                SqlDataReader rd;
                string sqlCommand = $"select * from HOADON where ID_DATBAN = '{idDatBan}'";
                SqlCommand cmd = CreateCommand(sqlCommand);
                rd = cmd.ExecuteReader();
                bool check = false;
                while (rd.Read())
                {
                    check = true;
                    int ID = (int)rd["ID"];
                    string VOUCHER = rd["VOUCHER"].ToString();
                    string NHANVIEN = (string)rd["NHANVIEN"];
                    int THANHTIEN = (int)rd["THANHTIEN"];
                    int THANHTIENGIAMGIA = (int)rd["THANHTIENGIAMGIA"];
                    int THANHTOAN = (int)rd["THANHTOAN"];
                    DateTime THOIGIAN_THANHTOAN = new DateTime();
                    if (!string.IsNullOrEmpty(rd["THOIGIAN_THANHTOAN"].ToString()))
                    {
                        THOIGIAN_THANHTOAN = (DateTime)rd["THOIGIAN_THANHTOAN"];
                    } 
                    DateTime THOIGIAN_TAO = (DateTime)rd["THOIGIAN_TAO"];
                    int KHACHTRA = (int)rd["KHACHTRA"];
                    int TIENTHUA = (int)rd["TIENTHUA"];
                    hoaDon = new HoaDon(
                        ID,
                        VOUCHER,
                        NHANVIEN,
                        THANHTIEN,
                        THANHTOAN,
                        THANHTIENGIAMGIA,
                        KHACHTRA,
                        TIENTHUA,
                        THOIGIAN_TAO,
                        THOIGIAN_THANHTOAN
                    );
                    hoaDon.IDBanDat = (int)rd["ID_DATBAN"];
                }
                rd.Close();
                if (check)
                {
                    return hoaDon;
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

        public bool CapNhatDungVoucher(int soTien, string voucher, int id)
        {
            try
            {
                string sqlCommand =
                    $"update HOADON set THANHTIENGIAMGIA = '{soTien}', VOUCHER = '{voucher}' where ID_DATBAN = '{id}'";

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

        public bool CapNhatDungVoucherNULL(int soTien, int id)
        {
            try
            {
                string sqlCommand =
                    $"update HOADON set THANHTIENGIAMGIA = '{soTien}', VOUCHER = NULL where ID_DATBAN = '{id}'";

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


        public bool CapNhatThanhToan(
            DateTime thoiGianThanhToan,
            int tienKhachTra,
            int tienThua,
            int idDatBan
        )
        {
            try
            {
                string sqlCommand =
                    $"update HOADON set THANHTOAN = '1', THOIGIAN_THANHTOAN = '{thoiGianThanhToan}', KHACHTRA = '{tienKhachTra}', TIENTHUA = '{tienThua}' where ID_DATBAN = '{idDatBan}'";

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

        public bool ResetThongTinHoaDon(DateTime thoiGianTao, int thanhTien, int idDatBan)
        {
            try
            {
                string sqlCommand =
                    $"update HOADON set THOIGIAN_TAO = '{thoiGianTao}', THOIGIAN_THANHTOAN = NULL, VOUCHER = NULL, THANHTIEN = '{thanhTien}', THANHTIENGIAMGIA = '{thanhTien}', KHACHTRA = '0', TIENTHUA = '0' where ID_DATBAN = '{idDatBan}'";

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
