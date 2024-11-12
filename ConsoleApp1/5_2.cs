using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point : Shapez
    {
        double x, y;
        string? Name;
        public double _x
        {
            get { return x; }
            set { x = value; }
        }
        public double _y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(double x, double y)
        {
            this._x = x;
            this._y = y;
        }
        public virtual void MoveObject(double x, double y)
        {
            this._x += x;
            this._y += y;
        }
        public virtual double GetCircumference()
        {
            return 0;
        }
        public override string ToString()
        {
            return $"Point: \n X: {_x} \n Y: {_y} \n";
        }
        public override bool Equals(object? obj)
        {
            if(obj is Point)
            {
                return ((Point)obj).x == this._x && ((Point)obj).y == this._y;
            }
            else
            {
                return false;
            }
        }
        public static Point operator <(Point a, Point b)
        {
            return a.GetCircumference() < b.GetCircumference() ? a : b;
        }
        public static Point operator >(Point a, Point b)
        {
            return a.GetCircumference() > b.GetCircumference() ? a : b;
        }
        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow((p1.x - p2.x),2) + Math.Pow((p1.y - p2.y),2));
        }
    }
}
