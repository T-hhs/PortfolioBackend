using Microsoft.EntityFrameworkCore;





public class backendDB : DbContext
{
    public backendDB(DbContextOptions<backendDB> options) : base(options)
    {}
    public DbSet<Blog> Blogs => Set<Blog>();

    public DbSet<Project> Projects => Set<Project>();
}