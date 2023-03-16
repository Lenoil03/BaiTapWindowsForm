﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoA.Text);
            int b = int.Parse(txtSoB.Text);
            int n = int.Parse(txtSoN.Text);
            int ketQua = 0;
            if (rdTong.Checked)
                TinhToan.CongHaiSo(a, b, ref ketQua);
            else
                ketQua = TinhToan.TongDaySo(n);
            lblKetQua.Text = ketQua.ToString();
        }
    }
}
