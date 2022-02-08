using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool isRight()
        {
            double area = Area();
            return (area == (a * b) / 2 || area == (b * c) / 2 || area == (a * c) / 2);
        }

        public bool Exist()
        {
            if (a == 0 || b == 0 || c == 0) { return false; }
            else if (a > b + c || b > a + c || c > a + b) { return false; }
            else { return true; }
        }

        

    }
}
