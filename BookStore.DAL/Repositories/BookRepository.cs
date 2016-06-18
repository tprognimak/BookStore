using BookStore.DAL.Interfaces;
using BookStore.DAL.Model;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.DAL.Repositories
{
    public class BookRepository : IBookRepository
    {
        public List<Book> GetBooks()
        {
            using (var context = new AuthorDbContext())
            {
                return context.Books.ToList();
            }
        }

        public List<Book> Create(Book book)
        {
            using (var context = new AuthorDbContext())
            {
                context.Books.Add(book);

                context.SaveChanges();

                return context.Books.ToList();
            }
        }
    }
}
