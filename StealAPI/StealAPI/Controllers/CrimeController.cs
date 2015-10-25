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
        public Crime GetACrimeSomewhereNearLocation(double lat, double lng)
        {
            var location = new Location(lng, lat);
            var crimeFetcher = new CrimeFetcher();
            var crimelist = crimeFetcher.FetchCrimesNearLocation(location);
            if (crimelist.Count > 0)
                return crimelist[0];

            return new Crime();
        }
    }
}
