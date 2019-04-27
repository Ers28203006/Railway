using System.Collections.Generic;

namespace Railway.Models
{
    public class Route
    {
        public int Id { get; set; }
        public virtual ICollection<City> City { get; set; }
        public virtual Train Train { get; set; }
        public Route()
        {
            City = new List<City>();
        }
        public int RouteListId { get; set; }
        public virtual RouteList RouteList { get; set; }
    }
}
