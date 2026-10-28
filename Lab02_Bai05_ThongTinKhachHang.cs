using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LAB02_DACBIET
{
    public partial class Lab02_Bai05_ThongTinKhachHang : Form
    {
        public Lab02_Bai05_ThongTinKhachHang(Lab02_Bai5_Phim phim)
        {
            InitializeComponent();

            phimDuocChon = phim;

            HienThiThongTinPhim(phim);
        }

        private Lab02_Bai5_Phim phimDuocChon;

        private void HienThiThongTinPhim(Lab02_Bai5_Phim phim)
        {
            // Hiển thị poster
            ptxPosterPhim.Image = phim.Poster;
            ptxPosterPhim.SizeMode = PictureBoxSizeMode.StretchImage;

            // Hiển thị tên phim
            tbxTenPhim.Text = phim.TenPhim;

            // Hiển thị giá vé
            tbxThongTinGiaVe.Text =
                "Vé thường: " + phim.GiaVe.ToString("N0") + " VNĐ\r\n" +
                "Vé VIP: " + (phim.GiaVe * 2m).ToString("N0") + " VNĐ\r\n" +
                "Vé vớt: " + (phim.GiaVe * 0.25m).ToString("N0") + " VNĐ";

            // Không cho khách hàng sửa thông tin phim
            tbxTenPhim.ReadOnly = true;
            tbxThongTinGiaVe.ReadOnly = true;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

private void btnChonGhe_Click(object sender, EventArgs e)
        {
            // Lấy thông tin khách hàng
            string hoVaTen = tbxHoVaTen.Text.Trim();
            string soDienThoai = tbxSoDienThoai.Text.Trim();
            string email = tbxEmail.Text.Trim();

            // Kiểm tra họ và tên
            if (string.IsNullOrWhiteSpace(hoVaTen))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ và tên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbxHoVaTen.Focus();
                return;
            }

            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(soDienThoai))
            {
                MessageBox.Show(
                    "Vui lòng nhập số điện thoại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbxSoDienThoai.Focus();
                return;
            }

            // Kiểm tra email
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show(
                    "Vui lòng nhập email!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbxEmail.Focus();
                return;
            }

            // Kiểm tra thông tin phim
            if (phimDuocChon == null)
            {
                MessageBox.Show(
                    "Không tìm thấy thông tin phim!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Thông tin khách hàng hợp lệ, mở form chọn ghế
            using (Lab02_Bai05_ChonGhe formChonGhe =
                   new Lab02_Bai05_ChonGhe(phimDuocChon))
            {
                formChonGhe.ShowDialog(this);
            }
        }
    }
}
