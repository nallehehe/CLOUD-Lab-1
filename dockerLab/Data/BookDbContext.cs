using dockerLab.Models;
using Microsoft.EntityFrameworkCore;

namespace dockerLab.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
