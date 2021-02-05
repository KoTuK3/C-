using L11_Task01_DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_Task01_DAL.Configurations
{
    internal class ClientConfig : EntityTypeConfiguration<Client>
    {
        public ClientConfig()
        {
            this.Property(c => c.Login)
                .HasMaxLength(100)
                .IsRequired();

            this.Property(c => c.Password)
                .HasMaxLength(100)
                .IsRequired();

            this.HasMany(c => c.Purchases)
                .WithRequired(p => p.Client)
                .HasForeignKey(p => p.ClientId);

            // Test
            this.HasMany(c => c.FavoriteBooks);
        }
    }
}
