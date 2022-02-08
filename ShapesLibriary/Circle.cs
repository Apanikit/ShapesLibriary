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

        public Circle(double R) 
        {
            this.R = R;
            Exist();
        }

        public override double Area()
        {
            Exist();
            return Math.PI * R * R; 
        }

        private void Exist()
        {
            if (R <= 0) { throw new ArgumentException("Circle does not exist"); }
        }
    }
}
