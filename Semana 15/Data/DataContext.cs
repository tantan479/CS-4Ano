using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
   public DbSet<Filme> Filmes { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options){ }
}