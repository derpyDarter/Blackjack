namespace Blackjack
{
    public class Dealer : Player
    {
        public Dealer(decimal bankroll)
        {
            Bankroll = bankroll;
            Name = "Dealer";
            IsStand = false;
            IsBust = false;
            IsNaturalWinner = false;
        }
    }
}
