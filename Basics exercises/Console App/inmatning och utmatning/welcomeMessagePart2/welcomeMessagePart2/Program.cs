using System;

namespace welcomeMessagePart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hejsan, vänligen ange ditt förnamn: ");
            Console.WriteLine();
            string fNamn = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Vänligen ange ditt efternamn: ");
            Console.WriteLine();
            string eNamn = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Välkommen hit " + fNamn + " " + eNamn + ".");
            Console.ReadLine();
        }
    }
}
