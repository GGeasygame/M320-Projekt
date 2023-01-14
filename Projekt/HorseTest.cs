using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    [TestFixture]
    class HorseTest
    {
        [Test]
        public void returnsSecondsToCompleteForShortJourney()
        {
            // arrange
            Journey journey = new Journey(10000);
            Horse horse = new Horse();

            // act
            double result = horse.getSecondsUntilJourneyCompleted(journey);

            // assert
            Assert.AreEqual(1266.6666666666665, result);
        }

        [Test]
        public void returnsSecondsToCompleteForLongJourney()
        {
            // arrange
            Journey journey = new Journey(4000);
            journey.addStop(7000);
            journey.addStop(5000);
            Horse horse = new Horse();

            // act
            double result = horse.getSecondsUntilJourneyCompleted(journey);

            // assert
            Assert.AreEqual(2866.666666666667, result);
        }
    }
}
