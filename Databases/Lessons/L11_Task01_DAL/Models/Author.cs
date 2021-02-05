using System.Collections.Generic;

namespace L11_Task01_DAL.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
