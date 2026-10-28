namespace LAB02_DACBIET
{
    partial class Lab02_Bai01
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
            btnReadFile = new Button();
            btnSaveFile = new Button();
            rtbNoiDung = new RichTextBox();
            button8 = new Button();
            SuspendLayout();
            // 
            // btnReadFile
            // 
            btnReadFile.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnReadFile.Location = new Point(22, 51);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(185, 47);
            btnReadFile.TabIndex = 0;
            btnReadFile.Text = "READ FILE";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnDoc_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Cursor = Cursors.No;
            btnSaveFile.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSaveFile.Location = new Point(22, 143);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(185, 47);
            btnSaveFile.TabIndex = 1;
            btnSaveFile.Text = "SAVE FILE";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnGhi_Click;
            // 
            // rtbNoiDung
            // 
            rtbNoiDung.Location = new Point(213, 12);
            rtbNoiDung.Name = "rtbNoiDung";
            rtbNoiDung.Size = new Size(557, 220);
            rtbNoiDung.TabIndex = 2;
            rtbNoiDung.Text = "";
            // 
            // button8
            // 
            button8.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button8.Location = new Point(676, 238);
            button8.Name = "button8";
            button8.Size = new Size(94, 38);
            button8.TabIndex = 17;
            button8.Text = "Thoát";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Lab02_Bai01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Preppy_Sky;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(779, 281);
            Controls.Add(button8);
            Controls.Add(rtbNoiDung);
            Controls.Add(btnSaveFile);
            Controls.Add(btnReadFile);
            Name = "Lab02_Bai01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab02_Bai01";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReadFile;
        private Button btnSaveFile;
        private RichTextBox rtbNoiDung;
        private Button button8;
    }
}