namespace CleanFormDemo
{
    public static class SmartHelper
    {
        public static void Clean(Control cntr)
        {
            foreach (Control control in cntr.Controls)
            {
                if (control is TextBox || control is ComboBox)
                    control.Text = string.Empty;
                if (control is GroupBox)
                {
                    Clean(control);
                }
            }
        }
    }
}
