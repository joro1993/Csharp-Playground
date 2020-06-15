using System;
using System.Collections.Generic;

namespace backpack1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = " ";
            List<string> items = new List<string>();


            Console.WriteLine("Välkommen till ryggsäcken!");
            Console.ReadLine();
            while (input != "5") 
            {

                Console.WriteLine();
                Console.WriteLine("[1] Lägg till ett föremål.");
                Console.WriteLine("[2] Skriv ut innehållet.");
                Console.WriteLine("[3] Ta bort senaste");
                Console.WriteLine("[4] Rensa innehållet");
                Console.WriteLine("[5] Avsluta");
                Console.WriteLine();
                Console.WriteLine("Välj: ");

                input = Console.ReadLine();
                Console.Clear();

                if (input == "1")
                {


                    if (items.Count < 6)
                    {

                        Console.WriteLine("Vad vill du lägga in i väskan?");
                        string thingsToAdd = Console.ReadLine();
                        items.Add(thingsToAdd);
                        Console.Clear();
                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Det får inte plats mer i väskan, tyvärr! Vill du rensa väskan? Tryck 3 i menyn.");
                        Console.ReadLine();
                        Console.Clear();
                    }

                }
                else if (input == "2")
                {
                    Console.WriteLine("Du har lagt in detta i väskan:");

                    foreach (string list in items)
                    {
                        Console.WriteLine(list);
                    }
                    Console.ReadLine();
                    Console.Clear();
                }

                else if (input == "3")
                {
                    items.RemoveAt(items.Count - 1);
                    Console.Clear();
                    Console.WriteLine("Du har tagit bort senaste föremålet.");
                    Console.ReadLine();
                }

                else if (input == "4")
                {

                    items.Clear();
                    Console.Clear();
                    Console.WriteLine("Du har nu rensat din väska! Vill du lägga till nytt, tryck 1 i menyn.");
                    Console.WriteLine("Vill du avsluta, tryck 5 i menyn");
                    Console.ReadLine();

                }

                else if (input == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Programmet avslutas!");
                }
            }
        }
    }
}
