namespace TestApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = "";
            txtNhapPassword.Clear();
            txtHienThi.Clear();
            txtNhapPassword.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtNhapPassword.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmQuanLyBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Có chắc bạn muốn đóng ứng dụng?", "Thông báo!",

            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button1);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }

        
    }
}
