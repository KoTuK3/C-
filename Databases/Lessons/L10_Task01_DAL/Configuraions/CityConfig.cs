using DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Configuraions
{
    internal class CityConfig : EntityTypeConfiguration<City>
    {
        public CityConfig()
        {
            Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("Name");

            HasOptional(ci => ci.Country)
                .WithMany(co => co.Cities)
                .HasForeignKey(ci => ci.CountryId)
                .WillCascadeOnDelete(false);

            HasMany(c => c.FlightsFrom)
                .WithOptional(f => f.CityFrom);

            HasMany(c => c.FlightsTo)
                .WithOptional(f => f.CityTo);
        }
    }
}
