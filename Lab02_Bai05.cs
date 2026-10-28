using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LAB02_DACBIET
{
    public partial class Lab02_Bai05 : Form
    {
        public Lab02_Bai05()
        {
            InitializeComponent();
        }

        private void MoFormThongTinKhachHang(Lab02_Bai5_Phim phim)
        {
            using (Lab02_Bai05_ThongTinKhachHang form =
                   new Lab02_Bai05_ThongTinKhachHang(phim))
            {
                form.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDaoPhoVaPiano_Click(object sender, EventArgs e)
        {
            Lab02_Bai5_Phim phim = new Lab02_Bai5_Phim(
        "ĐÀO PHỞ VÀ PIANO",
        45000m,
        Properties.Resources.Peach_Blossom__Pho_and_Piano__2024_2
    );

            MoFormThongTinKhachHang(phim);
        }

        private void btnMai_Click(object sender, EventArgs e)
        {
            Lab02_Bai5_Phim phim = new Lab02_Bai5_Phim(
        "MAI",
        100000m,
        Properties.Resources.Mai__2024__Phương_Anh_Đào__Tuấn_Trần
    );

            MoFormThongTinKhachHang(phim);
        }

        private void btnGapLaiChiBau_Click(object sender, EventArgs e)
        {
            Lab02_Bai5_Phim phim = new Lab02_Bai5_Phim(
        "GẶP LẠI CHỊ BẦU",
        70000m,
        Properties.Resources.Teaser_Poster___GẶP_LẠI_CHỊ_BẦU
    );

            MoFormThongTinKhachHang(phim);
        }

        private void btnTarot_Click(object sender, EventArgs e)
        {
            Lab02_Bai5_Phim phim = new Lab02_Bai5_Phim(
        "TAROT",
        90000m,
        Properties.Resources.Tarot
    );

            MoFormThongTinKhachHang(phim);
        }

        private void btnXemThongKe_Click(object sender, EventArgs e)
        {
            using (ThongKeDatVeXemPhim formThongKe = new ThongKeDatVeXemPhim())
            {
                formThongKe.ShowDialog();
            }
        }
    }
}
