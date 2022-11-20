using Microsoft.EntityFrameworkCore;

namespace PalestrasAspNetMVC.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    
    public DbSet<Palestrante> Palestrantes { get; set; }
}