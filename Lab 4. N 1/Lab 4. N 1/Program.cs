using System;

namespace Program_Geometry_1
{
    abstract class Figure
    {
        public abstract void Draw();
    }
    class Square : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Квадрат");
        }
    }
    class Rectangle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Прямокутник");
        }
    }
    class Program_Geometry_2
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Square sq = new Square();

            sq.Draw();
            rect.Draw();

            Console.ReadKey();
        }
    }
}