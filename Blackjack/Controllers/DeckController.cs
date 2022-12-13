namespace Blackjack
{
    public class DeckController
    {
        private Queue<char>_suits {get; set;}
        public DeckController()
        {
            _suits = new Queue<char>();
            _suits.Enqueue('D');
            _suits.Enqueue('H');
            _suits.Enqueue('S');
            _suits.Enqueue('C');
        }
        public List<Card> MakeDeck(int idSeed)
        {
            var deck = new List<Card>();
            foreach(char c in _suits)
            {
                for (int i = 2; i < 11; i++)
                {
                    var card = new Card();
                    card.Name = i.ToString();
                    card.Suit = c;
                    card.Value = i;
                    card.ID = idSeed;
                    deck.Add(card);
                    idSeed++;
                }

                var jack = new Card();
                jack.Name = "J";
                jack.Value = 10;
                jack.Suit = c;
                jack.ID = idSeed;
                deck.Add(jack);
                idSeed++;

                var queen = new Card();
                queen.Name = "Q";
                queen.Value = 10;
                queen.Suit = c;
                queen.ID = idSeed;
                deck.Add(queen);
                idSeed++;

                var king = new Card();
                king.Name = "K";
                king.Value = 10;
                king.Suit = c;
                king.ID = idSeed;
                deck.Add(king);
                idSeed++;

                // Ace values remain 0 until in gameplay.
                var ace = new Card();
                ace.Name = "A";
                ace.Suit = c;
                ace.ID = idSeed;
                deck.Add(ace);
                idSeed++;
            }

            return deck;
        }
    }
}
