using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StealAPI.Models
{
    public class Location
    {
        public Location(double lng, double lat)
        {
            Longitude = lng;
            Latitude = lat;
        }

        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}