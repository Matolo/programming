namespace assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double initialCapital = double.Parse(inputCapital.Text);

            for (int i = 0; i<5; i++)
            {
                initialCapital *= 1.05;
            }

            labFinalCap.Text = initialCapital.ToString("€ 0.00");
        }
    }
}