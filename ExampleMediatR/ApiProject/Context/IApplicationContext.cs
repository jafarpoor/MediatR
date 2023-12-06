using ApiProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampleMediatR.Context
{
    public interface IApplicationContext
    {
        DbSet<Person> Persons { get; set; }
        Task<int> SaveChangesAsync();
    }
}
