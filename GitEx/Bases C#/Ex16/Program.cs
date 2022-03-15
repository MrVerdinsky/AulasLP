using System;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z = 0;
            Console.WriteLine("Input 1st number to add:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Input 2nd number to add:");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Input number to confirm Sum:");
            z = int.Parse(Console.ReadLine());

            if (x + y == z) Console.WriteLine("Its possible :) ");
            else Console.WriteLine("Its impossible :(");

        }
    }
}
