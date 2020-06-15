using System;

namespace convert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett decimaltal: ");
            string inmatat;
            inmatat = Console.ReadLine();
            double decimalTal = double.Parse(inmatat);
            Console.WriteLine($"Resultatet blir efter konvertering till heltal: {decimalTal:N0}");

            Console.ReadLine();
        }
    }
}
