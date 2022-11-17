namespace assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            calculate.Image = Properties.Resources.calcIcon;
            calculate.ImageAlign = ContentAlignment.MiddleLeft;
        }


        private void calculate_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            labDate.Text = time.ToString("HH:mm:ss dd/MM/yy");

            string input = inpNumOfTsh.Text;
            double numTsh = double.Parse(input);
            input = inpNumOfJea.Text;
            double numJea = double.Parse(input);

            double price = (numTsh*30) + (numJea*100);
            double vat = price * 0.21;
            double totPrice = price + vat;

            labPrice.Text = price.ToString($"€ 0.00");
            labVAT.Text = vat.ToString($"€ 0.00");
            labTotPrice.Text = totPrice.ToString($"€ 0.00");


        }

    }
}