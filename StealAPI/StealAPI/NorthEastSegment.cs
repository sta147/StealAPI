using System;
using System.Collections.Generic;
using System.Linq;
using StealAPI.Controllers;
using StealAPI.Models;

namespace StealAPI
{
    public class NorthEastDirection : IDirection
    {
        private Location location;
        

        public NorthEastDirection(List<Crime> crimelist, Location location) 
        {
            this.location = location;
            var count = crimelist.Count(x => x.Location.Longitude > location.Longitude
                                 && x.Location.Latitude > location.Latitude);
        }

        public int Bearing { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }
}