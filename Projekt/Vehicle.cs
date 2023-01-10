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

        abstract public double getMetersUntilFuelDepleted();

        abstract public double getSecondsUntilRefueled();

        abstract public double getSpeedInMetersPerSecond();
    }
}
