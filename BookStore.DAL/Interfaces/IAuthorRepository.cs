using BookStore.DAL.Model;
using System.Collections.Generic;

namespace BookStore.DAL.Interfaces
{
    public interface IAuthorRepository
    {
        List<Author> GetAuthors();

        List<Author> Create(Author author);

        List<Author> EditComplite(Author author);

        Author Edit(int id);

        Author Delete(int id);

        List<Author> DeleteConfirmed(int id);
    }
}
