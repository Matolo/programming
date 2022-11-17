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
            string input = inpSec.Text;

            int secInp = int.Parse(input);

            int hours = secInp / 3600;
            int minutes = (secInp % 3600) / 60;
            int seconds = (secInp % 3600) % 60;

            result.Text = $"{hours:00}:{minutes:00}:{seconds:00}";

        }
    }
}