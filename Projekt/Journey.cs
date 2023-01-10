using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Journey
    {
        private double distanceInMeters;
        private ArrayList stops = new ArrayList();

        public Journey(double distanceInMeters)
        {
            this.distanceInMeters = distanceInMeters;
            stops.Add(distanceInMeters);
        }

        public Journey() { }

        public double getDistance()
        {
            return distanceInMeters;
        }

        public void addStop(double distanceInMetersUntilStop)
        {
            stops.Add(distanceInMetersUntilStop);
            distanceInMeters += distanceInMetersUntilStop;
        }

        public ArrayList getStops()
        {
            return stops;
        }
    }
}
