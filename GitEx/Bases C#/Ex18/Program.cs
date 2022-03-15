using System;

namespace Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int charCounter = 0;
            Console.WriteLine("Input String:");
            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                charCounter++;
            }

            if (charCounter > 20)
            {
                Console.WriteLine("Lol Too long didnt read!");
            }
            else if (charCounter > 5 && charCounter < 20)
            {
                Console.WriteLine("Ok, if you say so");
            }
            else
            {
                Console.WriteLine("Thats not very meanigful, is it?");
            }
        }
    }
}
