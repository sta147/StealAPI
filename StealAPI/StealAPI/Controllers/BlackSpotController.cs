using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;
using StealAPI.Fetchers;
using StealAPI.Models;

namespace StealAPI.Controllers
{
    [RoutePrefix("api/BlackSpot")]
    public class BlackSpotController : ApiController
    {
        [HttpGet]
        [Route("DirectionFromLocation")]
        public Direction DirectionFromLocation(float lat, float lng)
        {
            var location = new Location(lng, lat);
            var directionFinder = new DirectionFinder(location);
            return directionFinder.BestDirection();
        }
    }
}
