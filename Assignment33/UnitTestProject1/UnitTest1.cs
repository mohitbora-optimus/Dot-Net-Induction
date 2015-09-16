using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingStudentPercentage;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LowerBoundaryValueCase()
        {
            CheckPercentage checkPercentage = new CheckPercentage();
            string messageUpperValue = "Value Accepted : " + 0;
            string result = checkPercentage.CheckPercentageValidity(0.ToString());
            Assert.AreEqual(messageUpperValue, result);
        }

        [TestMethod]
        public void UpperBoundaryValueCase()
        {
            CheckPercentage checkPercentage = new CheckPercentage();
            string messageUpperValue = "Value Accepted : " + 100;
            string result = checkPercentage.CheckPercentageValidity(100.ToString());
            Assert.AreEqual(messageUpperValue, result);
        }

        [TestMethod]
        public void StringValueCase()
        {
            CheckPercentage checkPercentage = new CheckPercentage();
            string message = "Please enter a Number ! you have entered a String";
            string result = checkPercentage.CheckPercentageValidity("percentage");
            Assert.AreEqual(message, result);
        }

        [TestMethod]
        public void OutOfLowerBoundaryValueCase()
        {
            CheckPercentage checkPercentage = new CheckPercentage();
            string message = "Enter valid percentage between (0-100) ";
            string result = checkPercentage.CheckPercentageValidity("-1");
            Assert.AreEqual(message, result);
        }

        [TestMethod]
        public void OutOfUpperBoundaryValueCase()
        {
            CheckPercentage checkPercentage = new CheckPercentage();
            string result = checkPercentage.CheckPercentageValidity("1000");
            string message = "Enter valid percentage between (0-100) ";
            Assert.AreEqual(message, result);
        }
    }
}
