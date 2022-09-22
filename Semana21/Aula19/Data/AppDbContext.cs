using Aula19.Models;
using Microsoft.EntityFrameworkCore;

namespace Aula19.Data;

public class AppDbContext : DbContext
{
    public DbSet<RockStar> RockStars { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
}