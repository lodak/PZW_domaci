using Microsoft.VisualStudio.TestTools.UnitTesting;
using dz2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2.Tests
{
    [TestClass()]
    public class MyDateTests
    {
        [TestMethod()]
        [ExpectedException(typeof(InvalidProgramException))]
        public void InvalidLessDayhNumber()
        {
            var date = new MyDate(2001, 1, 0);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidProgramException))]
        public void InvalidLessMonthNumber()
        {
            var date = new MyDate(2001, 0, 1);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidProgramException))]
        public void InvalidLargerDayNumber()
        {
            var date = new MyDate(2001, 1, 33);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidProgramException))]
        public void InvalidLargerMonthNumber()
        {
            var date = new MyDate(2001, 13, 1);
        }


        [TestMethod()]
        public void CorrectNumberOfRemainingDays()
        {
            var date = new MyDate(2001, 1, 1);
            Assert.AreEqual(30, date.RemainingDaysInMonth(), "");
        }

        [TestMethod()]
        public void CorrectMonthName()
        {
            var date = new MyDate(2001, 1, 1);
            Assert.AreEqual("The name of the month is January.", date.GetMonthName(), "");
        }

    }
}