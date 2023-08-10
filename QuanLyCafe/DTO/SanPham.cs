using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class SanPham
    {
      
        public bool HienThiSuKien { get; set; }

        public string ID { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public int GiaTien { get; set; }
        public int HienThi { get; set; }
        public int Event { get; set; }
        public string ImagePath { get; set; }

        public string MoTa { get; set; }

        public SanPham() { }

        public SanPham(
            string id,
            string loaiSanPham,
            string moTa,
            string tenSanPham,
            int giaTien,
            int suKien,
            string imagePath
        )
        {
            ID = id;
            LoaiSanPham = loaiSanPham;
            MoTa = moTa;
            TenSanPham = tenSanPham;
            GiaTien = giaTien;
            Event = suKien;
            ImagePath = imagePath;
        }

        public void CapNhatSanPham(
            string loaiSanPham,
            string moTa,
            int giaTien,
            int suKien,
            string imagePath
        )
        {
            LoaiSanPham = loaiSanPham;
            MoTa = moTa;
            GiaTien = giaTien;
            Event = suKien;
            ImagePath = imagePath;
        }
    }
}
