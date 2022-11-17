namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[6] {0, 0, 0, 0, 0, 0 };
            Random random = new Random();
            labThrows.Text = string.Empty;

            for (int i = 0; i<6000; i++)
            {
                switch(random.Next(1, 7))
                {
                    case 1:
                        numbers[0]++;
                        break;
                    case 2:
                        numbers[1]++;
                        break;
                    case 3:
                        numbers[2]++;
                        break;
                    case 4:
                        numbers[3]++;
                        break;
                    case 5:
                        numbers[4]++;
                        break;
                    default:
                        numbers[5]++;
                        break;
                }
            }
            for (int i = 0; i<numbers.Length;i++)
                labThrows.Text += $"Number of throws of value {i+1} = {numbers[i]}\n";
            
        }
    }
}