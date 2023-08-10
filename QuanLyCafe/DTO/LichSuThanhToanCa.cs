using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class LichSuThanhToanCa
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public DateTime ThoiGian { get; set; }
        public DateTime ThoiGianThanhToan { get; set; }
        public int TongGioLam { get; set; }
        public int TongTien { get; set; }
        public int ThanhToan { get; set; }
    }
}
