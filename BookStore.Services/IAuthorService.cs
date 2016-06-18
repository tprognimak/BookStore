using BookStore.DAL.Model;
using System.Collections.Generic;

namespace BookStore.Services
{
    public interface IAuthorService
    {
        List<Author> GetAuthors();

        List<Author> Create(Author author);

        Author Edit(int id);

        List<Author> EditComplite(Author author);

        Author Delete(int id);

        List<Author> DeleteConfirmed(int id);
    }
}
