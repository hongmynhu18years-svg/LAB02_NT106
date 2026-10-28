using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LAB02_DACBIET
{
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();

            // Không cho phép người dùng sửa thông tin thống kê
            tbxFileName.ReadOnly = true;
            tbxSize.ReadOnly = true;
            tbxURL.ReadOnly = true;
            tbxLineCount.ReadOnly = true;
            tbxWordsCount.ReadOnly = true;
            tbxCharacterCount.ReadOnly = true;

            // Chỉ đọc nội dung file, không cho chỉnh sửa
            rtxNoiDung.ReadOnly = true;
        }

        // Sự kiện nút Read from File
        private void btnRead_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Thiết lập hộp thoại chọn file
                ofd.Title = "Chọn file cần đọc";
                ofd.Filter =
                    "Text files (*.txt)|*.txt|" +
                    "All files (*.*)|*.*";

                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;
                ofd.Multiselect = false;

                // Nếu người dùng không chọn file thì kết thúc
                if (ofd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    // Lấy thông tin file
                    FileInfo fi = new FileInfo(ofd.FileName);

                    // Đọc toàn bộ nội dung bằng StreamReader
                    string noiDung;

                    using (StreamReader sr = new StreamReader(
                        ofd.FileName,
                        Encoding.UTF8,
                        true))
                    {
                        noiDung = sr.ReadToEnd();
                    }

                    // 1. Tên file
                    tbxFileName.Text = ofd.SafeFileName;

                    // 2. Kích thước file (byte)
                    tbxSize.Text = fi.Length + " bytes";

                    // 3. Đường dẫn đầy đủ của file
                    tbxURL.Text = fi.FullName;

                    // 4. Số dòng
                    int soDong = 0;

                    if (noiDung.Length > 0)
                    {
                        // Đếm số ký tự xuống dòng và cộng 1
                        soDong = Regex.Split(
                            noiDung,
                            @"\r\n|\n|\r"
                        ).Length;
                    }

                    tbxLineCount.Text = soDong.ToString();

                    // 5. Số từ
                    int soTu = Regex.Matches(
                        noiDung,
                        @"\S+"
                    ).Count;

                    tbxWordsCount.Text = soTu.ToString();

                    // 6. Số ký tự
                    // Tính cả dấu cách và ký tự xuống dòng
                    int soKyTu = noiDung.Length;

                    tbxCharacterCount.Text = soKyTu.ToString();

                    // 7. Hiển thị nội dung file
                    rtxNoiDung.Text = noiDung;

                    // Đưa con trỏ về đầu nội dung
                    rtxNoiDung.SelectionStart = 0;
                    rtxNoiDung.SelectionLength = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Không thể đọc file!\nChi tiết: " + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        // Sự kiện nút Exit
        private void btnExit_Click(object? sender, EventArgs e)
        {
            // Xóa thông tin file
            tbxFileName.Clear();
            tbxSize.Clear();
            tbxURL.Clear();
            tbxLineCount.Clear();
            tbxWordsCount.Clear();
            tbxCharacterCount.Clear();

            // Xóa nội dung file
            rtxNoiDung.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}