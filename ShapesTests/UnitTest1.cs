using NUnit.Framework;
using System;
using TestShapes;
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

        }

        public void Common()
        {

        }
    }
}