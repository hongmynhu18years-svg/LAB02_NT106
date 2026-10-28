namespace LAB02_DACBIET
{
    partial class Lab02_Bai03
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
            rtxInputFile = new RichTextBox();
            rtxOutputFile = new RichTextBox();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // btnReadFile
            // 
            btnReadFile.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnReadFile.Location = new Point(12, 12);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(255, 40);
            btnReadFile.TabIndex = 0;
            btnReadFile.Text = "READ FILE";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSaveFile.Location = new Point(292, 12);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(255, 40);
            btnSaveFile.TabIndex = 1;
            btnSaveFile.Text = "SAVE FILE";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // rtxInputFile
            // 
            rtxInputFile.Location = new Point(12, 68);
            rtxInputFile.Name = "rtxInputFile";
            rtxInputFile.Size = new Size(255, 230);
            rtxInputFile.TabIndex = 2;
            rtxInputFile.Text = "";
            // 
            // rtxOutputFile
            // 
            rtxOutputFile.Location = new Point(292, 68);
            rtxOutputFile.Name = "rtxOutputFile";
            rtxOutputFile.Size = new Size(255, 230);
            rtxOutputFile.TabIndex = 3;
            rtxOutputFile.Text = "";
            // 
            // btnThoat
            // 
            btnThoat.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThoat.Location = new Point(454, 304);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 38);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Lab02_Bai03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__10_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(560, 354);
            Controls.Add(btnThoat);
            Controls.Add(rtxOutputFile);
            Controls.Add(rtxInputFile);
            Controls.Add(btnSaveFile);
            Controls.Add(btnReadFile);
            Name = "Lab02_Bai03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab02_Bai03";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReadFile;
        private Button btnSaveFile;
        private RichTextBox rtxInputFile;
        private RichTextBox rtxOutputFile;
        private Button btnThoat;
    }
}