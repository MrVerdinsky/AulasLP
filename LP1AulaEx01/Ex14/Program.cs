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
                int v3 = 0;
                int result = 0;

                bool valueV1 = false;
                bool valueV2 = false;
                bool valueV3 = false;

                //Cycle that checks for 1st value validity
                while (!valueV1)
                {
                    Console.Write("Please input Length size: ");
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
                    Console.Write("Please input Heigth size: ");
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

                while (!valueV3)
                {
                    Console.Write("Please input Width size: ");
                    string input = Console.ReadLine();

                    //Checks if player wrote exit and exits the app
                    if (input == "exit")
                    {
                        Console.WriteLine("Bye bye!");
                        System.Environment.Exit(0);
                    }

                    //Trys to convert the user input into an int
                    //If its invalid prints warning and asks for input again
                    else if (!int.TryParse(input, out v3))
                    {
                        Console.WriteLine("Invalid Value");
                    }
                    else
                    {
                        valueV3 = true;
                    }

                }

                Console.WriteLine("");
                Console.WriteLine("Your box has this values:");
                Console.WriteLine($"    Length: {v1}");
                Console.WriteLine($"    Heigth: {v2}");
                Console.WriteLine($"    Width: {v3}");
                Console.WriteLine("");
                Console.WriteLine($"It's volume is: {v1} * {v2} * {v3} = {v1*v2*v3}");
                Console.WriteLine("");
            }
        }
    }
}
