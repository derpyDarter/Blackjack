namespace Blackjack
{
    public class Table
    {
        public int NumPlayers { get; set; }
        public int NumDecks { get; set; }
        public int MinimumBet { get; set; }
        public int MaximumBet { get; set; }

        public List<Card> Cards { get; set;}
        public List<Player> Players { get; set; }
        public Dealer Dealer { get; set; }

        public List<Player> NaturalWinners { get; set; }
        public List<Player> Winners { get; set; }
        public List<Player> Pushers { get; set; }   
        public List<Player> Losers { get; set; }
        private List<string> _names { get; set; }

        public Table(int numPlayers, int numDecks, int minimumBet, int maximumBet, string playerName, decimal playerBankroll, decimal dealerBankroll)
        {
            NumPlayers = numPlayers;
            NumDecks = numDecks;
            MinimumBet = minimumBet;
            MaximumBet = maximumBet;

            Dealer = new Dealer(dealerBankroll);
            Cards = new List<Card>();
            Players = new List<Player>();
            NaturalWinners = new List<Player>();
            Winners = new List<Player>();
            Losers = new List<Player>();
            Pushers = new List<Player>();

            _names = new List<string>();
            _names = SetUpAvailableNames();

            SetUpTableDecks();
            SetUpTablePlayers(playerName, NumPlayers, playerBankroll);           
        }


        private void SetUpTableDecks()
        {
            var maker = new DeckController();
            for (int i = 0; i < NumDecks; i++)
            {
                Cards.AddRange(maker.MakeDeck(Cards.Count()));
            }
        }

        private void SetUpTablePlayers(string playerName, int numPlayers, decimal playerBankroll)
        {
            var rand = new Random();

            var userPlayer = new Player();
            userPlayer.Name = playerName;
            userPlayer.PlayerID = 1;
            userPlayer.Bankroll = playerBankroll;
            Players.Add(userPlayer);
            for (int i = 2;i <= numPlayers;i++)
            {
                var player = new Player();
                player.PlayerID = i;
                int nameIndex = rand.Next(0, _names.Count());
                player.Name = _names[nameIndex];
                if (player.Name == playerName) { player.Name += " Robot"; }
                _names.RemoveAt(nameIndex);

                player.Bankroll = rand.Next(100, 3000);
                Players.Add(player);
            }
        }

        private List<string> SetUpAvailableNames()
        {
            var names = new List<string>();

            names.Add("Dude");
            names.Add("Donnie");
            names.Add("Maude");
            names.Add("Bunny");
            names.Add("Karl");
            names.Add("Walter");
            names.Add("Jackie");
            names.Add("Rhiannon");
            names.Add("Hillary");
            names.Add("Dolly");
            names.Add("Natalie");
            names.Add("Pancho");
            names.Add("Lefty");
            names.Add("Willie");

            return names;
        }
    }
}
