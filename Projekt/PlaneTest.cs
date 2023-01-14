using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    [TestFixture]
    class PlaneTest
    {
        [Test]
        public void returnsSecondsToCompleteForShortJourney()
        {
            // arrange
            Journey journey = new Journey(500000);
            Plane plane = new Plane();

            // act
            double result = plane.getSecondsUntilJourneyCompleted(journey);

            // assert
            Assert.AreEqual(1550.0, result);
        }

        [Test]
        public void returnsSecondsToCompleteForLongJourney()
        {
            // arrange
            Journey journey = new Journey(700000);
            journey.addStop(140000);
            journey.addStop(500000);
            Plane plane = new Plane();

            // act
            double result = plane.getSecondsUntilJourneyCompleted(journey);

            // assert
            Assert.AreEqual(5780.0, result);
        }
    }
}
