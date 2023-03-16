using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4
{
    internal class XuLy
    {
        public static void ChaoHoi(ref string hoTen, ref string gioiTinh)
        {
            hoTen = hoTen.Substring(hoTen.LastIndexOf(" "));
            if (gioiTinh == "Nam")
                gioiTinh = "Ông";
            else
                gioiTinh = "Bà";
        }
        public static int USCLN(int m, int n)
        {
            if (n == 0) return m;
            return USCLN(n, m % n);
        }
    }
}
