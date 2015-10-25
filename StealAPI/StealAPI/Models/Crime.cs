using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StealAPI.Models
{
    public class Crime
    {
        public Crime()
        {
            Location = new Location(0, 0);
        }
        
        public int Id { get; set; }
        public string PersistentId { get; set; }
        public string Context { get; set; }
        public string Category { get; set; }
        public Location Location { get; set; }
        
    }
}