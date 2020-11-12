using System;
namespace Program
{
    class People
    {
        static void Main(string[] args)
        {
            string ask, change;
            Console.WriteLine("Enter the sentence...");
            ask = Console.ReadLine();
            if (ask.Contains("a"))
            {
                change = ask.Replace("a", "u");
                Console.WriteLine("The result: " + change);
            }
            else
            {
                Console.WriteLine("Try one more time.");

            }
        }
    }
}