using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarStaffTestTask;

namespace StarStaffTestProject
{
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void AreaTriangleTest()
        {
            var egyptian = new Triangle(3, 4, 5);
            var wishedArea = 6d;

            var area = egyptian.CalcArea();
            
            //Assert.AreEqual(area, wishedArea);
            Assert.IsTrue(Math.Abs(area - wishedArea) < double.Epsilon);
        }

        [TestMethod]
        public void AreaCircleTest()
        {
            var circle = new Circle(1);
            var wishedArea = Math.PI;

            var area = circle.CalcArea();

            //Assert.AreEqual(area, wishedArea);
            Assert.IsTrue(Math.Abs(area - wishedArea) < double.Epsilon);
        }

        [TestMethod]
        public void IsRightTest()
        {
            var egyptian = new Triangle(3, 4, 5);

            var isRight = egyptian.IsRight();

            Assert.IsTrue(isRight);
        }
    }
}
