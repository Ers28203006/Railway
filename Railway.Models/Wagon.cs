using System.Collections.Generic;

namespace Railway.Models
{
    public class Wagon
    {
        public int Id { get; set; }
        public int WagonNumber { get; set; }
        public virtual ICollection<Place> Places { get; set; }
        public Wagon()
        {
            Places = new List<Place>();
        }
        public int TrainId { get; set; }
        public virtual Train Train { set; get; }
    }
}