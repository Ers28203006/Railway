using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway.Models
{
    public class Train
    {
        [Key]
        [ForeignKey("Route")]
        public int Id { get; set; }
        public int TrainNumber { get; set; }
        public virtual ICollection<Wagon> Wagons { get; set; }
        public Train()
        {
            Wagons = new List<Wagon>();
        }
        public virtual Route Route { get; set; }
    }
}