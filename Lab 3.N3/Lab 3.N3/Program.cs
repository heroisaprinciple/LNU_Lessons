using System;

namespace Program
{
    class Circle
    {
        private static float PI = 3.141592f;
        public static float getlength(float radius)
        {
            return 2 * PI * radius;
        }
        public static float getpl(float radius)
        {
            return radius * radius * PI;
        }
        class Program_Geometry
        {
            static void Main(string[] args)
            {
                float radius;
                Console.Write("Введiть радiус кола: ");
                radius = float.Parse(Console.ReadLine());
                Console.WriteLine($"Площа кола: {Circle.getpl(radius)} \nДовжина кола: {Circle.getlength(radius)}");
            }
        }
    }
}