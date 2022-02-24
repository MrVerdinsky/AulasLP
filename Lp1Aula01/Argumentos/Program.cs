using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argument Number: {i+1} - {args[i]}");
            }
        }
    }
}
