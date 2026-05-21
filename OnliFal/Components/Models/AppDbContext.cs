using Microsoft.EntityFrameworkCore;

namespace OnliFal.Components.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options) { }

    public DbSet<Event> Events { get; set; }
}