using DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Configuraions
{
    internal class AirplaneConfig : EntityTypeConfiguration<Airplane>
    {
        public AirplaneConfig()
        {
            Property(a => a.Model)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("Model");

            HasRequired(a => a.Type)
                .WithMany(t => t.Airplanes)
                .HasForeignKey(a => a.TypeId)
                .WillCascadeOnDelete(false);

            HasOptional(a => a.Country)
                .WithMany(c => c.Airplanes)
                .HasForeignKey(a => a.CountryId)
                .WillCascadeOnDelete(false);

            HasMany(a => a.Flights)
                .WithOptional(f => f.Airplane);
        }
    }
}
