using BookStore.DAL.Model;
using System.Collections.Generic;

namespace BookStore.DAL.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetBooks();

        List<Book> Create(Book book);
    }
}
