using BookStore.DAL.Interfaces;
using BookStore.DAL.Model;
using BookStore.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepozitory;

        public AuthorService()
        {
            _authorRepozitory = new AuthorRepository();
        }


        public List<Author> GetAuthors()
        {
            return _authorRepozitory.GetAuthors();
        }

        public List<Author> Create(Author author)
        {
            return _authorRepozitory.Create(author);
        }

        public Author Edit(int id)
        {
            return _authorRepozitory.Edit(id);
        }

        public List<Author> EditComplite(Author author)
        {
            return _authorRepozitory.EditComplite(author);
        }

        public Author Delete(int id)
        {
            return _authorRepozitory.Delete(id);
        }

        public List<Author> DeleteConfirmed(int id)
        {
            return _authorRepozitory.DeleteConfirmed(id);
        }
    }
}
