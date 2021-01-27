using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_Task01.Service
{
    class DepartmentService
    {
        private readonly RentDBEntities _context;

        public DepartmentService()
        {
            _context = new RentDBEntities();
        }

        public IEnumerable<Departments> GetDepartments(int? square = null)
        {
            var departments = _context.Departments.AsQueryable();

            if (square != null)
                departments = departments.Where(d => d.Square == square);

            return departments;
        }
    }
}
