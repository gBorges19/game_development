using System;

namespace Exercice15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("∗∗∗∗∗∗∗∗∗∗∗∗∗∗");
            Console.WriteLine();
            Console.WriteLine("Menu: ");
            Console.WriteLine();
            Console.WriteLine("1 - NewGame");
            Console.WriteLine();
            Console.WriteLine("2 - LoadGame");
            Console.WriteLine();
            Console.WriteLine("3 - Options");
            Console.WriteLine();
            Console.WriteLine("4 - Quit");
            Console.WriteLine();
            Console.WriteLine("∗∗∗∗∗∗∗∗∗∗∗∗∗∗");
            Console.WriteLine();
            Console.WriteLine("Enter your choice (1, 2, 3 or 4): ");

            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                Console.WriteLine("Creating New Game . . .");
            }
            else if (escolha == 2)
            {
                Console.WriteLine("Loading Game . . .");
            }
            else if (escolha == 3)
            {
                Console.WriteLine("Setting Options . . .");
            }
            else if (escolha == 4)
            {
                Console.WriteLine("Leaving the Game . . .");

            }
            else
            {
                Console.WriteLine("DORK!!!");
            }

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Creating New Game . . .");
                    break;
                case 2:
                    Console.WriteLine("Loading Game . . .");
                    break;
                case 3:
                    Console.WriteLine("Setting Options . . .");
                    break;
                case 4:
                    Console.WriteLine("Leaving the Game . . .");
                    break;
                default:
                    Console.WriteLine("DORK!!!");
                    break;
            }

            Console.WriteLine();
        }
    }
}
