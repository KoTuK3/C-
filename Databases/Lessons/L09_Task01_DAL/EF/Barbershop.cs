using L09_Task01_DAL.Entity;
using System.Data.Entity;

namespace L09_Task01_DAL
{
    public class Barbershop : DbContext
    {
        public Barbershop()
            : base("name=Barbershop")
        {
        }

        public virtual DbSet<Barber> Barbers { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Service> Services { get; set; }
    }
}