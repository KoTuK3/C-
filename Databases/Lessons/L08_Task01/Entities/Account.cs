using System.ComponentModel.DataAnnotations;

namespace L08_Task01.Entities
{
    public class Account
    {
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        public int? ClientId { get; set; }
        public Client Client { get; set; }
    }
}
