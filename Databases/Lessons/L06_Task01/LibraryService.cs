using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_Task01
{
    public class LibraryService
    {
        private readonly Model1Container _context;

        public LibraryService()
        {
            _context = new Model1Container();
        }

        public IEnumerable<Books> Task01()
        {
            return _context.BooksSet.Where(b => b.Pages > 100);
        }

        public IEnumerable<Books> Task02()
        {
            return _context.BooksSet.Where(b => b.Name.ToLower().StartsWith("a"));
        }

        public IEnumerable<Books> Task03()
        {
            return _context.BooksSet.Where(b => b.Authors.Name.Equals("William Shakespeare"));
        }

        public IEnumerable<Books> Task04()
        {
            return _context.BooksSet.Where(b => b.Languages.Name.Equals("Ukraine"));
        }

        public IEnumerable<Books> Task05()
        {
            return _context.BooksSet.Where(b => b.Name.Count() < 10);
        }

        public Books Task06()
        {
            return _context.BooksSet
                .Where(b => b.Languages.Countries.Name != "USA")
                .OrderByDescending(b => b.Pages)
                .FirstOrDefault();
        }

        public Authors Task07()
        {
            return _context.AuthorsSet
                .OrderBy(a => a.Books.Count())
                .FirstOrDefault();
        }

        public IEnumerable<string> Task08()
        {
            return _context.AuthorsSet
                .Where(a => a.Books.Where(b => b.Languages.Equals("USA")).Count() == 0)
                .Select(a => $"{a.Surname} {a.Name}")
                .OrderBy(n => n);
        }

        //public Countries Task09()
        //{
        //    return _context.CountriesSet
        //        .Where(c=>c.Languages.Where()
        //}
    }
}
