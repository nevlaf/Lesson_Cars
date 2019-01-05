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
            Car fiat = new Car();
            #endregion

            #region Action
            fiat.IsDirty = true;
            CarWash.Wash(fiat);            
            #endregion

            #region Assert
            Assert.IsFalse(fiat.IsDirty);
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
        public void TestMethod_IsDirty_not_true()
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

        [TestMethod]
        public void TestMethod_Bill_for_Wash_20()
        {
            #region Arrange
            Car car = new Car();
            double bill;
            #endregion

            #region Action
            car.IsDirty = true;
            bill = CarWash.Wash(car);
            #endregion

            #region Assert
            Assert.AreEqual(bill, 20);
            #endregion
        }
    }
}
