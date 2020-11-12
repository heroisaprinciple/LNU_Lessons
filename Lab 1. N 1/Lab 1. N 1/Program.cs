using System;
namespace Program
{
    class Circle
    {
        static void Main(string[] args)
        {
            int power = 2;
            Console.WriteLine("The r is...");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The r of the circle is " + radius);
            double area = Math.PI * Math.Pow(radius, power);
            Console.WriteLine("The area of the circle is " + area);
        }
    }
}