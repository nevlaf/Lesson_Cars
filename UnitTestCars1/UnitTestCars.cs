using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson_Cars.Model;
using Lesson_Cars.Exceptions;

namespace UnitTestCars1
{
    [TestClass]
    public class UnitTestCars
    {
        [TestMethod]
        public void TestMethod1()
        {
            Car car = new Car();
            car.Mileage = 500;
            Assert.IsFalse(car.IsBreak);
        }
        [TestMethod]
        [ExpectedException(typeof(WastePathException))]
        public void TestException()
        {
            Car car = new Car();
            car.Mileage = -50;

        }
    }
}
