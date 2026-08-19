namespace form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFname_Click(object sender, EventArgs e)
        {
            String fname = txtFname.Text;
            String lname = txtLname.Text;
            String fullName = fname + " " + lname;
            txtFullname.Text = fullName;
            MessageBox.Show($"Full Name: {fullName}","Full Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
