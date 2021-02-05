using L11_Task01_DAL.EF;
using L11_Task01_DAL.Models;
using System;

namespace L11_Task01_DAL.Repositories
{
    public class UnitOfWork : IDisposable
    {
        private readonly BookShop _context;
        private GenericRepository<Book> _bookRepository;
        private GenericRepository<Author> _authorRepository;
        private GenericRepository<Client> _clientRepository;
        private GenericRepository<Purchase> _purchaseRepository;

        public UnitOfWork()
        {
            _context = new BookShop();

        }

        public GenericRepository<Book> BookRepository
        {
            get
            {
                if (_bookRepository == null)
                    _bookRepository = new GenericRepository<Book>(_context);
                return _bookRepository;
            }
        }

        public GenericRepository<Author> AuthorRepository
        {
            get
            {
                if (_authorRepository == null)
                    _authorRepository = new GenericRepository<Author>(_context);
                return _authorRepository;
            }
        }

        public GenericRepository<Client> ClientRepository
        {
            get
            {
                if (_clientRepository == null)
                    _clientRepository = new GenericRepository<Client>(_context);
                return _clientRepository;
            }
        }

        public GenericRepository<Purchase> PurchaseRepository
        {
            get
            {
                if (_purchaseRepository == null)
                    _purchaseRepository = new GenericRepository<Purchase>(_context);
                return _purchaseRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
