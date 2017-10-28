using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geo_Triangulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo_Triangulation.Tests
{
    [TestClass()]
    public class StormDataTests
    {
        [TestMethod()]
        public void StormDataTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CalculateDistanceFromUserTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CalculateTimeBetweenButtonPressesTest()
        {
            StormData stormData = new StormData();
            double timeResult = stormData.CalculateTimeBetweenButtonPresses();
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCompassDirectionWithBoundsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ConvertMeterstoMilesTest()
        {
            StormData stormData = new StormData();
            double result = stormData.ConvertMeterstoMilesTest(10);
            double resultShouldBe = 0.00621371;
            Assert.Equals(result, resultShouldBe);
        }

        [TestMethod()]
        public void TimeFactoringPingTest()
        {
            StormData stormData = new StormData();
            DateTime shouldFailAndReturn0Date = stormData.TimeFactoringPing(new DateTime(2017,05,18,12,30,20),"www.failtoping555.org");
            var shouldPassWithAnyResult = stormData.TimeFactoringPing(new DateTime(2017, 05, 18, 12, 30, 20),"www.google.co.uk");
            Assert.Equals(shouldFailAndReturn0Date(), new DateTime(0000,0,0));

        }
    }
}