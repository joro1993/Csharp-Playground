using System;

namespace LoopThree
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("skriv in en text du vill fördubbla");
            string text = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Tryck på valfri knapp förutom Q för att fördubbla texten");
            Console.WriteLine("Tryck på Q för att avsluta programmet");
            Console.WriteLine("Tryck på enter för att starta programmet!");
            Console.ReadLine();
            Console.Clear();


            string answer = "";
            int lines = 1;

            while (answer != "q".ToUpper())
            {
                for (int i = 1; i <= lines; i++)
                {
                    Console.WriteLine(text);
                }

                Console.WriteLine();
                Console.WriteLine("Fördubblat med " + lines);
                lines *= 2;
                answer = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
