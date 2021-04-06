using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace ProgrammingAssignment2
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 2
    /// </summary>
    class Program
    {
        /// <summary>
        /// Implements Nothing Like Blackjack functionality
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {

                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                // declare a deck variables and create a deck object
                Deck deck = new Deck();
                // DON'T SHUFFLE THE DECK

                // deal 2 cards each to 4 players (deal properly, dealing
                // the first card to each player before dealing the
                // second card to each player)
                Card cardPlayerOne1 = deck.TakeTopCard();
                Card cardPlayerTwo1 = deck.TakeTopCard();
                Card cardPlayerThree1 = deck.TakeTopCard();
                Card cardPlayerFour1 = deck.TakeTopCard();
                Card cardPlayerOne2 = deck.TakeTopCard();
                Card cardPlayerTwo2 = deck.TakeTopCard();
                Card cardPlayerThree2 = deck.TakeTopCard();
                Card cardPlayerFour2 = deck.TakeTopCard();

                // deal 1 more card to players 2 and 3
                Card cardPlayerTwo3 = deck.TakeTopCard();
                Card cardPlayerThree3 = deck.TakeTopCard();
                // flip all the cards over
                cardPlayerOne1.FlipOver();
                cardPlayerTwo1.FlipOver();
                cardPlayerThree1.FlipOver();
                cardPlayerFour1.FlipOver();
                cardPlayerOne2.FlipOver();
                cardPlayerTwo2.FlipOver();
                cardPlayerThree2.FlipOver();
                cardPlayerFour2.FlipOver();
                cardPlayerTwo3.FlipOver();
                cardPlayerThree3.FlipOver();
                // print the cards for player 1
                Console.WriteLine(cardPlayerOne1.Rank + "," + cardPlayerOne1.Suit);
                Console.WriteLine(cardPlayerOne2.Rank + "," + cardPlayerOne2.Suit);
                // print the cards for player 2
                Console.WriteLine(cardPlayerTwo1.Rank + "," + cardPlayerTwo1.Suit);
                Console.WriteLine(cardPlayerTwo2.Rank + "," + cardPlayerTwo2.Suit);
                Console.WriteLine(cardPlayerTwo3.Rank + "," + cardPlayerTwo3.Suit);
                // print the cards for player 3
                Console.WriteLine(cardPlayerThree1.Rank + "," + cardPlayerThree1.Suit);
                Console.WriteLine(cardPlayerThree2.Rank + "," + cardPlayerThree2.Suit);
                Console.WriteLine(cardPlayerThree3.Rank + "," + cardPlayerThree3.Suit);
                // print the cards for player 4
                Console.WriteLine(cardPlayerFour1.Rank + "," + cardPlayerFour1.Suit);
                Console.WriteLine(cardPlayerFour2.Rank + "," + cardPlayerFour2.Suit);
                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }
    }
}
