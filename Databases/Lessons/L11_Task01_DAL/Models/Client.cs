using System.Collections.Generic;

namespace L11_Task01_DAL.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<Book> FavoriteBooks { get; set; }
    }
}
