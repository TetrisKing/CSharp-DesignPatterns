using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Observer
{
    public struct Location
    {
        double lat, lon;
        public Location(double lat, double lon)
        {
            this.lat = lat;
            this.lon = lon;
        }

        public double Latitude { get { return this.lat; } }
        public double Longitude { get { return this.lon; } }
    }
}
