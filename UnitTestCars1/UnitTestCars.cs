using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson_Cars.Model;
using Lesson_Cars.Exceptions;
using Lesson_Cars.Controller;

namespace UnitTestCars1
{
    [TestClass]
    public class UnitTestCars
    {
        
        [TestMethod]
        public void TestMethod_500_600__1000()
        {
            #region Arrange
            Car car = new Car();
            #endregion

            #region Action
            car.Travel(500);
            car.Travel(600);
            #endregion

            #region Assert
            Assert.AreEqual(car.Mileage, 1000);
            #endregion
        }

        [TestMethod]
        public void TestMethod_999_200_not_1119()
        {
            #region Arrange
            Car car = new Car();
            #endregion

            #region Action
            car.Travel(999);
            car.Travel(200);
            #endregion

            #region Assert
            Assert.AreNotEqual(car.Mileage, 1119);
            #endregion
        }

        [TestMethod]
        public void TestMethod_1000_900_200__2000()
        {
            #region Arrange
            Car car = new Car();
            car.Travel(1000);
            car.IsBreak = false;
            car.Travel(900);
            #endregion

            #region Action
            car.Travel(200);

            #endregion

            #region Assert
            Assert.AreEqual(car.Mileage, 2000);
            #endregion
        }

        [TestMethod]
        public void TestMethod_1100_2200_200_3300__5000()
        {
            #region Arrange
            Car car = new Car();
            car.Travel(1100);
            car.IsBreak = false;            
            car.Travel(2200);
            car.IsBreak = false;
            car.Travel(200);
            #endregion

            #region Action
            car.Travel(3300);

            #endregion

            #region Assert
            Assert.AreEqual(car.Mileage, 5000);
            #endregion
        }

        [TestMethod]
        public void TestMethod_1100_2200_200_1100_2200_IsBrake_true()
        {
            #region Arrange
            Car car = new Car();
            car.Travel(1100);
            car.IsBreak = false;
            car.Travel(2200);
            car.IsBreak = false;
            car.Travel(200);
            #endregion

            #region Action
            car.Travel(1100);
            car.Travel(2200);
            #endregion

            #region Assert
            Assert.IsTrue(car.IsBreak);
            #endregion
        }

        [TestMethod]
        public void TestMethod_500_IsBreak_false()
        {
            #region Arrange
            Car car = new Car();
            #endregion

            #region Action
            car.Travel(500);
            #endregion

            #region Assert
            Assert.IsFalse(car.IsBreak);
            #endregion
        }

        [TestMethod]
        public void TestMethod__1001_IsBreak_true()
        {
            #region Arrange
            Car car = new Car();
            #endregion

            #region Action
            car.Travel(1001);
            #endregion

            #region Assert
            Assert.IsTrue(car.IsBreak);
            #endregion
        }

        [TestMethod]
        public void TestMethod_2001_IsBreak_true()
        {
            #region Arrange
            Car car = new Car();
            #endregion

            #region Action
            car.Travel(2001);
            #endregion

            #region Assert
            Assert.IsTrue(car.IsBreak);
            #endregion
        }

        [TestMethod]
        public void TestMethod_5001_IsBreak_true()
        {
            #region Arrange
            Car car = new Car();
            #endregion

            #region Action
            car.Travel(5001);
            #endregion

            #region Assert
            Assert.IsTrue(car.IsBreak);
            #endregion
        }
        [TestMethod]
        public void TestMethod_1_isDirty_false()
        {
            #region Arrange
            Car car = new Car();
            #endregion

            #region Action
            car.Travel(1);
            #endregion

            #region Assert
            Assert.IsTrue(car.IsDirty);
            #endregion
        }

        [TestMethod]
        public void TestMethod_1235_isDirty_false()
        {
            #region Arrange
            Car car = new Car();
            #endregion

            #region Action
            car.Travel(1235);
            #endregion

            #region Assert
            Assert.IsTrue(car.IsDirty);
            #endregion
        }

        [TestMethod]
        public void TestMethod_500_600_state_IsBrake()
        {
            #region Arrange
            Car car = new Car();
            #endregion

            #region Action
            car.Travel(500);
            car.Travel(600);
            #endregion

            #region Assert
            Assert.IsTrue(car.IsBreak);
            #endregion
        }        

        [TestMethod]
        public void TestMethod_300_State_isDirty()
        {
            #region Arrange
            Car car = new Car();
            #endregion

            #region Action
            car.Travel(300);          
            #endregion

            #region Assert
            Assert.IsTrue(car.IsDirty);
            #endregion
        }
        
        [TestMethod]
        [ExpectedException(typeof(DirtyException))]
        public void TestException_DirtyException()
        {
            Car fiat = new Car();
            fiat.IsDirty = true;
            RepairShop.Repair(fiat);

        }
        
        [TestMethod]
        [ExpectedException(typeof(WastePathException))]
        public void TestException_WastePathException_500()
        {
            Car car = new Car();
            car.Travel(-500);
        }

        [TestMethod]
        [ExpectedException(typeof(WastePathException))]
        public void TestException_WastePathException_0()
        {
            Car car = new Car();
            car.Travel(0);
        }

        [TestMethod]
        [ExpectedException(typeof(BreakCarException))]
        public void TestException_1000_200_BreakCarException()
        {
            Car car = new Car();
            car.Travel(1000);
            car.Travel(200);
        }

    }
}
