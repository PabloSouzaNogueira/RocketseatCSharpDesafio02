using Microsoft.EntityFrameworkCore;

namespace RocketseatCSharpDesafio02.Entities;

public class AppDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}