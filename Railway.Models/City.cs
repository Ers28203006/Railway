namespace Railway.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RouteId { get; set; }
        public virtual Route Route { set; get; }
    }
}