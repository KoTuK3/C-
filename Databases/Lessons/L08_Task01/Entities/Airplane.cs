using System.Collections.Generic;

namespace L08_Task01.Entities
{
    public class Airplane
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int? MaxPassangers { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }
    }
}