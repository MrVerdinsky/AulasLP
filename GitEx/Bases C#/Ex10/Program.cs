using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            Console.WriteLine("Write 'exit' to close program");
            Console.WriteLine("");
            while (x)
            {
                
                Console.Write("Please input something: ");
                string input = Console.ReadLine();
                Console.WriteLine("");
                if (input == "exit")
                {
                    x = false;
                    Console.WriteLine("Bye bye!");
                }
                else
                {
                    Console.WriteLine($"You wrote this: {input}");
                    Console.WriteLine("");
                } 
            }
        }

    }
}
