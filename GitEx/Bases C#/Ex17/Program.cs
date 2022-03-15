using System;

namespace Ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Input a number:");
            x = int.Parse(Console.ReadLine());

            if (x % 3 == 0 && x % 5 == 0)
            {
                Console.WriteLine("FizzBuzz!");
            }
            else if (x % 5 == 0) Console.WriteLine("Buzz!");
            else if (x % 3 == 0) Console.WriteLine("Fizz!");
            else Console.WriteLine($"{x}!");
        }
    }
}
