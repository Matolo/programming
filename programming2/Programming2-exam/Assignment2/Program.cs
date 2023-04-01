using System;

namespace Assignment2
{
    internal class Program
    {
        const int row = 15;
        const int column = 20;
        const int lowestRandom = 1;
        const int highestRandom = 200;
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            int[,] matrix = new int[row, column];
            FillMatrix(matrix);
            DisplayMatrix(matrix);

            Console.WriteLine();
            Position lowest = GetLowestPosition(matrix);
            Position highest = GetHighestPosition(matrix);
            DisplayPosition("lowest", lowest);
            DisplayPosition("highest", highest);
            Console.WriteLine();

            DisplayMatrixPositions(matrix, lowest, highest);
            
        }
        void FillMatrix(int[,] matrix)
        {
            Random random = new Random();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = random.Next(lowestRandom, highestRandom + 1);
                }
            }
        }
        void DisplayMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write($"{matrix[row, column], 3} ");
                }
                Console.WriteLine();
            }
        }
        void DisplayPosition(string name, Position pos)
        {
            Console.WriteLine($"{name}: {pos.value} (row: {pos.row + 1}, column: {pos.column + 1})");
        }
        Position GetLowestPosition(int[,] matrix)
        {
            Position position = new Position();

            int lowest = matrix[0,0];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (lowest > matrix[row, column])
                    {
                        lowest = matrix[row, column];
                        position.value = lowest;
                        position.row = row;
                        position.column = column;
                    }
                }
            }
            return position;
        }
        Position GetHighestPosition(int[,] matrix)
        {
            Position position = new Position();

            int highest = matrix[0, 0];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (highest < matrix[row, column])
                    {
                        highest = matrix[row, column];
                        position.value = highest;
                        position.row = row;
                        position.column = column;
                    }
                }
            }
            return position;
        }
        void DisplayMatrixPositions(int[,] matrix, Position lowest, Position highest)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (row == lowest.row || column == lowest.column)
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                    else if(row == highest.row || column == highest.column)
                        Console.ForegroundColor = ConsoleColor.Red;
                    if (matrix[row, column] == lowest.value)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else if (matrix[row, column] == highest.value)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    Console.Write($"{matrix[row, column], 3}");
                    Console.ResetColor();
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}