using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class BaoCao
    {
        string _taiKhoan;
        string _loai;
        DateTime _ngayBatDau;
        DateTime _ngayKetThuc;
        int _soLuong;

        // Báo cáo cho doanh thu

        int _doanhThu;

        // Báo cáo cho ca làm nhân viên
        int _tongTienCaLam;

        // Báo cáo cho số lượng sản phẩm bán ra
        string _idSanPham;

        public int SoLuong
        {
            get { return _soLuong; }
        }
        public int DoanhThu
        {
            get { return _doanhThu; }
        }
        public DateTime NgayBatDau
        {
            get { return _ngayBatDau; }
            set { _ngayBatDau = value; }
        }
        public DateTime NgayKetThuc
        {
            get { return _ngayKetThuc; }
            set { _ngayKetThuc = value; }
        }
        public string IDSanPham
        {
            get { return _idSanPham; }
            set { _idSanPham = value; }
        }
        public string TaiKhoan
        {
            get { return _taiKhoan; }
            set { _taiKhoan = value; }
        }
        public int TongTienCaLam
        {
            get { return _tongTienCaLam; }
            set { _tongTienCaLam = value; }
        }

        // Loại: doanhthuhoadon; doanhthuhoadoncanhan; calamnhanvien
        public string Loai
        {
            get { return _loai; }
        }

        public BaoCao(string loai, string taiKhoan)
        {
            _loai = loai;
            _taiKhoan = taiKhoan;
        }

        public void SetBaoCaoDoanhThu(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            _ngayBatDau = ngayBatDau;
            _ngayKetThuc = ngayKetThuc;
        }

        public void SetBaoCaoCaLamNhanVien(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            _ngayBatDau = ngayBatDau;
            _ngayKetThuc = ngayKetThuc;
        }
    }
}
