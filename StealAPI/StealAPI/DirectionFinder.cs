using System.Collections.Generic;
using System.Linq;
using System.Web;
using StealAPI.Controllers;
using StealAPI.Fetchers;
using StealAPI.Models;

namespace StealAPI
{
    public class DirectionFinder
    {
        private Location location;

        public DirectionFinder(Location location)
        {
            this.location = location;
        }

        public Direction BestDirection()
        {

            var crimeFetcher = new CrimeFetcher();
            var crimelist = crimeFetcher.FetchCrimesNearLocation(location);
            if (crimelist.Count > 0)
            {
                NorthEastDirection northEastDirection = new NorthEastDirection(
                    x => x.Location.Longitude > location.Longitude
                        && x.Location.Latitude > location.Latitude, 
                        crimelist, location);
            }
            return new Direction()
            {
                Name = "North East",
                Bearing = 45,
                Count = 5
            };
        }
    }
}