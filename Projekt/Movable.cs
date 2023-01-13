using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    interface Movable
    {
        /// <summary>
        /// Get the amount of seconds until the specified journey is completed with the given movable.
        /// </summary>
        /// <param name="journey">Journey which the time will be calculated for</param>
        /// <returns>the time in seconds it takes to complete the journey</returns>
        double getSecondsUntilJourneyCompleted(Journey journey);

        double getSpeedInMetersPerSecond();

        string getDescription();
    }
}
