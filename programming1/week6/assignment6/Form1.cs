using System.Globalization;

namespace assignment6
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

        private void squareByRef_Click(object sender, EventArgs e)
        {
            int input = int.Parse(inpNumber.Text);
            SquareByReference(ref input);
            labResult.Text = input.ToString();
        }

        private void squareByRefOut_Click(object sender, EventArgs e)
        {
            int input = int.Parse(inpNumber.Text);
            int result;
            SquareByReferenceOut(input, out result);
            labResult.Text = result.ToString();

        }

        private void squareByValue_Click(object sender, EventArgs e)
        {
            int input = int.Parse(inpNumber.Text);
            labResult.Text = SquareByValue(input).ToString();

        }

        void SquareByReference (ref int number)
        {
            number *= number;
        }
        void SquareByReferenceOut(int number, out int square)
        {
            square = number*number;
        }
        int SquareByValue(int number)
        {
            return number * number;
        }
    }
}