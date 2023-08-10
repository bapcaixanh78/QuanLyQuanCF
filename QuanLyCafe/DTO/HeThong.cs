using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class HeThong
    {
        public static int ID { get; set; }
        public static string TenCuaHang { get; set; }
        public static string DiaChiCuaHang { get; set; }
        public static int LuongPartTime { get; set; }

        public static void SetHeThong(
            int id,
            string tenCuaHang,
            string diaChiCuaHang,
            int luongPartTime
        )
        {
            ID = id;
            TenCuaHang = tenCuaHang;
            DiaChiCuaHang = diaChiCuaHang;
            LuongPartTime = luongPartTime;
        }
    }
}
