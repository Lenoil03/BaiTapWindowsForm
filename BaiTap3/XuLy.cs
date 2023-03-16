using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    internal class XuLy
    {
        public static void TachChuoi(string hoten, ref string s1, ref string s2)
        {
            s1 = hoten.Substring(hoten.LastIndexOf(" "));
            s2 = hoten.Substring(0, hoten.LastIndexOf(" "));
        }
        public static bool ThuTu(int n1, int n2)
        {
            if (n1 + 1 == n2 || n2 + 1 == n1)
                return true;
            else
                return false;
        }
    }
}
