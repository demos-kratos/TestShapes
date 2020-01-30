using System;
using System.Collections.Generic;
using System.Text;
using TestShapes.Interfaces;
using TestShapes.Shapes;

namespace TestShapes
{
    public class AreaService
    {
        public static AreaService Instance => _instance ?? (_instance = new AreaService());
        private static AreaService _instance;
        private AreaService()
        {

        }

        public double GetArea(IShape shape)
        {
            return shape.Area();
        }

        public double CircleArea(double radius)
        {
            return GetArea(new Circle(radius));
        }

        public double TriangleArea(double a, double b, double c)
        {
            return GetArea(new Triangle(a, b, c));
        }
    }
}
