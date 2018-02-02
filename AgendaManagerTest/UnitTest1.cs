using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        Day currentDay;

        [SetUp]
        public void Setup()
        {
            var today = new DateTime();
            var temp = new DateTime(today.Year, today.Month, today.Day);
            currentDay = new Day(temp);
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(9,currentDay.Slots.Count);
        }
    }
}