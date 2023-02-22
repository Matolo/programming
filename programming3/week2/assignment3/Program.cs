namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            Player player1 = new Player("John");
            Player player2 = new Player("Emma");
            WarCardGame war = new WarCardGame(player1, player2);
            PlayTheGame(war);
        }
        void PlayTheGame(WarCardGame war)
        {
            war.StartNewGame();
            while (!war.EndOfGame())
            {
                war.NextCard();
            }
            if (war.player1.cards.Count == 0)
                Console.WriteLine($"{war.player2.name} has won!");
            else if (war.player2.cards.Count == 0)
                Console.WriteLine($"{war.player1.name} has won!");
        }
    }
}