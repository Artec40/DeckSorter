using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Deck> deckCollection = new Dictionary<string, Deck>();

            Deck standart52Deck = new Deck("StandartDeck", 52);
            standart52Deck.FillTheDeck();
            deckCollection.Add("52 deck", standart52Deck);

            Deck standart36Deck = new Deck("StandartDeck", 36);
            standart36Deck.FillTheDeck();
            deckCollection.Add("36 deck", standart36Deck);

            Deck standart32Deck = new Deck("StandartDeck", 32);
            standart32Deck.FillTheDeck();
            deckCollection.Add("32 deck", standart32Deck);

            foreach (KeyValuePair<string, Deck> keyValue in deckCollection)
            {
                Console.WriteLine(keyValue.Key);
            }
        }
    }
}
