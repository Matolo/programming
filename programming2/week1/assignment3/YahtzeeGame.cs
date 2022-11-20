using System;

namespace assignment3
{
    class YahtzeeGame
    {
        Dice[] dices = new Dice[5];
        public void Init()
        {
            for (int i = 0; i < 5; i++)
            {
                dices[i] = new Dice();
            }
            
        }
        public void Throw()
        {
            for (int i = 0; i<5; i++)
            {
                dices[i].Throw();
            }
        }
        public void DisplayValues()
        {
            for (int i  = 0; i < 5; i++)
            {
                dices[i].DisplayValue();
            }
            Console.WriteLine();
        }
        public bool Yahtzee()
        {
            for (int i = 0; i< 4; i++)
            {
                if (dices[i].value != dices[i+1].value)
                    return false;
            }
            return true;
        }
    }
}
