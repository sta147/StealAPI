using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using StealAPI.Models;

namespace StealAPI.Fetchers
{
    public class CrimeFetcher
    {
        private const string CrimesAtLocationUri = "https://data.police.uk/api/crimes-at-location";

        public List<Crime> FetchSomeCrimes()
        {
            var mosiLocation = new Location()
            {
                Longitude = -2.255562,
                Latitude = 53.476788
            };
            return FetchCrimesNearLocation(mosiLocation);
            
        }

        public List<Crime> FetchCrimesNearLocation(Location location)
        {
            
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri(CrimesAtLocationUri);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                string uriQuerystring = 
                    string.Format("?date=2013-07&lat={0}&lng={1}", 
                         location.Latitude, location.Longitude  );
                
                HttpResponseMessage response = client.GetAsync(uriQuerystring).Result;
                if (response.IsSuccessStatusCode)
                {
                    var crimes = response.Content.ReadAsAsync<IEnumerable<Crime>>().Result;

                    return crimes.ToList();
                }
                else
                {
                    throw new Exception(
                        string.Format("{0} ({1})", (int) response.StatusCode, response.ReasonPhrase));
                }
            }

        }
    }
}