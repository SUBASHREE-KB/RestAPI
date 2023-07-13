using Microsoft.EntityFrameworkCore;
using LoginApi.Models;

namespace LoginApi
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<user> users { get; set; }
    }
}
