using System;

namespace Program
{
    class Figure
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public Figure(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public virtual void Draw()
        {
            Console.WriteLine("Фiгура");
        }
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
            Figure fig = new Figure(2.1f, 1.1f);
            sq.Draw();
            rect.Draw();
            fig.Draw();
        }
    }
}