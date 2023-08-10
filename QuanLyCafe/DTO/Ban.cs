using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class Ban
    {
        public string ID { get; set; }
        public string TenBan { get; set; }
        public int TinhTrang { get; set; }
        public int HienThi { get; set; }

        public Ban() { }

        public Ban(string id, string tenBan, int tinhTrang)
        {
            ID = id;
            TenBan = tenBan;
            TinhTrang = tinhTrang;
        }
    }
}
