using System;

namespace assignment2
{
    class Dice
    {
        public int value;
        Random random;

        public Dice(Random random)
        {
            this.random = random;
        }
        public void Throw()
        {
            value = random.Next(1, 7);
        }
        public void DisplayValue()
        {
            Console.Write($"{value} ");
        }
    }

}
