using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StealAPI.Fetchers;

namespace StealAPI.Tests
{
    [TestClass]
    public class CrimeFetcherTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var crimeFretcher = new CrimeFetcher();
            var crimeList = crimeFretcher.FetchACrime();

        }
    }
}
