namespace EventLab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.OnAge += new Form1.MyDelegateAge(Frm_OnAge);
            frm.Show();
        }
        // 6- call the method and call the parameter
        private void Frm_OnAge(DateTime dates)
        {
            label1.Text = (DateTime.Now.Year - dates.Year).ToString();
        }
    }
}
