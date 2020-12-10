using System;
using System.Collections.Generic;


namespace Lab_5._N_2
{
    interface ICoordinates
    {
        double X { get; set; }
        double Y { get; set; }
    }
    interface ISize
    {
        double Width { get; set; }
        double Height { get; set; }
        double Perimeter();
    }
    struct Rectangle : ISize, ICoordinates
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Rectangle(double width, double height, double x, double y)
        {
            Width = width;
            Height = height;
            X = x;
            Y = y;
        }
        public double Perimeter()
        {
            return 2 * Width + 2 * Height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect;
            string[] input;
            Console.Write("Enter coordinates (x, y) and height of the rectangle: ");
            input = Console.ReadLine().Split(' ');
            rect = new Rectangle(double.Parse(input[0]), double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
            Console.WriteLine($"Rectangle:\n\tWidth: {rect.Width}\n\tHeight: {rect.Height}\n\tPerimeter: {rect.Perimeter()}\n\tX: {rect.X}\n\tY: {rect.Y}");
        }
    }
}