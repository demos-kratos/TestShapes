using System;
using System.Collections.Generic;
using System.Text;
using TestShapes.Interfaces;

namespace TestShapes.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if(radius <= 0)
            {
                throw new ArgumentException("Invalid circle: radius cannot be less than or equal to 0");
            }

            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
