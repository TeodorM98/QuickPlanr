using QuickPlanr.Models;
using Microsoft.EntityFrameworkCore;

namespace QuickPlanr.Data
{
    public class AppDbContext : DbContext
    {
        //DbContextOptions contains configuration options for the database context, such as the database provider (PostgreSQL) connection string, etc.
        //These options are injected into the AppDbContext by dependency injection
        //base(options) - This calls the base class constructor of DbContext and passes the options to it.
        //In simple terms, this line tells EF Core: "Here are the settings for the database. Use them to configure the connection."
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }          // Table for Users
        public DbSet<Meeting> Meetings { get; set; }    // Table for Meetings
        public DbSet<Schedule> Schedules { get; set; }  // Table for Schedules

    }
}
