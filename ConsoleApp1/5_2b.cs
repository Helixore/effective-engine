using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle_ : Point, ICloneable
    {
        double radius;
        string? name;
        public double _radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public string _name
        {
            get { return name; }
            set { name = value; }
        }
        public Circle_(double x, double y, double radius, string name) : base(x, y)
        {
            this._x = x;
            this._y = y;
            this._radius = radius;
            this._name = name;
        }

        public Circle_ Clone() { return new Circle_(this._x, this._y, this._radius, this._name); }
        object ICloneable.Clone() 
        {
            return Clone();
        }
        public override double GetCircumference()
        {
            return (2 * Math.PI * _radius);
        }
        public override string ToString()
        {
            return $"Circle {name} \n X: {_x} - Y: {_y} \n Radius: {_radius} \n Circumference: {this.GetCircumference()}";
        }
        public override bool Equals(object? obj)
        {
            if(obj is Circle_){
                return ((Circle_)obj)._x == this._x && ((Circle_)obj)._y == this._y && ((Circle_)obj)._radius == this._radius;
            }
            else
            {
                return false;
            }
        }
        public static Circle_ operator <(Circle_ a, Circle_ b)
        {
            return a.GetCircumference() < b.GetCircumference() ? a : b;
        }
        public static Circle_ operator >(Circle_ a, Circle_ b)
        {
            return a.GetCircumference() > b.GetCircumference() ? a : b;
        }
    }
}
