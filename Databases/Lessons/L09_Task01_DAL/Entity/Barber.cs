using System;
using System.Collections.Generic;

namespace L09_Task01_DAL.Entity
{
    public class Barber
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string Position { get; set; }


        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
