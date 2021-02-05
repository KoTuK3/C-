using System.ComponentModel.DataAnnotations;

namespace L09_Task01_DAL.Entity
{
    public class Feedback
    {
        [Required]
        public int Id { get; set; }
        public string Content { get; set; }

        [Required]
        public int Rating { get; set; }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public int BarberId { get; set; }
        public virtual Barber Barber { get; set; }
    }
}
