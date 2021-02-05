using System.ComponentModel.DataAnnotations;

namespace L09_Task01_DAL.Entity
{
    public class Service
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Duration { get; set; }
    }
}
