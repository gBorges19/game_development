using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Console.WriteLine("Enter angle in degrees: ");
            float angle = float.Parse(Console.ReadLine());
            angle = (float)(Math.PI / 180);
            float cosine = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);

            Console.WriteLine("Cos : " + cosine);
            Console.WriteLine("Sin : " + sin);
        }
    }
}
