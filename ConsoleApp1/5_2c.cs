using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangle_ : Point, ICloneable
    {

        Point point1, point2, point3;
        string? name;
        public string _name
        {
            get { return name; }
            set { name = value; }
        }
        public Triangle_(double x1, double y1, double x2, double y2, double x3, double y3, string name) : base (x1,y1)
        {
            this.point1 = new Point(x1, y1);
            this.point2 = new Point(x2, y2);
            this.point3 = new Point(x3, y3);
            this._name = name;
        }

        public Triangle_ Clone() { return new Triangle_(this.point1._x, this.point1._y, this.point2._x, this.point2._y, this.point3._x, this.point3._y, this._name); }
        object ICloneable.Clone()
        {
            return Clone();
        }
        public override double GetCircumference()
        {
            return Distance(point1, point2) + Distance(point2, point3) + Distance(point3, point1);
        }
        public override string ToString()
        {
            return $"Triangle {name} \n P1: {point1.ToString()} \n P2: {point2} \n P3: {point3} \n Circumference: {this.GetCircumference()}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Triangle_)
            {
                return ((Triangle_)obj).point1.Equals(this.point1) && ((Triangle_)obj).point2.Equals(this.point2) && ((Triangle_)obj).point3.Equals(this.point3);
            }
            else
            {
                return false;
            }
        }
        public static Triangle_ operator <(Triangle_ a, Triangle_ b)
        {
            return a.GetCircumference() < b.GetCircumference() ? a : b;
        }
        public static Triangle_ operator >(Triangle_ a, Triangle_ b)
        {
            return a.GetCircumference() > b.GetCircumference() ? a : b;
        }
    }
}
