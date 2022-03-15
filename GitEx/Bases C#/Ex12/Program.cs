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
                int result = 0;

                bool valueV1 = false;
                bool valueV2 = false;

                //Cycle that checks for 1st value validity
                while (!valueV1)
                {
                    Console.Write("Please input 1st Value: ");
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
                    Console.Write("Please input 2nd Value: ");
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

                //Sums both values inputted by user
                result = v1 + v2;

                Console.WriteLine($"You inputted: {v1} + {v2} = {result}");
                Console.WriteLine("");
            }
        }
    }
}
