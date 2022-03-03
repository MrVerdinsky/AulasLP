using System;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable used in the input cycle
            bool x = true;


            Console.WriteLine("Write 'exit' to close program");
            Console.WriteLine("");

            //Cycle used to keep asking the user while "exit" is not written
            while (x)
            {
                int v1 = 0;
                int v2 = 0;

                bool valueV1 = false;
                bool valueV2 = false;

                //Cycle that checks for 1st value validity
                while (!valueV1)
                {
                    Console.Write("Please input Height size: ");
                    string input = Console.ReadLine();

                    //Checks if player wrote exit and exits the app
                    if (input == "exit")
                    {
                        Console.WriteLine("Bye bye!");
                        System.Environment.Exit(0);
                    }

                    //Trys to convert the user input into an int
                    //If its invalid prints warning and asks for input again
                    else if (!int.TryParse(input, out v1))
                    {
                        Console.WriteLine("Invalid Value");
                    }
                    else
                    {
                        valueV1 = true;
                    }

                }

                //Cycle that checks for 2nd value validity
                while (!valueV2)
                {
                    Console.Write("Please input Radius size: ");
                    string input = Console.ReadLine();

                    //Checks if player wrote exit and exits the app
                    if (input == "exit")
                    {
                        Console.WriteLine("Bye bye!");
                        System.Environment.Exit(0);
                    }

                    //Trys to convert the user input into an int
                    //If its invalid prints warning and asks for input again
                    else if (!int.TryParse(input, out v2))
                    {
                        Console.WriteLine("Invalid Value");
                    }
                    else
                    {
                        valueV2 = true;
                    }

                }

                

                Console.WriteLine("");
                Console.WriteLine("Your cilinder has this values:");
                Console.WriteLine($"    Height: {v1}");
                Console.WriteLine($"    Radius: {v2}");
                Console.WriteLine("");
                Console.WriteLine($"It's volume is: {Math.PI} * {Math.Pow(v2,2)} * {v1} = {Math.PI * Math.Pow(v2, 2) * v1}");
                Console.WriteLine("");
            }
        }
    }
}
