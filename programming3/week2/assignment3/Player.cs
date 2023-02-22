using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class Player
    {
        public string name;
        public List<PlayingCard> cards = new List<PlayingCard>();

        public Player(string name)
        {
            this.name = name;
        }
        public void AddCard(PlayingCard card)
        {
            cards.Add(card);
        }
        public PlayingCard GetNextCard()
        {
            PlayingCard currentCard;
            currentCard = cards[0];
            cards.Remove(currentCard);
            
            return currentCard;
        }
    }
}
