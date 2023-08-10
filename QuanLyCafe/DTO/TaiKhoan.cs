using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class TaiKhoan
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string CCCD { get; set; }
        public string Address { get; set; }
        public int QuyenHan { get; set; }
        public string Password { get; set; }
        public int HienThi { get; set; }
        public DateTime ThoiGianTao { get; set; }

        public TaiKhoan() { }

        public TaiKhoan(TaiKhoan taiKhoan)
        {
            UserName = taiKhoan.UserName;
            Password = taiKhoan.Password;
            FirstName = taiKhoan.FirstName;
            LastName = taiKhoan.LastName;
            Phone = taiKhoan.Phone;
            CCCD = taiKhoan.CCCD;
            Address = taiKhoan.Address;
            QuyenHan = taiKhoan.QuyenHan;
        }

        public TaiKhoan(
            string userName,
            string password,
            string firstName,
            string lastName,
            string phone,
            string cccd,
            string address,
            int quyenHan
        )
        {
            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            CCCD = cccd;
            Address = address;
            QuyenHan = quyenHan;
        }
    }
}
