using BookStore.DAL.Model;
using System.Collections.Generic;

namespace BookStore.Services
{
    public interface IBookService
    {
        List<Book> GetBooks();

        List<Book> Create(Book book);
    }
}
