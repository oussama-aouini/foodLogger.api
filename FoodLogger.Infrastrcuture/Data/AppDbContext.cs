using FoodLogger.Domain;
using Microsoft.EntityFrameworkCore;

namespace FoodLogger.Infrastrcuture.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Food> Foods { get; set; }
    }
}
