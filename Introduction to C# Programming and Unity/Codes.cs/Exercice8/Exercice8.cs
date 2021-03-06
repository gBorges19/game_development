using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    /// <summary>
    /// Exercise 8 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates rolling and using two dice
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // initialize random number generator
            RandomNumberGenerator.Initialize();

            // create two dice
            Die dieOne = new Die();
            Die dieTwo = new Die();
            // tell the dice to roll themselves
            dieOne.Roll();
            dieTwo.Roll();
            // print the top sides and the sum of the dice
            Console.WriteLine("Die1: " + dieOne.TopSide);
            Console.WriteLine("Die2: " + dieTwo.TopSide);
            int sum = dieOne.TopSide + dieTwo.TopSide;
            Console.WriteLine("Sum: " + sum);

            Console.WriteLine();
        }
    }
}