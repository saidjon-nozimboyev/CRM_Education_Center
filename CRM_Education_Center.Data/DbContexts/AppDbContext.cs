using CRM_Education_Center.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRM_Education_Center.Data.DbContexts
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
