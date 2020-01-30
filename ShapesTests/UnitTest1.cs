using NUnit.Framework;
using System;
using TestShapes;
using TestShapes.Interfaces;
using TestShapes.Shapes;

namespace ShapesTests
{
    public class Tests
    {
        private AreaService s;
        [SetUp]
        public void Setup()
        {
            s = AreaService.Instance;
        }

        [Test]
        public void Cirlce()
        {
            Assert.AreEqual(Math.PI, s.CircleArea(1));
            Assert.AreEqual(4 * Math.PI, s.CircleArea(2));

            Assert.Throws(typeof(ArgumentException), () => s.CircleArea(-1));

            var c = new Circle(2);

            Assert.AreEqual(s.CircleArea(2), c.Area());

            Assert.Pass();
        }

        [Test]
        public void Triangle()
        {
            Assert.AreEqual(6, s.TriangleArea(3, 4, 5));

            Assert.Throws(typeof(ArgumentException), () => s.TriangleArea(-1, 2, 3));

            var t = new Triangle(3, 4, 5);
            
            Assert.AreEqual(s.TriangleArea(5, 4, 3), t.Area());
            Assert.True(t.IsRight());
            Assert.True(s.IsTriangleRight(5, 4, 3));

            Assert.Pass();
        }

        public (IShape, double) GetRandomShape()
        {
            var r = new Random();
            IShape sh;
            if(r.NextDouble() > 0.5)
            {
                sh = new Triangle(r.NextDouble(), r.NextDouble(), r.NextDouble());
            }
            else
            {
                sh = new Circle(r.NextDouble());
            }

            return (sh, sh.Area());
        }

        [Test]
        public void Common()
        {
            for(int i = 0; i < 10; i++)
            {
                var (sh, area) = GetRandomShape();
                Assert.AreEqual(area, s.GetArea(sh));
            }

            Assert.Pass();
        }
    }
}