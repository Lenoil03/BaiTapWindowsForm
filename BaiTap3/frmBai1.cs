using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien("NV007", "Jack Ripper", DateTime.Parse("1986/5/6"), 4, 5);
            lblThongTin.Text = nv.HienThi();
            lblLuong.Text = nv.TongLuong(nv.HeSoLuong, nv.HeSoPhuCap).ToString();
        }
    }
}
