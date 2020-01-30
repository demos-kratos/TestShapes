using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using TestShapes.Interfaces;

namespace TestShapes.Shapes
{
    public class Triangle : IShape
    {
        private readonly double[] sides = new double[3];

        public Triangle(double a, double b, double c)
        {
            if(a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Invalid triangle");
            }

            sides[0] = a;
            sides[1] = b;
            sides[2] = c;
        }

        public double Area()
        {
            var hp = sides.Sum() / 2.0;
            return Math.Sqrt(hp * (hp - sides[0]) * (hp - sides[1]) * (hp - sides[2]));
        }

        public bool IsRight()
        {
            return
                sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2] ||
                sides[1] * sides[1] + sides[2] * sides[2] == sides[0] * sides[0] ||
                sides[2] * sides[2] + sides[0] * sides[0] == sides[1] * sides[1];
        }
    }
}
