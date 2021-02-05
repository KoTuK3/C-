using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L09_Task01_DAL.Entity
{
    public class Client
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
