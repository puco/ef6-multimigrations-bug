namespace Domain1;

public class DbContext1 : DbContext
{
  public DbSet<Entity1> Entities { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite($"Filename=:memory:");
}