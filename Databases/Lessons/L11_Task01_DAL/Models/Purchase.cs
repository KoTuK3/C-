using System;

namespace L11_Task01_DAL.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
