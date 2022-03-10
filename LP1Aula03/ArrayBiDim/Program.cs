using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cycle that controls the application
            while (true)
            {
                //Variables used to control input cycles
                bool validX = false;
                bool validY = false;
                bool validArrayValue = false;

                //Variables that hold Array information
                int inputX = 0;
                int inputY = 0;

                //Variable that holds value cell input
                float arrayValue = 0;

                //Array Variable
                float[,] biArray;

                //Variables used to calculate and display Avgs
                float lineAvg = 0;
                float sumAllAvgs = 0;

                //Cycle that ask user for X Dimensons of the Array and validates it
                while (!validX)
                {
                    Console.Write("Input value for X: ");
                    string tempInputX = Console.ReadLine();
                    if (int.TryParse(tempInputX, out inputX))
                    {
                        validX = true;
                    }
                    else Console.WriteLine("Invalid Input");
                }

                //Cycle that ask user for Y Dimensons of the Array and validates it
                while (!validY)
                {
                    Console.Write("Input value for Y: ");
                    string tempInputY = Console.ReadLine();
                    if (int.TryParse(tempInputY, out inputY))
                    {
                        validY = true;
                    }
                    else Console.WriteLine("Invalid Input");
                }

                biArray = new float[inputX, inputY];

                //Cycle used to input a value in every cell
                //of the input array
                for (int i = 0; i < inputX; i++)
                {
                    for (int j = 0; j < inputY; j++)
                    {
                        validArrayValue = false;

                        //Cycle that asks user for value for cell and validates
                        while (!validArrayValue)
                        {
                            Console.Write($"Input value for cell ({i}, {j}): ");
                            string tempValue = Console.ReadLine();
                            if (float.TryParse(tempValue, out arrayValue))
                            {
                                validArrayValue = true;
                                biArray[i, j] = arrayValue;
                            }

                            else Console.WriteLine("Invalid Value");
                           
                        }
                       
                    }
                }

                //Displays Array Dimensons
                Console.WriteLine();
                Console.WriteLine($"X: {inputX}");
                Console.WriteLine($"Y: {inputY}");
                Console.WriteLine();

                
                //Cycle used to calculate the Avg
                //Of each line of the array
                for (int i = 0; i < inputX; i++)
                {
                    float tempValue = 0;
                    for (int j = 0; j < inputY; j++)
                    {
                        tempValue += biArray[i, j];
                    }
                    
                    lineAvg = tempValue / inputX;
                    sumAllAvgs += lineAvg;

                    Console.WriteLine($"Line {i} Avg: {lineAvg}");
                    Console.WriteLine();
                }

                //Displays the sum off all the Avgs calculated
                Console.WriteLine($"Sum of All Line Averages: {sumAllAvgs}");
                Console.WriteLine();
            }
        }
    }
}
