namespace Blackjack
{
    public class GameController
    {
        public Table PlayUntilStandOrBust(Table table)
        {
            while (table.Players.Where(p => p.IsStand).Count() + table.Players.Where(p => p.IsBust).Count() < table.Players.Count())
            {
                table = PlayTableRound(table);
            }
            return table;
        }

        public Table PlayDealer(Table table)
        {
            SetOnePlayerStand(table.Dealer);
            while (!table.Dealer.IsStand)
            {

                SetOnePlayerStand(table.Dealer);
                table = DealSingleCard(table.Dealer, table);
                SetOnePlayerBust(table.Dealer);
                if (table.Dealer.IsBust)
                {
                    break;
                }
            }

            return table;
        }

        public Table PlayTableRound(Table table)
        {
            SetTablePlayerStands(table);
            table = DealCardsAroundTable(table);
            SetTablePlayerBusts(table);
            return table;
        }
        
        private void SetTablePlayerStands(Table table)
        {
            // Starts at index one, because user player is index 0.
            for (int i = 1; i < table.Players.Count; i++)
            {
                Player player = table.Players[i];
                SetOnePlayerStand(player);
            }

        }

        private void SetOnePlayerStand(Player player)
        {
            if (!player.IsBust)
            {
                int sum = 0;
                foreach (Card c in player.Hand)
                {

                    if (c.Name == "A")
                    {
                        var acer = new AceController();
                        c.Value = acer.SetAiAceValue(player.Hand);
                    }
                    sum += c.Value;
                }
                if (sum > SharedLimits.AiStand)
                {
                    player.IsStand = true;

                }
            }
        }

        private void SetTablePlayerBusts(Table table)
        {
            for (int i = 0; i < table.Players.Count; i++)
            {
                Player player = table.Players[i];
                SetOnePlayerBust(player);
            }
        }

        private void SetOnePlayerBust(Player player)
        {
            int sum = 0;
            foreach (Card c in player.Hand)
            {
                if (c.Name == "A")
                {
                    var acer = new AceController();
                    if (player.PlayerID == 1)
                    {
                        c.Value = acer.SetUserAceValue(player.Hand, c.ID);
                    }
                    else
                    {
                        c.Value = acer.SetAiAceValue(player.Hand);
                    }
                    
                }
                
                sum += c.Value;

                if (sum > SharedLimits.Limit)
                {
                    player.IsBust = true;
                }
            }
        }

        public Table InitialDeal(Table table)
        {
            // Integer returned is the number of winners. 
            for (int i = 0; i < 2; i++)
            {
                table = DealCardsAroundTable(table);
                table = DealSingleCard(table.Dealer, table);
            }
            return table;
        }
        
        public Table DealSingleCard(Player player, Table table)
        {
            if (!player.IsStand && !player.IsBust)
            {
                var rand = new Random();
                int cardIndex = rand.Next(0, table.Cards.Count);
                Card card = table.Cards[cardIndex];
                table.Cards.RemoveAt(cardIndex);
                player.Hand.Add(card);   
            }
            return table;
        }

        public Table DealCardsAroundTable(Table table)
        {
            // Does not deal to the dealer. At most real life tables, dealer hits separately after all players stand. 
            for (int i = 0; i < table.Players.Count; i++)
            {
                Player player = table.Players[i];
                table = DealSingleCard(player, table);
            }
            return table;
        }
    }
}
