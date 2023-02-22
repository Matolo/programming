using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class WarCardGame : CardGame
    {
        public Player player1, player2;

        public WarCardGame(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }
        public void StartNewGame()
        {
            deck.Shuffle();
            Player currentPlayer = player1;

            foreach(PlayingCard card in deck.allPlayingCards)
            {
                currentPlayer.AddCard(card);
                if(currentPlayer == player1)
                    currentPlayer = player2;
                else
                    currentPlayer = player1;
            }
        }
        public bool EndOfGame()
        {

            return (player1.cards.Count == 0 || player2.cards.Count == 0);
        }
        public void NextCard()
        {
            PlayingCard player1Card = player1.GetNextCard();
            PlayingCard player2Card = player2.GetNextCard();

            Console.WriteLine($"[{player1.name}] {player1Card} - [{player2.name}] {player2Card}");

            if (player1Card.rank > player2Card.rank)
            {
                player1.cards.Add(player1Card);
                player1.cards.Add(player2Card);
                Console.WriteLine($"{player1.name} got the cards");
            }
            else if (player1Card.rank < player2Card.rank)
            {
                player2.cards.Add(player2Card);
                player2.cards.Add(player1Card);
                Console.WriteLine($"{player2.name} got the cards");
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("2 cards lost...");
                Console.WriteLine($"cards left: [{player1.name}] {player1.cards.Count}x, [{player2.name}] {player2.cards.Count}x");
                Console.ResetColor();
            }
        }
    }
}
