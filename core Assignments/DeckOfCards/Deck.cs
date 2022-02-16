using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        string[] stringCards = new string[]
        {"Ace", "2", "3", "4", "5", "6", "7","8", "9", "10", "Jack", "Queen", "King"};

        string[] suits = new string []
        {"Hearts", "Clubs", "Spades", "Diamonds"};

        public List<Card> cards = new List<Card>();


        public void reMake()
        {
            for (int face = 0; face < stringCards.Length; face++)
            {
                for (int suit = 0; suit < suits.Length; suit++)
                {
                    Card myCard = new Card(stringCards[face], suits[suit], face + 1);
                    cards.Add(myCard);
                }
            }
        }
        public Card remove()
        {
            Card HoC = cards[cards.Count-1];
            cards.Remove(HoC);
            return HoC;
        }
        public void print()
        {
            for(int i = 0; i<cards.Count; i++)
            {
                cards[i].print();
            }
        }
        public void Shuffle()
        {
            Random rand = new Random();
            for (int s = 0; s< 2000; s++)
            {
                Card thisCard = cards[rand.Next(0,51)];
                cards.Remove(thisCard);
                cards.Add(thisCard);
            }

            /*
            loop through the deck
            grab a random card from the deck
            //random index of the deck
            call remove function
            insert random card ontop
            keep doing that throughout the whole deck
            */
        }
        public Deck()
        {
            reMake();
        }
    }
}