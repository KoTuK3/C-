using L11_Task01_DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_Task01_DAL.Configurations
{
    internal class AuthorConfig : EntityTypeConfiguration<Author>
    {
        public AuthorConfig()
        {
            this.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.HasMany(a => a.Books)
                .WithRequired(b => b.Author)
                .HasForeignKey(b => b.AuthorId);
        }
    }
}
