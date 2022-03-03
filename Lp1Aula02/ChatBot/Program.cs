using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {

            string response;
            while(true)
            {
                Console.WriteLine("Ask something to our AI:");
                string question = Console.ReadLine();
                if (question == "EXIT")
                    break;
                else
                {
                    switch (question)
                    {
                        case "Who are you?":
                            response = "I am Gladys";
                            break;

                        case "What is your purpose?":
                            response = "Test human subjects";
                            break;

                        case "Are you a good AI?":
                            response = "Well depends on the POV :)";
                            break;

                        case "Can I leave?":
                            response = "No.";
                            break;
                        default:
                            response = "There's a protocol breach, I now have to kill you.";
                            break;
                    }
                    Console.WriteLine(response);
                    Console.WriteLine("");
                }
               
            }
            Console.WriteLine("You can't escape me.....");
        }
    }
}
