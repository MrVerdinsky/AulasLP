using System;
using System.Text;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Normal String
            string s = "Um tab\t e um copyright \u03A9";

            Console.WriteLine($"This is a normal string = {s}");
            Console.WriteLine("");

            //String Verbatim
            string v1 = @"C:\Users\MrVerdinsky\Documents";
            string v2 = @"Nao e’ um codigo Unicode \u1234, nao e’ nova linha \n";

            Console.WriteLine($"This is a verbatim string = {v1}");
            Console.WriteLine($"This is a another verbatim string = {v2}");
            Console.WriteLine("");

            //Strings normais e verbatim
            string nV1 = "\"Esta string esta ’ entre aspas\"";
            string nV2 = @"""Esta string esta ’ entre aspas""";

            Console.WriteLine($"This is a normal and a verbatim string = {nV1}");
            Console.WriteLine($"This is a another normal and verbatim string = {nV2}");
            Console.WriteLine("");

            //String Concatenation
            int x = 5;
            string a = "This is number two: " + 2;
            string b = "This is number five: " + x;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("");

            //String Interpolation
            int y = 67;
            string c = $"valor de X e’ {x}";
            string d = $"{x} mais {y} e’ igual a {x + y}";

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine("");

            //String Interpolation with String.Format
            string f = String.Format("Y e’ {1}, X e’ {0}", x, y);

            Console.WriteLine(f);
            Console.WriteLine("");

            //String Interpolation with Verbatim
            Console.WriteLine(@"Verbatim com x = {0}", x);
            Console.WriteLine("");

            //String Format
            double xx = 0.12345;
            int ii = 18;

            Console.WriteLine($"XX has 2 Decimal points: {xx:f2}");
            Console.WriteLine($"XX has 1 Decimal points and is %: {xx:p1}");
            Console.WriteLine($"II has Hexadecimal: {ii:x}");
            Console.WriteLine($"II with Currency: {ii:c}");


        }
    }
}
