using System.ComponentModel;

namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("invalid number of arguments!");
                Console.WriteLine("usage: assignment[3-4] <filename>");
                return;
            }
            string filename = args[0];
            Program myProgram = new Program();
            myProgram.Start(filename);
        }
        void Start(string filename)
        {
            List<string> words = ReadWords(filename, 5);
            string lingoWord = SelectWord(words);
            Console.WriteLine(lingoWord);
            LingoGame lingoGame = new LingoGame();
            lingoGame.Init(lingoWord);
            if (PlayLingo(lingoGame))
                Console.WriteLine("You have guessed the word!");
            else
                Console.WriteLine($"Too bad, you did not guess the word({lingoWord})");
        }
        List<string> ReadWords(string filename, int wordLength)
        {
            List<string> words = new List<string>();
            StreamReader reader = new StreamReader(filename);

            while (!reader.EndOfStream)
            {
                //codegrade is case insensitive, however remake this to case insensitive, for now this is the solution
                string word = reader.ReadLine().ToLower();
                if(word.Length == wordLength)
                {
                    words.Add(word);
                }
            }

            reader.Close();
            return words;
        }
        
        string SelectWord(List<string> words)
        {
            Random random= new Random();
            return words[random.Next(0, words.Count)];
        }
        bool PlayLingo(LingoGame lingoGame)
        {
            int attemptsLeft = 5;
            int wordLength = lingoGame.lingoWord.Length;
            int i = 1;

            while (attemptsLeft > 0 && !lingoGame.WordGuessed())
            {
                Console.Write($"Enter a ({wordLength}-letter) word, attempt {i}: ");
                string playerWord = ReadPlayerWord(wordLength);
                LetterState[] letterResults = lingoGame.ProcessWord(playerWord);
                DisplayPlayerWord(playerWord, letterResults);
                Console.WriteLine();
                attemptsLeft--;
                i++;

            }
            return lingoGame.WordGuessed();
        }
        string ReadPlayerWord(int length)
        {
            int i = 1;
            string word;
            do
            {
                word = Console.ReadLine();
            } while (word.Length != length);
            return word;
        }
        void DisplayPlayerWord(string playerWord, LetterState[] letterResults)
        {
            for (int i = 0; i < playerWord.Length; i++)
            {
                if (letterResults[i] == LetterState.Correct)
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                else if (letterResults[i] == LetterState.WorngPosition)
                    Console.BackgroundColor = ConsoleColor.DarkYellow;

                Console.Write(playerWord[i]);
                Console.ResetColor();

            }
        }
    }
}