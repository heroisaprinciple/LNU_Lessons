using System;
namespace Program
{
    class People
    {
        static void Main(string[] args)
        {
            String first, second, first_lower, second_lower;
            Console.WriteLine("Enter the first name.");
            first = Console.ReadLine();
            Console.WriteLine("Enter the second name.");
            second = Console.ReadLine();
            first_lower = first;
            first_lower = first.ToLower();
            Console.WriteLine("The Lowercase of the first name is: " + first_lower);
            second_lower = second;
            second_lower = second.ToLower();
            Console.WriteLine("The Lowercase of the second name is: " + second_lower);

        }
    }
}