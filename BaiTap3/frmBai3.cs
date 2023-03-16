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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string hoLot = "";
            string ten = "";
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            XuLy.TachChuoi(hoTen, ref ten, ref hoLot);
            lblHoLot.Text = hoLot;
            lblTen.Text = ten;
            if (XuLy.ThuTu(a, b))
                lblLienTiep.Text = "Là hai số nguyên liên tiếp";
            else
                lblLienTiep.Text = "Không phải hai số nguyên liên tiếp";

        }
    }
}
