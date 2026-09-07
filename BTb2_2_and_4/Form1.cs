namespace BTb2_2
{
    public partial class Winform1 : Form
    {
        public Winform1()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked.");
        }
        // sự kiện khi load form
        private void frmSimpleEvent_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi , Welcome to C# 2010 programming!");
        }

        // sự kiện khi form được Click
        private void frmSimpleEvent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form was clicked.");
        }

    }
}
