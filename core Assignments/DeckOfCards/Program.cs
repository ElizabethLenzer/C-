using System;

namespace DeckOfCards
{
    class program
    {
        static void Main(string[] args)
        {
            Deck NewDeck = new Deck();  
            // Card RemoveCard = NewDeck.remove();
            // RemoveCard.print();
            NewDeck.Shuffle();
            NewDeck.print();
        }
    }
}