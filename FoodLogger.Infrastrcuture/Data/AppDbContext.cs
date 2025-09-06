using FoodLogger.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodLogger.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
