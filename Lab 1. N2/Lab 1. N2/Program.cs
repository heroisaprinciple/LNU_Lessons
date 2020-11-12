using System;
namespace Cube
{
    class Cubes
    {
        static void Main(string[] args)
        {
            int side_power = 3;
            Console.WriteLine("Choose the side of the cube: ");
            double side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The side of the cube is:  " + side);
            double area = Math.Pow(side, side_power);
            Console.WriteLine("The area of the cube is: " + area);
        }
    }
}