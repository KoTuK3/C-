using L11_Task01_DAL.Models;
using L11_Task01_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace L11_Task01_DAL.Services
{
    public class BookService
    {
        private readonly UnitOfWork _unitOfWork;

        public BookService()
        {
            _unitOfWork = new UnitOfWork();
        }

        public IEnumerable<Book> GetBooks()
        {
            return _unitOfWork.BookRepository.Get(b => true);
        }

        public Book GetBookByName(string name)
        {
            return _unitOfWork.BookRepository.Get()
                .Where(b => b.Name == name)
                .FirstOrDefault();
        }

        public Book GetBookByAuthorName(string authorName)
        {
            return _unitOfWork.BookRepository.Get()
                .Where(b => b.Author.Name == authorName)
                .FirstOrDefault();
        }

        public Book GetBookByGenre(string genre)
        {
            return _unitOfWork.BookRepository.Get()
                .Where(b => b.Genre == genre)
                .FirstOrDefault();
        }

        public IEnumerable<Book> GetNewBooks(int num, DateTime from, DateTime to)
        {
            if (num <= 0)
                throw new ArgumentException("Number must be greater than zero");

            if (from >= to)
                throw new ArgumentException("To must be later than from");

            return _unitOfWork.BookRepository.Get()
                .Where(b => from < b.PublicationDate && b.PublicationDate < to)
                .OrderByDescending(b => b.PublicationDate)
                .Take(num);
        }

        public IEnumerable<Book> GetBestSellers(int num, DateTime from, DateTime to)
        {
            if (num <= 0)
                throw new ArgumentException("Number must be greater than zero");

            if (from >= to)
                throw new ArgumentException("\'To\' must be later than \'from\'");

            return _unitOfWork.BookRepository.Get()
                .OrderByDescending(b => b.Purchases.Where(p => from < p.Date && p.Date < to).Count())
                .Take(num);
        }

        // Move to author service
        public IEnumerable<Author> GetBestAuthors(int num, DateTime from, DateTime to)
        {
            try
            {
                return GetBestSellers(num, from, to)
                    .Select(b => b.Author);
            }
            catch
            {
                throw;
            }
        }

        // Move to genre service
        public IEnumerable<string> GetBestGenres(int num, DateTime from, DateTime to)
        {
            try
            {
                return GetBestSellers(num, from, to)
                    .Select(b => b.Genre);
            }
            catch
            {
                throw;
            }
        }

    }
}
