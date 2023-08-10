using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.DTO
{
    public class ControlForm
    {
        public static Ban BanDangChon { get; set; }
        public static HoaDon HoaDonHienTai { get; set; }
        public static BanDat BanDatDangChon { get; set; }
        public static GUI.MainForm FormMain { get; set; }
        public static GUI.ChiTietBanForm FormChiTietBan { get; set; }
        public static BaoCao BaoCaoHienTai { get; set; }

        public static bool ConfirmForm(string message = "Xác nhận")
        {
            DialogResult r;
            r = MessageBox.Show(
                $"{message}",
                "Cảnh báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (r == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
    }
}
