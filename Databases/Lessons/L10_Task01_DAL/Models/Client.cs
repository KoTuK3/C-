﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        [MaxLength(50)]
        public string Gender { get; set; }

        // FOREIGN KEYS
        public int? AccountId { get; set; }

        // NAVIGATION PROPERTIES
        public virtual Account Account { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
