using Microsoft.EntityFrameworkCore;
using SerialKeyGenerate.Models;

namespace SerialKeyGenerate
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<srialkey> srialkey { get; set; }
        public DbSet <CustomerActiveDetails> CustomerActiveDetails { get; set; }

    }
}
