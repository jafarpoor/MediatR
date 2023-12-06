using ApiProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampleMediatR.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options) { }
        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
