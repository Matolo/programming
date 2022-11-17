namespace assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            string input = inputPrice.Text;

            double price = double.Parse(input);
            double vat = price * 0.21;
            double total = vat + price;

            priceResult.Text = price.ToString("0.00");
            vatResult.Text = vat.ToString("0.00");
            totalResult.Text = total.ToString("0.00");


        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}