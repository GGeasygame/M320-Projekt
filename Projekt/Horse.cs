using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Horse : Movable
    {
        private const double speedInMetersPerSecond = 15;
        private const double breakIntervalInMeters = 3600;
        private const double breakTimeInSeconds = 300;

        public double getSecondsUntilJourneyCompleted(Journey journey)
        {
            double time = 0;
            double distanceRidden = 0;
            foreach (double distance in journey.getStops())
            {
                distanceRidden += distance;
                time += distance / getSpeedInMetersPerSecond();
                time += breakTimeInSeconds * Math.Floor(distanceRidden / breakIntervalInMeters);
                time += breakTimeInSeconds;
            }
            return time - breakTimeInSeconds;
        }

        public double getSpeedInMetersPerSecond()
        {
            return speedInMetersPerSecond;
        }
    }
}
