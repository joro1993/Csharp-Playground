using System;
using System.Collections.Generic;

namespace fiveAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Nämn ett djur");
            string userInput1 = Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("Nämn ett andra djur:");
            string userInput2 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Nämn ett tredje djur:");
            string userInput3 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Nämn ett fjärde djur:");
            string userInput4 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Nämn ett femte djur:");
            string userInput5 = Console.ReadLine();
            Console.Clear();

            List<string> lista = new List<string>();

            lista.Add(userInput1);
            lista.Add(userInput2);
            lista.Add(userInput3);
            lista.Add(userInput4);
            lista.Add(userInput5);

            Console.Clear();

            Console.WriteLine("Detta är dem fem djuren som du valde: ");
            Console.WriteLine();

            foreach (string fiveAnimals in lista)
            {
                Console.WriteLine(fiveAnimals);

                Console.WriteLine();

            }
            Console.ReadLine();
            

        }
    }
}