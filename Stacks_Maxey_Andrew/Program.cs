using System;
using System.Collections.Generic;

namespace Stacks_Maxey_Andrew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card[] myCardsArray = new Card[]
            {
                new Card("Ace", "Spades"),
                 // get the first word in the sentence and assigns it to Number so for this one it will be "A"
                new Card("Jack", "Clubs"),
                new Card("Q", "Diamonds"),
                new Card("Q", "Hearts"),
                new Card("10", "Hearts"),
                new Card("2", "Diamonds"),
                new Card("6", "Spades"),
                new Card("9", "Clubs"),
                new Card("A", "Diamonds"),
            };

            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);

            Console.WriteLine("Cards in Deck:");
            foreach(Card card in startingDeck)
            {// so now you are calling the card object with the number value being called and because A is now reffered to as number it will print A
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");

            List<Card> myHand = new List<Card>();
            myHand.Add(new Card("Jack", "Diamonds"));
            myHand.Add(new Card("8", "Hearts"));
            myHand.Add(new Card("3", "Diamonds"));

            Console.WriteLine("Got any 8's?");
            if(startingDeck.Count > 0)
            {
                myHand.Add(startingDeck.Pop());
            }

            Console.WriteLine($"Cards in the stack: {startingDeck.Count}");

            startingDeck.Push(myHand[0]);
            myHand.RemoveAt(0);

            Console.WriteLine("Cards in Deck:");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

        }
    }
}