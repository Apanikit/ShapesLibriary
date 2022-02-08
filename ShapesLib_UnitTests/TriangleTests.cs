using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesLib;

namespace ShapesLib_UnitTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Area_3x4x5_6()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);
            double expected = 6;

            //Act
            var result = triangle.Area();

            //Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void Exist_0x0x0_false()
        {
            //Arrange
            var triangle = new Triangle(0, 0, 0);

            //Act
            var result = triangle.Exist();

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Exist_1x2x100_false()
        {
            //Arrange
            var triangle = new Triangle(1, 2, 100);

            //Act
            var result = triangle.Exist();

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Exist_10x12x15_true()
        {
            //Arrange
            var triangle = new Triangle(10, 12, 15);

            //Act
            var result = triangle.Exist();

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void isRight_3x4x5_true()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var result = triangle.isRight();

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void isRight_10x12x15_false()
        {
            //Arrange
            var triangle = new Triangle(10, 12, 15);

            //Act
            var result = triangle.isRight();

            //Assert
            Assert.IsFalse(result);
        }
    }
}
