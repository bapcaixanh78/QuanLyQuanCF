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
    public class DoanhThuDAL : Database
    {
        public DataTable LoadDoanhThu(string getDateBatDau, string getDateKetThuc)
        {
            try
            {
                string sqlCommand =
                      $"select * from HOADON where cast(THOIGIAN_TAO as date) >= '{getDateBatDau}' and cast(THOIGIAN_TAO as date) <= '{getDateKetThuc}' and THANHTOAN = '1'";
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
