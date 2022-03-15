using System;

namespace SkynetPatternSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ask something to the AI:");
            string question = Console.ReadLine();

            string response = question switch
            {
                "How are you?" => "I’m fine, thank you",
                "What’s your name?" => "Skynet",
                "What’s your mission?" => "Destroy mankind!",
                _ => "You got me, I’m not THAT smart!"
            };
            Console.WriteLine(response);
        }
    }
}
