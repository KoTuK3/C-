using L11_Task01_DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_Task01_DAL.Configurations
{
    internal class PurchaseConfig : EntityTypeConfiguration<Purchase>
    {
        public PurchaseConfig()
        {
            this.Property(p => p.Price)
                .IsRequired();

            this.Property(p => p.Date)
                .IsRequired();

            this.HasRequired(p => p.Client)
                .WithMany(c => c.Purchases)
                .HasForeignKey(p => p.ClientId);

            this.HasRequired(p => p.Book)
                .WithMany(b => b.Purchases)
                .HasForeignKey(p => p.BookId);
        }
    }
}
