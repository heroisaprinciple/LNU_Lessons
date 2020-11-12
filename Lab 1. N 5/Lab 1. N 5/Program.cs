using System;
namespace Division
{
    class Mathematics
    {
        static void Main()
        {
            Console.WriteLine("Choose a number (n>2): ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The number has chosen: " + number);
            if (number <= 0 || number % 2 == 0)
            {
                Console.WriteLine("The code will not work due to the condition. Please, try one more time.");
            }
            else
            {
                double division_by_2 = number / 2;
                Console.WriteLine("The division by 2 of your number is: " + division_by_2);
                double round = Math.Round(division_by_2, 2);
                Console.WriteLine("The round to hundreths of your number is: " + round);

            }






        }
    }
}