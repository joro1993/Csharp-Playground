using System;

namespace shortStory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange förnamn för karaktär 1:");
            string charName1 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ange efernamn för karaktär 1:");
            string charLastName1 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ange förnamn för karaktär 2:");
            string charName2 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ange efternamn för karaktär 2:");
            string charLastName2 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Dina två karaktärer heter " + charName1 + " " + charLastName1 + " och " + charName2 + " " + charLastName2 + ".");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(charName1 + " " + charLastName1 + " var ute och gick med sin hund, det var en varm och fin sommardag.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(charName1 + " tänkte att det vore ju roligt att låta hunden springa runt! Det är ju trotsallt en vinthund han har.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Sedan kom " + charName1 + "'s" + " kompis " + charName2 + " " + charLastName2 + " och dem hälsade på varandra!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("'Vad fin din hund är, " + charName1 + ".'" + " Sade " + charName2 + ".");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("'Tack " + charName2 + "'" + "Svarade " + charName1 + ".");
            Console.ReadLine();

        }
    }
}
