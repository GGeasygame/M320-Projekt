using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    abstract class Vehicle : Movable
    {
        abstract public double getSecondsUntilJourneyCompleted(Journey journey);

        /// <summary>
        /// The distance in meters a vehicle can drive until its fuel is depleted.
        /// </summary>
        /// <returns>distance in meters</returns>
        abstract public double getMetersUntilFuelDepleted();

        /// <summary>
        /// The amount of time in seconds needed to fully refuel a vehicle when its tank is empty.
        /// </summary>
        /// <returns></returns>
        abstract public double getSecondsUntilRefueled();

        /// <summary>
        /// The speed in meters per second at which a vehicle moves.
        /// </summary>
        /// <returns></returns>
        abstract public double getSpeedInMetersPerSecond();

        virtual public string getDescription()
        {
            return "A vehicle is a thing used for transporting people or goods, such as a car or plane.";
        }
    }
}
