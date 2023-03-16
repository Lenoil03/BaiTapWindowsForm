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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtLyThuyet.Text);
            int b = int.Parse(txtThucHanh.Text);
            double c = (a + b) / 2;
            if (a < 5 || b < 5)
                lblKetQua.Text = "Yếu";
            else
            {
                if (c < 7)
                    lblKetQua.Text = "Trung bình";
                if (7 <= c && c < 8)
                    lblKetQua.Text = "Khá";
                if (8 <= c && c < 9)
                    lblKetQua.Text = "Giỏi";
                if (9 <= c)
                    lblKetQua.Text = "Xuất sắc";
            }
        }
    }
}
