using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_Task01
{
    class RentService
    {
        private readonly RentDBEntities _context;

        public RentService()
        {
            _context = new RentDBEntities();
        }

        public IEnumerable<Rents> GetUserRents(int id)
        {
            return _context.Rents.Where(r => r.UserId == id);
        }

        public void AddRent(Rents rent)
        {
            _context.Rents.Add(rent);
            _context.SaveChanges();
        }
    }
}
