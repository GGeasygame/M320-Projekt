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

        /// <summary>
        /// Returns the time in seconds until a specified journey is complete. 
        /// The total time to complete the journey is calculated based on the speed, meters until fuel depleted and time to refuel.
        /// </summary>
        /// <param name="journey">the specified journey for which the time is calculated</param>
        /// <returns>The time in seconds needed to complete the journey</returns>
        public override double getSecondsUntilJourneyCompleted(Journey journey)
        {
            if (journey.getDistance() == 0)
            {
                return 0;
            }

            double time = journey.getDistance() / getSpeedInMetersPerSecond();
            time += getSecondsUntilRefueled() * Math.Floor(journey.getDistance() / getMetersUntilFuelDepleted());
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

        public override string getDescription()
        {
            return base.getDescription() + "\n A car is a land vehicle";
        }
    }
}
