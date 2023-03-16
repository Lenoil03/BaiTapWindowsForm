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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNhat.Text);
            int b = int.Parse(txtHai.Text);
            if (rdCong.Checked)
                lblKetQua.Text = (a + b).ToString();
            if (rdTru.Checked)
                lblKetQua.Text = (a - b).ToString();
            if (rdNhan.Checked)
                lblKetQua.Text = (a * b).ToString();
            if (rdChia.Checked)
                if (b != 0)
                    lblKetQua.Text = (a / b).ToString();
                else
                    lblKetQua.Text = "Không tồn tại!";
        }
    }
}
