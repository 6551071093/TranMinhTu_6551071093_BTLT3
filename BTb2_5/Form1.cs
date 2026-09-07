namespace BTb2_5
{
    public partial class frmDinhDang : Form
    {
        public frmDinhDang()
        {
            InitializeComponent();
        }

        private void frmDinhDang_Load(object sender, EventArgs e)
        {
            txtNhapten.Focus();
            radRed.Checked = true;

        }

        private void txtNhapten_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapten.Text;

        }

      
        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Green;
            txtNhapten.ForeColor = Color.Green;
        }
        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Blue;
            txtNhapten.ForeColor = Color.Blue;
        }
        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Black;
            txtNhapten.ForeColor = Color.Black;
        }
        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name,
            lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Bold);

        }
        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name,
            lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Italic);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name,
           lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Underline);
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Red;
            txtNhapten.ForeColor = Color.Red;
        }
    }
}
