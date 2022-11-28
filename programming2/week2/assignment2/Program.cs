namespace assignment2
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
            int[,] matrix = new int[numberOfRows, numberOfColumns];
            Position position = new Position();
            InitMatrixRandom(matrix, 1, 99);
            DisplayMatrix(matrix);

            Console.WriteLine();
            Console.Write("Enter a numnber (to search for): ");
            int numberToSearchFor = int.Parse(Console.ReadLine());
            position = SearchNumber(matrix, numberToSearchFor);
            Console.WriteLine($"Number {numberToSearchFor} is found (first) at position [{position.row},{position.column}]");
            position = SearchNumberBackwards(matrix, numberToSearchFor);
            Console.WriteLine($"Number {numberToSearchFor} is found (last) at position [{position.row},{position.column}]");

        }
        void InitMatrixRandom(int[,] matrix, int min, int max)
        {
            Random rnd = new Random();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = rnd.Next(min, max + 1);
                }
            }

        }
        void DisplayMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }
        }
        Position SearchNumber(int[,] matrix, int number)
        {
            Position position = new Position();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (matrix[row, column] == number)
                    {
                        position.row = row;
                        position.column = column;
                        return position;
                    }
                }
            }
            return position;
        }
        Position SearchNumberBackwards(int[,] matrix, int number)
        {
            Position position = new Position();

            for (int row = matrix.GetLength(0)-1; row >= 0; row--)
            {
                for (int column = matrix.GetLength(1)-1; column >= 0; column--)
                {
                    if (matrix[row, column] == number)
                    {
                        position.row = row;
                        position.column = column;
                        return position;
                    }
                }
            }
            return position;
        }

    }
}