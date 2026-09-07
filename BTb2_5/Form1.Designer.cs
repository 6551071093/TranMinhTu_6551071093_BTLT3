namespace BTb2_5
{
    partial class frmDinhDang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNhapTen = new Label();
            txtNhapten = new TextBox();
            grbColor = new GroupBox();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            grbFont = new GroupBox();
            chkUnderline = new CheckBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            lblLaptrinh1 = new Label();
            lblLapTrinh = new Label();
            btnThoat = new Button();
            grbColor.SuspendLayout();
            grbFont.SuspendLayout();
            SuspendLayout();
            // 
            // lblNhapTen
            // 
            lblNhapTen.AutoSize = true;
            lblNhapTen.BackColor = SystemColors.ActiveCaptionText;
            lblNhapTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNhapTen.ForeColor = Color.GreenYellow;
            lblNhapTen.Location = new Point(38, 37);
            lblNhapTen.Name = "lblNhapTen";
            lblNhapTen.Size = new Size(80, 20);
            lblNhapTen.TabIndex = 0;
            lblNhapTen.Text = "Nhập Tên:";
            // 
            // txtNhapten
            // 
            txtNhapten.Location = new Point(127, 35);
            txtNhapten.Name = "txtNhapten";
            txtNhapten.Size = new Size(380, 27);
            txtNhapten.TabIndex = 1;
            txtNhapten.TextChanged += txtNhapten_TextChanged;
            // 
            // grbColor
            // 
            grbColor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grbColor.BackColor = SystemColors.GradientActiveCaption;
            grbColor.Controls.Add(radBlack);
            grbColor.Controls.Add(radBlue);
            grbColor.Controls.Add(radGreen);
            grbColor.Controls.Add(radRed);
            grbColor.Location = new Point(38, 94);
            grbColor.Name = "grbColor";
            grbColor.Size = new Size(150, 176);
            grbColor.TabIndex = 2;
            grbColor.TabStop = false;
            grbColor.Text = "Color";
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlack.Location = new Point(22, 126);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(67, 24);
            radBlack.TabIndex = 3;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radBlack_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(22, 96);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(61, 24);
            radBlue.TabIndex = 2;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radBlue_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(22, 66);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(72, 24);
            radGreen.TabIndex = 1;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radGreen_CheckedChanged;
            // 
            // radRed
            // 
            radRed.AllowDrop = true;
            radRed.AutoSize = true;
            radRed.Checked = true;
            radRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(22, 36);
            radRed.Name = "radRed";
            radRed.Size = new Size(57, 24);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged;

            // 
            // grbFont
            // 
            grbFont.BackColor = Color.NavajoWhite;
            grbFont.Controls.Add(chkUnderline);
            grbFont.Controls.Add(chkItalic);
            grbFont.Controls.Add(chkBold);
            grbFont.Location = new Point(322, 94);
            grbFont.Name = "grbFont";
            grbFont.Size = new Size(185, 176);
            grbFont.TabIndex = 3;
            grbFont.TabStop = false;
            grbFont.Text = "Font";
            // 
            // chkUnderline
            // 
            chkUnderline.AutoSize = true;
            chkUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            chkUnderline.ForeColor = Color.Blue;
            chkUnderline.Location = new Point(29, 127);
            chkUnderline.Name = "chkUnderline";
            chkUnderline.Size = new Size(105, 24);
            chkUnderline.TabIndex = 2;
            chkUnderline.Text = "Gạch Chân";
            chkUnderline.UseVisualStyleBackColor = true;
            chkUnderline.CheckedChanged += chkUnderline_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            chkItalic.ForeColor = Color.Blue;
            chkItalic.Location = new Point(29, 84);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(133, 24);
            chkItalic.TabIndex = 1;
            chkItalic.Text = "Nghiêng Italic";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkBold.ForeColor = Color.Blue;
            chkBold.Location = new Point(29, 38);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(100, 24);
            chkBold.TabIndex = 0;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // lblLaptrinh1
            // 
            lblLaptrinh1.AutoSize = true;
            lblLaptrinh1.BackColor = SystemColors.Control;
            lblLaptrinh1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLaptrinh1.ForeColor = Color.SaddleBrown;
            lblLaptrinh1.Location = new Point(48, 329);
            lblLaptrinh1.Name = "lblLaptrinh1";
            lblLaptrinh1.Size = new Size(103, 20);
            lblLaptrinh1.TabIndex = 4;
            lblLaptrinh1.Text = "Lập trình Bởi:";
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.BorderStyle = BorderStyle.Fixed3D;
            lblLapTrinh.Location = new Point(157, 328);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(219, 42);
            lblLapTrinh.TabIndex = 5;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ActiveBorder;
            btnThoat.Location = new Point(382, 328);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(125, 54);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // frmDinhDang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(524, 405);
            Controls.Add(btnThoat);
            Controls.Add(lblLapTrinh);
            Controls.Add(lblLaptrinh1);
            Controls.Add(grbFont);
            Controls.Add(grbColor);
            Controls.Add(txtNhapten);
            Controls.Add(lblNhapTen);
            Name = "frmDinhDang";
            Text = "Định Dạng(Formater)";
            Load += frmDinhDang_Load;
            grbColor.ResumeLayout(false);
            grbColor.PerformLayout();
            grbFont.ResumeLayout(false);
            grbFont.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhapTen;
        private TextBox txtNhapten;
        private GroupBox grbColor;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private GroupBox grbFont;
        private Label lblLaptrinh1;
        private Label lblLapTrinh;
        private Button btnThoat;
        private CheckBox chkUnderline;
        private CheckBox chkItalic;
        private CheckBox chkBold;
    }
}
