using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int IDBanDat { get; set; }
        public int IDOrder { get; set; }
        public string VoucherHoaDon { get; set; }
        public string NhanVienHoaDon { get; set; }
        public int ThanhTien { get; set; }
        public int ThanhToan { get; set; }
        public int ThanhTienGiamGia { get; set; }
        public int TienKhachTra { get; set; }
        public int TienThua { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianThanhToan { get; set; }

        public HoaDon() { }

        public HoaDon(
            int id,
            string voucher,
            string nhanVien,
            int thanhTien,
            int thanhToan,
            int thanhTienGiamGia,
            int khachTra,
            int tienThua,
            DateTime thoiGianTao,
            DateTime thoiGianThanhToan
        )
        {
            ID = id;
            VoucherHoaDon = voucher;
            NhanVienHoaDon = nhanVien;
            ThanhTien = thanhTien;
            ThanhToan = thanhToan;
            ThanhTienGiamGia = thanhTienGiamGia;
            TienKhachTra = khachTra;
            TienThua = tienThua;
            ThoiGianTao = thoiGianTao;
            ThoiGianThanhToan = thoiGianThanhToan;
        }
    }
}
