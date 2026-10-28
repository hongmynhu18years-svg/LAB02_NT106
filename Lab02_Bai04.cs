using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace LAB02_DACBIET
{
    public partial class Lab02_Bai04 : Form
    {
        private int soThuTuFile = 1;
        private string fileDangLuu = "";
        // Danh sách sinh viên
        private List<SinhVien> danhSach = new List<SinhVien>();

        // Vị trí sinh viên đang được hiển thị
        private int viTriHienTai = 0;

        // Đường dẫn file trong thư mục chạy chương trình
        private readonly string fileInput =
            Path.Combine(Application.StartupPath, "input4.txt");

        private readonly string fileOutput =
            Path.Combine(Application.StartupPath, "output4.txt");

        public Lab02_Bai04()
        {
            InitializeComponent();

        }

        // =====================================================
        // 1. NÚT ADD: THÊM SINH VIÊN VÀO DANH SÁCH
        // =====================================================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string hoTen = tbxName_write.Text.Trim();
            string mssv = tbxID_write.Text.Trim();
            string dienThoai = tbxPhone_write.Text.Trim();

            // Kiểm tra thông tin bắt buộc
            if (hoTen == "" || mssv == "" || dienThoai == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập họ tên, MSSV và số điện thoại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra điểm môn 1
            float diem1;
            if (!float.TryParse(tbxCourse_write.Text, out diem1)
                || diem1 < 0 || diem1 > 10)
            {
                MessageBox.Show("Điểm môn 1 phải nằm trong khoảng 0 đến 10!");
                tbxCourse_write.Focus();
                return;
            }

            // Kiểm tra điểm môn 2
            float diem2;
            if (!float.TryParse(tbxCourse2_write.Text, out diem2)
                || diem2 < 0 || diem2 > 10)
            {
                MessageBox.Show("Điểm môn 2 phải nằm trong khoảng 0 đến 10!");
                tbxCourse2_write.Focus();
                return;
            }

            // Kiểm tra điểm môn 3
            float diem3;
            if (!float.TryParse(tbxCourse3_write.Text, out diem3)
                || diem3 < 0 || diem3 > 10)
            {
                MessageBox.Show("Điểm môn 3 phải nằm trong khoảng 0 đến 10!");
                tbxCourse3_write.Focus();
                return;
            }

            // Tạo đối tượng sinh viên
            SinhVien sv = new SinhVien
            {
                HoTen = hoTen,
                MSSV = mssv,
                DienThoai = dienThoai,
                Diem1 = diem1,
                Diem2 = diem2,
                Diem3 = diem3
            };

            // Thêm sinh viên vào danh sách
            danhSach.Add(sv);

            // Hiển thị danh sách ở RichTextBox
            HienThiDanhSach();

            // Xóa dữ liệu các ô nhập để nhập sinh viên tiếp theo
            tbxName_write.Clear();
            tbxID_write.Clear();
            tbxPhone_write.Clear();
            tbxCourse_write.Clear();
            tbxCourse2_write.Clear();
            tbxCourse3_write.Clear();

            tbxName_write.Focus();

            MessageBox.Show(
                "Đã thêm sinh viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =====================================================
        // 2. HIỂN THỊ DANH SÁCH TRONG RICHTEXTBOX
        // =====================================================
        private void HienThiDanhSach()
        {
            richTextBox1.Clear();

            for (int i = 0; i < danhSach.Count; i++)
            {
                SinhVien sv = danhSach[i];

                richTextBox1.AppendText(
                    "Sinh viên thứ " + (i + 1) + Environment.NewLine +
                    "Họ và tên: " + sv.HoTen + Environment.NewLine +
                    "MSSV: " + sv.MSSV + Environment.NewLine +
                    "Điện thoại: " + sv.DienThoai + Environment.NewLine +
                    "Điểm môn 1: " + sv.Diem1 + Environment.NewLine +
                    "Điểm môn 2: " + sv.Diem2 + Environment.NewLine +
                    "Điểm môn 3: " + sv.Diem3 + Environment.NewLine +
                    "------------------------------" +
                    Environment.NewLine);
            }
        }

        // =====================================================
        // 3. NÚT WRITE TO A FILE: GHI INPUT4.TXT
        // =====================================================
        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (danhSach.Count == 0)
            {
                MessageBox.Show("Danh sách chưa có sinh viên!");
                return;
            }

            try
            {
                // Tạo tên file theo số thứ tự
                string tenFile = $"output_{soThuTuFile}.txt";

                // Đường dẫn lưu file
                string duongDan = Path.Combine(
                    Application.StartupPath,
                    tenFile
                );

                fileDangLuu = duongDan;
                soThuTuFile++;

                // Chuyển danh sách sinh viên thành JSON
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string json = JsonSerializer.Serialize(danhSach, options);

                // Ghi dữ liệu vào file
                File.WriteAllText(duongDan, json);

                MessageBox.Show(
                    $"Đã lưu thông tin thành công!\nTên file: {tenFile}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Chỉ tăng số thứ tự sau khi lưu thành công
                soThuTuFile++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi ghi file: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // 4. NÚT READ A FILE: ĐỌC INPUT4.TXT
        // =====================================================
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(fileDangLuu) ||
                    !File.Exists(fileDangLuu))
                {
                    MessageBox.Show(
                        "Bạn chưa lưu dữ liệu hoặc file không tồn tại!\n" +
                        "Vui lòng nhấn Write to a file trước.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                string json = File.ReadAllText(fileDangLuu);

                danhSach = JsonSerializer.Deserialize<List<SinhVien>>(json)
                           ?? new List<SinhVien>();

                if (danhSach.Count == 0)
                {
                    MessageBox.Show("File không có sinh viên!");
                    return;
                }

                foreach (SinhVien sv in danhSach)
                {
                    sv.TinhDiemTrungBinh();
                }

                GhiFileOutput();

                viTriHienTai = 0;

                HienThiSinhVienHienTai();
                HienThiDanhSach();

                MessageBox.Show(
                    "Đọc file thành công!\n" +
                    "File: " + Path.GetFileName(fileDangLuu)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file: " + ex.Message);
            }
        }

        // =====================================================
        // 5. TÍNH ĐIỂM TRUNG BÌNH VÀ GHI OUTPUT4.TXT
        // =====================================================
        private void GhiFileOutput()
        {
            using (StreamWriter sw = new StreamWriter(
                fileOutput, false, Encoding.UTF8))
            {
                sw.WriteLine("DANH SACH SINH VIEN");
                sw.WriteLine("==============================");

                for (int i = 0; i < danhSach.Count; i++)
                {
                    SinhVien sv = danhSach[i];

                    sw.WriteLine("Sinh viên thứ " + (i + 1));
                    sw.WriteLine("Họ và tên: " + sv.HoTen);
                    sw.WriteLine("MSSV: " + sv.MSSV);
                    sw.WriteLine("Điện thoại: " + sv.DienThoai);
                    sw.WriteLine("Điểm môn 1: " + sv.Diem1);
                    sw.WriteLine("Điểm môn 2: " + sv.Diem2);
                    sw.WriteLine("Điểm môn 3: " + sv.Diem3);
                    sw.WriteLine(
                        "Điểm trung bình: " +
                        sv.DiemTrungBinh.ToString("F2"));

                    sw.WriteLine("------------------------------");
                }
            }
        }

        // =====================================================
        // 6. HIỂN THỊ THÔNG TIN SINH VIÊN BÊN PHẢI
        // =====================================================
        private void HienThiSinhVienHienTai()
        {
            if (danhSach.Count == 0)
            {
                XoaThongTinBenPhai();
                return;
            }

            SinhVien sv = danhSach[viTriHienTai];

            textBox8.Text = sv.HoTen;
            textBox13.Text = sv.MSSV;
            textBox12.Text = sv.DienThoai;
            textBox11.Text = sv.Diem1.ToString();
            textBox10.Text = sv.Diem2.ToString();
            textBox9.Text = sv.Diem3.ToString();
            textBox14.Text = sv.DiemTrungBinh.ToString("F2");

            // Hiển thị vị trí hiện tại trên tiêu đề Form
            this.Text = "Lab02_Bai04 - Sinh viên "
                + (viTriHienTai + 1) + "/" + danhSach.Count;

            // Bật/tắt nút theo vị trí
            btnBack.Enabled = viTriHienTai > 0;
            btnNext.Enabled = viTriHienTai < danhSach.Count - 1;
        }

        // =====================================================
        // 7. NÚT NEXT: SINH VIÊN TIẾP THEO
        // =====================================================
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (viTriHienTai < danhSach.Count - 1)
            {
                viTriHienTai++;
                HienThiSinhVienHienTai();
            }
        }

        // =====================================================
        // 8. NÚT BACK: SINH VIÊN TRƯỚC ĐÓ
        // =====================================================
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (viTriHienTai > 0)
            {
                viTriHienTai--;
                HienThiSinhVienHienTai();
            }
        }

        // =====================================================
        // 9. XÓA CÁC Ô HIỂN THỊ BÊN PHẢI
        // =====================================================
        private void XoaThongTinBenPhai()
        {
            textBox8.Clear();
            textBox13.Clear();
            textBox12.Clear();
            textBox11.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox14.Clear();

            btnBack.Enabled = false;
            btnNext.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // =========================================================
    // LỚP SINH VIÊN
    // =========================================================
    [Serializable]
    public class SinhVien
    {
        public string HoTen { get; set; }
        public string MSSV { get; set; }
        public string DienThoai { get; set; }

        public float Diem1 { get; set; }
        public float Diem2 { get; set; }
        public float Diem3 { get; set; }

        public float DiemTrungBinh { get; set; }

        public void TinhDiemTrungBinh()
        {
            DiemTrungBinh = (Diem1 + Diem2 + Diem3) / 3.0f;
        }
    }
}