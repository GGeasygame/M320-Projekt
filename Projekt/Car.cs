using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Car : Vehicle
    {
        private const double metersUntilFuelDepleted = 60000;
        private const double secondsUntilRefueled = 600;
        private const double speedInMetersPerSecond = 100;

        public override double getMetersUntilFuelDepleted()
        {
            return metersUntilFuelDepleted;
        }

        public override double getSecondsUntilJourneyCompleted(Journey journey)
        {
            double time = 0;
            double distanceDriven = 0;
            foreach (double distance in journey.getStops())
            {
                distanceDriven += distance;
                time += secondsUntilRefueled * Math.Floor(distanceDriven / metersUntilFuelDepleted);
                time += distance / getSpeedInMetersPerSecond();
            }
            return time;
        }

        public override double getSecondsUntilRefueled()
        {
            return secondsUntilRefueled;
        }

        public override double getSpeedInMetersPerSecond()
        {
            return speedInMetersPerSecond;
        }
    }
}
