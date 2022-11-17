namespace assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            string input = firstNum.Text;
            double firNum = double.Parse(input);
            input = secondNum.Text;
            double secNum = double.Parse(input);
            input = thirdNum.Text;
            double thrNum = double.Parse(input);

            double avg = (firNum + secNum + thrNum) / 3;
            avgNum.Text = avg.ToString("0.000");
           
        }

    }
}