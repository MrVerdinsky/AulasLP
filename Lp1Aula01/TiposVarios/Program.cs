using System;
using System.Text;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //INT Variables
            int x = 1;
            int y = 2;
            int z = 3;

            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");
            Console.WriteLine($"Z = {z}");
            Console.WriteLine("");

            //CHAR Variables
            char a = '\u2651';
            char b = '\u264B';
            char c = '\u264F';

            Console.WriteLine($"1st Letter = {a}");
            Console.WriteLine($"2nd Letter = {b}");
            Console.WriteLine($"3rd Letter = {c}");
            Console.WriteLine("");

            //Real Variables
            float thisFloat = 2.234f;
            double thisDouble = 1.4325;
            decimal thisDecimal = 0.32432444m;

            Console.WriteLine($"This is a Float: {thisFloat}");
            Console.WriteLine($"This is a Double: {thisDouble}");
            Console.WriteLine($"This is a Decimal: {thisDecimal}");
            Console.WriteLine("");

            //Bool Variables
            bool isTrue = 5 > 3;
            bool isFalse = 4 < 2;

            Console.WriteLine($"5 is bigger then 3? R: {isTrue}");
            Console.WriteLine($"4 is smaller then 2? R: {isFalse}");
            Console.WriteLine("");
        }
    }
}
