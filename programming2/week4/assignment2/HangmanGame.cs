using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class HangmanGame
    {
        public string secretWord;
        public string guessedWord;

        public void Init(string secretWord)
        {
            foreach(char c in secretWord)
            {
                guessedWord += ".";
            }
        }
        public bool ContainsLetter(char letter)
        {
            return secretWord.Contains(letter);
        }
        public void ProcessLetter(char letter)
        {
            char[] temp = guessedWord.ToCharArray();
            for (int i = 0; i < guessedWord.Length; i++)
            {
                if (letter == secretWord[i])
                {
                    temp[i] = letter;
                    guessedWord = new string(temp);
                } 
            }
        }
        public bool IsGuessed()
        {
            return secretWord == guessedWord;
        }
    }

}
