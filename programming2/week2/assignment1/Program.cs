using System.Drawing;

namespace assignment1
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
            InitMatrix2D(matrix);
            DisplayMatrixWithCross(matrix); 
        }
        void InitMatrix2D(int[,] matrix)
        {
            int n = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = n;
                    n++;
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
        void InitMatrixLinear(int[,] matrix)
        {
            //this is very confusing assignment, get back to it later

            for (int i = 0; i < matrix.GetLength(0) * matrix.GetLength(1); i++)
            {
                
            }
        }
        void DisplayMatrixWithCross(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {

                    if (row == column)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ResetColor();
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
                Console.ResetColor();
            }
        }
    }
}