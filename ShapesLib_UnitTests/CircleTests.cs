using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesLib;

namespace ShapesLib_UnitTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            var circle = new Circle(1);

            var result = circle.Area() == Math.PI;

            Assert.IsTrue(result);
        }
    }
}
