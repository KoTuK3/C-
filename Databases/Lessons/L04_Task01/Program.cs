using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_Task01
{
    internal class SalesService
    {
        private DataClasses1DataContext _context;
        public SalesService()
        {
            _context = new DataClasses1DataContext();
        }

        public Client GetClientById(int id)
        {
            return _context.Clients.FirstOrDefault(c => c.Id == id);
        }

        public Seller GetSellerById(int id)
        {
            return _context.Sellers.FirstOrDefault(s => s.Id == id);
        }

        public void AddSale(Sale sale)
        {
            _context.Sales.InsertOnSubmit(sale);
            _context.SubmitChanges();
        }

        public IEnumerable<Sale> GetAllByPeriod(DateTime date1, DateTime date2)
        {
            return _context.Sales.Where(s => s.Date > date1 && s.Date < date2);
        }

        //public Sale GetLastSale(string name, string surname)
        //{
        //    return _context.Clients.Where(c => c.Name == name && c.Surname == surname).Select(c => c.Sales.OrderByDescending(s => s.Date)).FirstOrDefault();
        //}

        public void DeleteClientById(int id)
        {
            var client = GetClientById(id);
            if (client != null)
            {
                _context.Clients.DeleteOnSubmit(client);
                _context.SubmitChanges();
            }
        }

        public void DeleteSalerById(int id)
        {
            var seller = GetSellerById(id);
            if (seller != null)
            {
                _context.Sellers.DeleteOnSubmit(seller);
                _context.SubmitChanges();
            }
        }

        //public Seller GetSellerWithMaxSales()
        //{
        //    return _context.Sellers.Where(s => s.Id == _context.Sales.Where(sa => sa.Price == _context.Sales.Max(sa => sa.Price)));
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
