
using System;
using System.Collections.Generic;

namespace presentation
{

    public class Person
    {
        public string firstName;
        public string lastName;
        public string age;
        public string whereLive;
        public string whatDoing;

        }

    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("Vad heter personen i förnamn?");
            person.firstName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Vad heter personen i efternamn?");
            person.lastName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Hur gammal är personen?");
            person.age = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Vart bor personen?");
            person.whereLive = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Vad har personen för sysselsättning?");
            person.whatDoing = Console.ReadLine();
            Console.Clear();

            List<String> lista = new List<string>();
            lista.Add(person.firstName);
            lista.Add(person.lastName);
            lista.Add(person.age);
            lista.Add(person.whereLive);
            lista.Add(person.whatDoing);

            Console.WriteLine("Detta är informationen som du har angivit.");
            Console.WriteLine();

            foreach (string personList in lista)
            {
                Console.WriteLine(personList);
            }

            Console.WriteLine();
            Console.WriteLine("Klicka på Enter för att fortsätta... ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(person.firstName + " är " + person.age + " år gammal. Personens sysselsättning är " + person.whatDoing + " i " + person.whereLive + "."); 
            Console.WriteLine("Personen heter " + person.lastName + " i efternamn.");

            Console.ReadLine();
        }
    }
}