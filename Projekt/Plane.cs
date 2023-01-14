using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Plane : Vehicle
    {
        private double metersUntilFuelDepleted = 1000000;
        private double secondsUntilRefueled = 900;
        private double speedInMetersPerSecond = 500;

        /// <summary>
        /// The amount of time in seconds needed to land a plane.
        /// </summary>
        private double timeToLandInSeconds = 300;

        /// <summary>
        /// The amount of time in seconds needed for take off with a plane.
        /// </summary>
        private double timeToTakeOff = 250;


        public override double getMetersUntilFuelDepleted()
        {
            return metersUntilFuelDepleted;
        }

        public override double getSecondsUntilRefueled()
        {
            return secondsUntilRefueled;
        }

        public override double getSpeedInMetersPerSecond()
        {
            return speedInMetersPerSecond;
        }


        /// <summary>
        /// Returns the time in seconds until a specified journey is complete. 
        /// The total time to complete the journey is calculated based on the speed, meters until fuel depleted, time to refuel, landing time, takeoff time and number of stops.
        /// </summary>
        /// <param name="journey">the specified journey for which the time is calculated</param>
        /// <returns>The time in seconds needed to complete the journey</returns>
        public override double getSecondsUntilJourneyCompleted(Journey journey)
        {
            if (journey.getDistance() == 0)
            {
                return 0;
            }

            double time = journey.getStops().Count * (timeToLandInSeconds + timeToTakeOff);
            time += (getSecondsUntilRefueled() + timeToLandInSeconds + timeToTakeOff) * Math.Floor(journey.getDistance() / getMetersUntilFuelDepleted());
            time += journey.getDistance() / getSpeedInMetersPerSecond();
            return time;
        }

        public override string getDescription()
        {
            return base.getDescription() + "\n A plane is a flying vehicle.";
        }
    }
}
