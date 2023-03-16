using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai2_Load(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi("MZ130", "Chuột", "Nhật", 130000, 35);
            lblThongTin.Text = tb.HienThi();
            lblThanhTien.Text = tb.ThanhTien(tb.SoLuong, tb.DonGia).ToString() + " đồng";
        }
    }
}
