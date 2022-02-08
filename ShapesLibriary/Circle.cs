using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    public class Circle : Shape
    {
        private double R { get; set; }

        public Circle(double R) { this.R = R; }

        public override double Area(){ return Math.PI * R * R; }
    }
}
