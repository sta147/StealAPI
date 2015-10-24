using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StealAPI.Models;

namespace StealAPI.Controllers
{
    public class CrimeController : ApiController
    {
        public Crime GetAEmptyCrime()
        {
            return new Crime();
        }
        public Crime GetACrimeSomewhereNearLocation(float lat, float lng)
        {
            return new Crime();
        }
    }
}
