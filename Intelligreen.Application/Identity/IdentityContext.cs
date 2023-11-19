using Intelligreen.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Intelligreen.Application.Identity;

public class IdentityContext : IdentityDbContext<Usuario>
{
    public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
    {
    }
}