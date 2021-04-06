using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Skydome
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deckPlayerOne = new Deck();
            Deck deckPlayerTwo = new Deck();

            deckPlayerOne.Print();
            Console.WriteLine();
            deckPlayerTwo.Print();
            Console.WriteLine();
            Console.WriteLine();

            deckPlayerOne.Shuffle();
            deckPlayerTwo.Shuffle();

            deckPlayerOne.Print();
            Console.WriteLine();
            deckPlayerTwo.Print();
            Console.WriteLine();

            Card cardPlayerOne1 = deckPlayerOne.TakeTopCard();
            Card cardPlayerOne2 = deckPlayerOne.TakeTopCard();
            Card cardPlayerOne3 = deckPlayerOne.TakeTopCard();
            Card cardPlayerOne4 = deckPlayerOne.TakeTopCard();
            Card cardPlayerOne5 = deckPlayerOne.TakeTopCard();

            Card cardPlayerTwo1 = deckPlayerTwo.TakeTopCard();
            Card cardPlayerTwo2 = deckPlayerTwo.TakeTopCard();
            Card cardPlayerTwo3 = deckPlayerTwo.TakeTopCard();
            Card cardPlayerTwo4 = deckPlayerTwo.TakeTopCard();
            Card cardPlayerTwo5 = deckPlayerTwo.TakeTopCard();

            Console.WriteLine();
            Console.WriteLine("Player One pick: " + cardPlayerOne1.Rank + " " + cardPlayerOne1.Suit);
            Console.WriteLine(cardPlayerOne2.Rank + " " + cardPlayerOne2.Suit);
            Console.WriteLine(cardPlayerOne3.Rank + " " + cardPlayerOne3.Suit);
            Console.WriteLine(cardPlayerOne4.Rank + " " + cardPlayerOne4.Suit);
            Console.WriteLine(cardPlayerOne5.Rank + " " + cardPlayerOne5.Suit);
            Console.WriteLine();
            Console.WriteLine("Player Two pick: " + cardPlayerTwo1.Rank + " " + cardPlayerTwo1.Suit);
            Console.WriteLine(cardPlayerTwo2.Rank + " " + cardPlayerTwo2.Suit);
            Console.WriteLine(cardPlayerTwo3.Rank + " " + cardPlayerTwo3.Suit);
            Console.WriteLine(cardPlayerTwo4.Rank + " " + cardPlayerTwo4.Suit);
            Console.WriteLine(cardPlayerTwo5.Rank + " " + cardPlayerTwo5.Suit);
            Console.WriteLine();
            Console.WriteLine("Quem é o vencedor?");
        }
    }
}
