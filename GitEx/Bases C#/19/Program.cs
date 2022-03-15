using System;

namespace Ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 0f;
            float y = 0f;
            string print = "";
            Console.WriteLine("Input 1st Number:");
            x = float.Parse(Console.ReadLine());

            Console.WriteLine("Input 2nd Number:");
            y = float.Parse(Console.ReadLine());

            Console.WriteLine($"HighScore: {x}");
            Console.WriteLine($"Score: {y}");

           print = x < y ? "New Highscore" : "Keep Trying!";
           
           Console.WriteLine(print);
        }
    }
}
