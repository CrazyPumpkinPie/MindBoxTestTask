using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FindAreaLib.Tests
{
    [TestClass]
    public class FindAreaTests
    {
        [TestMethod]
        public void Circle_FindArea_8_201returned()
        {
            double radius = 8;
            double expected = 201.061929829747;

            Circle circle = new Circle(radius);
            double actual = circle.FindArea();

            Assert.AreEqual(expected, actual);
        }
    }
}
