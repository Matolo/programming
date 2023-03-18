using System.Data;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        public void Start()
        {
            ChessPiece[,] chessboard = new ChessPiece[8, 8];
            InitChessboard(chessboard);
            DisplayChessboard(chessboard);
            PlayChess(chessboard);
        }
        public void InitChessboard(ChessPiece[,] chessboard)
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
                for (int column = 0; column < chessboard.GetLength(1); column++)
                    chessboard[row, column] = null;
            PutChessPieces(chessboard);
        }
        public void DisplayChessboard(ChessPiece[,] chessboard)
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                Console.Write($"{8 - row} ");
                for (int column = 0; column < chessboard.GetLength(1); column++)
                {
                    if ((row + column) % 2 == 0)
                        Console.BackgroundColor = ConsoleColor.Gray;
                    else
                        Console.BackgroundColor = ConsoleColor.DarkYellow;

                    DisplayChessPiece(chessboard[row, column]);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.Write("  ");
            for (char c = 'a'; c <= 'h'; c++)
                Console.Write($" {c} ");

            Console.WriteLine();
        }
        public void PutChessPieces(ChessPiece[,] chessboard)
        {
            ChessPieceType[] order = {
                ChessPieceType.Rook, ChessPieceType.Knight, ChessPieceType.Bishop,
                ChessPieceType.Queen, ChessPieceType.King, ChessPieceType.Bishop,
                ChessPieceType.Knight, ChessPieceType.Rook};

            for (int column = 0; column < chessboard.GetLength(1); column++)
            {
                chessboard[0, column] = new ChessPiece(ChessPieceColor.Black, order[column]);
                chessboard[1, column] = new ChessPiece(ChessPieceColor.Black, ChessPieceType.Pawn);
                chessboard[7, column] = new ChessPiece(ChessPieceColor.White, order[column]);
                chessboard[6, column] = new ChessPiece(ChessPieceColor.White, ChessPieceType.Pawn);
            }
        }
        public void DisplayChessPiece(ChessPiece chessPiece)
        {
            if (chessPiece == null)
            {
                Console.Write("   ");
                return;
            }
            if (chessPiece.color == ChessPieceColor.White)
                Console.ForegroundColor = ConsoleColor.White;
            else
                Console.ForegroundColor = ConsoleColor.Black;

            char piece = ' ';

            switch (chessPiece.type)
            {
                case ChessPieceType.Rook:
                    piece = 'r';
                    break;
                case ChessPieceType.Knight:
                    piece = 'k';
                    break;
                case ChessPieceType.Bishop:
                    piece = 'b';
                    break;
                case ChessPieceType.Queen:
                    piece = 'Q';
                    break;
                case ChessPieceType.King:
                    piece = 'K';
                    break;
                default:
                    piece = 'p';
                    break;
            }
            Console.Write($" {piece} ");
        }
        public Position String2Position(string pos)
        {
            int column = pos[0] - 'a';
            int row = 8 - int.Parse(pos[1].ToString());

            if (pos.Length != 2 || !char.IsLetter(pos[0]) || !char.IsDigit(pos[1]))
            {
                return null;
            }
            else if (column < 0 || column > 7 || row < 0 || row > 7)
            {
                return null;
            }

            return new Position(row, column);
        }
        public void PlayChess(ChessPiece[,] chessboard)
        {
            while (true)
            {
                Console.WriteLine("Enter a move (e.g. a2 a3): ");
                string input = Console.ReadLine();

                if (input == "stop")
                    break;

                string[] newMove = input.Split(' ');

                Position fromPos = String2Position(newMove[0]);
                Position toPos = String2Position(newMove[1]);

                if (newMove.Length != 2)
                    Console.WriteLine("Invalid position");
                if (fromPos == null)
                    Console.WriteLine($"Invalid position: {newMove[0]}");
                else if (toPos == null)
                    Console.WriteLine($"Invalid position: {newMove[1]}");
                else
                {
                    if (CheckMove(chessboard, fromPos, toPos))
                    {
                        Console.WriteLine($"move from {newMove[0]} to {newMove[1]}");
                        DoMove(chessboard, fromPos, toPos);
                        DisplayChessboard(chessboard);
                    }
                }
            }
        }
        public void DoMove(ChessPiece[,] chessboard, Position from, Position to)
        {
            chessboard[to.row, to.column] = chessboard[from.row, from.column];
            chessboard[from.row, from.column] = null;
        }
        public bool CheckMove(ChessPiece[,] chessboard, Position from, Position to)
        {
            if (chessboard[from.row, from.column] == null)
            {
                Console.WriteLine("No chess piece at from-position");
                return false;
            }
            else if (chessboard[to.row, to.column] != null && chessboard[from.row, from.column].color == chessboard[from.row, from.column].color)
            {
                Console.WriteLine("Can not take a chess piece of same color");
                return false;
            }


            int hor = Math.Abs(from.column - to.column);
            int ver = Math.Abs(from.row - to.row);

            switch (chessboard[from.row, from.column].type)
            {
                case ChessPieceType.Rook:
                    if (hor * ver != 0)
                    {
                        Console.WriteLine("Invalid move for chess piece Rook");
                        return false;
                    }
                    break;
                case ChessPieceType.Knight:
                    if (hor * ver != 2)
                    {
                        Console.WriteLine("Invalid move for chess piece Knight");
                        return false;
                    }
                    break;
                case ChessPieceType.Bishop:
                    if (hor != ver)
                    {
                        Console.WriteLine("Invalid move for chess piece Bishop");
                        return false;
                    }
                    break;
                case ChessPieceType.King:
                    if (hor != 1 && ver != 1)
                    {
                        Console.WriteLine("Invalid move for chess piece King");
                        return false;
                    }
                    break;
                case ChessPieceType.Queen:
                    if (hor != 0 || ver != 1)
                    {
                        Console.WriteLine("Invalid move for chess piece Queen");
                        return false;
                    }
                    break;
                case ChessPieceType.Pawn:
                    if (hor != 0 || ver != 1)
                    {
                        Console.WriteLine("Invalid move for chess piece Pawn");
                        return false;
                    }
                    break;
            }
            return true;
        }
    }
}