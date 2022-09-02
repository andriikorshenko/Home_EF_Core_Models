using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Task001Db020922;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .HasMany(p => p.Courses)
            .WithMany(p => p.Students);

        modelBuilder.Entity<Student>()
            .HasMany(p => p.Teachers)
            .WithMany(p => p.Students);

        modelBuilder.Entity<Teacher>()
            .HasMany(p => p.Courses)
            .WithMany(p => p.Teachers);

        modelBuilder.Entity<Teacher>()
            .HasMany(p => p.Students)
            .WithMany(p => p.Teachers);

        modelBuilder.Entity<Course>()
            .HasMany(p => p.Students)
            .WithMany(p => p.Courses);

        modelBuilder.Entity<Course>()
            .HasMany(p => p.Teachers)
            .WithMany(p => p.Courses);
    }
}

