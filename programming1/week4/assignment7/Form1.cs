namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createSquares_Click(object sender, EventArgs e)
        {
            int numSides = int.Parse(inpSides.Text);
            labSquare.Text = "";

            /*//Filled with Xs
            for (int i = 0; i < numSides; i++)
            {
                for (int j = 0; j < numSides; j++)
                {
                    labSquare.Text += " X";
                }
                labSquare.Text += "\n";

            }*/

            for (int i = 0; i < numSides; i++)
            {
                for (int j = 0; j < numSides; j++)
                {
                    //Check if it's first or last row
                    if (i == 0 || i == (numSides - 1))
                    {
                        labSquare.Text += " X";
                    }
                    else
                    {
                        //check if it's first or last column
                        if (j == 0 || j == (numSides - 1))
                        {
                            labSquare.Text += " X";
                        }
                        else
                        {
                            labSquare.Text += "  ";
                        }
                    }
                }
                labSquare.Text += ("\n");

            }









        }
    }
}