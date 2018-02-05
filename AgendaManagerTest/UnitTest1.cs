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

        [Test]
        public void checkDates() {
            DateTime today = new DateTime();
            DateTime temp = new DateTime(today.Year,today.Month,today.Day,9,0,0);
            currentDay.AddAppointement(temp,"jean","");
            temp = temp.AddHours((double)1);
            currentDay.AddAppointement(temp,"fred","");
            string dayDate = today.Year + "-" + today.Month + "-" + today.Day;
            foreach(ISlot sl in currentDay.Slots) {
                string date = sl.StartTime.Year + "-" + sl.StartTime.Month + "-" + sl.StartTime.Day;
                Assert.AreEqual(date,dayDate);
            }
        }
    }
}