using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class LichSuOrder
    {
        public int IDHoaDon { get; set; }
        public int IDDatBan { get; set; }
        public string IDSanPham { get; set; }
        public int DonGia { get; set; }
        public int DonGiaGiam { get; set; }
        public int SoLuong { get; set; }
        public int ThanhTien { get; set; }

        public DateTime ThoiGian { get; set; }

        public LichSuOrder() { }
    }
}
