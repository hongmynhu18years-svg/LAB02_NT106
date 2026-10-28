namespace LAB02_DACBIET
{
    partial class Lab02_Bai02
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
            components = new System.ComponentModel.Container();
            btnRead = new Button();
            lblFileName = new Label();
            lblSize = new Label();
            lblURL = new Label();
            lblLinecount = new Label();
            lblWordsCount = new Label();
            lblCharacterCount = new Label();
            tbxFileName = new MaskedTextBox();
            tbxSize = new MaskedTextBox();
            tbxURL = new MaskedTextBox();
            tbxLineCount = new MaskedTextBox();
            tbxWordsCount = new MaskedTextBox();
            tbxCharacterCount = new MaskedTextBox();
            btnExit = new Button();
            rtxNoiDung = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnThoat = new Button();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnRead.Location = new Point(12, 12);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(263, 28);
            btnRead.TabIndex = 0;
            btnRead.Text = "Read form file";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblFileName.Location = new Point(14, 60);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(60, 15);
            lblFileName.TabIndex = 1;
            lblFileName.Text = "File name";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSize.Location = new Point(14, 102);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(30, 15);
            lblSize.TabIndex = 2;
            lblSize.Text = "Size";
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblURL.Location = new Point(14, 144);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(30, 15);
            lblURL.TabIndex = 3;
            lblURL.Text = "URL";
            // 
            // lblLinecount
            // 
            lblLinecount.AutoSize = true;
            lblLinecount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLinecount.Location = new Point(14, 186);
            lblLinecount.Name = "lblLinecount";
            lblLinecount.Size = new Size(65, 15);
            lblLinecount.TabIndex = 4;
            lblLinecount.Text = "Line count";
            // 
            // lblWordsCount
            // 
            lblWordsCount.AutoSize = true;
            lblWordsCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWordsCount.Location = new Point(14, 228);
            lblWordsCount.Name = "lblWordsCount";
            lblWordsCount.Size = new Size(78, 15);
            lblWordsCount.TabIndex = 5;
            lblWordsCount.Text = "Words count";
            // 
            // lblCharacterCount
            // 
            lblCharacterCount.AutoSize = true;
            lblCharacterCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCharacterCount.Location = new Point(12, 270);
            lblCharacterCount.Name = "lblCharacterCount";
            lblCharacterCount.Size = new Size(96, 15);
            lblCharacterCount.TabIndex = 6;
            lblCharacterCount.Text = "Character count";
            // 
            // tbxFileName
            // 
            tbxFileName.Location = new Point(104, 60);
            tbxFileName.Name = "tbxFileName";
            tbxFileName.Size = new Size(171, 23);
            tbxFileName.TabIndex = 7;
            // 
            // tbxSize
            // 
            tbxSize.Location = new Point(104, 102);
            tbxSize.Name = "tbxSize";
            tbxSize.Size = new Size(171, 23);
            tbxSize.TabIndex = 8;
            // 
            // tbxURL
            // 
            tbxURL.Location = new Point(104, 144);
            tbxURL.Name = "tbxURL";
            tbxURL.Size = new Size(171, 23);
            tbxURL.TabIndex = 9;
            // 
            // tbxLineCount
            // 
            tbxLineCount.Location = new Point(104, 186);
            tbxLineCount.Name = "tbxLineCount";
            tbxLineCount.Size = new Size(171, 23);
            tbxLineCount.TabIndex = 10;
            // 
            // tbxWordsCount
            // 
            tbxWordsCount.Location = new Point(104, 228);
            tbxWordsCount.Name = "tbxWordsCount";
            tbxWordsCount.Size = new Size(171, 23);
            tbxWordsCount.TabIndex = 11;
            // 
            // tbxCharacterCount
            // 
            tbxCharacterCount.Location = new Point(104, 270);
            tbxCharacterCount.Name = "tbxCharacterCount";
            tbxCharacterCount.Size = new Size(171, 23);
            tbxCharacterCount.TabIndex = 12;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.GreenYellow;
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnExit.Location = new Point(12, 326);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(263, 28);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // rtxNoiDung
            // 
            rtxNoiDung.Location = new Point(290, 12);
            rtxNoiDung.Name = "rtxNoiDung";
            rtxNoiDung.Size = new Size(498, 303);
            rtxNoiDung.TabIndex = 14;
            rtxNoiDung.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnThoat
            // 
            btnThoat.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThoat.Location = new Point(694, 326);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 38);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += button8_Click;
            // 
            // Lab02_Bai02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__8_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 368);
            Controls.Add(btnThoat);
            Controls.Add(rtxNoiDung);
            Controls.Add(btnExit);
            Controls.Add(tbxCharacterCount);
            Controls.Add(tbxWordsCount);
            Controls.Add(tbxLineCount);
            Controls.Add(tbxURL);
            Controls.Add(tbxSize);
            Controls.Add(tbxFileName);
            Controls.Add(lblCharacterCount);
            Controls.Add(lblWordsCount);
            Controls.Add(lblLinecount);
            Controls.Add(lblURL);
            Controls.Add(lblSize);
            Controls.Add(lblFileName);
            Controls.Add(btnRead);
            Name = "Lab02_Bai02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab02_Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRead;
        private Label lblFileName;
        private Label lblSize;
        private Label lblURL;
        private Label lblLinecount;
        private Label lblWordsCount;
        private Label lblCharacterCount;
        private MaskedTextBox tbxFileName;
        private MaskedTextBox tbxSize;
        private MaskedTextBox tbxURL;
        private MaskedTextBox tbxLineCount;
        private MaskedTextBox tbxWordsCount;
        private MaskedTextBox tbxCharacterCount;
        private Button btnExit;
        private RichTextBox rtxNoiDung;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnThoat;
    }
}