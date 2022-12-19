using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    public enum LetterState { Correct, Incorrect, WorngPosition }
    public class LingoGame
    {
        
        public string lingoWord;
        public string playerWord;
        public void Init(string lingoWord)
        {
            this.lingoWord= lingoWord;
            this.playerWord = "";
        }
        public bool WordGuessed()
        {
            return lingoWord == playerWord;
        }
        public LetterState[] ProcessWord(string playerWord)
        {
            this.playerWord= playerWord;
            LetterState[] letterResults = new LetterState[lingoWord.Length];

            List<char> refLetters = new List<char>();

            for (int i = 0; i < lingoWord.Length; i++)
            {
                if (lingoWord[i] != playerWord[i])
                    refLetters.Add(lingoWord[i]);
            }
            for (int i = 0; i < lingoWord.Length; i++)
            {
                if (lingoWord[i] == playerWord[i])
                    letterResults[i] = LetterState.Correct;
                else
                {
                    if (refLetters.Contains(playerWord[i]))
                    {
                        letterResults[i] = LetterState.WorngPosition;
                        refLetters.Remove(playerWord[i]);
                    }
                    else
                        letterResults[i] = LetterState.Incorrect;
                }
            }
            
            return letterResults;
        }
    }
}
