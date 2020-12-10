using System;
using System.Collections.Generic;

namespace Lab_5._N_3
{
    enum Month { January, February, March, April, May, June, July, August, September, October, November, December }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the number of month, but you should count month - 1 (0-11): ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"The month: {(Month)n}");
        }
    }
}