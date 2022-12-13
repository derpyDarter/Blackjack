namespace Blackjack
{
    public class BetController
    {
        public Table PayOutWagers(Table table)
        {
            foreach (Player winner in table.Winners)
            {
                if (winner.IsNaturalWinner)
                {
                    table.Dealer.Bankroll -= (winner.Bet * (decimal)1.5);
                    winner.Bankroll += (winner.Bet * (decimal)2.5);
                    winner.Bet = 0;
                }
                else
                {
                    table.Dealer.Bankroll -= winner.Bet;
                    winner.Bankroll += (winner.Bet * 2);
                    winner.Bet = 0;
                }

            }

            return table;
        }

        public Table ReturnWagers(Table table)
        {
            foreach (Player pusher in table.Pushers)
            {
                pusher.Bankroll += pusher.Bet;
                pusher.Bet = 0;
            }
            return table;
        }

        public Table CollectWagers(Table table)
        {
            foreach (Player loser in table.Losers)
            {
                table.Dealer.Bankroll += loser.Bet;
                loser.Bet = 0;
            }
            return table;
        }
        
        public Player PlaceBet(Player player, decimal bet)
        {
            if (bet > player.Bankroll)
            {
                bet = player.Bankroll;
            }
            
            player.Bankroll -= bet;
            player.Bet += bet;
            return player;
        }

        public Table ExecuteTableAIWagers(Table table)
        {
            var rand = new Random();
            foreach (Player p in table.Players.Skip(1))
            {
                int bet = rand.Next(table.MinimumBet, table.MaximumBet);
                PlaceBet(p, bet);
            }
            return table;
        }

    }
}
