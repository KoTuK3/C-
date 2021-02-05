using DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Configuraions
{
    internal class AccountConfig : EntityTypeConfiguration<Account>
    {
        public AccountConfig()
        {
            HasKey(a => a.ClientId);

            Property(a => a.Login)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("Login");

            Property(a => a.Password)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("Password");

            HasOptional(a => a.Client)
                .WithRequired(c => c.Account);
        }
    }
}
