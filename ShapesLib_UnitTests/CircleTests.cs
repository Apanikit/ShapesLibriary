using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesLib;

namespace ShapesLib_UnitTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Area_1_PI()
        {
            //Arrange
            var circle = new Circle(1);
            double expected = Math.PI;

            //Act
            var result = circle.Area();

            //Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Exist_neg1_exeption()
        {
            //Arrange
            var circle = new Circle(-1);
            double expected = Math.PI;

            //Act
            var result = circle.Area();

            //Assert
            Assert.AreEqual(result, expected);
        }
    }
}
