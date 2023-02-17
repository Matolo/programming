using System;

namespace assignment2
{
    class YahtzeeGame
    {
        Dice[] dices = new Dice[5];
        public YahtzeeGame()
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {   
                dices[i] = new Dice(random);
            }
        }
        public void Throw()
        {
            for (int i = 0; i < 5; i++)
            {
                dices[i].Throw();
            }
        }
        public void DisplayValues()
        {
            for (int i = 0; i < 5; i++)
            {
                dices[i].DisplayValue();
            }
            Console.WriteLine();
        }
        public bool Yahtzee()
        {
            for (int i = 0; i < 4; i++)
            {
                if (dices[i].value != dices[i + 1].value)
                    return false;
            }
            return true;
        }
    }
}
