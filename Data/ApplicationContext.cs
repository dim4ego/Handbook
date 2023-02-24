namespace Handbook.Data;
using Microsoft.EntityFrameworkCore;

    public class ApplicationContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Department> Departments => Set<Department>();
    public ApplicationContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=users.db");
    }

}

