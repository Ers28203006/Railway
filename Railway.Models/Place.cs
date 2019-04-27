namespace Railway.Models
{
    public class Place
    {
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public double Price { get; set; }
        public string PlacesLocations { get; set; }
        public string Class { get; set; }
        public int? WagonId { get; set; }
        public virtual Wagon Wagon { get; set; }
    }
}