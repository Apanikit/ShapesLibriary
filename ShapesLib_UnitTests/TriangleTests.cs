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
        [ExpectedException(typeof(ArgumentException))]
        public void Exist_0x0x0_exeption()
        {
            //Arrange
            var triangle = new Triangle(0, 0, 0);

            //Act
            var area = triangle.Area();
            var right = triangle.isRight();

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Exist_1x2x100_exeption()
        {
            //Arrange
            var triangle = new Triangle(1, 2, 100);

            //Act
            var area = triangle.Area();
            var right = triangle.isRight();

            //Assert
        }

        [TestMethod]
        public void Exist_10x12x15_correct()
        {
            //Arrange
            var triangle = new Triangle(10, 12, 15);

            //Act
            var area = triangle.Area();
            var right = triangle.isRight();

            //Assert
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
