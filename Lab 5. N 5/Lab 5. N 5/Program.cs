using System;
using System.Collections.Generic;

namespace Lab_5._N_5
{
    public enum LongRange : long { Max = 9223372036854775807, Min = -9223372036854775808 }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Max value of LongRange: {(long)LongRange.Max}");
            Console.WriteLine($"Min value of LongRange: {(long)LongRange.Min}");
        }
    }
}