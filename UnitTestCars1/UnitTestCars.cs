﻿using System;
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
        [ExpectedException(typeof(DirtyException))]
        public void TestException_DirtyException()
        {
            Car car = new Car();
            car.IsDirty = true;

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

        [TestMethod]
        public void TestMethod_500_State_Break()
        {
            Car car = new Car();
            car.Travel(500);
            Assert.IsFalse(car.IsBreak);
        }

        [TestMethod]
        public void TestMethod__State_Break()
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
        public void TestMethod_2001_State_Break()
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
        public void TestMethod_5001_State_Break()
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
        public void TestMethod_1_State_isDirty()
        {
            #region Arrange
            Car car = new Car();
            #endregion

            #region Action
            car.Travel(1);
            #endregion

            #region Assert
            Assert.IsFalse(car.IsDirty);
            #endregion
        }
        
        [TestMethod]
        public void TestMethod_500_600_1000()
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
        public void TestMethod_999_200_1200()
        {
            #region Arrange
            Car car = new Car();
            #endregion

            #region Action
            car.Travel(999);
            car.Travel(200);
            #endregion

            #region Assert
            Assert.AreNotEqual(car.Mileage, 1200);
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
        public void TestMethod_1000_900_200_2000()
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
    }
}
