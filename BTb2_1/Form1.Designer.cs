namespace TestApp1
{
    partial class Form1
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
            lblNhapPassword = new Label();
            lblHienThi = new Label();
            btnHienThi = new Button();
            btnDong = new Button();
            txtNhapPassword = new TextBox();
            txtHienThi = new TextBox();
            btnTiep = new Button();
            SuspendLayout();
            // 
            // lblNhapPassword
            // 
            lblNhapPassword.AutoSize = true;
            lblNhapPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNhapPassword.Location = new Point(120, 80);
            lblNhapPassword.Name = "lblNhapPassword";
            lblNhapPassword.Size = new Size(122, 20);
            lblNhapPassword.TabIndex = 0;
            lblNhapPassword.Text = "Nhập Password:";
            lblNhapPassword.Click += label1_Click;
            // 
            // lblHienThi
            // 
            lblHienThi.AutoSize = true;
            lblHienThi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHienThi.Location = new Point(120, 160);
            lblHienThi.Name = "lblHienThi";
            lblHienThi.Size = new Size(68, 20);
            lblHienThi.TabIndex = 1;
            lblHienThi.Text = "Hiển thị:";
            // 
            // btnHienThi
            // 
            btnHienThi.AccessibleName = "btnHienThi";
            btnHienThi.BackColor = SystemColors.ControlLight;
            btnHienThi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHienThi.Location = new Point(120, 237);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(94, 29);
            btnHienThi.TabIndex = 2;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = false;
            btnHienThi.Click += button1_Click;
            // 
            // btnDong
            // 
            btnDong.AccessibleName = "btnDong";
            btnDong.BackColor = SystemColors.ButtonFace;
            btnDong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDong.Location = new Point(476, 237);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 4;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += button3_Click;
            // 
            // txtNhapPassword
            // 
            txtNhapPassword.AccessibleName = "txtNhapPassword";
            txtNhapPassword.Location = new Point(277, 80);
            txtNhapPassword.Name = "txtNhapPassword";
            txtNhapPassword.PasswordChar = '*';
            txtNhapPassword.Size = new Size(293, 27);
            txtNhapPassword.TabIndex = 5;
            txtNhapPassword.UseSystemPasswordChar = true;
            // 
            // txtHienThi
            // 
            txtHienThi.AccessibleName = "txtHienThi";
            txtHienThi.Location = new Point(277, 153);
            txtHienThi.Name = "txtHienThi";
            txtHienThi.Size = new Size(293, 27);
            txtHienThi.TabIndex = 6;
            // 
            // btnTiep
            // 
            btnTiep.AccessibleName = "btnTiep";
            btnTiep.BackColor = SystemColors.ControlLight;
            btnTiep.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTiep.Location = new Point(287, 237);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(94, 29);
            btnTiep.TabIndex = 7;
            btnTiep.Text = "Tiếp";
            btnTiep.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 337);
            Controls.Add(btnTiep);
            Controls.Add(txtHienThi);
            Controls.Add(txtNhapPassword);
            Controls.Add(btnDong);
            Controls.Add(btnHienThi);
            Controls.Add(lblHienThi);
            Controls.Add(lblNhapPassword);
            Name = "Form1";
            Text = "Sử dụng label và textbox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhapPassword;
        private Label lblHienThi;
        private Button btnHienThi;
        private Button btnDong;
        private TextBox txtNhapPassword;
        private TextBox txtHienThi;
        private Button btnTiep;
    }
}
