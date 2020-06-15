using System;

namespace count2Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ett nummer: ");
            string inmatat;
            inmatat = Console.ReadLine();
            int mittNr = int.Parse(inmatat);
            Console.WriteLine("Mata in ett annat nummer: ");
            inmatat = Console.ReadLine();
            int mittAndraNr = int.Parse(inmatat);
            Console.WriteLine("Summan av talen blir: " + (mittNr + mittAndraNr));

            Console.ReadLine();
        }
    }
}
