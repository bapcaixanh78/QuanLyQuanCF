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
    public class LichSuOrderDAL : Database
    {
        public DataTable TimHoaDonByUsername(
            string getDateBatDau,
            string getDateKetThuc,
            string username
        )
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

        public int ThemOrder(LichSuOrder lichSuOrder)
        {
            try
            {
                DateTime thoiGianHienTai = DateTime.Now;

                string sqlCommand =
                    $"insert into LICHSUORDER (ID_DATBAN, ID_SANPHAM, ID_HOADON, DONGIA, DONGIAGIAM, SOLUONG, THANHTIEN) values ('{lichSuOrder.IDDatBan}', '{lichSuOrder.IDSanPham}', '{lichSuOrder.IDHoaDon}', '{lichSuOrder.DonGia}', '{lichSuOrder.DonGiaGiam}', '{lichSuOrder.SoLuong}', '{lichSuOrder.ThanhTien}' )";
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

        public LichSuOrder LayThongTinLichSuOrder(int idDatBan, int idHoaDon, string idSanPham)
        {
            try
            {
                LichSuOrder lichSuOrder = null;
                SqlDataReader rd;
                string sqlCommand =
                    $"select * from LICHSUORDER where ID_HOADON = '{idHoaDon}' and ID_DATBAN = '{idDatBan}' and ID_SANPHAM = '{idSanPham}'";
                SqlCommand cmd = CreateCommand(sqlCommand);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lichSuOrder = new LichSuOrder();
                    lichSuOrder.IDSanPham = (string)rd["ID_SANPHAM"];
                    lichSuOrder.IDDatBan = (int)rd["ID_DATBAN"];
                    lichSuOrder.IDHoaDon = (int)rd["ID_HOADON"];
                    lichSuOrder.DonGia = (int)rd["DONGIA"];
                    lichSuOrder.DonGiaGiam = (int)rd["DONGIAGIAM"];
                    lichSuOrder.SoLuong = (int)rd["SOLUONG"];
                    lichSuOrder.ThanhTien = (int)rd["THANHTIEN"];
                    lichSuOrder.ThoiGian = (DateTime)rd["THOIGIAN"];
                }
                rd.Close();
                return lichSuOrder;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable LayThongTinTatCaLichSuOrder(int idHoaDon)
        {
            try
            {
                string sqlCommand = $"select * from LICHSUORDER where ID_HOADON = '{idHoaDon}'";
                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable LayThongTinChiTietLichSuOrder(int idBanDat)
        {
            try
            {
                string sqlCommand =
                    $"select B.TEN as TEN_SANPHAM_LS,A.ID_HOADON as ID_HOADON_LS, A.ID_DATBAN as ID_DATBAN_LS, A.ID_SANPHAM as ID_SANPHAM_LS, A.DONGIA as DONGIA_LS, A.DONGIAGIAM as DONGIAGIAM_LS, A.SOLUONG as SOLUONG_LS, A.THOIGIAN as THOIGIAN_LS, A.THANHTIEN as THANHTIEN_LS from LICHSUORDER A, DANHSACHSANPHAM B where A.ID_SANPHAM = B.ID AND A.ID_DATBAN = '{idBanDat}' order by A.THOIGIAN desc";
                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable TimLichSuOrderBySanPham(
            string getDateBatDau,
            string getDateKetThuc,
            string idSanPham
        )
        {
            try
            {
                string sqlCommand =
                    $"select * from LICHSUORDER where cast(THOIGIAN as date) >= '{getDateBatDau}' and cast(THOIGIAN as date) <= '{getDateKetThuc}' and ID_SANPHAM = '{idSanPham}'";
                DataTable dt;
                dt = SelectQuery(sqlCommand);
                return dt;
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
                    string VOUCHER = (string)rd["VOUCHER"];
                    string NHANVIEN = (string)rd["NHANVIEN"];
                    int THANHTIEN = (int)rd["THANHTIEN"];
                    int THANHTIENGIAMGIA = (int)rd["THANHTIENGIAMGIA"];
                    int THANHTOAN = (int)rd["THANHTOAN"];
                    DateTime THOIGIAN_TAO = (DateTime)rd["THOIGIAN_TAO"];
                    DateTime THOIGIAN_THANHTOAN = (DateTime)rd["THOIGIAN_THANHTOAN"];
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

        public bool CapNhatThongTinOrder(
            int soLuong,
            int donGia,
            int donGiaGiam,
            int thanhTien,
            int idHoaDon,
            int idDatBan,
            string idSanPham
        )
        {
            try
            {
                string sqlCommand =
                    $"update LICHSUORDER set SOLUONG = '{soLuong}', DONGIA = '{donGia}', DONGIAGIAM = '{donGiaGiam}', THANHTIEN = '{thanhTien}', THOIGIAN = '{DateTime.Now}' where ID_HOADON = '{idHoaDon}' and ID_DATBAN = '{idDatBan}' and ID_SANPHAM = '{idSanPham}'";

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

        public bool XoaOrder(int idHoaDon, int idDatBan, string idSanPham)
        {
            try
            {
                string sqlCommand =
                    $"delete from LICHSUORDER where ID_DATBAN = '{idDatBan}' and ID_HOADON = '{idHoaDon}' and ID_SANPHAM = '{idSanPham}'";

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
