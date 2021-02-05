using DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Configuraions
{
    internal class ClientConfig : EntityTypeConfiguration<Client>
    {
        public ClientConfig()
        {
            Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("Name");

            Property(c => c.Surname)
                .HasMaxLength(100)
                .IsRequired()                
                .HasColumnName("Surname");

            Property(c => c.Gender)
                .HasMaxLength(50)
                .HasColumnName("Gender");

            HasRequired(c => c.Account)
                .WithOptional(a => a.Client);
        }
    }
}
