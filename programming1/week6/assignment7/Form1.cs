using System.Globalization;

namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;   
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int degrees = int.Parse(inpDegrees.Text);

            if (rbtnCelsiusToKelvin.Checked)
                labResult.Text = $"{Celsius2Kelvin(degrees):0.00}";
            else if (rbtnCelsiusToFarenheit.Checked)
                labResult.Text = $"{Celsius2Farenheit(degrees):0.00}";
            else
                labResult.Text = $"{Farenheit2Celsius(degrees):0.00}";
        }
        double Celsius2Kelvin(int c)
        {
            return (double)c + 273;
        }
        double Celsius2Farenheit(int c)
        {
            return (double)c * 9 / 5 + 32;
        }
        double Farenheit2Celsius(int f)
        {
            return ((double)f - 32) * 5 / 9;
        }
    }
}