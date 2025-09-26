namespace EventLab
{

    public partial class Form1 : Form
    {
        public delegate void MyDelegateAge(DateTime datetime);
        public event MyDelegateAge OnAge;

        public Form1()
        {
            InitializeComponent();
            //this.dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
        }

        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{

        //}

        //private void DateTimePicker1_ValueChanged(object? sender, EventArgs e)
        //{
        //    label1.Text = dateTimePicker1.Value.ToString();
        //}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            OnAge(dateTimePicker1.Value);
        }


    }
}
