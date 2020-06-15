using System;

namespace ifSatser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Är det fint väder?");
            string answer;

            answer = Console.ReadLine();
            if (answer == "J")
            {
                Console.WriteLine("Gå ut på en picknick!");
            }
            else if (answer == "j")
            {
                Console.WriteLine("Gå ut på en picknick!");
            }

            else if (answer == "N")
            {
                Console.WriteLine("Du borde stanna hemma och läsa en bok om programmering!");
            }
            else if (answer == "n")
            {
                Console.WriteLine("Du borde stanna hemma och läsa en bok om programmering!");
            }
            else
            {
                Console.WriteLine("Jag Förstår inte riktigt!");
            }

            Console.ReadLine();
        }
    }
}
