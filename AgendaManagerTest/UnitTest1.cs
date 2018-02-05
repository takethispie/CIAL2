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
            currentDay = new Day(new DateTime());
        }

        [Test]
        public void CorrectCountOfFreeSlot()
        {
            Assert.AreEqual(10,currentDay.Slots.Count);
        }

        [Test]
        public void AddAppointement()
        {
            DateTime today = new DateTime();
            DateTime temp = new DateTime(today.Year,today.Month,today.Day,9,0,0);
            bool result = currentDay.AddAppointement(temp,"jean","");
            Assert.AreEqual(result, true);
        }
    }
}