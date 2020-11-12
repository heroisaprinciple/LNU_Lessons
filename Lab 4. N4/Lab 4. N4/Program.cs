using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    interface IDrawable
    {
        void Draw();
    }
    class Figure : IDrawable
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public Figure(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }
        void IDrawable.Draw()
        {
            Console.WriteLine("Фігура");
        }
    }
    class Square : Figure, IDrawable
    {
        public Square(float X, float Y) : base(X, Y)
        {

        }
        void IDrawable.Draw()
        {
            Console.WriteLine("Квадрат");
        }
    }
    class Rectangle : Figure, IDrawable
    {
        public Rectangle(float X, float Y) : base(X, Y)
        {

        }

        void IDrawable.Draw()
        {
            Console.WriteLine("Прямокутник");
        }
    }
    class Program_Geometry
    {
        static void DrawAll(params IDrawable[] array)
        {
            foreach (IDrawable drawable in array)
            {
                drawable.Draw();
            }
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(2.1f, 3.4f);
            Square sq = new Square(1.1f, 5.3f);
            Figure fig = new Figure(2.1f, 1.1f);

            IDrawable rectDrawable = (IDrawable)rect;
            IDrawable sqDrawable = (IDrawable)sq;
            IDrawable figDrawable = (IDrawable)fig;

            DrawAll(rectDrawable, sqDrawable, figDrawable);
        }
    }
}