using System;
using System.Collections.Generic;
using System.Linq;
using StealAPI.Controllers;
using StealAPI.Models;

namespace StealAPI
{
    public class NorthEastDirection : IDirection
    {

        public NorthEastDirection(Func<Crime, bool> predicate, List<Crime> crimelist, Location location) 
        {
            Count = crimelist.Count( predicate);
        }
        

        public int Bearing { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }
}