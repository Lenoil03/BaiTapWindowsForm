using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap4
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSanPham = "SKZ22685";
            sp.TenSanPham = "Trái cây đóng hộp";
            sp.LoaiSanPham = "Thực phẩm bảo quản";
            sp.NgaySanXuat = DateTime.Parse("2023/3/3");
            lblThongTin.Text = sp.HienThi();
            lblHetHan.Text = sp.NamHetHan().ToString();
        }
    }
}
