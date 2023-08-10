using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.DTO;
using QuanLyCafe.DAL;
using System.Data;

namespace QuanLyCafe.BLL
{
    public class DoanhThuBLL
    {
        DoanhThuDAL dal = new DoanhThuDAL();

        public Dictionary<string, string> LoadDoanhThu(string getDateBatDau, string getDateKetThuc)
        {
            try
            {
                Dictionary<string, string> result = new Dictionary<string, string>();
                DataTable dt;
                dt = dal.LoadDoanhThu(getDateBatDau, getDateKetThuc);
                string tuNgay = getDateBatDau;
                string denNgay = getDateKetThuc;
                int tongHoaDon = 0;
                int tongDoanhThu = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    tongDoanhThu += (int)dr["THANHTIENGIAMGIA"];
                }
                tongHoaDon = dt.Rows.Count;
                result.Add("tuNgay", tuNgay);
                result.Add("denNgay", denNgay);
                result.Add("tongHoaDon", tongHoaDon.ToString());
                result.Add("tongDoanhThu", tongDoanhThu.ToString());
                return result;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public DataTable LoadDoanhThuDataTable(string getDateBatDau, string getDateKetThuc)
        {
            try
            {
                DataTable dt;
                dt = dal.LoadDoanhThu(getDateBatDau, getDateKetThuc);

                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
