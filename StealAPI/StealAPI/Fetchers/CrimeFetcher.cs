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
        private string policUrl = "https://data.police.uk/api/crimes-at-location?date=2013-06&lat=53.471906&lng=-2.257676";

        public List<Crime> FetchACrime()
        {
            List<Crime> crimeList = new List<Crime>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(policUrl);


            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));


            HttpResponseMessage response = client.GetAsync("").Result;  
            if (response.IsSuccessStatusCode)
            {
                var crimes = response.Content.ReadAsAsync<IEnumerable<Crime>>().Result;

                return crimes.ToList();
                foreach (var crime in crimes)
                {
                    crimeList.Add(crime);
                }
            }
            else
            {
                throw  new Exception(
                    string.Format("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase));
            }

            return crimeList;
        } 
    }
}