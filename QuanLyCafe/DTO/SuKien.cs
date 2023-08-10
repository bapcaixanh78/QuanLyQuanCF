using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class SuKien
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public int GiamGia { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }

        public SuKien() { }

        public SuKien(
            int id,
            string ten,
            string moTa,
            int giamGia,
            DateTime thoiGianBatDau,
            DateTime thoiGianKetThuc
        )
        {
            ID = id;
            Ten = ten;
            MoTa = moTa;
            GiamGia = giamGia;
            ThoiGianBatDau = thoiGianBatDau;
            ThoiGianKetThuc = thoiGianKetThuc;
        }
    }
}
