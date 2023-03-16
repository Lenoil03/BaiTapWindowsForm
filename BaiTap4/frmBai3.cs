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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            string hoTen = txtTen.Text;
            string gioiTinh = txtGioi.Text;
            int a = int.Parse(txtM.Text);
            int b = int.Parse(txtN.Text);
            XuLy.ChaoHoi(ref hoTen, ref gioiTinh);
            lblLoiChao.Text = "Chào " + gioiTinh + hoTen;
            lblUocChung.Text = XuLy.USCLN(a, b).ToString();
        }
    }
}
