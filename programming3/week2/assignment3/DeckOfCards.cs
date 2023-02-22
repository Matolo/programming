namespace assignment3
{
    public class DeckOfCards
    {
        public List<PlayingCard> allPlayingCards = new List<PlayingCard>();
        public DeckOfCards()
        {
            InitCards();
        }
        void InitCards()
        {
            PlayingCard playingCard;
            CardSuit suit;
            
            for (int i = 0; i < 4; i++)
            {
                suit = (CardSuit)i;
                for (int j = 2; j <= 14; j++)
                {
                    playingCard = new PlayingCard(j, suit);
                    allPlayingCards.Add(playingCard);
                }
            }
        }
        public void Print()
        {
            foreach (PlayingCard playingCard in allPlayingCards)
            {
                Console.WriteLine(playingCard.ToString());
            }
        }
        public void Shuffle()
        {
            Random random = new Random();
            PlayingCard tempPlayingCard;
            int temp, temp2;
            for (int i = 0; i < 100; i++)
            {
                temp = random.Next(0, allPlayingCards.Count);
                tempPlayingCard = allPlayingCards[temp];
                temp2 = random.Next(0, allPlayingCards.Count);
                allPlayingCards[temp] = allPlayingCards[temp2];
                allPlayingCards[temp2] = tempPlayingCard;
            }
        }
    }
}
