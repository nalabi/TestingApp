using API.Entities;
using Microsoft.EntityFrameworkCore;

//using System.Threading.Tasks;


namespace API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<AppUser>Users { get; set; }

    }
}