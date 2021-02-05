using System;
using System.ComponentModel.DataAnnotations;

namespace L09_Task01_DAL.Entity
{
    public class Schedule
    {
        [Required]
        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int BarberId { get; set; }
        public virtual Barber Barber { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
