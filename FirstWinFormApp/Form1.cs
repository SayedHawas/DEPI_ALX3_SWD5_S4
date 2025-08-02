namespace FirstWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "sayed" && txtPassword.Text.Trim() == "123")
            {
                //Open Form
                MainFrm frm = new MainFrm();
                frm.Show();
            }
            else
            {
                MessageBox.Show("UserName Of Password InValid ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Text = string.Empty;
                txtPassword.Clear();
                txtUserName.Focus();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
