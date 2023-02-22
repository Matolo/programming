using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class PlayingCard
    {
        public string rank;
        public CardSuit suit;
        public PlayingCard(string rank, CardSuit suit) 
        {
            this.rank = rank;
            this.suit = suit;
        }
        public override string ToString()
        {
            return $"{rank} of {suit}";
        }
    }
}
