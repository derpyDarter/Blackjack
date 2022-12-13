namespace Blackjack
{
    public class WinController
    {
        public WinController(Table table)
        {
            table.Dealer.Score = GetScore(table.Dealer.Hand, false);
            foreach (Player p in table.Players)
            {
                if (p.PlayerID == 1)
                {
                    p.Score = GetScore(p.Hand, true);
                }
                else
                {
                    p.Score = GetScore(p.Hand, false);
                }
                
            }
        }

        public Table GetWinners(Table table)
        {
 
            var winners = new List<Player>();
            if (table.Dealer.IsBust)
            {
                foreach (Player p in table.Players)
                {
                    if (!p.IsBust)
                    {
                        winners.Add(p);
                    }
                }
            }
            else
            {
                foreach (Player p in table.Players)
                {
                    if (p.Score > table.Dealer.Score && !p.IsBust)
                    {
                        winners.Add(p);
                    }
                }
            }

            table.Winners = winners;
            return table;
        }

        public Table GetPushes(Table table)
        {
            var pushes = new List<Player>();
            
            if (!table.Dealer.IsBust)
            {
                foreach (Player p in table.Players)
                {
                    if (p.Score == table.Dealer.Score)
                    {
                        pushes.Add(p);
                    }
                }
            }

            table.Pushers = pushes;
            return table;
        }

        public Table GetLosers(Table table)
        {
            var losers = new List<Player>();

            if (!table.Dealer.IsBust)
            {
                foreach (Player p in table.Players)
                {
                    if (p.Score < table.Dealer.Score)
                    {
                        losers.Add(p);
                    }
                }
            }
            foreach (Player p in table.Players)
            {
                if (p.IsBust)
                {
                    losers.Add(p);
                }
            }
            
            table.Losers = losers;
            return table;
        }

        public int GetScore(List<Card> hand, bool isUser)
        {
            int score = 0;
            foreach (Card c in hand)
            {
                if (c.Name == "A")
                {
                    if (isUser)
                    {
                        var acer = new AceController();
                        c.Value = acer.SetUserAceValue(hand, c.ID);
                    }
                    else
                    {
                        var acer = new AceController();
                        c.Value = acer.SetAiAceValue(hand);
                    }
                }
                
                score += c.Value;

            }
            return score;
        }
        
        public Table GetNaturalWinners(Table table)
        {
            var naturals = new List<Player>();
            var acer = new AceController();
            foreach (Player p in table.Players)
            {
                if (acer.CheckNatural(p) == true)
                {
                    naturals.Add(p);
                    p.IsNaturalWinner = true;
                    p.Score = 21;
                }
            }

            if (acer.CheckNatural(table.Dealer) == true)
            {
                naturals.Add(table.Dealer);
                table.Dealer.IsNaturalWinner = true;
                table.Dealer.IsStand = true;
                table.Dealer.Score = 21;    
            }

            if (naturals.Any() && !table.Dealer.IsNaturalWinner)
            {
                table.Winners = naturals;
            }

            if (naturals.Any() && table.Dealer.IsNaturalWinner)
            {
                table.Pushers = naturals;
            }

            table.Losers = table.Players.Except(naturals).ToList();

            return table;
        }

        public Table RemoveBankruptPlayers(Table table)
        {
            for (int i = 0; i < table.Players.Count(); i++)
            {
                if (table.Players[i].Bankroll < table.MinimumBet)
                {
                    table.Players.RemoveAt(i);
                    i--;
                }
            }
            
            return table;
        }
    }
}
