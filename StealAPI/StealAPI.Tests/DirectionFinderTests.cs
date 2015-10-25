using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StealAPI.Fetchers;
using StealAPI.Models;

namespace StealAPI.Tests
{
    [TestClass]
    public class DirectionFinderTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var crimeFretcher = new CrimeFetcher();
            var mosiLocation = new Location(-2.255562, 53.476788);
            var crimeList = crimeFretcher.FetchCrimesNearLocation(mosiLocation);
            var northEastDirection = new NorthEastDirection(x => x.Location.Longitude > mosiLocation.Longitude
                        && x.Location.Latitude > mosiLocation.Latitude, crimeList, mosiLocation);
            var numberOfCrimesToTheNorthEast = northEastDirection.Count;
            Assert.AreNotEqual(numberOfCrimesToTheNorthEast, crimeList.Count);
        }
    }
}
