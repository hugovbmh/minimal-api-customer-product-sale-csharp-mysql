using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace WebinarApiRest;
//DbContext mapea la BD en el proyecto
public class WebinarDbContext : DbContext
{
    public WebinarDbContext(DbContextOptions<WebinarDbContext> options)
        :base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(AssemblyBuilder.GetExecutingAssembly());
    }
}