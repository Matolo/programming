using System.Globalization;

namespace assignment5
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
        private void plus_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(inpNum1.Text);
            int number2 = int.Parse(inpNum2.Text);
            labResult.Text = AddedUp(number1, number2).ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(inpNum1.Text);
            int number2 = int.Parse(inpNum2.Text);
            labResult.Text = Subtracted(number1, number2).ToString();

        }

        private void multiply_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(inpNum1.Text);
            int number2 = int.Parse(inpNum2.Text);
            labResult.Text = Multiplied(number1, number2).ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(inpNum1.Text);
            int number2 = int.Parse(inpNum2.Text);
            labResult.Text = $"{Divided(number1, number2):0.000}";
        }
        int AddedUp(int num1, int num2)
        {
            return num1 + num2;
        }
        int Subtracted(int num1, int num2)
        {
            return num1 - num2;
        }
        int Multiplied(int num1, int num2)
        {
            return num1 * num2;
        }
        double Divided(int num1, int num2)
        {
            return (double)num1 / (double)num2;
        }
    }
}