namespace Railway.DataAccess
{
    using Railway.Models;
    using System.Data.Entity;

    public class RailwaysContext : DbContext
    {
        public RailwaysContext()
            : base("name=RailwaysContext")
        {
        }
        public DbSet<Place> Places { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<RouteList> RouteLists { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<Wagon> Wagons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}