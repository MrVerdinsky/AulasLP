using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 0;

            //Displays a Suffix operation information on screen
            Console.WriteLine("Values before suffix operation");
            Console.WriteLine("");
            Console.WriteLine($"A Value = {a}");
            Console.WriteLine($"B Value = {b}");
            Console.WriteLine($"C Value = {c}");
            Console.WriteLine("");
            Console.WriteLine("Suffix Operation:");
            Console.WriteLine("");
            Console.WriteLine(@"c = a++ + b++");
            Console.WriteLine("");
            c = a++ + b++;
            Console.WriteLine("Values after Prefix operation:");
            Console.WriteLine("");
            Console.WriteLine($"A Value = {a}");
            Console.WriteLine($"B Value = {b}");
            Console.WriteLine($"C Value = {c}");
            Console.WriteLine("");
            // ------------------------------------------//

            //Displays a Prefix operation information on screen
            int z = 1;
            int y = 2;
            int x = 0;
            Console.WriteLine("Values before Prefix operation");
            Console.WriteLine("");
            Console.WriteLine($"Z Value = {z}");
            Console.WriteLine($"Y Value = {y}");
            Console.WriteLine($"X Value = {x}");
            Console.WriteLine("");
            Console.WriteLine("Prefix Operation:");
            Console.WriteLine("");
            Console.WriteLine(@"x = --z + --y");
            Console.WriteLine("");
            x = --z + --y;
            Console.WriteLine("Values after suffix operation:");
            Console.WriteLine("");
            Console.WriteLine($"Z Value = {z}");
            Console.WriteLine($"Y Value = {y}");
            Console.WriteLine($"X Value = {x}");
        }
    }
}
