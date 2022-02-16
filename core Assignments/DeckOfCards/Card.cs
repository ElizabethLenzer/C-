using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Card
    {
        public string StringValue { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }
        
        public Card (String faceValue, string suitValue, int value)
        {
            StringValue = faceValue;
            Suit = suitValue;
            Value = value;
        }
        public void print()
        {
            Console.WriteLine($"{StringValue} of {Suit}");
        }
    }
}
