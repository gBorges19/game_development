using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            double originalTempFahrenheit = 32;
            double originalTempCelsius = 32;
            double calculatedTempCelsius;
            double calculatedTempFahrenheit;

            calculatedTempCelsius = (((originalTempFahrenheit - 32) / 9) * 5);
            calculatedTempFahrenheit = (((originalTempCelsius * 9) / 5) + 32);

            Console.WriteLine("Fahrenheit: " + calculatedTempFahrenheit);
            Console.WriteLine();
            Console.WriteLine("Celsius: " + calculatedTempCelsius);
        }
    }
}
