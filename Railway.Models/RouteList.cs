using System.Collections.Generic;

namespace Railway.Models
{
    public class RouteList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Route> Routes { get; set; }
        public RouteList()
        {
            Routes = new List<Route>();
        }
    }
}
