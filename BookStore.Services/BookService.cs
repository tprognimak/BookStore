using BookStore.DAL.Interfaces;
using BookStore.DAL.Model;
using BookStore.DAL.Repositories;
using System.Collections.Generic;

namespace BookStore.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepozitory;

        public BookService()
        {
            _bookRepozitory = new BookRepository();
        }

        public List<Book> GetBooks()
        {
            return _bookRepozitory.GetBooks();
        }

        public List<Book> Create(Book book)
        {
            return _bookRepozitory.Create(book);
        }
    }
}
