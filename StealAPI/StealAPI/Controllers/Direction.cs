using System.Threading;

namespace StealAPI.Controllers
{
    public class Direction : IDirection
    {
        public string Name { get; set; }
        public int Bearing { get; set; }
        public int Count  { get; set; }       
    }
}