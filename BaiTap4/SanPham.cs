using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4
{
    internal class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public SanPham()
        {

        }
        public int NamHetHan()
        {
            return NgaySanXuat.Year + 3;
        }
        public string HienThi()
        {
            return string.Format("" +
                "\n\tMã sản phẩm: {0}" +
                "\n\tTên sản phẩm: {1}" +
                "\n\tLoại sản phẩm: {2}" +
                "\n\tNăm sản xuất: {3}",
                MaSanPham, TenSanPham, LoaiSanPham, NgaySanXuat.Year);
        }
    }
}
