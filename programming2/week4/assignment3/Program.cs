using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("invalid number of arguments!");
                Console.WriteLine("usage: assignment[2-3] <filename>");
                return;
            }
            string filename = args[0];
            Program myProgram = new Program();
            myProgram.Start(filename);
        }
        void Start(string filename)
        {
            Console.Write("Enter a word (to search): ");
            string word = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Number of lines containing the word: {SearchWordInFile(filename, word)}");
        }
        bool WordInLine(string line, string word)
        {
            return line.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0;
        }
        int SearchWordInFile(string filename, string word)
        {
            StreamReader reader = new StreamReader(filename);
            int count = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (WordInLine(line, word))
                {

                    DisplayWordInLine(line, word);
                    Console.WriteLine();
                    count++;
                }
            }
            return count;
        }
        void DisplayWordInLine(string line, string word)
        {
            int start = line.IndexOf(word, StringComparison.OrdinalIgnoreCase);


            string newWord = line.Substring(start, word.Length);
            newWord = $"[{newWord}]";
            line = line.Replace(word, newWord, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(line);


            /*for (int i = 0; i < line.Length; i++)
            {
                //Temporary solution for codegrade, if I have enough time I will fix it with Substring
                switch (i)
                {
                    case int j when j == line.IndexOf(word) + word.Length - 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(newWord);
                        Console.ResetColor();
                        break;
                    case int j when j >= line.IndexOf(word) && j < (line.IndexOf(word) + word.Length):
                        break;
                    default:
                        Console.Write(line[i]);
                        break;
                }
            }*/
        }
    }
}
