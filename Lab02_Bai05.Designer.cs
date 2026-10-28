namespace LAB02_DACBIET
{
    partial class Lab02_Bai05
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "ĐÀO PHỞ VÀ PIANO", "45.000đ", "1,2,3" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "MAI", "100.000đ", "2,3" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "GẶP LẠI CHỊ BẦU", "70.000đ", "1" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "TAROT", "90.000đ", "3" }, -1);
            lblCinema = new Label();
            btnDaoPhoVaPiano = new Button();
            btnMai = new Button();
            btnGapLaiChiBau = new Button();
            btnTarot = new Button();
            label1 = new Label();
            listView1 = new ListView();
            TenPhim = new ColumnHeader();
            GiaVeChuan = new ColumnHeader();
            PhongChieu = new ColumnHeader();
            btnThoat = new Button();
            btnXemThongKe = new Button();
            SuspendLayout();
            // 
            // lblCinema
            // 
            lblCinema.AutoSize = true;
            lblCinema.BackColor = Color.Wheat;
            lblCinema.BorderStyle = BorderStyle.FixedSingle;
            lblCinema.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCinema.ForeColor = SystemColors.InactiveCaptionText;
            lblCinema.Location = new Point(341, 77);
            lblCinema.Name = "lblCinema";
            lblCinema.Size = new Size(113, 28);
            lblCinema.TabIndex = 0;
            lblCinema.Text = "CINEMA";
            // 
            // btnDaoPhoVaPiano
            // 
            btnDaoPhoVaPiano.BackgroundImage = Properties.Resources.Peach_Blossom__Pho_and_Piano__2024_2;
            btnDaoPhoVaPiano.BackgroundImageLayout = ImageLayout.Stretch;
            btnDaoPhoVaPiano.Location = new Point(129, 168);
            btnDaoPhoVaPiano.Name = "btnDaoPhoVaPiano";
            btnDaoPhoVaPiano.Size = new Size(90, 167);
            btnDaoPhoVaPiano.TabIndex = 5;
            btnDaoPhoVaPiano.UseVisualStyleBackColor = true;
            btnDaoPhoVaPiano.Click += btnDaoPhoVaPiano_Click;
            // 
            // btnMai
            // 
            btnMai.BackgroundImage = Properties.Resources.Mai__2024__Phương_Anh_Đào__Tuấn_Trần;
            btnMai.BackgroundImageLayout = ImageLayout.Stretch;
            btnMai.Location = new Point(270, 168);
            btnMai.Name = "btnMai";
            btnMai.Size = new Size(96, 167);
            btnMai.TabIndex = 6;
            btnMai.UseVisualStyleBackColor = true;
            btnMai.Click += btnMai_Click;
            // 
            // btnGapLaiChiBau
            // 
            btnGapLaiChiBau.BackgroundImage = Properties.Resources.Teaser_Poster___GẶP_LẠI_CHỊ_BẦU;
            btnGapLaiChiBau.BackgroundImageLayout = ImageLayout.Stretch;
            btnGapLaiChiBau.Location = new Point(413, 168);
            btnGapLaiChiBau.Name = "btnGapLaiChiBau";
            btnGapLaiChiBau.Size = new Size(100, 167);
            btnGapLaiChiBau.TabIndex = 7;
            btnGapLaiChiBau.UseVisualStyleBackColor = true;
            btnGapLaiChiBau.Click += btnGapLaiChiBau_Click;
            // 
            // btnTarot
            // 
            btnTarot.BackgroundImage = Properties.Resources.Tarot;
            btnTarot.BackgroundImageLayout = ImageLayout.Stretch;
            btnTarot.Location = new Point(569, 168);
            btnTarot.Name = "btnTarot";
            btnTarot.Size = new Size(99, 167);
            btnTarot.TabIndex = 8;
            btnTarot.UseVisualStyleBackColor = true;
            btnTarot.Click += btnTarot_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowText;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(48, 470);
            label1.Name = "label1";
            label1.Size = new Size(225, 15);
            label1.TabIndex = 9;
            label1.Text = "Vui lòng click chọn phim bạn muốn xem!";
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ButtonShadow;
            listView1.Columns.AddRange(new ColumnHeader[] { TenPhim, GiaVeChuan, PhongChieu });
            listView1.Cursor = Cursors.WaitCursor;
            listView1.ForeColor = Color.Sienna;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            listView1.Location = new Point(26, 359);
            listView1.Name = "listView1";
            listView1.Size = new Size(305, 105);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // TenPhim
            // 
            TenPhim.Text = "Tên Phim";
            TenPhim.Width = 120;
            // 
            // GiaVeChuan
            // 
            GiaVeChuan.Text = "Giá vé chuẩn";
            GiaVeChuan.Width = 100;
            // 
            // PhongChieu
            // 
            PhongChieu.Text = "Phòng chiếu";
            PhongChieu.Width = 80;
            // 
            // btnThoat
            // 
            btnThoat.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThoat.Location = new Point(685, 456);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 38);
            btnThoat.TabIndex = 35;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXemThongKe
            // 
            btnXemThongKe.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnXemThongKe.FlatStyle = FlatStyle.Flat;
            btnXemThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnXemThongKe.Location = new Point(517, 456);
            btnXemThongKe.Name = "btnXemThongKe";
            btnXemThongKe.Size = new Size(146, 38);
            btnXemThongKe.TabIndex = 36;
            btnXemThongKe.Text = "Xem thống kê";
            btnXemThongKe.UseVisualStyleBackColor = true;
            btnXemThongKe.Click += btnXemThongKe_Click;
            // 
            // Lab02_Bai05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bốn_khung_áp_phích_rạp_chiếu_phim;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 506);
            Controls.Add(btnXemThongKe);
            Controls.Add(btnThoat);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(btnTarot);
            Controls.Add(btnGapLaiChiBau);
            Controls.Add(btnMai);
            Controls.Add(btnDaoPhoVaPiano);
            Controls.Add(lblCinema);
            Name = "Lab02_Bai05";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab02_Bai05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCinema;
        private Button btnDaoPhoVaPiano;
        private Button btnMai;
        private Button btnGapLaiChiBau;
        private Button btnTarot;
        private Label label1;
        private ListView listView1;
        private ColumnHeader TenPhim;
        private ColumnHeader GiaVeChuan;
        private ColumnHeader PhongChieu;
        private Button btnThoat;
        private Button btnXemThongKe;
    }
}