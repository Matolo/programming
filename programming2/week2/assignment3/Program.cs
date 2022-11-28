namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("invalid number of arguments!");
                Console.WriteLine("usage: assignment[1-3] <nr of rows> <nr of columns>");
                return;
            }
            int numberOfRows = int.Parse(args[0]);
            int numberOfColumns = int.Parse(args[1]);

            Program myProgram = new Program();
            myProgram.Start(numberOfRows, numberOfColumns);
        }
        void Start(int numberOfRows, int numberOfColumns)
        {
            RegularCandies[,] playingField = new RegularCandies[numberOfRows, numberOfColumns];
            InitCandies(playingField);
            DisplayCandies(playingField);
            Console.WriteLine();
            if (ScoreRowPresent(playingField))
                Console.WriteLine("row score");
            else
                Console.WriteLine("no row score");
            if (ScoreColumnPresent(playingField))
                Console.WriteLine("column score");
            else
                Console.WriteLine("no column score");

        }
        void InitCandies(RegularCandies[,] playingField)
        {
            Random rnd = new Random();

            int min = (int)RegularCandies.JellyBean;
            int max = (int)RegularCandies.JujubeCluster;

            for (int row = 0; row < playingField.GetLength(0); row++)
            {
                for (int column = 0; column < playingField.GetLength(1); column++)
                {
                    RegularCandies randomCandy = (RegularCandies)rnd.Next(min, max+1);
                    playingField[row, column] = randomCandy;
                }
            }
        }
        void DisplayCandies(RegularCandies[,] playingField)
        {
            for (int row = 0; row < playingField.GetLength(0); row++)
            {
                for (int column = 0; column < playingField.GetLength(1); column++)
                {
                    switch (playingField[row, column])
                    {
                        case RegularCandies.JellyBean:
                            Console.ForegroundColor= ConsoleColor.Red;
                            break;
                        case RegularCandies.Lozenge:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;
                        case RegularCandies.LemonDrop:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case RegularCandies.GumSquare:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case RegularCandies.LollipopHead:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            break;
                    }
                    Console.Write("#");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
        bool ScoreRowPresent(RegularCandies[,] playingField)
        {
            
            for (int row = 0; row < playingField.GetLength(0); row++)
            {
                int counter = 1;
                for (int column = 1; column < playingField.GetLength(1); column++)
                {
                    if (playingField[row, column] == playingField[row, column - 1])
                    {
                        counter++;
                        if (counter == 3)
                            return true;
                    }
                    else
                        counter = 1;
                }
            }
            return false;
        }
        bool ScoreColumnPresent(RegularCandies[,] playingField)
        {
            
            for (int column = 0; column < playingField.GetLength(0); column++)
            {
                int counter = 1;
                for (int row = 1; row < playingField.GetLength(1); row++)
                {
                    if (playingField[row, column] == playingField[row - 1 , column])
                    {
                        counter++;
                        if (counter == 3)
                            return true;
                    }
                    else
                        counter = 1;
                }
            }
            return false;
        }
    }
}