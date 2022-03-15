using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int nLevels;
            Console.Write("How many levels does the pyramid have?");
            string input = Console.ReadLine();
            if (int.TryParse(input, out nLevels))
            {
                
                for (int i = 0; i < nLevels; i++)
                {
                    if (i % 3 == 0)
                    {
                        for (int j = 1; j <= i; j++)
                        {

                            Console.Write("*");
                        }
                    }
                    Console.WriteLine("*");

                }
            }
            
        }
    }
}
