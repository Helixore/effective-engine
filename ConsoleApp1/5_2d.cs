using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Polygon : Point, ICloneable, Shapez
    {
        List<Point> points;
        Point originalPoint;
        string? name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Polygon(double x, double y, List<Point> points, string name) : base(x, y)
        {
            this.points = points;
            this.originalPoint = new Point(x, y);
            this.name = name;
        }
        public Polygon Clone() { return new Polygon(originalPoint._x, originalPoint._y, points, Name); }
        object ICloneable.Clone()
        {
            return Clone();
        }

        void AddPoint(double x, double y)
        {
            points.Add(new Point(x, y));
        }

        public override void MoveObject(double x, double y)
        {
            foreach (Point p in points)
            {
                p.MoveObject(x, y);
            }
        }
        public override double GetCircumference()
        {
            double temp = 0.0;
            if (points.Count <= 1) { temp += Distance(originalPoint, points[0]); return temp; }
            else
            {
                temp += Distance(originalPoint, points[0]);
                for (int i = 0; i < points.Count - 1; i++)
                {
                    temp += Distance(points[i], points[i + 1]);
                }
            }
            return temp;
        }
        public override string ToString()
        {
            return $"Polygon {Name} \n Point count: {points.Count} \n Circumference: {GetCircumference()}";
        }
        public override bool Equals(object? obj)
        {
            if(obj is Polygon)
            {
                Polygon p = (Polygon)obj;
                if(p.points.Count == this.points.Count) 
                {
                    for(int x = 0; x < this.points.Count; x++)
                    {
                        if (points[x].Equals(p.points[x]))
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }

                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else { return false; }
        }
        public static Polygon operator <(Polygon a, Polygon b)
        {
            return a.GetCircumference() < b.GetCircumference() ? a : b;
        }
        public static Polygon operator >(Polygon a, Polygon b)
        {
            return a.GetCircumference() > b.GetCircumference() ? a : b;
        }
    }
}
