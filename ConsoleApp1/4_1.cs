using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Shape
    {
        public int X;
        public int Y;
        public int Height;
        public int Width;
        public Shape(int v1, int v2, int v3, int v4)
        {
            this.X = v1;
            this.Y = v2;
            this.Width = v3;
            this.Height = v4;
        }
        public virtual void draw()
        {
            Console.WriteLine("This function draws a shape!");
        }
    }
    class Rectangle : Shape
    {
        public Rectangle(int v1, int v2, int v3, int v4) : base(v1, v2, v3, v4)
        {
            this.X = v1;
            this.Y = v2;
            this.Width = v3;
            this.Height = v4;
        }
        public override void draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
    class Triangle : Shape
    {
        public Triangle(int v1, int v2, int v3, int v4) : base(v1, v2, v3, v4)
        {
            this.X = v1;
            this.Y = v2;
            this.Width = v3;
            this.Height = v4;
        }
        public override void draw()
        {
            Console.WriteLine("Drawing a Triangle");
        }
    }
    class Circle : Shape
    {
        public Circle(int v1, int v2, int v3, int v4) : base(v1, v2, v3, v4)
        {
            this.X = v1;
            this.Y = v2;
            this.Width = v3;
            this.Height = v4;
        }
        public override void draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }
}
