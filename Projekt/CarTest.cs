using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    [TestFixture]
    class CarTest
    {
        [Test]
        public void returnsSecondsToCompleteForShortJourney()
        {
            // arrange
            Journey journey = new Journey();
            journey.addStop(10000);
            Car car = new Car();

            // act
            double result = car.getSecondsUntilJourneyCompleted(journey);

            Assert.AreEqual(100.0, result);
        }

        [Test]
        public void returnsSecondsToCompleteForLongJourney()
        {
            // arrange
            Journey journey = new Journey();
            journey.addStop(1000000);
            Car car = new Car();

            // act
            double result = car.getSecondsUntilJourneyCompleted(journey);

            Assert.AreEqual(19600.0, result);
        }
    }
}
