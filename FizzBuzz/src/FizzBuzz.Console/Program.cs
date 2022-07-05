using System;

namespace FizzBuzz.App
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 100; i++)
            {
                Console.WriteLine("{0}", FizzBuzz.CheckInput(i));
            }

            Console.ReadKey();
        }
    }
}
