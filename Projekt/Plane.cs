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

        public override double getSecondsUntilJourneyCompleted(Journey journey)
        {
            if (journey.getDistance() == 0)
            {
                return 0;
            }
          
            double time = (getSecondsUntilRefueled() + timeToLandInSeconds + timeToTakeOff) * Math.Floor(journey.getDistance() / getMetersUntilFuelDepleted());
            time += journey.getDistance() / getSpeedInMetersPerSecond();
            return time;
        }

        public override string getDescription()
        {
            return base.getDescription() + "\n A plane is a flying vehicle.";
        }
    }
}
