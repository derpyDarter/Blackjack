namespace Blackjack
{
    public class Player
    {
        public Player()
        {
            Hand = new List<Card>();
            IsBust = false;
            IsStand = false;
            IsNaturalWinner = false;
            Score = 0;
            Bet = 0;
        }

        public int PlayerID { get; set; }
        public string? Name { get; set; }
        public decimal Bankroll { get; set; }
        public List<Card> Hand { get; set; }
        public bool IsStand { get; set; }
        public bool IsBust { get; set; }
        public bool IsNaturalWinner { get; set; }
        public int Score {get; set;}
        public decimal Bet { get; set; }    
    }
}
