namespace assignment2
{
    internal class DeckOfCards
    {
        public List<PlayingCard> allPlayingCards = new List<PlayingCard>();
        public DeckOfCards() 
        { 
            InitCards();
        }
        void InitCards()
        {
            //PlayingCard playingCard;
            CardSuit suit;
            //string rank;
            for (int i = 0; i < 4; i++)
            {
                suit = (CardSuit)i;
                /*for (int j = 1; j <= 13; j++)
                {*/
                
                PlayingCard two = new PlayingCard("2", suit);
                allPlayingCards.Add(two);
                PlayingCard three = new PlayingCard("3", suit);
                allPlayingCards.Add(three);
                PlayingCard four = new PlayingCard("4", suit);
                allPlayingCards.Add(four);
                PlayingCard five = new PlayingCard("5", suit);
                allPlayingCards.Add(five);
                PlayingCard six = new PlayingCard("6", suit);
                allPlayingCards.Add(six);
                PlayingCard seven = new PlayingCard("7", suit);
                allPlayingCards.Add(seven);
                PlayingCard eight = new PlayingCard("8", suit);
                allPlayingCards.Add(eight);
                PlayingCard nine = new PlayingCard("9", suit);
                allPlayingCards.Add(nine);
                PlayingCard ten = new PlayingCard("10", suit);
                allPlayingCards.Add(ten);
                PlayingCard jack = new PlayingCard("Jack", suit);
                allPlayingCards.Add(jack);
                PlayingCard queen = new PlayingCard("Queen", suit);
                allPlayingCards.Add(queen);
                PlayingCard king = new PlayingCard("King", suit);
                allPlayingCards.Add(king);
                PlayingCard one = new PlayingCard("Ace", suit);
                allPlayingCards.Add(one);
                /*switch (j)
                {
                    case 1:
                        rank = "Ace";
                        break;
                    case 2:
                        rank = "2";
                        break;
                    case 3:
                        rank = "3";
                        break;
                    case 4:
                        rank = "4";
                        break;
                    case 5:
                        rank = "5";
                        break;
                    case 6:
                        rank = "6";
                        break;
                    case 7:
                        rank = "7";
                        break;
                    case 8:
                        rank = "8";
                        break;
                    case 9:
                        rank = "9";
                        break;
                    case 10:
                        rank = "10";
                        break;
                    case 11:
                        rank = "Jack";
                        break;
                    case 12:
                        rank = "Queen";
                        break;
                    default:
                        rank = "King";
                        break;
                }
                playingCard = new PlayingCard(rank, suit);
                allPlayingCards.Add(playingCard);
            }*/
            }
        }
        public void Print()
        {
            foreach(PlayingCard playingCard in allPlayingCards)
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
