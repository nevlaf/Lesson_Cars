using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson_Cars.Model;
using Lesson_Cars.Exceptions;
using Lesson_Cars.Controller;

namespace UnitTestCars1
{
    [TestClass]
    public class UnitTestRepairShop
    {
        [TestMethod]
        public void TestMethod_IsBreak_false()
        {
            #region Arrange
            Car reno = new Car();
            #endregion

            #region Action
            RepairShop.Repair(reno);
            #endregion

            #region Assert
            Assert.IsFalse(reno.IsBreak);
            #endregion
        }

        [TestMethod]
        [ExpectedException(typeof(DirtyException))]
        public void TestException_DirtyException()
        {
            #region Arrange
            Car reno = new Car();
            #endregion

            #region Action
            reno.IsDirty = true;
            RepairShop.Repair(reno);
            #endregion

        }

        [TestMethod]
        public void TestMethod_999_200_not_1119()
        {
            #region Arrange
            Car car = new Car();
            #endregion

            #region Action
            car.IsBreak = true;
            RepairShop.Repair(car);
            #endregion

            #region Assert
            Assert.AreNotEqual(car.IsDirty, true);
            #endregion
        }
    }
}
