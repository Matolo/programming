namespace assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numbers = new int[20];
        Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 501);
                labContentTableBefore.Text += $"Element {i:00} = {numbers[i]}\n";
            }
        }

        private void compare_Click(object sender, EventArgs e)
        {
            int comparsionNumber = int.Parse(inpComparsionNumber.Text);
            labContentTableAfter.Text = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (comparsionNumber <= numbers[i])
                {
                    numbers[i] += 10;
                    labContentTableAfter.Text += $"Element {i:00} = {numbers[i]}\n";
                }
                else
                {
                    numbers[i] -= 5;
                    labContentTableAfter.Text += $"Element {i:00} = {numbers[i]}\n";
                }

            }
        }
    }
}