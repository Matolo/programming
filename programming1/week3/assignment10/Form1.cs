namespace assignment10
{
    public partial class Form1 : Form
    {
        const int basicPrice = 12;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int age = int.Parse(inpAge.Text);
            int price = basicPrice;

            switch(age)
            {
                case < 5 or >= 55:
                    price = 0;
                    break;
                case >= 5 and <=12:
                    price /= 2;
                    break;
                default:
                    break;
            }

            labPrice.Text = price.ToString("€ 0.00");

        }
    }
}