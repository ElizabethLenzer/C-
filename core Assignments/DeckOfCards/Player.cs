using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        public string Name {get; set;}
        // get set is default behavior and just gets data how it is and set sets data how it comes in
        // get a function that allows you to control how you receive data from the property Variable inside a class
        // get changes how the data retrieved
        // set changes how the data is saved
        public List<Card> Hand = new List<Card>();
        public Player (string name)
        {
            Name = name;
        }
        // Draw Method
        public Card Draw (Deck deck, Player player)
        {
            string currentPlayer = player.Name;
            Card = newCard = deck.Deal();
            Console.WriteLine($"{currentPlayer} drew {newCard.StringValue} of {newCard.Suit}");
            Hand.Add(newCard);
            return newCard
        }
        // Discard Method
        public Card Discard(int card)
        {
            if (Hand[card] != null)
            {
                Card toDiscard = Hand[card];
                Hand.Remove(toDiscard);
                return toDiscard;
            }
            return null;
        }
    }
}