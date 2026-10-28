using System;
using System.Windows.Forms;

namespace LAB02_DACBIET
{
    public partial class ThongKeDatVeXemPhim : Form
    {
        public ThongKeDatVeXemPhim()
        {
            InitializeComponent();

            KhoiTaoThongKe();
            GanSuKien();
        }

        // Khởi tạo giao diện thống kê
        private void KhoiTaoThongKe()
        {
            // Cấu hình bảng chi tiết đặt vé
            lvwChiTietDatVe.View = View.Details;
            lvwChiTietDatVe.FullRowSelect = true;
            lvwChiTietDatVe.GridLines = true;
            lvwChiTietDatVe.MultiSelect = false;

            lvwChiTietDatVe.Columns.Clear();

            lvwChiTietDatVe.Columns.Add("STT", 40);
            lvwChiTietDatVe.Columns.Add("Mã vé", 70);
            lvwChiTietDatVe.Columns.Add("Tên phim", 130);
            lvwChiTietDatVe.Columns.Add("Khách hàng", 120);
            lvwChiTietDatVe.Columns.Add("Phòng", 60);
            lvwChiTietDatVe.Columns.Add("Ghế", 70);
            lvwChiTietDatVe.Columns.Add("Ngày đặt", 90);
            lvwChiTietDatVe.Columns.Add("Tổng tiền", 100);

            // Bộ lọc phim
            cbxPhim.Items.Clear();
            cbxPhim.Items.Add("Tất cả phim");
            cbxPhim.Items.Add("ĐÀO PHỞ VÀ PIANO");
            cbxPhim.Items.Add("MAI");
            cbxPhim.Items.Add("GẶP LẠI CHỊ BẦU");
            cbxPhim.Items.Add("TAROT");
            cbxPhim.SelectedIndex = 0;

            // Bộ lọc trạng thái
            cbxTrangThai.Items.Clear();
            cbxTrangThai.Items.Add("Tất cả trạng thái");
            cbxTrangThai.Items.Add("Đã đặt");
            cbxTrangThai.Items.Add("Đã hủy");
            cbxTrangThai.SelectedIndex = 0;

            // Bộ lọc từ ngày
            cbxTuNgay.Items.Clear();
            cbxTuNgay.Items.Add("Tất cả");

            // Bộ lọc đến ngày
            pnlDenNgay.Items.Clear();
            pnlDenNgay.Items.Add("Tất cả");

            cbxTuNgay.SelectedIndex = 0;
            pnlDenNgay.SelectedIndex = 0;

            // Giá trị thống kê ban đầu
            lblTongSoVe.Text = "TỔNG SỐ VÉ: 0";
            lblDoanhThu.Text = "DOANH THU: 0 VNĐ";
            lblTongLuotDat.Text = "TỔNG LƯỢT ĐẶT: 0";

            // Chưa có dữ liệu giao dịch được kết nối
            lvwChiTietDatVe.Items.Clear();
        }

        // Kết nối các sự kiện
        private void GanSuKien()
        {
            btnThongKe.Click += btnThongKe_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            XuatBaoCao.Click += XuatBaoCao_Click;
            btnQuayLai.Click += btnQuayLai_Click;
            btnThoat.Click += btnThoat_Click;
        }

        // Nút thống kê
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Giao diện thống kê đã sẵn sàng.\n" +
                "Cần kết nối dữ liệu đặt vé để tính doanh thu và hiển thị giao dịch.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Nút làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbxPhim.SelectedIndex = 0;
            cbxTrangThai.SelectedIndex = 0;
            cbxTuNgay.SelectedIndex = 0;
            pnlDenNgay.SelectedIndex = 0;

            lvwChiTietDatVe.Items.Clear();

            lblTongSoVe.Text = "TỔNG SỐ VÉ: 0";
            lblDoanhThu.Text = "DOANH THU: 0 VNĐ";
            lblTongLuotDat.Text = "TỔNG LƯỢT ĐẶT: 0";
        }

        // Nút xuất báo cáo
        private void XuatBaoCao_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Chức năng xuất báo cáo sẽ được triển khai sau khi kết nối dữ liệu đặt vé.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Nút quay lại
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Nút thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn đóng form thống kê?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}