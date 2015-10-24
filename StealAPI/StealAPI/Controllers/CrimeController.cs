using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StealAPI.Fetchers;
using StealAPI.Models;

namespace StealAPI.Controllers
{
    [RoutePrefix("api/Crime")]
    public class CrimeController : ApiController
    {

        [HttpGet]
        [Route("GetARandomCrime")]
        public Crime GetARandomCrime()
        {
            CrimeFetcher crimeFetcher = new CrimeFetcher();
            var crimelist = crimeFetcher.FetchSomeCrimes();
            if (crimelist.Count > 0)
                return crimelist[0];

            return new Crime();
        }

        [HttpGet]
        [Route("GetACrimeSomewhereNearLocation")]
        public Crime GetACrimeSomewhereNearLocation(float lat, float lng)
        {
            var location = new Location()
            {
                Longitude = lng,
                Latitude = lat
            };
            CrimeFetcher crimeFetcher = new CrimeFetcher();
            var crimelist = crimeFetcher.FetchCrimesNearLocation(location);
            if (crimelist.Count > 0)
                return crimelist[0];

            return new Crime();
        }
    }
}
