using System;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You used this arguments:");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argument {i+1}: {args[i]}");
            }
            
        }
    }
}
