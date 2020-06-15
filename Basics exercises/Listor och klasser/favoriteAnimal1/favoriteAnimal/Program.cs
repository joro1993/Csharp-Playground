using System;

namespace favoriteAnimal
{

    

    class Dog : Animals
    {

        public string name;
        public int age;
    }

    class secondDog : Animals
    {
        public string name;
        public int age;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.name = "Idúnn";
            dog1.age = 2;
            Console.WriteLine(dog1.name + ", " + dog1.age + " år.");
            dog1.talk();

            Console.WriteLine();
            secondDog dog2 = new secondDog();
            dog2.name = "Valkyria";
            dog2.age = 3;
            Console.WriteLine(dog2.name + ", " + dog2.age + " år.");
            dog2.talk1();
            Console.ReadLine();
        }
    }
}
