using System;

class FrenchDeck
{
    public readonly List<Card> _frenchDeck;

    //public int NumberOfCards = 52;
    //private int currentCard = 0;

    public ListCard()
    {
        _frenchDeck = new List<Card>();
    }
    public FrenchDeck(Card card)
    {
        string[] ranks = {"ACE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE",
                          "TEN", "JACK", "QUEEN", "KING"};

        string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
        //    deck = new Card[NumberOfCards];

        //    for(int i=0; i< deck.Length; i++)
        //        deck[i] = new Card(rank[i % 11], suits[i / 13]);
        //}
        foreach (string rank in ranks)
        {
            foreach (string suit in suits)
            {
                _frenchDeck.Add(new Card(rank, suit));
            }
        }
    }

    public void PrintDeck()
    {
        foreach (Card card in Deck)
        {
            card.PrintCard();
        }
    }
}