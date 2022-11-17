using System.Diagnostics;

namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            string input = inpStKm.Text;
            double stKm = double.Parse(input);
            input = inpEndKm.Text;
            double endKm = double.Parse(input);
            input = inpPriceKm.Text;
            double priceKm = double.Parse(input);

            double kmDone = endKm - stKm;
            double price = kmDone * priceKm;

            double vat = price * 0.21;
            double total = price + vat;

            labPriceEVAT.Text = price.ToString("0.00");
            labVAT.Text = vat.ToString("0.00");
            labPriceIVAT.Text = total.ToString("0.00");


        }

        private void erase_Click(object sender, EventArgs e)
        {
            labPriceEVAT.Text = String.Empty;
            labVAT.Text = String.Empty;
            labPriceIVAT.Text = String.Empty;
            inpStKm.Text = String.Empty;
            inpEndKm.Text = String.Empty;
            inpPriceKm.Text = String.Empty;

        }
    }
}