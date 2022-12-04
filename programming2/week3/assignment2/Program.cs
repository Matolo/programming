namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            HangmanGame hangman = new HangmanGame();
            List<string> words = ListOfWords();
            hangman.secretWord = SelectWord(words);
            hangman.Init(hangman.secretWord);
            Console.WriteLine($"The secret word is: {hangman.secretWord}");
            if (PlayHangman(hangman))
                Console.WriteLine("You guessed the word!");
            else
                Console.WriteLine($"Too bad, you did not guess the word ({hangman.secretWord})");
            

        }
        List<String> ListOfWords()
        {

            List<String> list = new List<String>();
            list.Add("airplane");
            list.Add("kitchen");
            list.Add("building");
            list.Add("incredible");
            list.Add("funny");
            list.Add("trainstation");
            list.Add("neighbour");
            list.Add("different");
            list.Add("department");
            list.Add("planet");
            list.Add("presentation");
            list.Add("embarrassment");
            list.Add("integration");
            list.Add("scenario");
            list.Add("discount");
            list.Add("management");
            list.Add("understanding");
            list.Add("registration");
            list.Add("security");
            list.Add("language");

            return list;
        }
        string SelectWord(List<String> words)
        {
            Random rnd = new Random();

            return words[rnd.Next(0, words.Count)];
        }
        bool PlayHangman(HangmanGame hangman)
        {
            int nrOfAttempts = 8;
            char userEnteredLetter;
            List<char> enteredLetters = new List<char>();
            List<char> blacklist = new List<char>();
            blacklist.Add(' ');

            DisplayWord(hangman.guessedWord);
            do
            {
                
                userEnteredLetter = ReadLetter(blacklist);
                enteredLetters.Add(userEnteredLetter);
                blacklist.Add(userEnteredLetter);
                DisplayLetters(enteredLetters);
                if (hangman.ContainsLetter(userEnteredLetter))
                    hangman.ProcessLetter(userEnteredLetter);
                else
                    nrOfAttempts--;
                Console.WriteLine($"\nAttempts left: {nrOfAttempts}");
                Console.WriteLine();
                DisplayWord(hangman.guessedWord);

            } while (!hangman.IsGuessed() && nrOfAttempts > 0);
            return hangman.IsGuessed();
        }
        void DisplayWord(string word)
        {
            for(int i = 0; i < word.Length; i++)
                Console.Write($"{word[i]} ");
            Console.WriteLine();
        }
        void DisplayLetters(List<char> letters)
        {
            Console.Write("Entered letters: ");
            foreach(char c in letters)
                Console.Write($"{c} ");
        }
        char ReadLetter(List<char> blacklistLetters)
        {
            char letter;
            do
            {
                Console.Write("Enter a letter: ");
                letter = char.Parse(Console.ReadLine());

            } while (blacklistLetters.Contains(letter));
            return letter;
        }
    }
}