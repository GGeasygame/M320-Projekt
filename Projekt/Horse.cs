using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Horse : Movable
    {
        /// <summary>
        /// The speed in meters per second at which the horse moves.
        /// </summary>
        private const double speedInMetersPerSecond = 15;
        /// <summary>
        /// The distance in meters the horse can go until it needs a break.
        /// </summary>
        private const double breakIntervalInMeters = 3600;
        /// <summary>
        /// The time in seconds the horse needs in a break to no longer be exhausted.
        /// </summary>
        private const double breakTimeInSeconds = 300;


        /// <summary>
        /// Returns the time in seconds until a specified journey is complete. 
        /// The total time to complete the journey is calculated based on the speed, the break interval in meters and the break time in seconds.
        /// A horse needs breaks at every stop and additionally always at a given interval.
        /// </summary>
        /// <param name="journey">the specified journey for which the time is calculated</param>
        /// <returns>The time in seconds needed to complete the journey</returns>
        public double getSecondsUntilJourneyCompleted(Journey journey)
        {
            if (journey.getDistance() == 0)
            {
                return 0;
            }

            double time = journey.getStops().Count * breakTimeInSeconds;
            time += journey.getDistance() / getSpeedInMetersPerSecond();
            time += breakTimeInSeconds * Math.Floor(journey.getDistance() / breakIntervalInMeters);
            return time;
        }

        public double getSpeedInMetersPerSecond()
        {
            return speedInMetersPerSecond;
        }

        public string getDescription()
        {
            return "A horse can be used for riding.";
        }
    }
}
