using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class BanDat
    {
        public int ID { get; set; }
        public string Ban { get; set; }
        public DateTime ThoiGianVaoBan { get; set; }
        public DateTime ThoiGianRaBan { get; set; }

        public BanDat() { }

        public BanDat(int id, string ban, DateTime thoiGianVaoBan)
        {
            ID = id;
            Ban = ban;
            ThoiGianVaoBan = thoiGianVaoBan;
        }
    }
}
