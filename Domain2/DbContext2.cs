namespace Domain2;

public class DbContext2 : DbContext
{
  public DbSet<Entity2> Entities { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite($"Filename=:memory:");

}