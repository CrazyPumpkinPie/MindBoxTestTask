using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FindAreaLib.Tests
{
    [TestClass]
    public class CircleFindAreaTests
    {
        [TestMethod]
        public void Circle_FindArea_8_Return_201()
        {
            Circle circle = new Circle(8);
            double expected = 201.06193;

            double actual = circle.FindArea();

            Assert.AreEqual(expected, actual, 0.0001);
        }
    }

    [TestClass]
    public class TriangleFindAreaTest
    {
        [TestMethod]
        public void TriangleFindArea_3_4_5_Return_6()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expected = 6;

            double actual = triangle.FindArea();

            Assert.AreEqual(expected, actual,0.0001);
        }
    }

    [TestClass]
    public class TriangleIsRectangularTest
    {
        [TestMethod]
        public void TriangleIsRectangular_3_4_5_Return_True()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool expected = true;

            bool actual = triangle.IsRectangular;

            Assert.AreEqual(expected, actual);
        }
    }
}
