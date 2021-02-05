using System;
using System.Collections.Generic;

namespace L11_Task01_DAL.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int Pages { get; set; }
        public string Genre { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal CostPrice { get; set; }
        public decimal Price { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public int NextBookId { get; set; }
        public Book NextBook { get; set; }
        public int PrevBookId { get; set; }
        public Book PrevBook { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
