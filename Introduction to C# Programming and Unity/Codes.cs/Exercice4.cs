using System;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstAltitude;
            int secondAltitude;
            int distance;

            Console.WriteLine();
            Console.WriteLine("Enter first altitude : ");
            firstAltitude = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter second altitude : ");
            secondAltitude = int.Parse(Console.ReadLine());
            Console.WriteLine();

            distance = secondAltitude - firstAltitude;
            Console.WriteLine("first point to the second point: " + distance);
            Console.WriteLine();
        }
    }
}
