using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public ThietBi(string maThietBi, string tenThietBi, string nuocSanXuat, int donGia, int soLuong)
        {
            MaThietBi = maThietBi;
            TenThietBi = tenThietBi;
            NuocSanXuat = nuocSanXuat;
            DonGia = donGia;
            SoLuong = soLuong;
        }
        public int ThanhTien(int a, int b)
        {
            return a * b;
        }
        public string HienThi()
        {
            return string.Format("" +
                "\n\tMã thiết bị: {0}" +
                "\n\tTên thiết bị: {1}" +
                "\n\tNước sản xuất: {2}" +
                "\n\tĐơn giá: {3}" +
                "\n\tSố lượng: {4}",
                MaThietBi, TenThietBi, NuocSanXuat, DonGia, SoLuong);
        }
    }
}
