using System;

namespace NameAndAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du?");
            string namn;
            namn = Console.ReadLine();
            Console.WriteLine("Välkommen! Hur gammal är du, " + namn + "?");

            string age;
            age = Console.ReadLine();
            Console.WriteLine("Du är " + age + " år gammal.");

            int daysAlive = Convert.ToInt32(age) * 356;
            Console.WriteLine("Du har levt i " + daysAlive + " dagar.");

            Console.ReadLine();
  

        }
    }
}
