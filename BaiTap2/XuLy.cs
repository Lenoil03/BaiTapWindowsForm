using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class XuLy
    {
        public static void NoiChuoi(string ho, string ten, ref string s)
        {
            s = ho + " " + ten;
        }
        public static long GiaiThua(int n)
        {
            int ketQua = 1;
            for (int i = 2; i <= n; i++)
                ketQua *= i;
            return ketQua;
        }
    }
}
