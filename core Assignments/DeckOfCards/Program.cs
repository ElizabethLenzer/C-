using System;

namespace DeckOfCards
{
    class Card
    {
        public string Name { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }

        public Card { }
        public Card (string name, string suit,)
        {
            Name = name;
            suit = suit;
            Value = ValueTuple;
        }
        public override string ToString()
        {
            return $@"
            Name : {Name}
            Suit: {Suit}
            Value: {Value}';
        }
    }
}