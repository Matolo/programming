namespace assignment9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void calculate_Click(object sender, EventArgs e)
        {

            int age = int.Parse(inpAge.Text);
            int memDuration = int.Parse(inpMemDur.Text);
            int memFee;

            if (rBtnFootball.Checked)
            {
                memFee = 175;
            }
            else 
            {
                memFee = 225;
            }

            if (age > 40)
            {
                memFee -= 25;
            }
            if (memDuration > 10)
            {
                memFee -= 20;
            }

            labFeeToPay.Text = memFee.ToString("€ 0.00");
        }
    }
}