namespace LAB02_DACBIET
{
    partial class Lab02_Bai05_ThongTinKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTenKhachHang = new Label();
            tbxHoVaTen = new TextBox();
            lblSoDienThoai = new Label();
            tbxSoDienThoai = new TextBox();
            btnChonGhe = new Button();
            lblEmail = new Label();
            tbxEmail = new TextBox();
            btnQuayLai = new Button();
            pnlThongTinKhachHang = new Panel();
            lblThongTinKhachHang = new Label();
            pnlThongTinPhim = new Panel();
            ptxPosterPhim = new PictureBox();
            tbxThongTinGiaVe = new TextBox();
            tbxTenPhim = new TextBox();
            lblThongTinGiaVe = new Label();
            lblTenPhim = new Label();
            btnThoat = new Button();
            pnlThongTinKhachHang.SuspendLayout();
            pnlThongTinPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptxPosterPhim).BeginInit();
            SuspendLayout();
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.BackColor = Color.Transparent;
            lblTenKhachHang.ForeColor = SystemColors.ControlLightLight;
            lblTenKhachHang.Location = new Point(3, 154);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(58, 15);
            lblTenKhachHang.TabIndex = 0;
            lblTenKhachHang.Text = "Họ và tên";
            // 
            // tbxHoVaTen
            // 
            tbxHoVaTen.BackColor = SystemColors.ActiveBorder;
            tbxHoVaTen.Location = new Point(22, 172);
            tbxHoVaTen.Multiline = true;
            tbxHoVaTen.Name = "tbxHoVaTen";
            tbxHoVaTen.Size = new Size(242, 23);
            tbxHoVaTen.TabIndex = 1;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.BackColor = Color.Transparent;
            lblSoDienThoai.ForeColor = SystemColors.ControlLightLight;
            lblSoDienThoai.Location = new Point(6, 208);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(28, 15);
            lblSoDienThoai.TabIndex = 3;
            lblSoDienThoai.Text = "SĐT";
            // 
            // tbxSoDienThoai
            // 
            tbxSoDienThoai.BackColor = SystemColors.ActiveBorder;
            tbxSoDienThoai.Location = new Point(22, 226);
            tbxSoDienThoai.Multiline = true;
            tbxSoDienThoai.Name = "tbxSoDienThoai";
            tbxSoDienThoai.Size = new Size(242, 26);
            tbxSoDienThoai.TabIndex = 4;
            // 
            // btnChonGhe
            // 
            btnChonGhe.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnChonGhe.BackColor = Color.Beige;
            btnChonGhe.Location = new Point(203, 399);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(75, 23);
            btnChonGhe.TabIndex = 3;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = false;
            btnChonGhe.Click += btnChonGhe_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.ForeColor = SystemColors.ControlLightLight;
            lblEmail.Location = new Point(3, 282);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = SystemColors.ActiveBorder;
            tbxEmail.Location = new Point(22, 300);
            tbxEmail.Multiline = true;
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(242, 23);
            tbxEmail.TabIndex = 6;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Anchor = AnchorStyles.Right;
            btnQuayLai.BackColor = Color.Beige;
            btnQuayLai.Location = new Point(6, 399);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(75, 23);
            btnQuayLai.TabIndex = 7;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // pnlThongTinKhachHang
            // 
            pnlThongTinKhachHang.BackgroundImage = Properties.Resources.Screenshot_2026_10_26_205018;
            pnlThongTinKhachHang.BackgroundImageLayout = ImageLayout.Stretch;
            pnlThongTinKhachHang.Controls.Add(lblThongTinKhachHang);
            pnlThongTinKhachHang.Controls.Add(btnQuayLai);
            pnlThongTinKhachHang.Controls.Add(tbxEmail);
            pnlThongTinKhachHang.Controls.Add(btnChonGhe);
            pnlThongTinKhachHang.Controls.Add(lblEmail);
            pnlThongTinKhachHang.Controls.Add(tbxSoDienThoai);
            pnlThongTinKhachHang.Controls.Add(lblSoDienThoai);
            pnlThongTinKhachHang.Controls.Add(tbxHoVaTen);
            pnlThongTinKhachHang.Controls.Add(lblTenKhachHang);
            pnlThongTinKhachHang.Location = new Point(424, 54);
            pnlThongTinKhachHang.Name = "pnlThongTinKhachHang";
            pnlThongTinKhachHang.Size = new Size(294, 429);
            pnlThongTinKhachHang.TabIndex = 3;
            // 
            // lblThongTinKhachHang
            // 
            lblThongTinKhachHang.AutoSize = true;
            lblThongTinKhachHang.BackColor = Color.Chocolate;
            lblThongTinKhachHang.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblThongTinKhachHang.Location = new Point(35, 112);
            lblThongTinKhachHang.Name = "lblThongTinKhachHang";
            lblThongTinKhachHang.Size = new Size(216, 19);
            lblThongTinKhachHang.TabIndex = 8;
            lblThongTinKhachHang.Text = "THÔNG TIN KHÁCH HÀNG ";
            // 
            // pnlThongTinPhim
            // 
            pnlThongTinPhim.BackgroundImage = Properties.Resources.Screenshot_2026_10_26_204915;
            pnlThongTinPhim.BackgroundImageLayout = ImageLayout.Stretch;
            pnlThongTinPhim.Controls.Add(ptxPosterPhim);
            pnlThongTinPhim.Controls.Add(tbxThongTinGiaVe);
            pnlThongTinPhim.Controls.Add(tbxTenPhim);
            pnlThongTinPhim.Controls.Add(lblThongTinGiaVe);
            pnlThongTinPhim.Controls.Add(lblTenPhim);
            pnlThongTinPhim.Location = new Point(41, 54);
            pnlThongTinPhim.Name = "pnlThongTinPhim";
            pnlThongTinPhim.Size = new Size(377, 429);
            pnlThongTinPhim.TabIndex = 5;
            // 
            // ptxPosterPhim
            // 
            ptxPosterPhim.BackColor = Color.BlanchedAlmond;
            ptxPosterPhim.Location = new Point(15, 16);
            ptxPosterPhim.Name = "ptxPosterPhim";
            ptxPosterPhim.Size = new Size(345, 245);
            ptxPosterPhim.TabIndex = 10;
            ptxPosterPhim.TabStop = false;
            // 
            // tbxThongTinGiaVe
            // 
            tbxThongTinGiaVe.BackColor = SystemColors.Info;
            tbxThongTinGiaVe.Location = new Point(73, 359);
            tbxThongTinGiaVe.Multiline = true;
            tbxThongTinGiaVe.Name = "tbxThongTinGiaVe";
            tbxThongTinGiaVe.Size = new Size(287, 63);
            tbxThongTinGiaVe.TabIndex = 9;
            // 
            // tbxTenPhim
            // 
            tbxTenPhim.BackColor = SystemColors.Info;
            tbxTenPhim.Location = new Point(73, 300);
            tbxTenPhim.Multiline = true;
            tbxTenPhim.Name = "tbxTenPhim";
            tbxTenPhim.Size = new Size(287, 23);
            tbxTenPhim.TabIndex = 8;
            // 
            // lblThongTinGiaVe
            // 
            lblThongTinGiaVe.AutoSize = true;
            lblThongTinGiaVe.BackColor = Color.Transparent;
            lblThongTinGiaVe.ForeColor = SystemColors.ControlLightLight;
            lblThongTinGiaVe.Location = new Point(15, 341);
            lblThongTinGiaVe.Name = "lblThongTinGiaVe";
            lblThongTinGiaVe.Size = new Size(93, 15);
            lblThongTinGiaVe.TabIndex = 7;
            lblThongTinGiaVe.Text = "Thông tin giá vé";
            // 
            // lblTenPhim
            // 
            lblTenPhim.AutoSize = true;
            lblTenPhim.BackColor = Color.Transparent;
            lblTenPhim.ForeColor = SystemColors.ControlLightLight;
            lblTenPhim.Location = new Point(15, 282);
            lblTenPhim.Name = "lblTenPhim";
            lblTenPhim.Size = new Size(57, 15);
            lblTenPhim.TabIndex = 6;
            lblTenPhim.Text = "Tên phim";
            // 
            // btnThoat
            // 
            btnThoat.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThoat.Location = new Point(660, 497);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 38);
            btnThoat.TabIndex = 36;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Lab02_Bai05_ThongTinKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_s7rkejs7rkejs7rk;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(766, 547);
            Controls.Add(btnThoat);
            Controls.Add(pnlThongTinPhim);
            Controls.Add(pnlThongTinKhachHang);
            DoubleBuffered = true;
            Name = "Lab02_Bai05_ThongTinKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab02_Bai05_ThongTinKhachHang";
            pnlThongTinKhachHang.ResumeLayout(false);
            pnlThongTinKhachHang.PerformLayout();
            pnlThongTinPhim.ResumeLayout(false);
            pnlThongTinPhim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptxPosterPhim).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTenKhachHang;
        private TextBox tbxHoVaTen;
        private Label lblSoDienThoai;
        private TextBox tbxSoDienThoai;
        private Label lblEmail;
        private TextBox tbxEmail;
        private Button btnChonGhe;
        private Button btnQuayLai;
        private Panel pnlThongTinKhachHang;
        private Label lblTenPhim;
        private Label lblThongTinKhachHang;
        private PictureBox ptxPosterPhim;
        private Panel pnlThongTinPhim;
        private Label lblThongTinGiaVe;
        private TextBox tbxTenPhim;
        private TextBox tbxThongTinGiaVe;
        private Button btnThoat;
    }
}