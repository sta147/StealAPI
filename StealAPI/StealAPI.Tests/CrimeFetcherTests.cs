using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StealAPI.Fetchers;
using StealAPI.Models;

namespace StealAPI.Tests
{
    [TestClass]
    public class CrimeFetcherTests
    {
        [TestMethod]
        public void CrimeFretcherCanFetchACrime()
        {
            var crimeFretcher = new CrimeFetcher();
            var crimeList = crimeFretcher.FetchSomeCrimes();
            Assert.AreNotEqual(0, crimeList.Count);

        }
        [TestMethod]
        public void CrimeFretcherCanFetchACrimeSomewhereNearALocation()
        {
            var crimeFretcher = new CrimeFetcher();
            var mosiLocation = new Location()
            {
                Longitude = -2.255562,
                Latitude = 53.476788
            };
            var crimeList = crimeFretcher.FetchCrimesNearLocation(mosiLocation);
            Assert.AreNotEqual(0, crimeList.Count);

        }
    }
}
