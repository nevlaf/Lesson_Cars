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
        public void TestMethod_1000_IsBreak_false()
        {
            #region Arrange
            Car reno = new Car();
            reno.Travel(1000);
            reno.Look = false;
            #endregion

            #region Action
            RepairShop.Repair(reno);
            #endregion

            #region Assert
            Assert.IsFalse(reno.State);
            #endregion
        }


        [TestMethod]
        public void TestMethod_1000_Bill_for_Repair_120()
        {
            #region Arrange
            double bill;
            Car reno = new Car();
            reno.Travel(1000);
            reno.Look = false;
            #endregion

            #region Action
            bill = RepairShop.Repair(reno);
            #endregion

            #region Assert
            Assert.AreEqual(bill, 120);
            #endregion
        }

        [TestMethod]
        public void TestMethod_2000_IsBreak_false()
        {
            #region Arrange
            Car reno = new Car();
            reno.Travel(1000);
            reno.Look = false;
            reno.State = false;
            reno.Travel(1000);
            reno.Look = false;
            #endregion

            #region Action
            RepairShop.Repair(reno);
            #endregion

            #region Assert
            Assert.IsFalse(reno.State);
            #endregion
        }


        [TestMethod]
        public void TestMethod_2000_Bill_for_Repair_150()
        {
            #region Arrange
            double bill;
            Car reno = new Car();
            reno.Travel(1000);
            reno.Look = false;
            reno.State = false;
            reno.Travel(1000);
            reno.Look = false;
            #endregion

            #region Action
            bill = RepairShop.Repair(reno);
            #endregion

            #region Assert
            Assert.AreEqual(bill, 150);
            #endregion
        }

        [TestMethod]
        public void TestMethod_5000_IsBreak_false()
        {
            #region Arrange
            Car reno = new Car();
            reno.Travel(1000);
            reno.Look = false;
            reno.State = false;
            reno.Travel(1000);
            reno.Look = false;
            reno.State = false;
            reno.Travel(3000);
            reno.Look = false;
            #endregion

            #region Action
            RepairShop.Repair(reno);
            #endregion

            #region Assert
            Assert.IsFalse(reno.State);
            #endregion
        }

        [TestMethod]
        public void TestMethod_5000_Bill_for_Repair_180()
        {
            #region Arrange
            double bill;
            Car reno = new Car();
            reno.Travel(1000);
            reno.Look = false;
            reno.State = false;
            reno.Travel(1000);
            reno.Look = false;
            reno.State = false;
            reno.Travel(3000);
            reno.Look = false;
            #endregion

            #region Action
            bill = RepairShop.Repair(reno);
            #endregion

            #region Assert
            Assert.AreEqual(bill, 180);
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
            reno.Look = true;
            RepairShop.Repair(reno);
            #endregion
        }

        [TestMethod]
        [ExpectedException(typeof(MissingMileageException))]
        public void TestException_MissingMileageException()
        {
            #region Arrange
            Car reno = new Car();
            reno.Travel(1000);
            reno.Look = false;
            reno.State = false;
            reno.Travel(1000);
            reno.Look = false;
            reno.State = false;
            reno.Travel(2900);
            reno.Look = false;
            #endregion

            #region Action
            RepairShop.Repair(reno);
            #endregion
        }
    }
}
