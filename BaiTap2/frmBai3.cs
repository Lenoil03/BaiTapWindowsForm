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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            string a = txtHoLot.Text;
            string b = txtTen.Text;
            int n = int.Parse(txtN.Text);
            string hoTen = "";
            XuLy.NoiChuoi(a, b, ref hoTen);
            long ketQua = XuLy.GiaiThua(n);
            lblTen.Text = hoTen;
            lblKetQua.Text = ketQua.ToString();
        }
    }
}
