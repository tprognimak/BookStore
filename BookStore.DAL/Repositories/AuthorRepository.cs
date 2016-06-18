using BookStore.DAL.Interfaces;
using BookStore.DAL.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace BookStore.DAL.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public List<Author> GetAuthors()
        {
            using (var context = new AuthorDbContext())
            {
                return context.Authors.ToList();
            }
        }

        public List<Author> Create(Author author)
        {
            using (var context = new AuthorDbContext())
            {
                context.Authors.Add(author);

                context.SaveChanges();

                return context.Authors.ToList();
            }
        }

        public Author Edit(int id)
        {
            using (var context = new AuthorDbContext())
            {
                Author author = context.Authors.Find(id);
                return author;
            }
        }

        public List<Author> EditComplite(Author author)
        {
            using (var context = new AuthorDbContext())
            {
                context.Entry(author).State = EntityState.Modified;
                context.SaveChanges();

                return context.Authors.ToList();
            }
        }

        public Author Delete(int id)
        {
            using (var context = new AuthorDbContext())
            {
                Author author = context.Authors.Find(id);
                return author;
            }
        }

        public List<Author> DeleteConfirmed(int id)
        {
            using (var context = new AuthorDbContext())
            {
                Author author = context.Authors.Find(id);

                context.Authors.Remove(author);

                context.SaveChanges();

                return context.Authors.ToList();
            }
        }
    }
}
