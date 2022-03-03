﻿using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            //All type Min Values
            byte a = byte.MinValue;
            short b = short.MinValue;
            int c = int.MinValue;
            long d = long.MinValue;
            double e = double.MinValue;
            float f = float.MinValue;
            char g = char.MinValue;

            //All type Max Values
            byte a2 = byte.MaxValue;
            short b2 = short.MaxValue;
            int c2 = int.MaxValue;
            long d2 = long.MaxValue;
            double e2 = double.MaxValue;
            float f2 = float.MaxValue;
            char g2 = char.MaxValue;

            Console.WriteLine("Min Values of all Types:");
            Console.WriteLine($"    Byte Min Value is: {a}");
            Console.WriteLine($"    Short Min Value is: {b}");
            Console.WriteLine($"    Int Min Value is: {c}");
            Console.WriteLine($"    Long Min Value is: {d}");
            Console.WriteLine($"    Double Min Value is: {e}");
            Console.WriteLine($"    Float Min Value is: {f}");
            Console.WriteLine($"    Char Min Value is: {g}");
            Console.WriteLine("");
            Console.WriteLine("Max Values of all Types:");
            Console.WriteLine($"    Byte Max Value is: {a2}");
            Console.WriteLine($"    Short Max Value is: {b2}");
            Console.WriteLine($"    Int Max Value is: {c2}");
            Console.WriteLine($"    Long Max Value is: {d2}");
            Console.WriteLine($"    Double Max Value is: {e2}");
            Console.WriteLine($"    Float Max Value is: {f2}");
            Console.WriteLine($"    Char Max Value is: {g2}");
            Console.WriteLine("");

            //Special Values Float
            float minusInf = float.NegativeInfinity;
            float maxInf = float.PositiveInfinity;
            float notAN = float.NaN;
            Console.WriteLine("Special Values Float:");
            Console.WriteLine($"Float Negative Infinity: {minusInf}");
            Console.WriteLine($"Float Positive Infinity {maxInf}");
            Console.WriteLine($"Float Not a Number: {notAN}");
            Console.WriteLine("");

            //Special Values Double
            double minusInfD = double.NegativeInfinity;
            double maxInfD = double.PositiveInfinity;
            double notAND = double.NaN;
            Console.WriteLine("Special Values Double:");
            Console.WriteLine($"Double Negative Infinity: {minusInfD}");
            Console.WriteLine($"Double Positive Infinity {maxInfD}");
            Console.WriteLine($"Double Not a Number: {notAND}");
        }
    }
}
