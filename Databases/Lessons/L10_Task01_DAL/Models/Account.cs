using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Account
    {
        public int ClientId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        // NAVIGATION PROPERTIES
        public virtual Client Client { get; set; }
    }
}
