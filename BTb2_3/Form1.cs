namespace BTb2_3
{
    public partial class frmBaitapHoTen : Form
    {
        public frmBaitapHoTen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + ' ' + txtTen.Text;
        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = "";
        }

        private void btnThoatChuongTrinh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
