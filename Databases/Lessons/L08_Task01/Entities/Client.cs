using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace L08_Task01.Entities
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        [ForeignKey(nameof(Account))]
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
    }
}