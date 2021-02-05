using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L08_Task01.Entities
{
    public class Flight
    {
        public int Id { get; set; }
        [Required]
        public string Number { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }

        public int AirplaneId { get; set; }
        public Airplane Airplane { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}