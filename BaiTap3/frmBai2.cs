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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            int ketQua;
            if (rdTongN.Checked)
            {
                ketQua = 0;
                for (int i = 1; i <= n; i++)
                    ketQua += i;
            }
            else
            {
                ketQua = 1;
                for (int i = 1; i <= n; i++)
                    ketQua *= i;
            }
            lblKetQua.Text = ketQua.ToString();
        }
    }
}
