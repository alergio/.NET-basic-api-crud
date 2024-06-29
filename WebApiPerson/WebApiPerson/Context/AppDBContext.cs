using Microsoft.EntityFrameworkCore;
using WebApiPerson.Models;

namespace WebApiPerson.Context
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }
    }
}
