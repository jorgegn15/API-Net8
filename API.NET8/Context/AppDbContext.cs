using API.NET8.Models;
using Microsoft.EntityFrameworkCore;

namespace API.NET8.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<Person> Persons { get; set; }
    }
}
