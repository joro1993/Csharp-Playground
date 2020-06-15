using System;

namespace welcomeMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hejsan! Vad är ditt namn?");
            Console.WriteLine();

            string namn = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Välkommen hit " + namn + ".");
            Console.ReadLine();
        }
    }
}
