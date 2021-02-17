using L11_Task01_DAL.Configurations;
using L11_Task01_DAL.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace L11_Task01_DAL.EF
{
    public class BookShop : DbContext
    {        
        public BookShop()
            : base("name=BookShop")
        {
            Database.SetInitializer(new Initializer());
        }        

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<Client> Client { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
                        
            modelBuilder.Configurations.Add(new AuthorConfig());
            modelBuilder.Configurations.Add(new BookConfig());
            modelBuilder.Configurations.Add(new ClientConfig());
            modelBuilder.Configurations.Add(new PurchaseConfig());
        }
    }
}