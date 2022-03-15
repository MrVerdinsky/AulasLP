using System;

namespace Ex11
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
                string reversedString = "";
                Console.Write("Please input something: ");
                string input = Console.ReadLine();

                //Cycle used to reverse input by user
                for (int i = input.Length - 1 ; i >= 0; i--)
                {
                    reversedString += input[i]; 
                }

                Console.WriteLine("");

                //Checks if the user wrote "exit" as input
                if (input == "exit")
                {
                    x = false;
                    Console.WriteLine("Bye bye!");
                }
                else
                {
                    Console.WriteLine($"You wrote this but its reversed: {reversedString}");
                    Console.WriteLine("");
                }
            }
        }
    }
}
