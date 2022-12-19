namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("invalid number of arguments!");
                return;
            }
            string filename = args[0];
            Program myProgram = new Program();
            myProgram.Start(filename);
        }
        void Start(string filename)
        {
            TranslateWords(ReadWords(filename));
        }
        Dictionary<string, string> ReadWords(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] words = line.Split(';');
                dictionary.Add(words[0], words[1]);
            }
            return dictionary;
        }
        void TranslateWords(Dictionary<string, string> words)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            string translatedWord;

            while (word != "stop")
            {
                if (word == "listall")
                    ListAllWords(words);
                else if (!words.ContainsKey(word))
                    Console.WriteLine($"word '{word}' not found");
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    words.TryGetValue(word, out translatedWord);
                    Console.WriteLine($"{word} => {translatedWord}");
                }
                Console.ResetColor();
                Console.Write("Enter a word: ");
                word = Console.ReadLine();
            }
        }
        void ListAllWords(Dictionary<string, string> words)
        {
            foreach (var word in words)
            {
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine($"{word.Key} => {word.Value}");
            }
            Console.ResetColor();
        }
    }
}