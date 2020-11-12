using System;

namespace Sorting_by_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;

            Console.Write("Enter string separated by commas and spaces (e.g. \"one, two, three\"): ");
            input = Console.ReadLine().Split(", ");

            Array.Sort(input, StringComparer.InvariantCultureIgnoreCase);

            for (int i = 0; i < input.Length; i++)
            {
                if (i != input.Length - 1)
                {
                    Console.Write($"{input[i]}, ");
                }
                else
                {
                    Console.WriteLine($"{input[i]}.");
                }
            }

            Console.ReadKey();
        }
    }
}
