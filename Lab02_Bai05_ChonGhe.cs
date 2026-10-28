using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LAB02_DACBIET
{
    public partial class Lab02_Bai05_ChonGhe : Form
    {
        // Thông tin phim được truyền từ form trước.
        private Lab02_Bai5_Phim phim;

        // Lưu ghế đã mua theo từng phim và phòng chiếu.
        private static readonly Dictionary<string, HashSet<string>> GheDaMua
            = new Dictionary<string, HashSet<string>>();

        // Các ghế khách đang chọn.
        private HashSet<string> gheDangChon = new HashSet<string>();

        // Danh sách 15 nút ghế.
        private Button[] cacNutGhe;

        // Màu sắc trạng thái ghế.
        private readonly Color mauGheTrong = Color.Gainsboro;
        private readonly Color mauGheDangChon = Color.DodgerBlue;
        private readonly Color mauGheDaMua = Color.Tomato;

        // Constructor mặc định để Designer sử dụng.
        public Lab02_Bai05_ChonGhe()
        {
            InitializeComponent();
            KhoiTaoForm();
        }

        // Constructor nhận thông tin phim.
        public Lab02_Bai05_ChonGhe(Lab02_Bai5_Phim phimDuocChon)
        {
            InitializeComponent();

            phim = phimDuocChon;

            KhoiTaoForm();

            if (phim != null)
            {
                this.Text = "Chọn ghế - " + phim.TenPhim;

                // Hiển thị poster nếu PictureBox tồn tại.
                ptxPoster.Image = phim.Poster;
                ptxPoster.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        // Khởi tạo giao diện và sự kiện.
        private void KhoiTaoForm()
        {
            cacNutGhe = new Button[]
            {
                btnA1, btnA2, btnA3, btnA4, btnA5,
                btnB1, btnB2, btnB3, btnB4, btnB5,
                btnC1, btnC2, btnC3, btnC4, btnC5
            };

            cboPhongChieu.Items.Clear();
            cboPhongChieu.Items.Add("Phòng 1");
            cboPhongChieu.Items.Add("Phòng 2");
            cboPhongChieu.Items.Add("Phòng 3");
            cboPhongChieu.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (Button btn in cacNutGhe)
            {
                // Lưu mã ghế dựa trên Text ban đầu của nút.
                btn.Tag = btn.Text.Trim();

                btn.Click -= btnGhe_Click;
                btn.Click += btnGhe_Click;
            }

            cboPhongChieu.SelectedIndexChanged -=
                cboPhongChieu_SelectedIndexChanged;
            cboPhongChieu.SelectedIndexChanged +=
                cboPhongChieu_SelectedIndexChanged;

            // Chọn phòng đầu tiên.
            cboPhongChieu.SelectedIndex = 0;

            // Cập nhật màu và thông tin vé.
            CapNhatMauGhe();
            CapNhatThongTinVe();
        }

        // Tạo khóa lưu trạng thái ghế theo phim và phòng.
        private string LayKhoaPhong()
        {
            string tenPhim = phim?.TenPhim ?? "ChuaChonPhim";
            string tenPhong = cboPhongChieu.SelectedItem?.ToString() ?? "";

            return tenPhim + "|" + tenPhong;
        }

        // Lấy danh sách ghế đã mua.
        private HashSet<string> LayDanhSachGheDaMua()
        {
            string khoa = LayKhoaPhong();

            if (!GheDaMua.ContainsKey(khoa))
            {
                GheDaMua[khoa] = new HashSet<string>();
            }

            return GheDaMua[khoa];
        }

        // Xác định loại vé theo vị trí ghế.
        private string LayLoaiVe(string maGhe)
        {
            if (maGhe == "A1" || maGhe == "A5" ||
                maGhe == "C1" || maGhe == "C5")
            {
                return "Vé vớt";
            }

            if (maGhe == "B2" || maGhe == "B3" ||
                maGhe == "B4")
            {
                return "Vé VIP";
            }

            return "Vé thường";
        }

        // Tính giá vé theo giá chuẩn của phim.
        private decimal LayGiaVe(string maGhe)
        {
            if (phim == null)
                return 0m;

            switch (LayLoaiVe(maGhe))
            {
                case "Vé vớt":
                    return phim.GiaVe / 4m;

                case "Vé VIP":
                    return phim.GiaVe * 2m;

                default:
                    return phim.GiaVe;
            }
        }

        // Xử lý khi nhấn vào một ghế.
        private void btnGhe_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn == null || cboPhongChieu.SelectedItem == null)
                return;

            string maGhe = btn.Tag.ToString();

            if (LayDanhSachGheDaMua().Contains(maGhe))
            {
                MessageBox.Show(
                    "Ghế " + maGhe + " đã được mua!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Nếu ghế đã chọn thì bỏ chọn.
            if (gheDangChon.Contains(maGhe))
            {
                gheDangChon.Remove(maGhe);
            }
            else
            {
                // Giới hạn tối đa 2 ghế.
                if (gheDangChon.Count >= 2)
                {
                    MessageBox.Show(
                        "Bạn chỉ được chọn tối đa 2 ghế!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                gheDangChon.Add(maGhe);
            }

            CapNhatMauGhe();
            CapNhatThongTinVe();
        }

        // Cập nhật màu ghế theo trạng thái.
        private void CapNhatMauGhe()
        {
            if (cacNutGhe == null ||
                cboPhongChieu.SelectedItem == null)
            {
                return;
            }

            HashSet<string> daMua = LayDanhSachGheDaMua();

            foreach (Button btn in cacNutGhe)
            {
                string maGhe = btn.Tag.ToString();

                if (daMua.Contains(maGhe))
                {
                    btn.BackColor = mauGheDaMua;
                    btn.Enabled = false;
                }
                else if (gheDangChon.Contains(maGhe))
                {
                    btn.BackColor = mauGheDangChon;
                    btn.Enabled = true;
                }
                else
                {
                    btn.BackColor = mauGheTrong;
                    btn.Enabled = true;
                }

                btn.ForeColor = Color.Black;
            }
        }

        // Xử lý khi đổi phòng chiếu.
        private void cboPhongChieu_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            // Bỏ lựa chọn chưa xác nhận ở phòng cũ.
            gheDangChon.Clear();

            CapNhatMauGhe();
            CapNhatThongTinVe();
        }

        // Hiển thị loại vé và số lượng.
        private void CapNhatThongTinVe()
        {
            tbxSoLuong.Text = gheDangChon.Count.ToString();

            if (gheDangChon.Count == 0)
            {
                tbxLoaiVe.Clear();
                return;
            }

            var cacLoaiVe = gheDangChon
                .Select(LayLoaiVe)
                .Distinct();

            tbxLoaiVe.Text = string.Join(", ", cacLoaiVe);
        }

        // Nút xác nhận đặt vé.
        private void btnXacNhanDatVe_Click(object sender, EventArgs e)
        {
            if (phim == null)
            {
                MessageBox.Show(
                    "Chưa có thông tin phim. Vui lòng chọn phim trước!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (gheDangChon.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn ít nhất một ghế!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string tenPhong = cboPhongChieu.SelectedItem.ToString();

            decimal tongTien = gheDangChon.Sum(LayGiaVe);

            string danhSachGhe = string.Join(
                ", ",
                gheDangChon.OrderBy(g => g));

            DialogResult ketQua = MessageBox.Show(
                "Tên phim: " + phim.TenPhim + "\n" +
                "Phòng chiếu: " + tenPhong + "\n" +
                "Ghế đã chọn: " + danhSachGhe + "\n" +
                "Số lượng: " + gheDangChon.Count + "\n" +
                "Tổng tiền: " + tongTien.ToString("N0") + " VNĐ\n\n" +
                "Bạn có muốn xác nhận đặt vé không?",
                "Xác nhận đặt vé",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            HashSet<string> daMua = LayDanhSachGheDaMua();

            foreach (string maGhe in gheDangChon)
            {
                daMua.Add(maGhe);
            }

            MessageBox.Show(
                "Đặt vé thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            gheDangChon.Clear();

            CapNhatMauGhe();
            CapNhatThongTinVe();
        }

        // Nút quay lại.
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Nút thoát.
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}