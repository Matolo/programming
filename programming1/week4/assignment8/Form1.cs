namespace assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void compare_Click(object sender, EventArgs e)
        {
            int input = int.Parse(inpNumber.Text);
            int sum = 0;
            

            for (int i = 0; i <= input; i++)
            {
                sum += i;
            }

            double multiple = (double)input * ((double)input + 1.0) / 2.0;
            labSum.Text = sum.ToString();
            labMult.Text = multiple.ToString();

            if (sum == multiple)
            {
                labEquality.Text = "The sum and formula are equal.";
            }
            else
            {
                labEquality.Text = "The sum and formula are not equal.";

            }
        }
    }
}