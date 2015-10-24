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
    public class CrimeController : ApiController
    {
        public Crime GetARandomCrime()
        {
            CrimeFetcher crimeFetcher = new CrimeFetcher();
            var crimelist = crimeFetcher.FetchACrime();
            if (crimelist.Count > 0)
                return crimelist[0];

            return new Crime()
            {
                Location = new LocationModel()
            };
        }
        public Crime GetACrimeSomewhereNearLocation(float lat, float lng)
        {
            return new Crime();
        }
    }
}
