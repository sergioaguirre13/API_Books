using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class BooksDb : DbContext
    {
        public BooksDb(DbContextOptions<BooksDb> options) : base(options) 
        {
            
        }

        public DbSet<Book> Books => Set<Book>();
    }
}
