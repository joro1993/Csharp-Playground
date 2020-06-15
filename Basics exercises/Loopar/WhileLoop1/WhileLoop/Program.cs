using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (true)
            {

                i++;

                if (i > 10)
                    break;
                Console.WriteLine(i);
            }
        }
    }
}
