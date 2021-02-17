using L11_Task01_DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace L11_Task01_DAL.EF
{
    internal class Initializer : CreateDatabaseIfNotExists<BookShop>
    {
        protected override void Seed(BookShop context)
        {
            base.Seed(context);            

            #region Authors
            var authors = new List<Author>
            {
                new Author { Name = "Joanne", Surname="Rowling", Patronymic = "" },
                new Author { Name = "Andrzej", Surname="Sapkowski", Patronymic = "" },
                new Author { Name = "John", Surname="Tolkien", Patronymic = "" },

            };

            context.Authors.AddRange(authors);
            #endregion

            #region Books
            var witcher1 = new Book
            {
                Name = "The Witcher. The Last Wish",
                PublicationDate = new DateTime(1993, 1, 1),
                Author = authors[1],
                CostPrice = 10,
                Genre = "Fantasy",
                Pages = 288,
                Price = 12,
                Publisher = "Publisher 1"                
            };

            var witcher2 = new Book
            {
                Name = "The Witcher. Sword of Destiny",
                PublicationDate = new DateTime(1992, 1, 1),
                Author = authors[1],
                CostPrice = 10,
                Genre = "Fantasy",
                Pages = 250,
                Price = 12,
                Publisher = "Publisher 1",
                PrevBook = witcher1
            };

            var witcher3 = new Book
            {
                Name = "The Witcher. Blood of Elves",
                PublicationDate = new DateTime(1994, 1, 1),
                Author = authors[1],
                CostPrice = 10,
                Genre = "Fantasy",
                Pages = 300,
                Price = 12,
                Publisher = "Publisher 1",
                PrevBook = witcher2
            };

            var lor1 = new Book
            {
                Name = "The Hobbit",
                PublicationDate = new DateTime(1994, 9, 23),
                Author = authors[2],
                CostPrice = 20,
                Genre = "High fantasy, Juvenile fantasy",
                Pages = 310,
                Price = 25,
                Publisher = "Publisher 2"
            };

            var hp1 = new Book
            {
                Name = "Harry Potter and the Philosopher's Stone",
                PublicationDate = new DateTime(1997, 6, 26),
                Author = authors[0],
                CostPrice = 5,
                Genre = "Fantasy",
                Pages = 223,
                Price = 15,
                Publisher = "Publisher 2"
            };

            context.Books.Add(witcher1);
            context.Books.Add(witcher2);
            context.Books.Add(witcher3);
            context.Books.Add(lor1);
            context.Books.Add(hp1);
            #endregion

            context.SaveChanges();
        }
    }
}
