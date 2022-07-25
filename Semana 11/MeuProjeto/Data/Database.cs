using Microsoft.EntityFrameworkCore;

public class Database: DbContext
{
    public DbSet<Requerente> Requerentes { get; set; }
}