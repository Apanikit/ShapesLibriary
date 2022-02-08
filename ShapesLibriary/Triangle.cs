using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    public class Triangle : Shape
    {
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            Exist();
        }

        public override double Area()
        {
            Exist();

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool isRight()
        {
            Exist();

            double area = Area();
            return (area == (a * b) / 2 || area == (b * c) / 2 || area == (a * c) / 2);
        }

        private void Exist()
        {
            if (a <= 0 || b <= 0 || c <= 0) { throw new ArgumentException("Triangle does not exist"); }
            else if (a > b + c || b > a + c || c > a + b) { throw new ArgumentException("Triangle does not exist"); }
        }

        

    }
}
