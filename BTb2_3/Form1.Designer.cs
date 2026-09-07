namespace BTb2_3
{
    partial class frmBaitapHoTen
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
            lblHoLot = new Label();
            lblTen = new Label();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnThoatChuongTrinh = new Button();
            txtHo = new TextBox();
            txtTen = new TextBox();
            lblHoTen = new Label();
            SuspendLayout();
            // 
            // lblHoLot
            // 
            lblHoLot.AutoSize = true;
            lblHoLot.Location = new Point(42, 116);
            lblHoLot.Name = "lblHoLot";
            lblHoLot.Size = new Size(51, 20);
            lblHoLot.TabIndex = 0;
            lblHoLot.Text = "Họ lót";

            // 
            // lblTen
            // 
            lblTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTen.AutoSize = true;
            lblTen.Location = new Point(42, 189);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(32, 20);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên";

            // 
            // btnHo
            // 
            btnHo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnHo.Location = new Point(42, 248);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(119, 39);
            btnHo.TabIndex = 2;
            btnHo.Text = "Họ Lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnTen.Location = new Point(234, 248);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(119, 39);
            btnTen.TabIndex = 3;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnHoTen.Location = new Point(393, 248);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(119, 39);
            btnHoTen.TabIndex = 4;
            btnHoTen.Text = "Họ và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnThoatChuongTrinh
            // 
            btnThoatChuongTrinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnThoatChuongTrinh.Location = new Point(208, 355);
            btnThoatChuongTrinh.Name = "btnThoatChuongTrinh";
            btnThoatChuongTrinh.Size = new Size(163, 39);
            btnThoatChuongTrinh.TabIndex = 5;
            btnThoatChuongTrinh.Text = "Thoát Chương trình";
            btnThoatChuongTrinh.UseVisualStyleBackColor = true;
            btnThoatChuongTrinh.Click += btnThoatChuongTrinh_Click;
            // 
            // txtHo
            // 
            txtHo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHo.Location = new Point(152, 116);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(360, 27);
            txtHo.TabIndex = 6;
            txtHo.TextChanged += txtHo_TextChanged;
            // 
            // txtTen
            // 
            txtTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTen.BackColor = Color.LightCoral;
            txtTen.Location = new Point(152, 182);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(360, 27);
            txtTen.TabIndex = 7;

            // 
            // lblHoTen
            // 
            lblHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblHoTen.BackColor = Color.DodgerBlue;
            lblHoTen.Location = new Point(2, -1);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(582, 88);
            lblHoTen.TabIndex = 8;
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            lblHoTen.Click += lblHoTen_Click;
            // 
            // frmBaitapHoTen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 416);
            Controls.Add(lblHoTen);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(btnThoatChuongTrinh);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(lblTen);
            Controls.Add(lblHoLot);
            Name = "frmBaitapHoTen";
            Text = "Bài Tập Họ Tên";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoLot;
        private Label lblTen;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnThoatChuongTrinh;
        private TextBox txtHo;
        private TextBox txtTen;
        private Label lblHoTen;
    }
}
