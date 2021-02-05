using DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Configuraions
{
    internal class FlightConfig : EntityTypeConfiguration<Flight>
    {
        public FlightConfig()
        {

        }
    }
}
