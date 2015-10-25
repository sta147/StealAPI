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
                NorthEastDirection northEastDirection = new NorthEastDirection(crimelist, location);
            }
            return new Direction();
        }
    }
}