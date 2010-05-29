﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiengViet4
{
    public partial class KeChuyenForm : Form
    {
        public KeChuyenForm()
        {
            InitializeComponent();
        }
        ChonBaiHocForm   frmParent;

        public KeChuyenForm(string strMaBaiHoc, ChonBaiHocForm MyParent)
        {
        InitializeComponent();

            frmParent = MyParent;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            grpCauHoi.Visible = true;
        }

        private void KeChuyen_Load(object sender, EventArgs e)
        {

        }

        private void picGCDCauTiepTheo_Click(object sender, EventArgs e)
        {
            if (pnlHinhAnh.Expanded == true && pnlCauChuyenTraLoi.Expanded == false)
            {
                lblGCDCauChuyen.Text = "Hình Ảnh";
                pnlHinhAnh.AnimationTime = 100;
                pnlCauChuyenTraLoi.AnimationTime = 1000;
                pnlHinhAnh.Expanded = false;
                pnlCauChuyenTraLoi.Expanded = true;
            }
            else
            {
                lblGCDCauChuyen.Text = "Câu Chuyện";
                pnlCauChuyenTraLoi.AnimationTime = 100;
                pnlHinhAnh.AnimationTime = 1000;
                pnlCauChuyenTraLoi.Expanded = false;               
                pnlHinhAnh.Expanded = true;
            }
        }

        private void btnHome_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Close();
            frmParent.Show();
        }

        private void btnThoat_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Close();
            frmParent.Close();
        }
    }
}