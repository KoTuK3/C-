using L11_Task01_DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_Task01_DAL.Configurations
{
    internal class BookConfig : EntityTypeConfiguration<Book>
    {
        public BookConfig()
        {
            this.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(b => b.Publisher)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(b => b.Pages)
                .IsRequired();

            this.Property(b => b.Genre)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(b => b.PublicationDate)
                .IsRequired();

            this.Property(b => b.CostPrice)
                .IsRequired();

            this.Property(b => b.Price)
                .IsRequired();

            this.HasRequired(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId)
                .WillCascadeOnDelete(false);

            this.HasOptional(b => b.NextBook)
                .WithMany()
                .HasForeignKey(b => b.NextBookId);

            this.HasOptional(b => b.PrevBook)
                .WithMany()
                .HasForeignKey(b => b.PrevBookId);
        }
    }
}
