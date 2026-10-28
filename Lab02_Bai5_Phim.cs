using System.Drawing;

namespace LAB02_DACBIET
{
    public class Lab02_Bai5_Phim // <--- Sửa thành public ở đây
    {
        public string TenPhim { get; set; }
        public decimal GiaVe { get; set; }
        public Image Poster { get; set; }

        public Lab02_Bai5_Phim(string tenPhim, decimal giaVe, Image poster)
        {
            TenPhim = tenPhim;
            GiaVe = giaVe;
            Poster = poster;
        }
    }
}