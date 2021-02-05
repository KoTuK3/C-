using DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Configuraions
{
    internal class CountryConfig : EntityTypeConfiguration<Country>
    {
        public CountryConfig()
        {

        }
    }
}
