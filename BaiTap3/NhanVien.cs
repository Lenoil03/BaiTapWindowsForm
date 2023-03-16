using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public double HeSoLuong { get; set; }
        public double HeSoPhuCap { get; set; }
        public NhanVien(string maNV, string hoTen, DateTime ngaySinh, double heSoLuong, double heSoPhuCap)
        {
            MaNV = maNV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            HeSoLuong = heSoLuong;
            HeSoPhuCap = heSoPhuCap;
        }
        public double TongLuong(double a, double b)
        {
            return (a + b) * 1150000;
        }
        public string HienThi()
        {
            return string.Format("" +
                "\n\tMã nhân viên: {0}" +
                "\n\tHọ tên: {1}" +
                "\n\tNăm sinh: {2}" +
                "\n\tHệ số lương: {3}" +
                "\n\tHệ số phụ cấp: {4}",
                MaNV, HoTen, NgaySinh.Year, HeSoLuong, HeSoPhuCap);
        }
    }
}
