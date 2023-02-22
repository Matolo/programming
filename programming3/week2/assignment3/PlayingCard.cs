using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class PlayingCard
    {
        public int rank;
        public CardSuit suit;
        public PlayingCard(int rank, CardSuit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }
        public override string ToString()
        {
            switch (rank)
            {
                case 11:
                    return $"Jack of {suit}";
                    break;
                case 12:
                    return $"Queen of {suit}";
                    break;
                case 13:
                    return $"King of {suit}";
                    break;
                case 14:
                    return $"Ace of {suit}";
                    break;
                default:
                    return $"{rank} of {suit}";
                    break;
            }
        }
    }
}
