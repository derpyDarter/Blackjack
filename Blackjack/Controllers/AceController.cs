namespace Blackjack
{
    public class AceController
    {   
        public int SetUserAceValue(List<Card> hand, int id)
        {
            // User decides whether to hit, but must not be bust
            // Called when there is an ace. 
            var otherCards = hand.Where(c => c.Name != "A");
            int sum = 0;

            foreach (Card c in otherCards)
            {
                sum += c.Value;
            }

            var aces = hand.Where(c => c.Name == "A").OrderBy(c => c.ID);
            if (aces.Count() == 1)
            {
                if ((sum + 11) <= SharedLimits.Limit)
                {
                    return 11;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                var otherAces = aces.Where(c => c.ID != id);

                // Choose the highest id if multiple aces. No more than one ace can have 11
                if (!otherAces.Any(c => c.ID > id))
                {
                    if ((sum + 11 + otherAces.Count()) <= SharedLimits.Limit)
                    {
                        return 11;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    return 1;
                }
            }
        }
        
        public int SetAiAceValue(List<Card> hand)
        {
            var otherCards = hand.Where(c => c.Name != "A");

            int sum = 0;
            foreach (Card c in otherCards)
            {
                sum += c.Value;
            }



            if ((sum + 11) > SharedLimits.AiStand && (sum + 11) <= SharedLimits.Limit)
            {
                return 11;
            }
            else
            {
                return 1;
            }
        }


        
        public bool CheckNatural(Player player)
        {
            // A natural is a blackjack (21) dealt at the initial deal. Immediate win
            if (player.Hand[0].Name == "A")
            {
                if (player.Hand[1].Value == 10)
                {
                    return true;
                }
            }
            else if (player.Hand[0].Value == 10)
            {
                if (player.Hand[1].Name == "A")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
