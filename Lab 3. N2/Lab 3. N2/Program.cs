using System;

namespace Program
{
    class Rectangle
    {
        private Vertex leftTopVertex;
        private Vertex rightBottomVertex;
        private double verticalEdge;
        private double horizontalEdge;
        public double pl { get; private set; }
        public double pr { get; private set; }
        public Rectangle(Vertex leftTopVertex, Vertex rightBottomVertex)
        {
            this.leftTopVertex = leftTopVertex;
            this.rightBottomVertex = rightBottomVertex;
            verticalEdge = leftTopVertex.Y - rightBottomVertex.Y;
            horizontalEdge = rightBottomVertex.X - leftTopVertex.X;
            pl = verticalEdge * horizontalEdge;
            pr = verticalEdge * 2 + horizontalEdge * 2;
        }
    }
    class Vertex
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Vertex(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    class Program_Geometry
    {
        static void Main(string[] args)
        {
            string[] input;
            double[] inputVertex = new double[4];
            Rectangle rect;
            Vertex leftTop;
            Vertex rightBottom;
            Console.Write("Введiть координати верхньоi-лiвоi та нижньоi-правоi точок через пробiл\n(напр. 2 3 3 1): ");
            input = Console.ReadLine().Split(' ');
            for (int i = 0; i < 4; i++)
            {
                inputVertex[i] = double.Parse(input[i]);
            }
            leftTop = new Vertex(inputVertex[0], inputVertex[1]);
            rightBottom = new Vertex(inputVertex[2], inputVertex[3]);
            rect = new Rectangle(leftTop, rightBottom);
            Console.WriteLine($"Площа прямокутника: {rect.pl} \nПериметр прямокутника: {rect.pr}");
        }
    }
}