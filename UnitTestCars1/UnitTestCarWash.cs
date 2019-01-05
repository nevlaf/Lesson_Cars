using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson_Cars.Model;
using Lesson_Cars.Exceptions;
using Lesson_Cars.Controller;

namespace UnitTestCars1
{
    [TestClass]
    public class UnitTestCarWash
    {
        [TestMethod]
        public void TestMethod_IsDirty_false()
        {
            #region Arrange
            Car reno = new Car();
            #endregion

            #region Action
            CarWash.Wash(reno);            
            #endregion

            #region Assert
            Assert.IsFalse(reno.IsDirty);
            #endregion
        }

        [TestMethod]
        [ExpectedException(typeof(ClearCarException))]
        public void TestException_CleanCarException()
        {
            #region Arrange
            Car reno = new Car();
            #endregion

            #region Action
            reno.IsDirty = false;
            CarWash.Wash(reno);
            #endregion

        }

        [TestMethod]
        public void TestMethod_999_200_not_1119()
        {
            #region Arrange
            Car car = new Car();
            #endregion

            #region Action
            car.IsDirty = true;
            CarWash.Wash(car);
            #endregion

            #region Assert
            Assert.AreNotEqual(car.IsDirty, true);
            #endregion
        }
    }
}
