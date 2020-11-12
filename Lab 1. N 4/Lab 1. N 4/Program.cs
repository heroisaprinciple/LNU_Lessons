using System;
namespace Number
{
    class mathematics
    {
        static void Main()
        {
            Console.WriteLine("Choose a number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The number has chosen: " + number);
            double round = Math.Round(number);
            Console.WriteLine("The ceiling of the number is: " + round);
            double floor = Math.Floor(number);
            Console.WriteLine("The floor of the number is: " + floor);
        }
    }
}