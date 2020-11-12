using System;

namespace Program
{
    abstract class Figure
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        protected Figure(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public abstract void Draw();
    }
    class Square : Figure
    {
        public Square(float X, float Y) : base(X, Y)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("Квадрат");
        }
    }
    class Rectangle : Figure
    {
        public Rectangle(float X, float Y) : base(X, Y)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("Прямокутник");
        }
    }
    class Program_Geometry
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(2.1f, 3.4f);
            Square sq = new Square(1.1f, 5.3f);
            sq.Draw();
            rect.Draw();
        }
    }
}