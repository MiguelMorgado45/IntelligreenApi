using Intelligreen.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Intelligreen.Application;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<Planta> Plantas { get; set; }
    public DbSet<Cuidado> Cuidados { get; set; }
}