using System.Data.Entity;


namespace BookStore.DAL.Model
{
    public class AuthorDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Book>().ToTable("Books")
        //        .HasKey(o => o.Id);

        //    modelBuilder.Entity<Book>().Property(o => o.Id)
        //        .HasColumnName("Id");


        //    modelBuilder.Entity<Book>().Property(o => o.Name)
        //        .HasColumnName("Name");

        //    modelBuilder.Entity<Book>().Property(o => o.AuthorId)
        //        .HasColumnName("AuthorId");

        //    modelBuilder.Entity<Book>().Property(o => o.Genre)
        //        .HasColumnName("Genre");

        //    modelBuilder.Entity<Book>().Property(o => o.BookLenght)
        //        .HasColumnName("BookLenght");
        //}
    }
}
